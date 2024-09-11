using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configurtion
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole {Id = "06c89d20-2688-4ba4-939c-4562838a061a", Name = "User", NormalizedName = "User" },
                new IdentityRole { Id = "0650a88a-1647-4039-bbb8-af77779a1e59", Name = "Administrator", NormalizedName = "ADMINISTRATOR" },
                 new IdentityRole { Id = "dbd0d55e-6c75-45fa-9f33-303f06fb336d", Name = "Operator", NormalizedName = "OPERATOR" },
                   new IdentityRole { Id = "42a6ba09-9eed-4d77-9f3c-fb92dfcb40e9", Name = "Manager", NormalizedName = "MANAGER" }
            );
        }
    }
}
