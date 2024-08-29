using Entities.DataTransferObjects.Models;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IService
{
    public interface IUserCompnayService
    {
        Task<UserCompanyDto> AddToCompany(Guid UserId,Guid CompanyId);
        Task<UserCompanyDto> DisableCompany(Guid UserId, Guid CompanyId);
        //Task<UserCompanyDto> AddToCompany(Guid UserId, Guid CompanyId);

    }
}
