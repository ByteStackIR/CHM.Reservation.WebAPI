using System.Collections.Generic;
using System.Numerics;
using System.Security.Claims;
using AutoMapper;
using Contracts.IContext;
using Contracts.IMarker;
using Contracts.IRepository;
using Contracts.IService;
using Entities.DataTransferObjects;
using Entities.DataTransferObjects.Models;
using Entities.Enum;
using Entities.IdentityExtensions;
using Entities.Models;
using Entities.QueryExtensions;
using Features.CustomRequest;
using Features.RequestFeatures;
using LoggerService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Services.Services;

public class RelativesService : ServiceBase, IRelativesService, IScopeMarker
{
    private IRelationsService _relationsService;
    private UserManager<User> _userManager;

    public RelativesService(
        IMapper mapper,
        UserManager<User> userManager,
        ILoggerManager logger,
        IRepositoryManager repoManger,
        IHttpContextAccessor httpContextAccessor,
        ISystemContext systemContext,
        IRelationsService relationsService
    )
        : base(repoManger, mapper, httpContextAccessor, systemContext, logger)
    {
        _relationsService = relationsService;
        _userManager = userManager;
    }

    public async Task<List<RelativeDto>> GetbyUserId(Guid UserId)
    {
        var userRelatives = await _repositoryManager
            .Relatives.FindByCondition(x => x.UserId == UserId.ToString(), false)
            .ToListAsync();

        return _mapper.Map<List<RelativeDto>>(userRelatives);
    }

    public async Task<RelativeDto> GetById(Guid Id)
    {
        var userRelatives = await _repositoryManager
            .Relatives.FindByCondition(x => x.Id == Id, false)
            .ToListAsync();

        return _mapper.Map<RelativeDto>(userRelatives);
    }

    public async Task<List<RelativeOfUserDto>> GetConfirmedRelatives(Guid UserId)
    {
        try
        {
            var userRelatives = await _repositoryManager
                .Relatives.FindByCondition(
                    x =>
                        x.UserId == UserId.ToString()
                        && x.IsChecked
                        && x.IsConfirmed
                        && !x.IsDeleted,
                    false
                )
                .Include(x => x.Relation)
                .ToListAsync();

            return _mapper.Map<List<RelativeOfUserDto>>(userRelatives);
        }
        catch (Exception e)
        {
            return null;
        }
    }

    /// <summary>
    /// بررسی نشده ها -- برای سطح مدیریت
    /// </summary>
    /// <returns></returns>
    public async Task<PagedData<List<UserRelativesDto>>> GetNotCheckedRelativesAsAdmin(
        ListNotCheckedRelativesRequest request
    )
    {
        var query = _repositoryManager
            .UserCompany.FindByCondition(x => x.IsActive, false)
            .Include(y => y.User)
            .ThenInclude(z => z.Relatives.Where(x => !x.IsChecked && !x.IsDeleted))
            .Include(x => x.Company)
            .OrderByDescending(x => x.CreatedDate);

        var data = await query.GetPage(request).ToListAsync();
        List<UserRelativesDto> res = new();

        foreach (var item in data)
        {
            res.Add(
                new UserRelativesDto()
                {
                    CompanyTitle = item.Company.Title,
                    FirstName = item.User.FirstName,
                    LastName = item.User.LastName,
                    Relatives = new()
                    {
                        Items = _mapper.Map<List<RelativeDto>>(item.User.Relatives),
                    },
                }
            );
        }

        PagedData<List<UserRelativesDto>> result =
            new(new(query.Count(), request.PageNumber, request.PageSize), res);

        return result;
    }

    /// <summary>
    /// بررسی نشده ها -- برای سرح پنل شرکتی
    /// </summary>
    /// <param name="CompanyId">آیدی شرکت</param>
    /// <returns></returns>
    public async Task<PagedData<List<UserRelativesDto>>> GetNotCheckedRelativesAsCompany(
        ListNotCheckedRelativesRequest request
    )
    {
        var query = _repositoryManager
            .UserCompany.FindByCondition(
                x => x.IsActive && x.CompanyId == _systemContext.UserCompany.Id,
                false
            )
            .Include(y => y.User)
            .ThenInclude(z => z.Relatives.Where(x => !x.IsChecked && !x.IsDeleted))
            .Include(x => x.Company)
            .OrderByDescending(x => x.CreatedDate);

        var data = await query.GetPage(request).ToListAsync();
        List<UserRelativesDto> res = new();

        foreach (var item in data)
        {
            res.Add(
                new UserRelativesDto()
                {
                    CompanyTitle = item.Company.Title,
                    FirstName = item.User.FirstName,
                    LastName = item.User.LastName,
                    Relatives = new()
                    {
                        Items = _mapper.Map<List<RelativeDto>>(item.User.Relatives),
                    },
                }
            );
        }

        PagedData<List<UserRelativesDto>> result =
            new(new(query.Count(), request.PageNumber, request.PageSize), res);

        return result;
    }

    public async Task<RelativeDto> InsertByUser(RelativeDto dto)
    {
        if (
            !(
                await _relationsService.CheckMaximumLimit(
                    dto.RelationId,
                    _systemContext.CurrentUser.GetUserId().Value
                )
            )
        )
            throw new Exception("Cannot be inserted because of limit!");

        var oldModel = await _repositoryManager
            .Relatives.FindByCondition(
                x =>
                    x.IdentityCode == dto.IdentityCode
                    && x.UserId == _systemContext.CurrentUser.GetUserId().Value.ToString(),
                false
            )
            .FirstOrDefaultAsync();

        if (oldModel != null)
            throw new Exception("There is person with this IdentityCode!");

        Relatives model = _mapper.Map<Relatives>(dto);

        model.UserId = _systemContext.CurrentUser.GetUserId().Value.ToString();
        model.Id = Guid.NewGuid();
        model.CreatedDate = DateTime.Now;
        model.IsDeleted = false;
        model.IsChecked = true;
        model.IsConfirmed = true;

        bool mustBeChecked = await _relationsService.NeedConfirmation(dto.RelationId);

        if (mustBeChecked)
        {
            model.IsChecked = false;
            model.IsConfirmed = false;
        }

        _repositoryManager.Relatives.Create(model);
        _repositoryManager.Save();
        return _mapper.Map<RelativeDto>(model);
    }

    public async Task<List<RelativeDto>> BulkInsertByUser(List<RelativeDto> dto)
    {
        List<RelativeDto> res = new();
        foreach (var item in dto)
        {
            if (
                !(
                    await _relationsService.CheckMaximumLimit(
                        item.RelationId,
                        _systemContext.CurrentUser.GetUserId().Value
                    )
                )
            )
                throw new Exception("Cannot be inserted because of limit!");

            var oldModel = await _repositoryManager
                .Relatives.FindByCondition(
                    x =>
                        x.IdentityCode == item.IdentityCode
                        && x.UserId == _systemContext.CurrentUser.GetUserId().Value.ToString(),
                    false
                )
                .FirstOrDefaultAsync();

            if (oldModel != null)
                throw new Exception("There is person with this IdentityCode!");

            Relatives model = _mapper.Map<Relatives>(item);
            model.UserId = _systemContext.CurrentUser.GetUserId().Value.ToString();
            model.Id = Guid.NewGuid();
            model.CreatedDate = DateTime.Now;
            model.IsDeleted = false;
            model.IsChecked = true;
            model.IsConfirmed = true;

            bool mustBeChecked = await _relationsService.NeedConfirmation(item.RelationId);

            if (mustBeChecked)
            {
                model.IsChecked = false;
                model.IsConfirmed = false;
            }

            _repositoryManager.Relatives.Create(model);
            res.Add(_mapper.Map<RelativeDto>(model));
        }
        _repositoryManager.Save();

        return res;
    }

    public async Task<List<RelativeDto>> BulkInsertByCompany(UserRelativesCreationDto dto)
    {
        if (dto.UserId == Guid.Empty)
            throw new Exception();

        var EndUserCompany = await _repositoryManager
            .UserCompany.FindByCondition(
                x => x.UserId == dto.UserId.ToString() && x.IsActive,
                false
            )
            .FirstOrDefaultAsync();

        if (EndUserCompany == null || EndUserCompany.CompanyId != _systemContext.UserCompany.Id)
            throw new Exception("You are not allowed!");

        List<RelativeDto> res = new();
        foreach (var item in dto.Relatives)
        {
            if (!(await _relationsService.CheckMaximumLimit(item.RelationId, dto.UserId)))
                throw new Exception("Cannot be inserted because of limit!");

            var oldModel = await _repositoryManager
                .Relatives.FindByCondition(
                    x => x.IdentityCode == item.IdentityCode && x.UserId == dto.UserId.ToString(),
                    false
                )
                .FirstOrDefaultAsync();

            if (oldModel != null)
                throw new Exception("There is person with this IdentityCode!");

            Relatives model = _mapper.Map<Relatives>(item);
            model.UserId = dto.UserId.ToString();
            model.Id = Guid.NewGuid();
            model.IsDeleted = false;
            model.CreatedDate = DateTime.Now;
            model.IsChecked = true;
            model.IsConfirmed = true;

            _repositoryManager.Relatives.Create(model);
            res.Add(_mapper.Map<RelativeDto>(model));
        }
        _repositoryManager.Save();

        return res;
    }

    public async Task<List<RelativeDto>> BulkInsertByAdmin(UserRelativesCreationDto dto)
    {
        if (dto.UserId == Guid.Empty)
            throw new Exception();

        List<RelativeDto> res = new();
        foreach (var item in dto.Relatives)
        {
            if (!(await _relationsService.CheckMaximumLimit(item.RelationId, dto.UserId)))
                throw new Exception("Cannot be inserted because of limit!");

            var oldModel = await _repositoryManager
                .Relatives.FindByCondition(
                    x => x.IdentityCode == item.IdentityCode && x.UserId == dto.UserId.ToString(),
                    false
                )
                .FirstOrDefaultAsync();

            if (oldModel != null)
                throw new Exception("There is person with this IdentityCode!");

            Relatives model = _mapper.Map<Relatives>(item);
            model.UserId = dto.UserId.ToString();
            model.Id = Guid.NewGuid();
            model.IsDeleted = false;
            model.CreatedDate = DateTime.Now;
            model.IsChecked = true;
            model.IsConfirmed = true;

            _repositoryManager.Relatives.Create(model);
            res.Add(_mapper.Map<RelativeDto>(model));
        }
        _repositoryManager.Save();

        return res;
    }

    public async Task<RelativeDto> UpdateByUser(RelativeDto dto)
    {
        var model = await _repositoryManager
            .Relatives.FindByCondition(x => x.Id == dto.Id && x.UserId == dto.UserId, false)
            .FirstOrDefaultAsync();

        if (model is null)
            throw new Exception($"Relation with Id {dto.Id} was not found!");

        if (model.RelationId != dto.RelationId)
            if (
                !(
                    await _relationsService.CheckMaximumLimit(
                        dto.RelationId,
                        _systemContext.CurrentUser.GetUserId().Value
                    )
                )
            )
                throw new Exception("Cannot be inserted because of limit!");

        if (model.IdentityCode != dto.IdentityCode)
        {
            var oldModel = await _repositoryManager
                .Relatives.FindByCondition(
                    x =>
                        x.IdentityCode == dto.IdentityCode
                        && x.UserId == _systemContext.CurrentUser.GetUserId().Value.ToString(),
                    false
                )
                .FirstOrDefaultAsync();

            if (oldModel != null)
                throw new Exception("There is person with this IdentityCode!");
        }

        model.RelationId = dto.RelationId;
        model.BirthDate = dto.BirthDate;
        model.FirstName = dto.FirstName;
        model.FamilyName = dto.FamilyName;
        model.IdentityCode = dto.IdentityCode;
        model.FatherName = dto.FatherName;
        model.Gender = dto.Gender;
        model.UserId = _systemContext.CurrentUser.GetUserId().Value.ToString();
        model.IsChecked = true;
        model.IsConfirmed = true;

        bool mustBeChecked = await _relationsService.NeedConfirmation(dto.RelationId);

        if (mustBeChecked)
        {
            model.IsChecked = false;
            model.IsConfirmed = false;
        }

        model.IsDeleted = false;

        _repositoryManager.Relatives.Update(model);
        _repositoryManager.Save();
        return _mapper.Map<RelativeDto>(model);
    }

    public async Task<List<RelativeDto>> ManiuplateRelatives(ManiuplateRelativeDto dto)
    {
        List<RelativeDto> res = new();

        foreach (var item in dto.Update)
        {
            if (item.IsDeleted == true)
                continue;

            try
            {
                res.Add(await this.UpdateByUser(item));
            }
            catch (Exception ex)
            {
                res.Add(item);
            }
        }

        foreach (var item in dto.Create)
        {
            if (item.IsDeleted == true)
                continue;

            try
            {
                res.Add(await this.InsertByUser(item));
            }
            catch (Exception ex)
            {
                res.Add(item);
            }
        }

        foreach (var item in dto.Delete)
        {
            if (item.Id == null)
                continue;

            try
            {
                res.Add(await ToggleByUser(item.Id.Value));
            }
            catch (Exception ex)
            {
                res.Add(item);
            }
        }

        return res;
    }

    public async Task<RelativeDto> UpdateByCompany(RelativeDto dto)
    {
        var EndUserCompany = await _repositoryManager
            .UserCompany.FindByCondition(x => x.UserId == dto.UserId && x.IsActive, false)
            .FirstOrDefaultAsync();

        if (EndUserCompany == null || EndUserCompany.CompanyId != _systemContext.UserCompany.Id)
            throw new Exception("You are not allowed!");

        var model = await _repositoryManager
            .Relatives.FindByCondition(x => x.Id == dto.Id && x.UserId == dto.UserId, false)
            .FirstOrDefaultAsync();

        if (model is null)
            throw new Exception($"Relation with Id {dto.Id} was not found!");

        if (model.RelationId != dto.RelationId)
            if (
                !(
                    await _relationsService.CheckMaximumLimit(
                        dto.RelationId,
                        _systemContext.CurrentUser.GetUserId().Value
                    )
                )
            )
                throw new Exception("Cannot be inserted because of limit!");

        if (model.IdentityCode != dto.IdentityCode)
        {
            var oldModel = await _repositoryManager
                .Relatives.FindByCondition(
                    x => x.IdentityCode == dto.IdentityCode && x.UserId == model.UserId.ToString(),
                    false
                )
                .FirstOrDefaultAsync();

            if (oldModel != null)
                throw new Exception("There is person with this IdentityCode!");
        }

        model.RelationId = dto.RelationId;
        model.BirthDate = dto.BirthDate;
        model.FirstName = dto.FirstName;
        model.FamilyName = dto.FamilyName;
        model.FatherName = dto.FatherName;
        model.IdentityCode = dto.IdentityCode;
        model.Gender = dto.Gender;
        model.IsChecked = true;
        model.IsConfirmed = true;
        model.IsDeleted = false;

        _repositoryManager.Relatives.Update(model);
        _repositoryManager.Save();
        return _mapper.Map<RelativeDto>(model);
    }

    public async Task<RelativeDto> UpdateByAdmin(RelativeDto dto)
    {
        var model = await _repositoryManager
            .Relatives.FindByCondition(x => x.Id == dto.Id && x.UserId == dto.UserId, false)
            .FirstOrDefaultAsync();

        if (model is null)
            throw new Exception($"Relation with Id {dto.Id} was not found!");

        if (model.RelationId != dto.RelationId)
            if (
                !(
                    await _relationsService.CheckMaximumLimit(
                        dto.RelationId,
                        _systemContext.CurrentUser.GetUserId().Value
                    )
                )
            )
                throw new Exception("Cannot be inserted because of limit!");

        if (model.IdentityCode != dto.IdentityCode)
        {
            var oldModel = await _repositoryManager
                .Relatives.FindByCondition(
                    x => x.IdentityCode == dto.IdentityCode && x.UserId == model.UserId.ToString(),
                    false
                )
                .FirstOrDefaultAsync();

            if (oldModel != null)
                throw new Exception("There is person with this IdentityCode!");
        }

        model.RelationId = dto.RelationId;
        model.BirthDate = dto.BirthDate;
        model.FirstName = dto.FirstName;
        model.FamilyName = dto.FamilyName;
        model.FatherName = dto.FatherName;

        model.IdentityCode = dto.IdentityCode;
        model.Gender = dto.Gender;
        model.IsChecked = true;
        model.IsConfirmed = true;
        model.IsDeleted = false;

        _repositoryManager.Relatives.Update(model);
        _repositoryManager.Save();
        return _mapper.Map<RelativeDto>(model);
    }

    public async Task<RelativeDto> ToggleByUser(Guid Id)
    {
        var model = await _repositoryManager
            .Relatives.FindByCondition(
                x =>
                    x.Id == Id
                    && x.UserId == _systemContext.CurrentUser.GetUserId().Value.ToString(),
                false
            )
            .FirstOrDefaultAsync();
        if (model is null)
            throw new Exception($"Relation with Id {Id} was not found!");

        if (!(await _relationsService.CanBeDeleted(model.RelationId)))
            throw new Exception($"This Item can be deleted!");

        model.IsDeleted = !model.IsDeleted;

        if (!model.IsDeleted)
        {
            bool mustBeChecked = await _relationsService.NeedConfirmation(model.RelationId);

            if (mustBeChecked)
            {
                model.IsChecked = false;
                model.IsConfirmed = false;
            }
        }

        _repositoryManager.Relatives.Update(model);
        _repositoryManager.Save();
        return _mapper.Map<RelativeDto>(model);
    }

    public async Task<RelativeDto> ToggleByCompany(Guid UserId, Guid Id)
    {
        var EndUserCompany = await _repositoryManager
            .UserCompany.FindByCondition(x => x.UserId == UserId.ToString() && x.IsActive, false)
            .FirstOrDefaultAsync();

        if (EndUserCompany == null || EndUserCompany.CompanyId != _systemContext.UserCompany.Id)
            throw new Exception("You are not allowed!");

        var model = await _repositoryManager
            .Relatives.FindByCondition(x => x.Id == Id && x.UserId == UserId.ToString(), false)
            .FirstOrDefaultAsync();
        if (model is null)
            throw new Exception($"Relation with Id {Id} was not found!");

        if (!(await _relationsService.CanBeDeleted(model.RelationId)))
            throw new Exception($"This Item can be deleted!");

        model.IsDeleted = !model.IsDeleted;
        _repositoryManager.Relatives.Update(model);
        _repositoryManager.Save();
        return _mapper.Map<RelativeDto>(model);
    }

    public async Task<RelativeDto> ToggleByAdmin(Guid UserId, Guid Id)
    {
        var model = await _repositoryManager
            .Relatives.FindByCondition(x => x.Id == Id && x.UserId == UserId.ToString(), false)
            .FirstOrDefaultAsync();

        if (model is null)
            throw new Exception($"Relation with Id {Id} was not found!");

        if (!(await _relationsService.CanBeDeleted(model.RelationId)))
            throw new Exception($"This Item can be deleted!");

        if (!(await _relationsService.CanBeDeleted(model.RelationId)))
            throw new Exception($"This Item can be deleted!");

        model.IsDeleted = !model.IsDeleted;
        _repositoryManager.Relatives.Update(model);
        _repositoryManager.Save();
        return _mapper.Map<RelativeDto>(model);
    }


    public async Task<List<RelativeDto>> ManiuplateRelativesAsAdmin(ManiuplateRelativeDto dto)
    {
        List<RelativeDto> res = new();

        foreach (var item in dto.Update)
        {
            if (item.IsDeleted == true)
                continue;

            item.UserId = dto.UserId.Value.ToString();

            try
            {
                res.Add(await this.UpdateByAdmin(item));
            }
            catch (Exception ex)
            {
                res.Add(item);
            }
        }



       res.AddRange(await this.BulkInsertByAdmin(new() { UserId = dto.UserId.Value, Relatives = dto.Create }));

    

        foreach (var item in dto.Delete)
        {
            if (item.Id == null)
                continue;

            try
            {
                res.Add(await ToggleByAdmin(dto.UserId.Value,item.Id.Value));
            }
            catch (Exception ex)
            {
                res.Add(item);
            }
        }

        return res;
    }
    public async Task<List<RelativeDto>> ManiuplateRelativesAsCompany(ManiuplateRelativeDto dto)
    {
        List<RelativeDto> res = new();

        foreach (var item in dto.Update)
        {
            if (item.IsDeleted == true)
                continue;

            item.UserId = dto.UserId.Value.ToString();

            try
            {
                res.Add(await this.UpdateByCompany(item));
            }
            catch (Exception ex)
            {
                res.Add(item);
            }
        }



        res.AddRange(await this.BulkInsertByCompany(new() { UserId = dto.UserId.Value, Relatives = dto.Create }));



        foreach (var item in dto.Delete)
        {
            if (item.Id == null)
                continue;

            try
            {
                res.Add(await ToggleByCompany(dto.UserId.Value, item.Id.Value));
            }
            catch (Exception ex)
            {
                res.Add(item);
            }
        }

        return res;
    }







    public async Task<RelativeDto> ResultOfReviewRelativeByAdmin(Guid UserId, Guid Id, bool Accept)
    {
        var model = await _repositoryManager
            .Relatives.FindByCondition(x => x.Id == Id && x.UserId == UserId.ToString(), false)
            .FirstOrDefaultAsync();
        if (model is null)
            throw new Exception($"Relation with Id {Id} was not found!");

        model.IsChecked = true;
        model.IsConfirmed = Accept;
        _repositoryManager.Relatives.Update(model);
        _repositoryManager.Save();
        return _mapper.Map<RelativeDto>(model);
    }

    public async Task<RelativeDto> ResultOfReviewRelativeByCompany(
        Guid UserId,
        Guid Id,
        bool Accept
    )
    {
        var EndUserCompany = await _repositoryManager
            .UserCompany.FindByCondition(x => x.UserId == UserId.ToString() && x.IsActive, false)
            .FirstOrDefaultAsync();

        if (EndUserCompany == null || EndUserCompany.CompanyId != _systemContext.UserCompany.Id)
            throw new Exception("You are not allowed!");

        var model = await _repositoryManager
            .Relatives.FindByCondition(x => x.Id == Id && x.UserId == UserId.ToString(), false)
            .FirstOrDefaultAsync();
        if (model is null)
            throw new Exception($"Relation with Id {Id} was not found!");

        model.IsChecked = true;
        model.IsConfirmed = Accept;
        _repositoryManager.Relatives.Update(model);
        _repositoryManager.Save();
        return _mapper.Map<RelativeDto>(model);
    }



    #region [Self]

    public async Task<RelativeDto> AddSelf(UserForRegistrationDto user)
    {
        var relation = await _relationsService.GetByType(RelationType.SELF);
        var userModel = await _userManager.Users.FirstOrDefaultAsync(x =>
            x.PhoneNumber == user.PhoneNumber
        );

        Relatives model =
            new()
            {
                BirthDate = user.BirthDate,
                CreatedDate = DateTime.Now,
                FamilyName = user.LastName,
                FirstName = user.FirstName,
                Gender = user.Gender,
                Id = Guid.NewGuid(),
                IdentityCode = user.IdentityCode,
                IsChecked = true,
                IsConfirmed = true,
                IsDeleted = false,
                RelationId = relation.Id,
                UserId = userModel.Id,
                FatherName = user.FatherName,
            };

        _repositoryManager.Relatives.Create(model);
        _repositoryManager.Save();

        return _mapper.Map<RelativeDto>(model);
    }

    public async Task<RelativeDto> UpdateSelf(UserUpdateDto dto)
    {
        var relation = await _relationsService.GetByType(RelationType.SELF);
        var userModel = await _userManager.Users.FirstOrDefaultAsync(x =>
            x.PhoneNumber == dto.PhoneNumber
        );
        var model = await _repositoryManager
            .Relatives.FindByCondition(
                x => x.UserId == userModel.Id && x.RelationId == relation.Id,
                true
            )
            .FirstOrDefaultAsync();

        model.BirthDate = dto.BirthDate;
        model.FirstName = dto.FirstName;
        model.FamilyName = dto.LastName;
        model.IdentityCode = dto.IdentityCode;
        model.Gender = dto.Gender;
        model.IsDeleted = false;
        model.IsChecked = true;
        model.IsConfirmed = true;
        model.FatherName = dto.FatherName;

        _repositoryManager.Relatives.Update(model);
        _repositoryManager.Relatives.SaveChanges();

        return _mapper.Map<RelativeDto>(model);
    }
    #endregion
}
