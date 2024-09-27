using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.ModelsConfiguration
{
    public class CompaniesConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                new Company()
                {
                    Id = Guid.Parse("cd97c448-da11-4553-93e3-cac2976eb64f"),
                    Title = "گندله سازی",
                    IsDeleted = false,
                    CreatedDate = new DateTime(2024, 01, 01, 01, 01, 01),
                },
                new Company()
                {
                    Id = Guid.Parse("bd97c448-da11-4553-93e3-cac2976eb64f"),
                    Title = "احیاء مستقیم",
                    IsDeleted = false,

                    CreatedDate = new DateTime(2024, 01, 01, 01, 01, 01),
                }
            );
        }
    }
}
