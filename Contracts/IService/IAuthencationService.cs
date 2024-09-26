using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Identity;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IService
{
    public interface IAuthenticationService {
        
        Task<bool> ValidateUser(UserForAuthenticationDto userForAuth);
        Task<string> CreateToken();
        Task<TokenDto> CreateToken(bool populateExp);
        Task<TokenDto> RefreshToken(TokenDto tokenDto);

        Task<OTPResultDto> GenerateUserOTP(string PhoneNumber, string identityCode);
        Task<bool> VerifyUserOTP(string PhoneNumber, string code);
    }
}
