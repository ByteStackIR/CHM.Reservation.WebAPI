namespace Entities.ModelsConfiguration
{
    using System;
    using Entities.Enum;
    using Entities.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Defines the <see cref="ParametersConfiguration" />
    /// </summary>
    public class ParametersConfiguration : IEntityTypeConfiguration<Parameter>
    {
        /// <summary>
        /// The Configure
        /// </summary>
        /// <param name="builder">The builder<see cref="EntityTypeBuilder{Parameter}"/></param>
        public void Configure(EntityTypeBuilder<Parameter> builder)
        {
            builder.HasData(
                new Parameter()
                {
                    Id = Guid.Parse("f47ac10b-58cc-4372-a567-0e02b2c3d479"), // آدرس
                    Title = "آدرس", // Address
                    CategoryId = Guid.Parse("cd97c448-da11-4553-93e3-cac2976eb64f"),
                    Type = ParameterType.Text,
                    CreatedDate = new DateTime(2024, 01, 01, 01, 01, 01),
                },
                new Parameter()
                {
                    Id = Guid.Parse("c9eb3f7a-bd4e-4b1d-b7e8-0a1c5f5e3c8e"), // ناهار؟
                    CategoryId = Guid.Parse("cd97c448-da11-4553-93e3-cac2976eb64f"),
                    Title = "ناهار؟", // Lunch?
                    Type =
                        ParameterType.Bool // Yes/No question
                    ,
                    CreatedDate = new DateTime(2024, 01, 01, 01, 01, 01),
                },
                new Parameter()
                {
                    Id = Guid.Parse("d9b5f0d4-5e8a-4b2f-bf29-0b7a4a3e6c6f"), // شام؟
                    Title = "شام؟", // Dinner?
                    CategoryId = Guid.Parse("cd97c448-da11-4553-93e3-cac2976eb64f"),
                    Type =
                        ParameterType.Bool // Yes/No question
                    ,
                    CreatedDate = new DateTime(2024, 01, 01, 01, 01, 01),
                },
                new Parameter()
                {
                    Id = Guid.Parse("3c6eb8a1-5d7a-4b9d-b3f3-0b3c6c7e8f8a"), // صبحانه؟
                    Title = "صبحانه؟", // Breakfast?
                    CategoryId = Guid.Parse("cd97c448-da11-4553-93e3-cac2976eb64f"),
                    Type =
                        ParameterType.Bool // Yes/No question
                    ,
                    CreatedDate = new DateTime(2024, 01, 01, 01, 01, 01),
                },
                new Parameter()
                {
                    Id = Guid.Parse("ab2b5f9e-df6e-4ef9-b8b1-0a1d0f9d0a1c"), // سرویس ایاب و ذهاب
                    Title = "سرویس ایاب و ذهاب", // Transportation Service
                    CategoryId = Guid.Parse("cd97c448-da11-4553-93e3-cac2976eb64f"),
                    Type =
                        ParameterType.Bool // Yes/No question
                    ,
                    CreatedDate = new DateTime(2024, 01, 01, 01, 01, 01),
                },
                new Parameter()
                {
                    Id = Guid.Parse("f47ac10b-58cc-4372-93e3-cac2976eb64f"), // توضیحات
                    Title = "توضیحات", // Description
                    CategoryId = Guid.Parse("cd97c448-da11-4553-93e3-cac2976eb64f"),
                    Type =
                        ParameterType.Text // Text type for detailed descriptions
                    ,
                    CreatedDate = new DateTime(2024, 01, 01, 01, 01, 01),
                },
                new Parameter()
                {
                    Id = Guid.Parse("f47ac10b-58cc-4372-a567-cac2976eb64f"), // توضیحات
                    Title = "توضیحات", // Description
                    CategoryId = Guid.Parse("bd97c448-da11-4553-93e3-cac2976eb64f"),
                    Type =
                        ParameterType.Text // Text type for detailed descriptions
                    ,
                    CreatedDate = new DateTime(2024, 01, 01, 01, 01, 01),
                },
                new Parameter()
                {
                    Id = Guid.Parse("c9eb3f7a-bd4e-4b1d-b7e8-cac2976eb64f"), // تعداد روز
                    Title = "تعداد روز", // Number of Days
                    Type = ParameterType.Numeric, // Numeric type for inputting the number of days
                    CategoryId = Guid.Parse("bd97c448-da11-4553-93e3-cac2976eb64f"),
                    CreatedDate = new DateTime(2024, 01, 01, 01, 01, 01),
                }
            );
        }
    }
}
