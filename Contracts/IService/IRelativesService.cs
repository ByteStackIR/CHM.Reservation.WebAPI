using Entities.DataTransferObjects;
using Entities.DataTransferObjects.Models;
using Features.CustomRequest;
using Features.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IService
{
    public interface IRelativesService
    {
        Task<List<RelativeDto>> GetbyUserId(Guid UserId);
        Task<RelativeDto> GetById(Guid Id);
        Task<List<RelativeDto>> GetConfirmedRelatives(Guid UserId);
        Task<PagedData<List<UserRelativesDto>>> GetNotCheckedRelativesAsAdmin(ListNotCheckedRelativesRequest request);
        Task<PagedData<List<UserRelativesDto>>> GetNotCheckedRelativesAsCompany(ListNotCheckedRelativesRequest request);

        Task<RelativeDto> InsertByUser(RelativeDto dto);
        Task<List<RelativeDto>> BulkInsertByUser(List<RelativeDto> dto);
        Task<List<RelativeDto>> BulkInsertByCompany(UserRelativesCreationDto dto);

        Task<List<RelativeDto>> BulkInsertByAdmin(UserRelativesCreationDto dto);
        Task<RelativeDto> UpdateByUser(RelativeDto dto);
        Task<RelativeDto> UpdateByCompany(RelativeDto dto);
        Task<RelativeDto> UpdateByAdmin(RelativeDto dto);
        Task<RelativeDto> ToggleByUser(Guid Id);
        Task<RelativeDto> ToggleByCompany(Guid UserId, Guid Id);
        Task<RelativeDto> ToggleByAdmin(Guid UserId, Guid Id);
        Task<RelativeDto> ResultOfReviewRelative(Guid UserId, Guid Id, bool Accept);
    }
}
