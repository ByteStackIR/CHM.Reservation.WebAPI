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
    public interface ICompanyService
    {
        Task<PagedData<List<CompanyDto>>> GetPagedAllCompanies(CompanyRequest request);
    }
}
