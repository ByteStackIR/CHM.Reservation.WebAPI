using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Entities.IdentityExtensions
{
    public static class ClaimsExtenstion
    {

        public static Guid? GetUserId(this ClaimsPrincipal claimsPrincipal)
        {
            string? UserId = claimsPrincipal.FindFirstValue(ClaimTypes.NameIdentifier);
            if(UserId==null)
                return null;

            return Guid.Parse(UserId);

        }

        public static bool IsInRoles(this ClaimsPrincipal claimsPrincipal,List<string> Roles)
        {
           var userRoles = claimsPrincipal.FindAll(ClaimTypes.Role).Select(x=>x.Value).ToList();
            var t = userRoles.Intersect(Roles).ToList();
            if (userRoles.Intersect(Roles).Count() > 0)
                return true;
            return false;

        }

    }
}
