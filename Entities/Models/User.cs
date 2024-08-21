using Entities.Enum;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Index(nameof(PhoneNumber),IsUnique =true)]
    public class User: IdentityUser
    {
        public override string? Email { get => base.Email ; set => base.Email = value ; }
        public string FirstName { get; set; }
        public string LastName { get; set;}

        public GenderType? Gender { get; set; }
        public override string PhoneNumber { get => base.PhoneNumber; set => base.PhoneNumber = value; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }


    }
}
