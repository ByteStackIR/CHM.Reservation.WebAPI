using Entities.DataTransferObjects;
using Entities.DataTransferObjects.Models;
using Features.CustomRequest;
using Features.RequestFeatures;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IService
{
    public interface IUsersService
    {
        Task<PagedData<List<UserDto>>> GetAllUsersAsAdmin(AdminUsersTableRequest request);
        Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration);
        Task ToggleUserLockOut(Guid UserId);
        Task<UserForRegistrationDto> GetUserById(Guid UserId);
        Task<bool> UpdateUserAsAdmin(UserUpdateDto dto);
        Task<bool> UpdateUserAsCompany(UserUpdateDto dto);


        Task<List<UserDto>> GetUsersByRoles(List<string> roles);
    }
}
