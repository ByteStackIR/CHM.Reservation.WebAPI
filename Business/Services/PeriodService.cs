using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts.IContext;
using Contracts.IMarker;
using Contracts.IRepository;
using Contracts.IService;
using Entities.DataTransferObjects.Models;
using Entities.Models;
using Entities.QueryExtensions;
using Features.CustomRequest;
using Features.RequestFeatures;
using LoggerService;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Services.Services;

/// <summary>
/// Defines the <see cref="PeriodService" />
/// </summary>
public class PeriodService : ServiceBase, IPeriodService, IScopeMarker
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PeriodService"/> class.
    /// </summary>
    /// <param name="mapper">The mapper<see cref="IMapper"/></param>
    /// <param name="repoManger">The repoManger<see cref="IRepositoryManager"/></param>
    /// <param name="httpContextAccessor">The httpContextAccessor<see cref="IHttpContextAccessor"/></param>
    /// <param name="systemContext">The systemContext<see cref="ISystemContext"/></param>
    /// <param name="logger">The logger<see cref="ILoggerManager"/></param>
    public PeriodService(
        IMapper mapper,
        IRepositoryManager repoManger,
        IHttpContextAccessor httpContextAccessor,
        ISystemContext systemContext,
        ILoggerManager logger
    )
        : base(repoManger, mapper, httpContextAccessor, systemContext, logger) { }

    public async Task<PagedData<List<PeriodDto>>> GetPagnationData(PeriodTableRequest request)
    {
        try
        {
            var query = _repositoryManager.Period.FindAll(false);

            int count = query.Count();

            var data = await query.GetPage(request).ToListAsync();

            return new(
                new(count, request.PageNumber, request.PageSize),
                _mapper.Map<List<PeriodDto>>(data)
            );
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<PeriodDto> GetById(Guid periodId)
    {
        try
        {
            var periodModel = await _repositoryManager.Period.GetByIdAsync(periodId);
            if (periodModel is not null && periodModel.IsDeleted is false)
            {
                var periodDto = _mapper.Map<PeriodDto>(periodModel);

                var CouponShares = await _repositoryManager
                    .CouponShare.FindByCondition(x => x.PeriodId == periodDto.Id, false)
                    // .Include(x => x.Relation)
                    .ToListAsync();

                periodDto.CouponShare = _mapper.Map<List<CouponShareDto>>(CouponShares);

                return periodDto;
            }
            else
            {
                throw new KeyNotFoundException($"Period with ID {periodId} was not found.");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public bool AddPeriod(PeriodDto dto)
    {
        try
        {
            dto.Id = Guid.NewGuid();
            var periodModel = _mapper.Map<Period>(dto);
            periodModel.IsDeleted = false;
            periodModel.CreatedDate = DateTime.Now;

            //! TODO should CouponShare add to periodModel.CouponShare an then insert to db BUT first periodModel.CouponShare must be empty on first. why it's full??
            foreach (var shit in periodModel.CouponShare)
            {
                shit.CreatedDate = DateTime.Now;
            }

            foreach (var share in dto.CouponShare)
            {
                CouponShare model = _mapper.Map<CouponShare>(share);
                model.Id = Guid.NewGuid();
                model.CreatedDate = DateTime.Now;
                model.PeriodId = periodModel.Id;
                _repositoryManager.CouponShare.Create(model);
            }
            _repositoryManager.Period.Create(periodModel);
            _repositoryManager.Save();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    /// <summary>
    /// The UpdatePeriod
    /// </summary>
    /// <param name="dto">The dto<see cref="PeriodDto"/></param>
    /// <returns>The <see cref="Task{PeriodDto}"/></returns>
    public async Task<PeriodDto> UpdatePeriod(PeriodDto dto)
    {
        try
        {
            Period? periodModel = await _repositoryManager.Period.GetByIdAsync(dto.Id);
            if (periodModel is not null && periodModel.IsDeleted is false)
            {
                _mapper.Map(dto, periodModel);
                periodModel.IsDeleted = false;

                periodModel.CouponShare = null;
                foreach (var share in dto.CouponShare)
                {
                    if (share.Id == null || share.Id == Guid.Empty)
                    {
                        CouponShare model = _mapper.Map<CouponShare>(share);
                        model.Id = Guid.NewGuid();
                        model.CreatedDate = DateTime.Now;
                        model.PeriodId = periodModel.Id;
                        _repositoryManager.CouponShare.Create(model);
                    }
                    else
                    {
                        var model = await _repositoryManager.CouponShare.GetByIdAsync(
                            share.Id.Value
                        );

                        if (model != null)
                        {
                            model.Entitlement = share.Entitlement;
                            _repositoryManager.CouponShare.Update(model);
                        }
                    }
                }

                _repositoryManager.Period.Update(periodModel);
                _repositoryManager.Save();
                return dto;
            }
            else
            {
                throw new Exception($"Period With Id of {dto.Id} Not Found");
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"An Error Occured While Updating Period With Id of {dto.Id}");
        }
    }

    public async Task<PeriodDto> DeletePeriod(Guid Id)
    {
        try
        {
            Period? periodModel = await _repositoryManager.Period.GetByIdAsync(Id);
            if (periodModel is not null)
            {
                periodModel.IsDeleted = true;
                _repositoryManager.Period.Update(periodModel);
                _repositoryManager.Save();
                return new PeriodDto();
            }
            else
            {
                throw new Exception($"Period With Id of {Id} Not Found");
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"An Error Occured While Updating Period With Id of {Id}");
        }
    }
}
