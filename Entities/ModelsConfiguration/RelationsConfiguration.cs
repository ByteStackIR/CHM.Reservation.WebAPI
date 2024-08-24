namespace Entities.ModelsConfiguration
{
    using Entities.Enum;
    using Entities.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;

    /// <summary>
    /// Defines the <see cref="RelationsConfiguration" />
    /// </summary>
    public class RelationsConfiguration : IEntityTypeConfiguration<Relation>
    {
        /// <summary>
        /// The Configure
        /// </summary>
        /// <param name="builder">The builder<see cref="EntityTypeBuilder{Relation}"/></param>
        public void Configure(EntityTypeBuilder<Relation> builder)
        {
            builder.HasData(
                  new Relation() { Id = Guid.Parse("10f944bb-9d33-4279-aed3-8f372907f27e"), Title = "خود", Type = RelationType.SELF, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("11f944bb-9d33-4279-aed3-8f372907f27e"), Title = "همسر", Type = RelationType.HAMSAR, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("12f944bb-9d33-4279-aed3-8f372907f27e"), Title = "فرزند", Type = RelationType.FARZAND, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("13f944bb-9d33-4279-aed3-8f372907f27e"), Title = "پدر", Type = RelationType.PEDAR, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("14f944bb-9d33-4279-aed3-8f372907f27e"), Title = "مادر", Type = RelationType.MADAR, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("15f944bb-9d33-4279-aed3-8f372907f27e"), Title = "پدر همسر", Type = RelationType.PEDAR2, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("16f944bb-9d33-4279-aed3-8f372907f27e"), Title = "مادر همسر", Type = RelationType.MADAR2, CreatedDate = DateTime.Now },

                  new Relation() { Id = Guid.Parse("17f944bb-9d33-4279-aed3-8f372907f27e"), Title = "عروس", Type = RelationType.AROS, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("18f944bb-9d33-4279-aed3-8f372907f27e"), Title = "داماد", Type = RelationType.DAMAD, CreatedDate = DateTime.Now },

                  new Relation() { Id = Guid.Parse("19f944bb-9d33-4279-aed3-8f372907f27e"), Title = "خواهر", Type = RelationType.KHAHAR, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("20f944bb-9d33-4279-aed3-8f372907f27e"), Title = "برادر", Type = RelationType.BARADAR, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("21f944bb-9d33-4279-aed3-8f372907f27e"), Title = "عمه", Type = RelationType.AMMEH, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("22f944bb-9d33-4279-aed3-8f372907f27e"), Title = "خاله", Type = RelationType.KHALEH, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("23f944bb-9d33-4279-aed3-8f372907f27e"), Title = "دایی", Type = RelationType.DAEI, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("24f944bb-9d33-4279-aed3-8f372907f27e"), Title = "عمو", Type = RelationType.AMO, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("25f944bb-9d33-4279-aed3-8f372907f27e"), Title = "آزاد", Type = RelationType.AZAD, CreatedDate = DateTime.Now }
              );
        }
    }
}
