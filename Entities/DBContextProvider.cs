using Entities.Configurtion;
using Entities.Models;
using Entities.ModelsConfiguration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Entities
{
    public class DBContextProvider : IdentityDbContext<User>
    {
        public DBContextProvider(DbContextOptions options):base(options)
           { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.ApplyConfiguration(new DefinitionsConfiguration());
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RoleConfiguration());
           modelBuilder.ApplyConfiguration(new RelationsConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriesConfiguration());
        }




       // public DbSet<Transactions> Transactions { get; set; }
       public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CouponShare> CouponShares { get; set; }

        public DbSet<Entity> Entities { get; set; }
        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<Period> Periods { get; set; }



        public DbSet<Relation> Relations { get; set; }

        public DbSet<Relatives> Relatives { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<SelectedRelatives> SelectedRelatives { get; set; }

        public DbSet<Slot> Slots { get; set; }

        public DbSet<Tx_Coupon> Tx_Coupons { get; set; }

        public DbSet<Tx_User> Tx_Users { get; set; }

        public DbSet<UserCompany> UserCompanies { get; set; }
        public DbSet<ParameterValues> ParameterValues { get; set; }
        public DbSet<Attachments> Attachments { get; set; }

    }


}
