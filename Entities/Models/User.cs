using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enum;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Entities.Models
{
    [Index(nameof(PhoneNumber), IsUnique = true)]
    public class User : IdentityUser
    {
        public override string? Email
        {
            get => base.Email;
            set => base.Email = value;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public GenderType Gender { get; set; }
        public override string PhoneNumber
        {
            get => base.PhoneNumber;
            set => base.PhoneNumber = value;
        }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        public ICollection<UserCompany> UserCompanies { get; set; }
        public ICollection<Reservation> Reservations { get; set; }

        [InverseProperty(nameof(Tx_Coupon.User))]
        public ICollection<Tx_Coupon> TxCoupons { get; set; }

        [InverseProperty(nameof(Tx_User.User))]
        public ICollection<Tx_User> TxUsers { get; set; }

        [InverseProperty(nameof(Tx_Credit.User))]
        public ICollection<Tx_Credit> TxCredits { get; set; }

        [DeleteBehavior(DeleteBehavior.ClientNoAction)]
        [InverseProperty(nameof(Tx_Coupon.CreatorUser))]
        public ICollection<Tx_Coupon> CreatorTxCoupons { get; set; }

        [DeleteBehavior(DeleteBehavior.ClientNoAction)]
        [InverseProperty(nameof(Tx_User.CreatorUser))]
        public ICollection<Tx_User> CreatorTxUsers { get; set; }

        [DeleteBehavior(DeleteBehavior.ClientNoAction)]
        [InverseProperty(nameof(Tx_Credit.CreatorUser))]
        public ICollection<Tx_Credit> CreatorTxCredits { get; set; }
        public ICollection<Relatives> Relatives { get; set; }
    }
}
