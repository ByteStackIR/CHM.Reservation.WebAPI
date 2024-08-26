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

        public ICollection<UserCompany> UserCompanies { get; set; } = new List<UserCompany>();
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
        public ICollection<Tx_Coupon> TxCoupons { get; set; } = new List<Tx_Coupon>();
        public ICollection<Tx_User> TxUsers { get; set; } = new List<Tx_User>();

        public ICollection<Relatives> Relatives { get; set; }   
    }
}
