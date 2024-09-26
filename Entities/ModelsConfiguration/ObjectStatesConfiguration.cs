namespace Entities.ModelsConfiguration
{
    using System;
    using Entities.Constant;
    using Entities.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Defines the <see cref="ObjectStatesConfiguration" />
    /// </summary>
    public class ObjectStatesConfiguration : IEntityTypeConfiguration<ObjectStates>
    {
        /// <summary>
        /// The Configure
        /// </summary>
        /// <param name="builder">The builder<see cref="EntityTypeBuilder{ObjectStates}"/></param>
        public void Configure(EntityTypeBuilder<ObjectStates> builder)
        {
            builder.HasData(
                new ObjectStates()
                {
                    Id = Guid.Parse("e790a6ce-6381-4b87-a157-5c6a73bc6470"),
                    Cancellable = false,
                    CategoryId = Guid.Parse("bd97c448-da11-4553-93e3-cac2976eb64f"),
                    Code = -1,
                    Title = "لفو شده!",
                    CreatedDate = DateTime.Now,
                    RoleId = RolesConstant.System,
                    ToBackward = false,
                    ToForward = false,
                    IsFinalNode = true,
                }
                ,
                new ObjectStates()
                {
                    Id = Guid.Parse("e790a6ce-6381-4b87-a157-5c6a73bc6471"),
                    Cancellable = true,
                    CategoryId = Guid.Parse("bd97c448-da11-4553-93e3-cac2976eb64f"),
                    Code = 0,
                    Title ="رزرو شده",
                    CreatedDate = DateTime.Now,
                    RoleId = RolesConstant.Operator,
                    ToBackward = true,
                    ToForward = true,
                    IsFinalNode = false,
                    CancelNode = -1,
                    NextNode = 1,
                    PreviousNode = -1,
                    IsStartNode = true
                }
                ,
                new ObjectStates()
                {
                    Id = Guid.Parse("e790a6ce-6381-4b87-a157-5c6a73bc6472"),
                    Cancellable = true,
                    CategoryId = Guid.Parse("bd97c448-da11-4553-93e3-cac2976eb64f"),
                    Code = 1,
                    Title = "در انتظار تایید مجری...",
                    CreatedDate = DateTime.Now,
                    RoleId = RolesConstant.Operator,
                    ToBackward = true,
                    ToForward = true,
                    IsFinalNode = false,
                    CancelNode = -1,
                    NextNode = 2,
                    PreviousNode = -1,
                    IsStartNode = false
                },
                new ObjectStates()
                {
                    Id = Guid.Parse("e790a6ce-6381-4b87-a157-5c6a73bc6473"),
                    Cancellable = false,
                    CategoryId = Guid.Parse("bd97c448-da11-4553-93e3-cac2976eb64f"),
                    Code = 2,
                    Title = "تایید شده!",
                    CreatedDate = DateTime.Now,
                    RoleId = RolesConstant.System,
                    ToBackward = false,
                    ToForward = false,
                    IsFinalNode = true,
                },
                // Hotel




                new ObjectStates()
                {
                    Id = Guid.Parse("99cf7da7-838f-4899-bc2f-5f9fe137bdb0"),
                    Cancellable = false,
                    CategoryId = Guid.Parse("cd97c448-da11-4553-93e3-cac2976eb64f"),
                    Code = -1,
                    Title = "لفو شده!",
                    CreatedDate = DateTime.Now,
                    RoleId = RolesConstant.System,
                    ToBackward = false,
                    ToForward = false,
                    IsFinalNode = true,
                },
                new ObjectStates()
                {
                    Id = Guid.Parse("99cf7da7-838f-4899-bc2f-5f9fe137bdb1"),
                    Cancellable = true,
                    CategoryId = Guid.Parse("cd97c448-da11-4553-93e3-cac2976eb64f"),
                    Code = 0,
                    Title = "رزرو شده",
                    CreatedDate = DateTime.Now,
                    RoleId = RolesConstant.System,
                    ToBackward = false,
                    ToForward = true,
                    IsFinalNode = false,
                    CancelNode = -1,
                    NextNode = 1,
                    IsStartNode = true
                },
                new ObjectStates()
                {
                    Id = Guid.Parse("99cf7da7-838f-4899-bc2f-5f9fe137bdb2"),
                    Cancellable = false,
                    CategoryId = Guid.Parse("cd97c448-da11-4553-93e3-cac2976eb64f"),
                    Code = 1,
                    Title = "در انتظار تایید حضور",
                    CreatedDate = DateTime.Now,
                    RoleId = RolesConstant.Operator,
                    ToBackward = false,
                    ToForward = true,
                    IsFinalNode = false,

                    NextNode = 2,
                },
                new ObjectStates()
                {
                    Id = Guid.Parse("99cf7da7-838f-4899-bc2f-5f9fe137bdb3"),
                    Cancellable = false,
                    CategoryId = Guid.Parse("cd97c448-da11-4553-93e3-cac2976eb64f"),
                    Code = 2,
                    Title = "حضور تایید شد!",
                    CreatedDate = DateTime.Now,
                    RoleId = RolesConstant.System,
                    ToBackward = false,
                    ToForward = false,
                    IsFinalNode = true,
                },
                new ObjectStates()
                {
                    Id = Guid.Parse("99cf7da7-838f-4899-bc2f-5f9fe137bdb4"),
                    Cancellable = false,
                    CategoryId = Guid.Parse("cd97c448-da11-4553-93e3-cac2976eb64f"),
                    Code = 3,
                    Title = "عدم حضور",
                    CreatedDate = DateTime.Now,
                    RoleId = RolesConstant.System,
                    ToBackward = false,
                    ToForward = false,
                    IsFinalNode = true,
                }
            );
        }
    }
}
