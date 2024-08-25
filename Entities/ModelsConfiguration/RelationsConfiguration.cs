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
                  new Relation() { Id = Guid.Parse("00000000-9d33-4279-aed3-8f372907f27e"), Title = "تحت تکفل",ParentId=null, Type = RelationType.DEPENDENTS, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("11111111-9d33-4279-aed3-8f372907f27e"), Title = "سایر", ParentId = null, Type = RelationType.INDEPENDENTS, CreatedDate = DateTime.Now },



                  new Relation() { Id = Guid.Parse("10f944bb-9d33-4279-aed3-8f372907f27e"), Title = "خود", ParentId = Guid.Parse("00000000-9d33-4279-aed3-8f372907f27e"), Type = RelationType.SELF, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("11f944bb-9d33-4279-aed3-8f372907f27e"), Title = "همسر", ParentId = Guid.Parse("00000000-9d33-4279-aed3-8f372907f27e"), Type = RelationType.HAMSAR, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("12f944bb-9d33-4279-aed3-8f372907f27e"), Title = "فرزند", ParentId = Guid.Parse("00000000-9d33-4279-aed3-8f372907f27e"), Type = RelationType.FARZAND, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("13f944bb-9d33-4279-aed3-8f372907f27e"), Title = "پدر", ParentId = Guid.Parse("00000000-9d33-4279-aed3-8f372907f27e"), Type = RelationType.PEDAR, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("14f944bb-9d33-4279-aed3-8f372907f27e"), Title = "مادر", ParentId = Guid.Parse("00000000-9d33-4279-aed3-8f372907f27e"), Type = RelationType.MADAR, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("15f944bb-9d33-4279-aed3-8f372907f27e"), Title = "پدر همسر", ParentId = Guid.Parse("00000000-9d33-4279-aed3-8f372907f27e"), Type = RelationType.PEDAR2, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("16f944bb-9d33-4279-aed3-8f372907f27e"), Title = "مادر همسر", ParentId = Guid.Parse("00000000-9d33-4279-aed3-8f372907f27e"), Type = RelationType.MADAR2, CreatedDate = DateTime.Now },

                  new Relation() { Id = Guid.Parse("17f944bb-9d33-4279-aed3-8f372907f27e"), Title = "عروس", ParentId = Guid.Parse("11111111-9d33-4279-aed3-8f372907f27e"), Type = RelationType.AROS, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("18f944bb-9d33-4279-aed3-8f372907f27e"), Title = "داماد", ParentId = Guid.Parse("11111111-9d33-4279-aed3-8f372907f27e"), Type = RelationType.DAMAD, CreatedDate = DateTime.Now },

                  new Relation() { Id = Guid.Parse("19f944bb-9d33-4279-aed3-8f372907f27e"), Title = "خواهر", ParentId = Guid.Parse("11111111-9d33-4279-aed3-8f372907f27e"), Type = RelationType.KHAHAR, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("20f944bb-9d33-4279-aed3-8f372907f27e"), Title = "برادر", ParentId = Guid.Parse("11111111-9d33-4279-aed3-8f372907f27e"), Type = RelationType.BARADAR, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("21f944bb-9d33-4279-aed3-8f372907f27e"), Title = "عمه", ParentId = Guid.Parse("11111111-9d33-4279-aed3-8f372907f27e"), Type = RelationType.AMMEH, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("22f944bb-9d33-4279-aed3-8f372907f27e"), Title = "خاله", ParentId = Guid.Parse("11111111-9d33-4279-aed3-8f372907f27e"), Type = RelationType.KHALEH, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("23f944bb-9d33-4279-aed3-8f372907f27e"), Title = "دایی", ParentId = Guid.Parse("11111111-9d33-4279-aed3-8f372907f27e"), Type = RelationType.DAEI, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("24f944bb-9d33-4279-aed3-8f372907f27e"), Title = "عمو", ParentId = Guid.Parse("11111111-9d33-4279-aed3-8f372907f27e"), Type = RelationType.AMO, CreatedDate = DateTime.Now },
                  new Relation() { Id = Guid.Parse("25f944bb-9d33-4279-aed3-8f372907f27e"), Title = "بدون نسبت", ParentId = Guid.Parse("11111111-9d33-4279-aed3-8f372907f27e"), Type = RelationType.AZAD, CreatedDate = DateTime.Now }
              );
        }
    }
}
