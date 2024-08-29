using Entities.DataTransferObjects.Models;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IService
{
    public interface IUserCompanyService
    {
        Task<UserCompanyDto> AddUserToCompany(Guid UserId,Guid CompanyId, string PersonnelCode);
        Task<UserCompanyDto> AddUserToCompany(string PhoneNumber, Guid CompanyId, string PersonnelCode);
        //Task<UserCompanyDto> RemoveUserFromCompany(Guid UserId, Guid CompanyId);

        //Task<UserCompanyDto> ChangePersonnelCode(Guid UserId, Guid CompanyId);

        //Task<UserCompanyDto> AddToCompany(Guid UserId, Guid CompanyId);

    }
}
