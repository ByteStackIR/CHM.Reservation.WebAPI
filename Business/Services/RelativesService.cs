using AutoMapper;
using Contracts.IContext;
using Contracts.IMarker;
using Contracts.IRepository;
using Contracts.IService;
using Entities.DataTransferObjects;
using Entities.DataTransferObjects.Models;
using Entities.Models;
using Entities.QueryExtensions;
using Features.CustomRequest;
using Features.RequestFeatures;
using LoggerService;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Claims;

namespace Services.Services;

public class RelativesService : ServiceBase, IRelativesService, IScopeMarker
{
    private IRelationsService _relationsService;
    public RelativesService(IMapper mapper,
        ILoggerManager logger,
        IRepositoryManager repoManger,
        IHttpContextAccessor httpContextAccessor,
        ISystemContext systemContext,
        IRelationsService relationsService) :
        base(repoManger,
            mapper,
            httpContextAccessor,
            systemContext,
            logger)
    {
        _relationsService = relationsService;
    }

    public async Task<List<RelativeDto>> GetbyUserId(Guid UserId)
    {

        var userRelatives = await _repositoryManager.Relatives.FindByCondition(x => x.UserId == UserId.ToString(), false).ToListAsync();

        return _mapper.Map<List<RelativeDto>>(userRelatives);
    }

    public async Task<RelativeDto> GetById(Guid Id)
    {

        var userRelatives = await _repositoryManager.Relatives.FindByCondition(x => x.Id == Id, false).ToListAsync();

        return _mapper.Map<RelativeDto>(userRelatives);
    }

    public async Task<List<RelativeDto>> GetConfirmedRelatives(Guid UserId)
    {
        var userRelatives = await _repositoryManager.Relatives.FindByCondition(x => x.UserId == UserId.ToString() && x.IsChecked && x.IsConfirmed, false).ToListAsync();

        return _mapper.Map<List<RelativeDto>>(userRelatives);
    }

    /// <summary>
    /// بررسی نشده ها -- برای سطح مدیریت
    /// </summary>
    /// <returns></returns>
    public async Task<PagedData<List<UserRelativesDto>>> GetNotCheckedRelativesAsAdmin(ListNotCheckedRelativesRequest request)
    {
        var query = _repositoryManager
          .UserCompany
          .FindByCondition(x => x.IsActive, false)
          .Include(y => y.User)
          .ThenInclude(z => z.Relatives.Where(x => !x.IsChecked)).Include(x => x.Company).OrderByDescending(x => x.CreatedDate);

        var data = await query.GetPage(request).ToListAsync();
        List<UserRelativesDto> res = new();

        foreach (var item in data)
        {
            res.Add(new UserRelativesDto()
            {
                CompanyTitle = item.Company.Title,
                FirstName = item.User.FirstName,
                LastName = item.User.LastName,
                Relatives = new()
                {
                    Items = _mapper.Map<List<RelativeDto>>(item.User.Relatives)
                }

            });
        }

        PagedData<List<UserRelativesDto>> result = new(new(query.Count(), request.PageNumber, request.PageSize), res);

        return result;
    }

    /// <summary>
    /// بررسی نشده ها -- برای سرح پنل شرکتی
    /// </summary>
    /// <param name="CompanyId">آیدی شرکت</param>
    /// <returns></returns>
    public async Task<PagedData<List<UserRelativesDto>>> GetNotCheckedRelativesAsCompany(ListNotCheckedRelativesRequest request)
    {

        var query = _repositoryManager
           .UserCompany
           .FindByCondition(x => x.IsActive && x.CompanyId==_systemContext.UserCompany.Id, false)
           .Include(y => y.User)
           .ThenInclude(z => z.Relatives.Where(x => !x.IsChecked)).Include(x => x.Company).OrderByDescending(x => x.CreatedDate);

        var data = await query.GetPage(request).ToListAsync();
        List<UserRelativesDto> res = new();

        foreach (var item in data)
        {
            res.Add(new UserRelativesDto()
            {
                CompanyTitle = item.Company.Title,
                FirstName = item.User.FirstName,
                LastName = item.User.LastName,
                Relatives = new()
                {
                    Items = _mapper.Map<List<RelativeDto>>(item.User.Relatives)
                }

            });
        }

        PagedData<List<UserRelativesDto>> result = new(new(query.Count(), request.PageNumber, request.PageSize), res);

        return result;
    }



    public async Task<RelativeDto> InsertByUser(RelativeDto dto)
    {
        Relatives model = _mapper.Map<Relatives>(dto);
        model.UserId = _systemContext.CurrentUser.FindFirstValue(ClaimTypes.NameIdentifier);
        model.Id = Guid.NewGuid();
        model.CreatedDate = DateTime.Now;
        model.IsChecked = true;
        model.IsConfirmed = true;

        bool mustBeChecked= await _relationsService.NeedConfirmation(dto.RelationId);
  
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



            Relatives model = _mapper.Map<Relatives>(item);
            model.UserId = _systemContext.CurrentUser.FindFirstValue(ClaimTypes.NameIdentifier);
            model.Id = Guid.NewGuid();
            model.CreatedDate = DateTime.Now;
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

        List<RelativeDto> res = new();
        foreach (var item in dto.Relatives)
        {
            Relatives model = _mapper.Map<Relatives>(item);
            model.UserId = dto.UserId.ToString();
            model.Id = Guid.NewGuid();
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
            Relatives model = _mapper.Map<Relatives>(item);
            model.UserId = dto.UserId.ToString();
            model.Id = Guid.NewGuid();
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

        var model = await _repositoryManager.Relatives.FindByCondition(x=>x.Id==dto.Id && x.UserId == dto.UserId,false).FirstOrDefaultAsync();

        if (model is null)
            throw new Exception("Invalid Data!");

        model.RelationId = dto.RelationId;
        model.BirthDate = dto.BirthDate;
        model.FirstName = dto.FirstName;
        model.FamilyName = dto.FamilyName;
        model.IdentityCode = dto.IdentityCode;
        model.Gender = dto.Gender;
        model.UserId = _systemContext.CurrentUser.FindFirstValue(ClaimTypes.NameIdentifier);
        model.IsChecked = true;
        model.IsConfirmed = true;

        bool mustBeChecked = await _relationsService.NeedConfirmation(dto.RelationId);

        if (mustBeChecked)
        {
            model.IsChecked = false;
            model.IsConfirmed = false;
        }


        _repositoryManager.Relatives.Update(model);
        _repositoryManager.Save();
        return _mapper.Map<RelativeDto>(model);

    }

    public async Task<RelativeDto> UpdateByCompany(RelativeDto dto)
    {
        var model = await _repositoryManager.Relatives.FindByCondition(x => x.Id == dto.Id && x.UserId == dto.UserId, false).FirstOrDefaultAsync();

        if (model is null)
            throw new Exception("Invalid Data!");

        model.RelationId = dto.RelationId;
        model.BirthDate = dto.BirthDate;
        model.FirstName = dto.FirstName;
        model.FamilyName = dto.FamilyName;
        model.IdentityCode = dto.IdentityCode;
        model.Gender = dto.Gender;
        model.IsChecked = true;
        model.IsConfirmed = true;


        _repositoryManager.Relatives.Update(model);
        _repositoryManager.Save();
        return _mapper.Map<RelativeDto>(model);

    }

    public async Task<RelativeDto> UpdateByAdmin(RelativeDto dto)
    {
        var model = await _repositoryManager.Relatives.FindByCondition(x => x.Id == dto.Id && x.UserId == dto.UserId, false).FirstOrDefaultAsync();

        if (model is null)
            throw new Exception("Invalid Data!");

        model.RelationId = dto.RelationId;
        model.BirthDate = dto.BirthDate;
        model.FirstName = dto.FirstName;
        model.FamilyName = dto.FamilyName;
        model.IdentityCode = dto.IdentityCode;
        model.Gender = dto.Gender;
        model.IsChecked = true;
        model.IsConfirmed = true;



        _repositoryManager.Relatives.Update(model);
        _repositoryManager.Save();
        return _mapper.Map<RelativeDto>(model);

    }



    public async Task<RelativeDto> ToggleByUser(Guid Id)
    {
        var model = await _repositoryManager.Relatives.FindByCondition(x => x.Id == Id && x.UserId == _systemContext.CurrentUser.FindFirstValue(ClaimTypes.NameIdentifier), false).FirstOrDefaultAsync();

        return _mapper.Map<RelativeDto>(model);
    }

    public async Task<RelativeDto> ToggleByCompany(Guid UserId,Guid Id)
    {
        var model = await _repositoryManager.Relatives.FindByCondition(x => x.Id == Id && x.UserId == UserId.ToString(), false).FirstOrDefaultAsync();

        return _mapper.Map<RelativeDto>(model);
    }

    public async Task<RelativeDto> ToggleByAdmin(Guid UserId, Guid Id)
    {
        var model = await _repositoryManager.Relatives.FindByCondition(x => x.Id == Id && x.UserId == UserId.ToString(), false).FirstOrDefaultAsync();

        return _mapper.Map<RelativeDto>(model);
    }

}

