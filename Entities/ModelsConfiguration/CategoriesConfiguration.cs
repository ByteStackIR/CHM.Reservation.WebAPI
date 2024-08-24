using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Entities.ModelsConfiguration
{

    public class CategoriesConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
               new Category() { Id = Guid.Parse("cd97c448-da11-4553-93e3-cac2976eb64f"), Title = "Hotel", Description = "هتل به فارسی", CreatedDate = new DateTime(2024, 01, 01, 01, 01, 01) },
                new Category() { Id = Guid.Parse("bd97c448-da11-4553-93e3-cac2976eb64f"), Title = "Tour", Description = "تور به فارسی", CreatedDate = new DateTime(2024, 01, 01, 01, 01, 01) }
            );
        }
    }
}
