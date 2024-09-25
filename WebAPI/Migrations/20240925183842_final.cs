using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<short>(type: "smallint", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attachments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ObjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Definitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Definitions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Definitions_Definitions_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Definitions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Periods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stipend = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Relations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<short>(type: "smallint", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Maximum = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Relations_Relations_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Relations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntityManagers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityManagers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityManagers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ObjectStates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    NextNode = table.Column<int>(type: "int", nullable: true),
                    PreviousNode = table.Column<int>(type: "int", nullable: true),
                    CancelNode = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cancellable = table.Column<bool>(type: "bit", nullable: false),
                    ToForward = table.Column<bool>(type: "bit", nullable: false),
                    ToBackward = table.Column<bool>(type: "bit", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsFinalNode = table.Column<bool>(type: "bit", nullable: false),
                    IsStartNode = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectStates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ObjectStates_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObjectStates_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parameters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parameters_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCompanies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    PersonnelCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCompanies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCompanies_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCompanies_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PeriodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PerPerson = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CompanyShare = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PersonShare = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cancelable = table.Column<bool>(type: "bit", nullable: false),
                    MaxReserveTimes = table.Column<short>(type: "smallint", nullable: false),
                    MinAge = table.Column<short>(type: "smallint", nullable: false),
                    DaysToCancel = table.Column<short>(type: "smallint", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entities_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Entities_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entities_Definitions_CityId",
                        column: x => x.CityId,
                        principalTable: "Definitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entities_Periods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "Periods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CouponShares",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PeriodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RelationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Entitlement = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CouponShares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CouponShares_Periods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "Periods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CouponShares_Relations_RelationId",
                        column: x => x.RelationId,
                        principalTable: "Relations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Relatives",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RelationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdentityCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<short>(type: "smallint", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsChecked = table.Column<bool>(type: "bit", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relatives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Relatives_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Relatives_Relations_RelationId",
                        column: x => x.RelationId,
                        principalTable: "Relations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParameterValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParameterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParameterValues_Entities_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParameterValues_Parameters_ParameterId",
                        column: x => x.ParameterId,
                        principalTable: "Parameters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Slots",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slots_Entities_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SlotId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BillAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsFinalized = table.Column<bool>(type: "bit", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ObjectStateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_ObjectStates_ObjectStateId",
                        column: x => x.ObjectStateId,
                        principalTable: "ObjectStates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_Slots_SlotId",
                        column: x => x.SlotId,
                        principalTable: "Slots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservationStates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReservationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ObjectStateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToForward = table.Column<bool>(type: "bit", nullable: false),
                    IsCancelled = table.Column<bool>(type: "bit", nullable: false),
                    IsDone = table.Column<bool>(type: "bit", nullable: false),
                    CreatorUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ActorUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationStates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservationStates_AspNetUsers_ActorUserId",
                        column: x => x.ActorUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReservationStates_AspNetUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationStates_ObjectStates_ObjectStateId",
                        column: x => x.ObjectStateId,
                        principalTable: "ObjectStates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReservationStates_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SelectedRelatives",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReservationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RelativeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedRelatives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SelectedRelatives_Relatives_RelativeId",
                        column: x => x.RelativeId,
                        principalTable: "Relatives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedRelatives_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tx_Coupons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ReservationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PeriodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tx_Coupons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tx_Coupons_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tx_Coupons_Periods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "Periods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tx_Coupons_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tx_Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ReservationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PeriodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tx_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tx_Users_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tx_Users_Periods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "Periods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tx_Users_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0650a88a-1647-4039-bbb8-af77779a1e59", null, "Administrator", "ADMINISTRATOR" },
                    { "06c89d20-2688-4ba4-939c-4562838a061a", null, "User", "User" },
                    { "42a6ba09-9eed-4d77-9f3c-fb92dfcb40e9", null, "Manager", "MANAGER" },
                    { "53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9", null, "System", "SYSTEM" },
                    { "dbd0d55e-6c75-45fa-9f33-303f06fb336d", null, "Operator", "OPERATOR" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("bd97c448-da11-4553-93e3-cac2976eb64f"), new DateTime(2024, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "تور به فارسی", "Tour" },
                    { new Guid("cd97c448-da11-4553-93e3-cac2976eb64f"), new DateTime(2024, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "هتل به فارسی", "Hotel" }
                });

            migrationBuilder.InsertData(
                table: "Definitions",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ParentId", "Title" },
                values: new object[] { new Guid("89798567-a31a-43e9-9608-aa726eea6167"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(671), false, null, "Cities" });

            migrationBuilder.InsertData(
                table: "Relations",
                columns: new[] { "Id", "CreatedDate", "Maximum", "ParentId", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("00000000-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9211), null, null, "تحت تکفل", (short)-1 },
                    { new Guid("11111111-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9219), null, null, "سایر", (short)-2 }
                });

            migrationBuilder.InsertData(
                table: "Definitions",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ParentId", "Title" },
                values: new object[,]
                {
                    { new Guid("00426149-b220-4d2f-8a8c-7a0fd828ae63"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1055), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خمام" },
                    { new Guid("00796d93-3bac-4438-800f-a517e1d25fb1"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1188), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "كردكوی" },
                    { new Guid("0089da3e-e43d-4e95-a575-703e236f754e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1032), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "نجف آباد" },
                    { new Guid("008b8712-9c18-409f-b800-59d810b8de56"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(970), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خرمشهر" },
                    { new Guid("010954e4-b6c9-43ae-a8c3-9408a664469a"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1153), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سرپل ذهاب" },
                    { new Guid("0232d0bd-ab11-4521-846e-63e2680ceadd"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1001), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "پارس آباد" },
                    { new Guid("0259f4b1-ce87-4c87-9563-ac2e0b5a592e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1233), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "پارسیان" },
                    { new Guid("037318bb-5724-41f7-8051-5d23548177c1"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(978), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "کاشان" },
                    { new Guid("041e29fc-5a95-4ac5-a874-46a3a5a485a9"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(902), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "تایباد" },
                    { new Guid("04d7614a-fd5b-43c0-997f-5d0bc6992c22"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(977), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "گرمی" },
                    { new Guid("053c3572-09f0-4b19-a27a-9a3ab5603eea"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1161), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "نیشابور" },
                    { new Guid("0551b1ae-02fb-4a85-8d6f-843c176ab185"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1121), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "چایپاره" },
                    { new Guid("05adef7a-da72-4cd6-a773-afdbc6856f30"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1240), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "لنگرود" },
                    { new Guid("06385e6d-71b8-4cc1-b674-f7d89dd51e3a"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1403), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "دزپارت" },
                    { new Guid("06495180-6ca0-4a80-adaa-0919c62d64c5"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(705), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "زرآباد" },
                    { new Guid("066c5ba4-db24-4508-9e2b-fff2e03cba04"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1416), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خرم بید" },
                    { new Guid("07041287-5b65-496d-9321-038ae5726180"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(694), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "قایم شهر" },
                    { new Guid("074db01f-a37f-4018-affa-279bf48bb0e9"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(816), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "دهگلان" },
                    { new Guid("07c74cb0-b861-49e3-98d5-f972fb6a3fdc"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1404), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "الیگودرز" },
                    { new Guid("07d836c1-6b34-4672-bbfe-6726ba94d574"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1010), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "گیلانغرب" },
                    { new Guid("08861d0f-f9cd-4a3b-89ec-8c72ba8b5bcc"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1139), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "آمل" },
                    { new Guid("08c0780a-87db-4f7a-9d92-3cc15df8064c"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(870), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ایرانشهر" },
                    { new Guid("0928fab9-ab19-4046-8312-2d7252b61ffa"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(826), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سراب" },
                    { new Guid("099ec0e6-db40-467b-9e74-2f5adab88e54"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(834), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سمیرم" },
                    { new Guid("09e61570-9ae5-464c-85fa-8e4b07720f1c"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1141), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "عنبرآباد" },
                    { new Guid("09ff7859-d023-4f78-8821-e0d45af4fe3a"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1360), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "زارچ" },
                    { new Guid("0b2196a7-083b-4ac5-91d6-e4412f59a0c7"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1366), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "كنگان" },
                    { new Guid("0b82168f-89f5-47ba-98e0-83f5ebec0061"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1120), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "آبادان" },
                    { new Guid("0c0295cf-7a5c-45cb-b095-dd25da8476ea"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1330), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "انگوت" },
                    { new Guid("0dc49665-00a9-4d3d-a4e3-7b77fc90c92f"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1084), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "رامهرمز" },
                    { new Guid("0df6575d-b889-47a1-9351-76974fee3692"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1050), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خور و بیابانک" },
                    { new Guid("0e19da8d-710d-4f4f-9fcd-244a46428058"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(806), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بجستان" },
                    { new Guid("0e6e8a20-0b44-4f05-80a0-663be5021e1e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1004), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "برخوار" },
                    { new Guid("0f9967df-85fb-4da4-97d6-713f6fb9958c"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1034), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "باخرز" },
                    { new Guid("0ff09a27-a182-444d-b1e5-a63154bfcb5b"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1220), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "قروه" },
                    { new Guid("10f10dd8-c4ca-4a52-b7f4-fb2798115098"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1410), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "دشتیاری" },
                    { new Guid("10fcf4e8-99a7-4a07-9e8c-dd390b752814"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1331), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "آبدانان" },
                    { new Guid("11931771-4c9d-4702-b9e5-38656e12faf1"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(855), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سروستان" },
                    { new Guid("11d4977a-2994-4cd9-a3d8-977f461970b5"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1157), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "باغ ملک" },
                    { new Guid("11e4f171-9f82-460a-acd8-d1fc128b81c0"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1303), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "شوشتر" },
                    { new Guid("11fb93aa-6d4f-49a1-abc4-3dbe21405b7a"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(871), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "فریدونكنار" },
                    { new Guid("12129a02-7541-451d-8327-f104949f39c3"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1388), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "تركمن" },
                    { new Guid("1475c694-8485-424d-82b4-586a73a16cfc"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(965), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "فسا" },
                    { new Guid("14c4ff41-e7a8-4dad-a68e-254702ae1c7a"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(809), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خرمدره" },
                    { new Guid("14c6146d-5e3f-4748-9ff6-c2d0c95cb2c4"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1275), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "باشت" },
                    { new Guid("15bcd116-32fb-4715-9828-e935fcc10a3b"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1374), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "مهرستان" },
                    { new Guid("165bebab-de98-4f5e-bfe6-efd0775c1029"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1386), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "آق قلا" },
                    { new Guid("1689dd47-ef24-458a-a730-bbf7e06fe2eb"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1261), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "روانسر" },
                    { new Guid("16fc89ad-e6e8-49e4-9e8b-564eb840238d"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(961), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "نطنز" },
                    { new Guid("18570096-a785-4fb4-bcbe-334990a885ee"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(841), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "شهرکرد" },
                    { new Guid("19383580-add1-4306-9c59-81c14fa7b8e6"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1112), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "آزادشهر" },
                    { new Guid("199eaf80-692c-49ec-bd7c-12aac8404727"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(735), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "تبریز" },
                    { new Guid("19a16bfa-42a6-440b-af73-88125a28fe30"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1129), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "چاه بهار" },
                    { new Guid("1a24e60e-a22b-49d2-a781-134ff662080f"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(740), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "هرند" },
                    { new Guid("1a7a091e-51b7-4bcf-b87b-9f302cee1416"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1171), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "کرج" },
                    { new Guid("1aaeace3-c873-41c7-b204-d7e056d98db9"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1315), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "رودان" },
                    { new Guid("1ab6e719-eb6a-4cca-af09-ec33b883e938"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1381), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "چرداول" },
                    { new Guid("1b2284c8-286f-499d-992f-0d0073839155"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(714), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سلسله" },
                    { new Guid("1b6493f4-0420-4d1a-9f4e-b8a28e329b08"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1255), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "نیمروز" },
                    { new Guid("1b7ed58c-45da-4dc8-bbf9-fa323f0e749f"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1406), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بختگان" },
                    { new Guid("1c7ab1a7-41c1-4034-aeb6-e049d2f8f942"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1356), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "پاكدشت" },
                    { new Guid("1d22f948-00f7-41e9-9417-895c18db51d8"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1130), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "طالقان" },
                    { new Guid("1d5607a4-0879-444f-a376-81105afea93b"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1107), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "آستانه اشرفیه" },
                    { new Guid("1ddde177-9c8b-4c97-a440-1f2a803f0365"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(765), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بویراحمد" },
                    { new Guid("1e2ba14a-c065-4cf6-a3e6-4e1917784c0f"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(948), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "نایین" },
                    { new Guid("1ea6a91f-3584-417d-9036-83c3a3b10926"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1118), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ایجرود" },
                    { new Guid("1f994a98-9dbd-486f-8d9b-ad854169d3c8"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1237), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "هیرمند" },
                    { new Guid("209858f9-abe6-4485-866d-7014badb77d8"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1030), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "رامیان" },
                    { new Guid("2261bb04-71f1-4e99-b2dc-8182d876f2dd"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1109), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سرایان" },
                    { new Guid("22b12edb-4818-42fd-94ae-6da9e55b4012"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1024), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "لیلان" },
                    { new Guid("232e5aeb-c4bc-4fff-8667-5550631a69a3"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(959), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "طبس" },
                    { new Guid("24303819-1ee4-4ec2-b571-a407ec3aa378"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1187), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "صیدون" },
                    { new Guid("25e19797-06ea-4696-a3f2-d1ab3248ab43"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1301), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "چهارباغ" },
                    { new Guid("2636492d-1cb3-4e50-8aac-0ee34ad8e4cd"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(725), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "جلفا" },
                    { new Guid("26f94415-8b8f-45b4-8632-2d959cfeecf4"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(828), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "اصفهان" },
                    { new Guid("2853f370-1546-47a0-b60d-6d528b73c92a"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1022), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بهمیی" },
                    { new Guid("285b1d5c-e1c2-4a5b-a5dc-2b943f97f979"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(824), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خواف" },
                    { new Guid("28a37e94-cad9-4f06-b2fc-4b67ed20fdfe"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(911), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ملکان" },
                    { new Guid("2926410c-854d-4c8b-8245-0336496d6c00"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(692), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "اشکذر" },
                    { new Guid("29d54105-fffa-4a4a-ad98-175920430b51"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(749), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "زبرخان" },
                    { new Guid("2a0b9a3c-7cd2-4716-bec9-73bba194cb09"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1042), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "گرمسار" },
                    { new Guid("2a260d88-e538-4d80-92ad-aaf1240c8017"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1228), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "شیروان" },
                    { new Guid("2a8d107e-5f4c-4290-91a3-3e59be3d64ef"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(872), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "قصرقند" },
                    { new Guid("2b38c454-1e24-4b98-9a0a-e03ff43301e2"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1355), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "اهواز" },
                    { new Guid("2b52d3fc-9cd8-486f-84c3-68b530f5463c"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1015), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بیرجند" },
                    { new Guid("2c88305d-e042-4557-91af-0d5ea2563679"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(720), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خداآفرین" },
                    { new Guid("2ca68fb0-ab73-4463-8fa6-61d47cf15dac"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(993), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "فومن" },
                    { new Guid("2d82efc8-b056-4577-8455-058946fb4c62"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(699), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "اشنویه" },
                    { new Guid("2dc5dfd9-dc4e-445d-8e4d-91d57bbe5378"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1149), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "دیلم" },
                    { new Guid("2dd97c45-9749-4801-acc1-2340b1912ef4"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(803), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "میبد" },
                    { new Guid("2e5a8cdd-36ab-49be-aa20-4da313576141"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(946), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سراوان" },
                    { new Guid("2ecdcbd2-f9ed-4f09-80cd-43f2e4c5c76e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(890), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خرامه" },
                    { new Guid("2f2f5da8-b6c3-495a-ad90-6b96b85c8892"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1019), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ازنا" },
                    { new Guid("2fc0d02a-7cad-4bd8-9595-fa6c62304a24"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1407), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "گمیشان" },
                    { new Guid("2ff82f99-9cc2-4f48-b232-594849157f93"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(966), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "كوثر" },
                    { new Guid("33cd7e7a-eb2f-4f8d-98d9-72a5861254b5"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1038), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "جاسك" },
                    { new Guid("344aaa4f-8e21-4b00-acde-c650227d3956"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1288), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بشاگرد" },
                    { new Guid("35aa4138-af76-45d9-abb2-9f434e90528f"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1173), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "هوراند" },
                    { new Guid("35b52a43-0d0d-427f-9d77-a57f69b21c77"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1191), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "زرند" },
                    { new Guid("377d24c3-274d-4146-acaa-4c122928d6d1"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(913), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ماهنشان" },
                    { new Guid("378c9ddf-099e-4c8a-bdc6-9cbf5a396384"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1166), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "آستارا" },
                    { new Guid("3839bd7a-2883-4c4a-bd88-d01177941f0b"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1297), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "آباده" },
                    { new Guid("39c114bb-2f88-4ba7-ad93-6aed02fb4792"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1017), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "کوهپایه" },
                    { new Guid("3a75b685-2102-44ec-94dd-1145e926a0aa"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(731), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "زرین دشت" },
                    { new Guid("3a77157e-79ae-4bcc-8422-75f13225b1ba"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1049), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سرخه" },
                    { new Guid("3a800b7e-03ce-46b8-b476-4d83c38fe68b"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(945), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "پردیس" },
                    { new Guid("3ac165e0-5697-4e5c-8f17-2e3e23e0c2c8"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(830), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "جویم" },
                    { new Guid("3b5e911d-cf4d-400f-b5e6-2e6552467d49"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(833), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سروآباد" },
                    { new Guid("3b931ba7-43a3-48a2-b329-3ae34e663f3e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(866), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "دشتی" },
                    { new Guid("3cab5f0f-7a5f-4006-aacf-1b3f3b79dd54"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(758), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بابل" },
                    { new Guid("3d44850a-0910-4c76-bc22-edd9023e61bd"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1385), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سرباز" },
                    { new Guid("3d580e2f-3e6c-40ea-b7fa-ba28d79ed42e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1259), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "کرمانشاه" },
                    { new Guid("3d90f010-97f0-4c7f-bce9-0faebd657b9d"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(727), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "کلیبر" },
                    { new Guid("3e6b1364-e6cc-429c-a265-2ff5531dad9b"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(837), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "اسدآباد" },
                    { new Guid("3ee8fa6e-581f-43d6-90ca-0325bb7d9bc3"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(690), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "چرام" },
                    { new Guid("3fc83420-bc3a-4ca4-81f7-33c84c8e2069"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(845), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ساری" },
                    { new Guid("405af3e9-caab-4956-b055-dfc53f541cf4"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1352), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "درمیان" },
                    { new Guid("412002b6-64ba-4400-aca0-bb5313ff5b95"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1260), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سیمرغ" },
                    { new Guid("41316ba4-3dbc-4a09-a0a6-f6a11432d0cd"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1396), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "شمیرانات" },
                    { new Guid("4164c126-3206-436b-a5e2-0c7373f2bb1d"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(713), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سیرجان" },
                    { new Guid("41c93f45-0521-4a5f-9d9f-6eaf23b39e61"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1025), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "راسک" },
                    { new Guid("41dbe593-b8e0-4d5a-b634-fec2197d5b46"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1414), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "همدان" },
                    { new Guid("43c86327-c931-46ea-b0ef-3162ffd5605f"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(838), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "گرمه" },
                    { new Guid("44119950-4fcb-4679-b8f4-2e2bb9396d9e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(829), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "کوار" },
                    { new Guid("442d7441-cae3-4e56-b898-0d24e0803340"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(717), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "زیرکوه" },
                    { new Guid("4504062b-53bc-4fac-a0e6-5a02c50b21d8"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(971), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "مشگین شهر" },
                    { new Guid("459bbba3-4feb-4b55-bc7d-3c3c08ef474d"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(868), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "دیر" },
                    { new Guid("45a4b551-49ba-43a8-9030-c5d380d480c1"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1287), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "رودسر" },
                    { new Guid("45ed2363-ab56-4bbc-80f2-6192e74e63b3"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(991), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "کوهسرخ" },
                    { new Guid("46f8cb0e-7b9c-44ee-bfdb-12db3c92bfd3"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(737), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "فریمان" },
                    { new Guid("4740fbff-245d-4578-813f-b9596a47523b"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1257), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خنج" },
                    { new Guid("47c1432d-e35e-4510-833f-15f15a515190"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(744), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سپیدان" },
                    { new Guid("47c91ea2-6350-437c-8142-388098ab3a18"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(857), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "گرگان" },
                    { new Guid("48f9a0eb-6ccb-45e7-9168-951949718c83"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1154), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خوی" },
                    { new Guid("4915c4f4-e198-4ae7-8222-e4de91b431cb"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1368), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بروجرد" },
                    { new Guid("4955990b-4a8f-4075-8e88-5393913a49fa"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(956), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "باوی" },
                    { new Guid("4a290d8f-a2c1-4b0f-8a32-a6144636f2d8"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1218), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "پاسارگاد" },
                    { new Guid("4a477f19-9d9f-48d2-9aaf-f789109f565a"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1402), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "پیرانشهر" },
                    { new Guid("4a52efe9-c9df-4b46-b6b2-12c804f83f14"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(736), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "رباط کریم" },
                    { new Guid("4b214e78-b72a-475d-9285-e5445c4e314e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1369), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "كبودرآهنگ" },
                    { new Guid("4bb41681-6261-4b93-8116-40443ecfc2a0"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(884), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "لامرد" },
                    { new Guid("4bd86ffd-378f-4236-a3a5-91a4939148c9"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1148), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "عسلویه" },
                    { new Guid("4c725dcb-dfe3-4586-8140-c02f24364d6d"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1270), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "صحنه" },
                    { new Guid("4dc6124a-1f25-4188-b032-d89cdb950870"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1320), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "گچساران" },
                    { new Guid("4e02d0ff-7259-44fe-9f60-122ddbfad80d"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(733), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "جهرم" },
                    { new Guid("4f0a3567-ae7d-4bd7-b2c4-405729e74a4e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(886), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "رفسنجان" },
                    { new Guid("4f3ab0c1-c6e2-445e-9cbf-6ba4cd49b208"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1020), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "تیران وکرون" },
                    { new Guid("4fc7f33b-bd02-42d4-9c1a-bee66c120f47"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1265), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "هلیلان" },
                    { new Guid("50034e5a-64d2-4095-9c7e-2807a5825551"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(818), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سربیشه" },
                    { new Guid("51453f26-0d50-4fff-9f05-1031be904c03"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(728), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "هریس" },
                    { new Guid("5159bc0d-55a2-4d1e-a006-ab9d2233954e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1231), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "نرماشیر" },
                    { new Guid("51913cdd-2e43-4085-9466-212b0a166774"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(799), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "تفت" },
                    { new Guid("5293319b-cb27-4fbd-b96a-5992f8bf9c72"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(969), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "اسلام آبادغرب" },
                    { new Guid("52f577d3-3580-4f86-bf71-ff2ad19379ae"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1415), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "نهاوند" },
                    { new Guid("534c9ad7-b833-4795-9ae1-b07a1ab0f2fb"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1241), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "مهدی شهر" },
                    { new Guid("538c8107-dfbc-435b-a2d5-19d625b1238b"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(750), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بن" },
                    { new Guid("540399d5-db8c-4b02-bb88-5765b64308f2"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(962), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "معمولان" },
                    { new Guid("5432100a-f7cb-438b-b4a2-dfcd96134ea0"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1353), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "امیدیه" },
                    { new Guid("548b413d-745a-4e5d-a4c1-43f749276931"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(892), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "قدس" },
                    { new Guid("54c193b1-e91d-4d01-9d67-ed5fccd0dbe8"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1383), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "اسفراین" },
                    { new Guid("555fa5da-2d59-4759-ae10-1669618732dd"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(745), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سیب و سوران" },
                    { new Guid("564c4ad4-50ba-429c-be14-84ca4d6de76a"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1123), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "داورزن" },
                    { new Guid("57f5b221-1645-4d1f-a715-e06135eedc47"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1357), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "شوط" },
                    { new Guid("584205ff-0cb3-41ba-b008-7c515ee6e8f9"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1087), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "هندیجان" },
                    { new Guid("588424d4-16a8-4298-b653-3384b578257f"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(842), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خوانسار" },
                    { new Guid("590dfbe6-f65e-4e9d-b4a1-0d97fec342f8"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(721), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ری" },
                    { new Guid("59a3ab07-748a-4703-966c-68831566a8bb"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1012), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سلماس" },
                    { new Guid("59e9585d-257e-4ae7-918b-ac943ea4a649"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1236), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "راور" },
                    { new Guid("5a34f02a-5365-45a4-99ed-5dad342c92d7"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(982), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بیضا" },
                    { new Guid("5b418601-a219-4336-9631-213a1c63a173"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(800), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خوشاب" },
                    { new Guid("5c83cdf5-ebd9-4742-a0ff-f535bd4b21cd"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1394), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سرخس" },
                    { new Guid("5d649418-d9ba-4ed6-b2e3-0bef0d4eacb5"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(712), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بانه" },
                    { new Guid("5d8aa47c-09e9-4def-9bc4-4d641741e231"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(941), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بشرویه" },
                    { new Guid("5dae8288-5744-463c-b9d6-ec67e7914a31"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1382), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "جوین" },
                    { new Guid("5e96761f-964d-48c0-a06e-a639a39eb6f3"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1221), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "فیروزكوه" },
                    { new Guid("5e9fdd38-9287-4b65-a01c-719da8af2195"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1036), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "صومعه سرا" },
                    { new Guid("5f173ca3-e8db-4b69-a094-622a3005544e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(994), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بیله سوار" },
                    { new Guid("5f9b70ee-2032-4fb2-8a82-9e70c0a0c378"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1168), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "مراغه" },
                    { new Guid("5fec153d-7f95-42bd-a181-d1c1aa26040a"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1302), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "آران و بیدگل" },
                    { new Guid("601324a7-28d3-46fa-9930-7d838d4e9a6e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1095), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خانمیرزا" },
                    { new Guid("605672aa-f57f-4127-bd4d-4652d5ef49fa"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(901), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "تربت جام" },
                    { new Guid("6148fee1-e591-468e-bc34-8fea673d9d53"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1145), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "شهریار" },
                    { new Guid("618ef73c-963f-4a05-8ba6-e2f5352b598c"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1365), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بردسیر" },
                    { new Guid("61b0bb61-71f7-4410-a637-3f41fc2538a0"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(879), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "پیشوا" },
                    { new Guid("62b06bbd-a5eb-47f7-a161-004979e6b7bc"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(685), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "راز و جرگلان" },
                    { new Guid("636193a3-60a6-4a99-99c4-7808e60f4e08"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1054), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "مینودشت" },
                    { new Guid("6378a661-d5c9-4e26-82f3-b598460f4045"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1248), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "کیار" },
                    { new Guid("63d7be55-628a-4e91-bfa3-c43762391e10"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1280), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "لارستان" },
                    { new Guid("65231359-3eff-4dcb-8084-3191d940d1cc"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(839), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "مهر" },
                    { new Guid("664b8153-220d-4cce-83e0-03968a82de3d"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(695), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بندرانزلی" },
                    { new Guid("6736a71f-e1c4-4f60-af9c-01c1d07b6fa7"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(688), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "فرخ شهر" },
                    { new Guid("680627a4-9b06-44ff-835a-ac1b56664b5e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1232), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "کوهرنگ" },
                    { new Guid("68084055-595d-4fed-9dbe-a83448f1a745"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1225), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "مراوه تپه" },
                    { new Guid("6841427a-ea2b-4bd5-9e89-7c5d91375ef3"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1090), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "هفتکل" },
                    { new Guid("68a00cda-e073-4d69-a723-3422accf583c"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(846), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بوانات" },
                    { new Guid("68f43971-e21b-4f0f-aadc-40510bce8270"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(885), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "دورود" },
                    { new Guid("691d68df-b213-4d1e-92f1-689e9bde48e5"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1013), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "مهاباد" },
                    { new Guid("6a2b475a-b0f2-4d69-972b-d84893810f23"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1317), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "اقلید" },
                    { new Guid("6b05d2c9-dfec-49ac-9610-4f085d3958ec"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(952), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "مروست" },
                    { new Guid("6b2a3600-7ec0-41e3-ad39-4605bbf00991"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(899), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "نیک شهر" },
                    { new Guid("6b573192-959b-4160-8ec7-e1dd11608d27"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1364), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "داراب" },
                    { new Guid("6b950142-e5e0-4f0c-8452-880f58111dbb"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1127), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "نمین" },
                    { new Guid("6c94ce6c-623f-4ff6-bbcc-344428e94ea7"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(847), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "كهنوج" },
                    { new Guid("6dedc6c0-e18a-4d44-8ce1-3e66b000871d"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(874), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "قشم" },
                    { new Guid("6f163dcf-679e-4659-b616-dd0358e63697"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1328), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بروجن" },
                    { new Guid("6fde6bde-66bd-48f9-8648-7cd7832aa968"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1091), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "رزن" },
                    { new Guid("6ff2ef85-1bbc-4664-8b3e-e5568b1a2329"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1370), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "كرمان" },
                    { new Guid("70703c5b-1993-490e-8c03-66f6ba4e5e80"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1008), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بدره" },
                    { new Guid("72232b06-cf3a-4200-b9f1-fb45d203123a"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1411), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "نظرآباد" },
                    { new Guid("72416c7f-e6aa-43d5-a9b6-9fdda16919d4"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1174), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "فراشبند" },
                    { new Guid("7286f898-53be-407f-8484-11a400fdf5c5"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(732), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "تهران" },
                    { new Guid("73ca55a4-ad79-401f-aa66-1ab1e7761585"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(753), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "اسلامشهر" },
                    { new Guid("73e61618-eed1-4e3d-b646-907668627d56"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1147), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "نهبندان" },
                    { new Guid("74969d19-c778-4a50-890e-da2be6892417"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1322), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "کارون" },
                    { new Guid("749ca733-8bca-44f2-95cd-81ba1bc87f4c"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1111), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "زاوه" },
                    { new Guid("74eb2c1f-2f67-4896-9264-348c4ca5fd7c"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(849), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بهشهر" },
                    { new Guid("75fd1a32-ef64-4774-a580-9a9419828086"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1162), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "كامیاران" },
                    { new Guid("76224bd4-3d91-40b9-b108-8b6f050e76e3"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1136), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ارسنجان" },
                    { new Guid("76cbf49e-46e3-42b8-952c-c830a3ddfd4e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1293), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "میامی" },
                    { new Guid("7719a5b7-0e01-46b9-928e-adc07595b225"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1239), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "لنده" },
                    { new Guid("77d2e9e4-1f69-4490-a9cb-a5eb981edda1"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1192), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "اردستان" },
                    { new Guid("7a1ba934-2e0b-4d44-814d-c4e1956876b8"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1283), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ثلاث باباجانی" },
                    { new Guid("7a203e5f-d23b-4a4c-88a1-53dc53a5309e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(958), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "پلدشت" },
                    { new Guid("7ab369fc-08d7-4d9c-8cbf-ac6ee062d865"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1235), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "گالیكش" },
                    { new Guid("7c11660d-d300-4ba6-96c7-9fe45b338299"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1175), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "فیروزآباد" },
                    { new Guid("7d957d4b-afc1-49aa-a66c-6248688c993a"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(997), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "فارسان" },
                    { new Guid("7f2b7b59-c8eb-4d32-8fb0-60ea96ced12e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(989), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بیجار" },
                    { new Guid("7fbb49e1-2446-45c4-96a0-0b14fa6a7931"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(709), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "رابر" },
                    { new Guid("8122ec18-d201-40c6-98c1-75bc96ba9d1c"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1047), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ورزنه" },
                    { new Guid("8137d9f1-f3d0-4ff3-aa7d-c4e6ef44e254"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1284), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "اهر" },
                    { new Guid("81af5828-0c57-491f-a9df-1b6844103d0f"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(761), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سقز" },
                    { new Guid("821e99cd-ecbf-48d5-8b9c-cda26a0c1217"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1296), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ایذه" },
                    { new Guid("829dc30f-89be-47eb-b631-def292ceac3e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1350), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "زابل" },
                    { new Guid("82c8dba7-1d07-4ce9-bb70-7fdf10e0d312"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1103), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "اندیمشک" },
                    { new Guid("833a7e30-5e22-495f-98d3-f43ef941897d"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1392), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "میان جلگه" },
                    { new Guid("83b6e04a-4620-4611-8096-8300086877cc"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1114), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "قرچک" },
                    { new Guid("8439577c-357d-47e0-b936-5d64df897cf8"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(981), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "چهاربرج" },
                    { new Guid("8528dfa2-d7a5-4bc0-b270-2f8449635869"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(835), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "مهران" },
                    { new Guid("857274ca-a685-4ee3-be87-aa0302a75db6"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1227), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خلیل آباد" },
                    { new Guid("862a304c-d467-4422-823f-7c5bc468dd54"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1088), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "مهریز" },
                    { new Guid("86f16ef5-44b1-43eb-b078-2459cf32ed12"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(808), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "رامشیر" },
                    { new Guid("8733fa11-09a7-4076-b7bc-f77c91c252ca"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1399), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "قاینات" },
                    { new Guid("888b57ff-a8a4-4453-87a4-e12efd4024ba"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1361), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ابركوه" },
                    { new Guid("88e90a64-e145-490f-8b84-dd78f39add25"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1349), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بهاباد" },
                    { new Guid("88f0f31c-2fea-48e0-9bfd-7e0085afdff0"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1097), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "فاریاب" },
                    { new Guid("89899a5e-9208-4bce-a5dd-26ecd170f99e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(814), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "تویسركان" },
                    { new Guid("8a77f5e7-a432-41f4-a267-dd5c3adb8d06"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1348), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بم" },
                    { new Guid("8aafe79c-f21f-4300-88c1-110d7b12a63f"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(729), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "میاندورود" },
                    { new Guid("8bec7b32-7c49-44f1-b41a-7afa29574c05"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1080), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "كوهبنان" },
                    { new Guid("8bf94013-3ad7-4a0a-ae29-f40b0d869ba0"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1390), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ریگان" },
                    { new Guid("8cc8f121-0bd0-4221-b33f-5ca8230a0e91"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(975), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "البرز" },
                    { new Guid("8ce2b787-6f46-4241-8b61-5c982795f874"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(974), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "گلشن" },
                    { new Guid("8da0c156-4a01-42c6-ae16-45df213658c9"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(897), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بندر لنگه" },
                    { new Guid("8da77773-4c6f-4808-955a-d0231b87ca3b"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1298), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "دامغان" },
                    { new Guid("8eed45a8-0794-401a-8a3a-9989a3f4d739"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1158), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "رودبارجنوب" },
                    { new Guid("8ef09110-d213-46cd-8415-640260328351"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1002), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "اردكان" },
                    { new Guid("8efc5e47-4ad1-4817-9dee-da77cde668b7"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1323), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سردشت" },
                    { new Guid("8f18fbc9-afbe-4506-a931-71ea5aa52755"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1037), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ابهر" },
                    { new Guid("8f620fe1-67f6-4171-b999-99e40ea251cd"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1159), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "میرجاوه" },
                    { new Guid("901331c0-f225-4bf6-b7ee-803c3965bcd8"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1104), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "تكاب" },
                    { new Guid("90f8853b-c70c-4ed4-978d-5c8419d0f113"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(973), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بام و صفی آباد" },
                    { new Guid("91d23f14-6ce2-47cb-a5de-38f23f833ef6"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(859), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "میناب" },
                    { new Guid("92742b8e-f2d6-4a69-afd2-442bc3709c64"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(893), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سرعین" },
                    { new Guid("932f2a1f-28b4-4293-8c23-7b5824386fcc"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1083), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خمیر" },
                    { new Guid("934a32c1-245e-4107-be03-23b19e7ca626"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(805), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "مارگون" },
                    { new Guid("938d8591-ca9f-4318-adc0-2e4bf3c1aa38"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(831), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "منوجان" },
                    { new Guid("93ac6bf7-e2fe-4b61-940a-3a0131e6a1b4"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(861), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "اوز" },
                    { new Guid("95664ee4-d31a-4be8-80c1-33c2373e689c"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(843), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سوادکوه شمالی" },
                    { new Guid("9633ba15-c995-4a64-ae22-c1546ad877d0"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1273), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "جعفرآباد" },
                    { new Guid("96ad33c2-9686-41db-a738-447f7408d8be"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(894), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "اندیکا" },
                    { new Guid("97943ab1-ad20-4793-b803-73450088fc15"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1041), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "زنجان" },
                    { new Guid("98fb1ad4-f0ef-4e0b-bb8a-3ef1cb977dcb"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(876), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "آرادان" },
                    { new Guid("991944e9-ecbd-453c-977c-85ebced0561f"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1125), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "درگزین" },
                    { new Guid("9981464c-09e5-46ff-8df4-36b95b839412"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(851), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "لاشار" },
                    { new Guid("99ed70e5-5982-4f75-9061-d75b087221cd"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1313), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "رومشکان" },
                    { new Guid("99f9e926-2c29-4507-b958-1f65811626a8"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(766), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "اردل" },
                    { new Guid("9af6804f-53d9-4188-945e-c7a8c58ae0f4"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1292), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "قوچان" },
                    { new Guid("9b62d15d-6082-4257-9933-34cdbe7e07a8"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(850), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "دلگان" },
                    { new Guid("9c1b68f1-0a39-415e-bb48-6ef4ffe9cfc6"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1027), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "نقده" },
                    { new Guid("9ce7903a-b9ee-4c17-b335-a3bcae305ed0"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1184), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سنندج" },
                    { new Guid("9d4d09fd-827c-439a-b2c4-d6321306a4ff"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1312), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "هرسین" },
                    { new Guid("9d5b4be5-16c9-446e-bc2c-bf3f3bf92bdc"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1267), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "چوار" },
                    { new Guid("9d62c008-cff2-4fbe-9024-27d4bfd4d4e6"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(817), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "قلعه گنج" },
                    { new Guid("9de5395c-2c8e-4b2f-9e31-613c581bfdd4"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(990), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بهارستان" },
                    { new Guid("9e277330-5a23-433c-9aba-68c6a72ffd63"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1016), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "جیرفت" },
                    { new Guid("9e2d5775-a0b5-46a1-b82a-fa7b2c3df732"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1408), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "آبیك" },
                    { new Guid("9e9c10e8-45ff-4c2f-96cd-745dbb403ad1"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1045), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "رشتخوار" },
                    { new Guid("9f0d0893-87db-4ed4-a7b4-9f2e3e66db59"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1170), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "جاجرم" },
                    { new Guid("9f110333-8fc4-46fa-bbb6-6368e92952c7"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(998), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "مشهد" },
                    { new Guid("9f586c69-8ac7-412a-b4a6-eba1bfdc5e15"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1379), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سبزوار" },
                    { new Guid("a05e3b03-805f-484f-8230-a07ec5c94349"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1176), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سامان" },
                    { new Guid("a09907f0-785a-4a02-9e76-37002b2e0780"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(853), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "لنجان" },
                    { new Guid("a28e0572-f4cf-44cd-a34c-e556e5e07017"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1372), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "مرند" },
                    { new Guid("a4c9f911-fc44-4596-a409-c4c374544450"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1281), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "رامسر" },
                    { new Guid("a4d8e50b-313e-4d9a-a64f-7e89c8ba3da0"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1098), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "اصلاندوز" },
                    { new Guid("a59b04cc-c529-413e-8668-7a994598d7ac"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1078), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خاش" },
                    { new Guid("a7088dce-eaec-4741-be56-3a053b1ecf36"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(862), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "دهلران" },
                    { new Guid("a759f834-d067-4081-8779-0d2d899b4970"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(718), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "رشت" },
                    { new Guid("a7986f26-74e9-4923-9511-476ac94425d1"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(903), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "میرآباد" },
                    { new Guid("a7aadea1-5da8-4158-99a0-a21792f5eb62"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1178), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "فردیس" },
                    { new Guid("a7c51a86-324f-4c77-b417-38ed883f1a24"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(858), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "دیواندره" },
                    { new Guid("a810680e-1483-48e2-a656-d1031cb47d55"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1300), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "جغتای" },
                    { new Guid("a829b01f-3742-4762-904c-6efcba063869"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1028), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ورامین" },
                    { new Guid("a9e1688e-c3fb-4da0-bcb2-d46656b3f9b6"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1311), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ممسنی" },
                    { new Guid("aa2316af-c055-45a7-9165-770bfff4009d"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1051), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "كلاله" },
                    { new Guid("ab0a83da-97fb-4861-bb46-b610cf202ae2"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1250), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "زاهدان" },
                    { new Guid("ac49cded-beea-4688-ae3f-7b28fad146e7"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1081), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "جویبار" },
                    { new Guid("ac5d462b-8b1c-4d72-bbfd-fe2fd3e2e695"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1412), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "فلاورجان" },
                    { new Guid("ac7d043f-abaa-4bf8-a804-a2f8dc07da00"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1180), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "چناران" },
                    { new Guid("ad4ebbd7-56fd-4aa0-9d1f-4940fe6c34f5"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(906), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "لردگان" },
                    { new Guid("adc42d66-93dd-488b-8d7e-3f7841f4de17"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(883), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "مبارکه" },
                    { new Guid("ae28e696-06a6-4e21-a7fa-1dcbbe9eef6b"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(762), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بندرماهشهر" },
                    { new Guid("ae970bd4-e903-4e37-a2a4-a534107674e6"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1189), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "کلاردشت" },
                    { new Guid("af8ddc88-816d-4f8b-a979-d80c9646a78f"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1316), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "قزوین" },
                    { new Guid("b05e85cf-ca1c-4427-ab73-07b9a5844537"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(703), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ابوموسی" },
                    { new Guid("b0df6753-0e25-4c46-bb17-812af17eb18f"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1108), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "علی آباد کتول" },
                    { new Guid("b0ef7004-cb5a-485f-a4b0-d455a2cc5eab"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1309), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "گناباد" },
                    { new Guid("b13436ea-786a-44c1-8256-8448e3f18b2f"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1122), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بندر عباس" },
                    { new Guid("b165f426-799c-42b5-be0a-37ebaa32823d"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(854), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بندرگز" },
                    { new Guid("b2a4a8e5-c640-4188-bda6-6f663ffd1e5e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1029), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "جم" },
                    { new Guid("b2c3e2ba-0f36-4f60-929c-929381702494"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1150), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ارومیه" },
                    { new Guid("b3276c4d-18ca-432a-ae4f-d229839ae842"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1306), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خمینی شهر" },
                    { new Guid("b41191e0-186b-475e-9719-b744c5d1765e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1251), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "دماوند" },
                    { new Guid("b41b2965-286a-4f3a-b8dd-89d13d0c268c"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1131), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "حمیدیه" },
                    { new Guid("b42fe311-4813-4d25-ab33-c715fcdd563b"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1289), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بافت" },
                    { new Guid("b45eefe3-c3da-4657-8929-6793f699dce7"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1011), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بویین و میاندشت" },
                    { new Guid("b863588a-143e-4a2e-aa3e-d987af6cb5c9"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1321), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "کهک" },
                    { new Guid("b8bf91a1-beae-40d5-8c6f-c3eb6c1ef499"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1278), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "باروق" },
                    { new Guid("bba52d03-e307-42c0-97df-5ef87752e2a7"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(985), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سملقان" },
                    { new Guid("bc96900a-2867-43dc-81c3-13a68d65b815"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(741), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "کوه چنار" },
                    { new Guid("bcc73ad5-aa8e-4abd-b620-a402ecbca59d"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1186), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "مه ولات" },
                    { new Guid("bde68f7a-f49a-4018-ba27-5fe9dc62f60f"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(986), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خاتم" },
                    { new Guid("bdfe397f-6a21-4309-b5e9-4b2c5a1432a5"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(910), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ارزوییه" },
                    { new Guid("be11cf1a-a368-4e35-876f-577319cf71f2"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(963), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "شهرضا" },
                    { new Guid("bf936a12-8a70-4c5f-afcc-7554a41a39ff"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1046), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بهار" },
                    { new Guid("c0560872-4974-42a6-a8f7-4e67fd3e1bac"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(951), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "عباس آباد" },
                    { new Guid("c1cadea9-1dd3-4df6-a30a-03bcd8efa0e6"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(697), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ماكو" },
                    { new Guid("c234c4d3-557c-456e-94be-8a14bd8c3ae7"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1133), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "استهبان" },
                    { new Guid("c273e036-5431-42fb-a2df-eb10e5bb401d"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1378), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سلطانیه" },
                    { new Guid("c2b69395-ecc6-45cc-8641-66e416a42e09"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1007), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "پاوه" },
                    { new Guid("c2df0c1c-b098-4597-8ba1-3a4e43215410"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(864), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بوشهر" },
                    { new Guid("c391d26e-56c8-4643-bb39-3b59693ea203"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(867), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "رودبار" },
                    { new Guid("c3d39ce8-e0ae-4326-b4e2-c5c685c985ca"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1285), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "حاجی آباد" },
                    { new Guid("c49a09e1-ccd3-4a1c-a7bf-7bedb47aa6a2"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1086), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "میانه" },
                    { new Guid("c5010a95-37c8-41ff-9f56-f785c67d69e7"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1400), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "دالاهو" },
                    { new Guid("c5013e79-8583-479d-9fc8-49f61e26f513"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(907), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سوادكوه" },
                    { new Guid("c573464d-8e69-4bf0-a8b3-0ba7e20c70f9"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(710), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "فردوس" },
                    { new Guid("c62ef4b9-8f48-47a7-8dfb-7d060c3bae0a"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1094), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "قیروکارزین" },
                    { new Guid("c64b6774-af24-4f5d-a73d-0421a4c1a2c4"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(698), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "شبستر" },
                    { new Guid("c66f79c7-3ac6-407d-b4c7-e6ad2925f638"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1373), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سیروان" },
                    { new Guid("c6893abb-dce4-4e02-80d9-771ae9f8c70d"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1053), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "آوج" },
                    { new Guid("c6b98900-f55e-4570-b119-7f2a35996bef"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1100), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سمنان" },
                    { new Guid("c7154589-f194-40a4-b0ff-a5f9ac7591db"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1215), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "دره شهر" },
                    { new Guid("c76dfa6e-177e-40d5-aff6-ab769f86696c"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1229), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خرم آباد" },
                    { new Guid("c7a40d3d-0015-4a61-8794-456c40111527"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(896), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ماسال" },
                    { new Guid("c7ffb60a-331b-4de2-866d-eaaab33bf060"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1376), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "طارم" },
                    { new Guid("c87a2bcf-8132-47c2-b728-63bf6c75098c"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(999), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "شیراز" },
                    { new Guid("c9307459-ed9c-4c54-8919-173a05534417"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(748), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "دشتستان" },
                    { new Guid("ca30de93-b00f-4696-a049-9c0eb6a89b78"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1163), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "کلات" },
                    { new Guid("caade10f-09a7-4d18-b622-1b0ba777bb30"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(757), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "زهک" },
                    { new Guid("cb08827b-fa85-498f-a7c9-4c1d37a30d33"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(914), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بردسکن" },
                    { new Guid("cb52606a-5774-44d9-96ce-dc7ceff8bc81"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1327), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "چگنی" },
                    { new Guid("cbc71c17-2072-4161-9a87-bf42bb8b955e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1268), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بهبهان" },
                    { new Guid("cbd2b6c9-2c52-4541-9a97-0ad35f27a0f7"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(708), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "کنگاور" },
                    { new Guid("cc61b7c1-b29b-48df-b9e2-02936e115422"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(689), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "درگز" },
                    { new Guid("cc802e83-3cd3-40b3-bd85-0e15580e313f"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(723), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "جرقویه" },
                    { new Guid("cddaf9b1-5622-4dc5-97d5-be2c3d45fbc9"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1264), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "تنگستان" },
                    { new Guid("cdfd5b7f-cd5c-48ef-bdbc-0e20c8f1296f"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(724), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ششتمد" },
                    { new Guid("ceadab37-a0c1-4016-b2d8-29a50b19bbc1"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(822), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "شاهرود" },
                    { new Guid("cebee0ae-d726-4ec4-a194-13490bcccd74"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(739), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "قم" },
                    { new Guid("ced5934e-d0b3-4577-aee7-a76d64648077"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1223), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "قصرشیرین" },
                    { new Guid("ceffdf66-984d-4130-a99a-9c39bd0c1061"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1165), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "تربت حیدریه" },
                    { new Guid("cf40b31e-2130-43fc-bad7-0a443f2eaa6a"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(706), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سنقر" },
                    { new Guid("cfe68a65-4e5d-4aae-ba96-2693f2adfb46"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(811), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "فلارد" },
                    { new Guid("d0903197-7f82-4a86-9bd6-93a8042c2136"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1152), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "اشتهارد" },
                    { new Guid("d1205b77-01a9-4db2-a9d8-810b5958a527"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1105), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "زرقان" },
                    { new Guid("d1fbb0c5-ef37-4153-86ad-1b408ceb9c38"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(760), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ایلام" },
                    { new Guid("d21579b7-505b-4acc-acc0-26a94b9d48c3"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(813), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "جوانرود" },
                    { new Guid("d2c4a703-629c-4031-ba7f-4b20269e09aa"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(909), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سیریك" },
                    { new Guid("d34a61e2-2683-40ae-a18b-6d105dd00985"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1021), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "دزفول" },
                    { new Guid("d3ff70df-b6ab-4dc1-9ad9-3ef9ec7038b7"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(878), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "شادگان" },
                    { new Guid("d54ebb7f-dd5a-4325-8d57-a600f1cf816f"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1217), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ملكشاهی" },
                    { new Guid("d671b031-ca23-4d39-aeb3-8ec89d38ef76"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1143), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "نی ریز" },
                    { new Guid("d7634bbe-ea83-4778-8eb2-83a1655aa9cb"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1116), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "هشترود" },
                    { new Guid("d90754e4-69ad-4ee7-bd3b-bfc95320f232"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1269), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "پلدختر" },
                    { new Guid("da168a7c-5f78-4ed2-8564-4f8a1bcd6566"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(954), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "هویزه" },
                    { new Guid("da66a52f-fbf3-400b-b529-00104c89b142"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(683), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خدابنده" },
                    { new Guid("da91e3fc-b31a-4b41-b157-646e192f6274"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1003), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بمپور" },
                    { new Guid("dabcfb3a-540b-4b79-a0de-4d657673b072"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(943), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ملایر" },
                    { new Guid("daee79b8-9341-472d-82ef-7cf998fc7ff9"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1093), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "سرچهان" },
                    { new Guid("db1de636-0fc8-4fbb-b862-b3d611e5c291"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1245), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "تنكابن" },
                    { new Guid("db5daa1d-468e-4d75-9d8d-29929e6ce8d1"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(821), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "رستم" },
                    { new Guid("dc0a45e7-12aa-430a-90fe-4130ffcc21db"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(888), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "میاندوآب" },
                    { new Guid("dd835106-65cc-4c01-8836-8a54221dbc5e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1134), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "فریدونشهر" },
                    { new Guid("dd96c9f7-3260-45e7-891c-f140a5643bb6"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1389), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بستان آباد" },
                    { new Guid("df0db550-abbc-48bf-a1d2-3ec0c1a848f1"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(875), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ایوان" },
                    { new Guid("df6450f7-f26b-40b8-964c-8d7f63f262ee"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1140), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "شاهین شهرو میمه" },
                    { new Guid("df71bd5b-9606-402c-ac30-b8091c367429"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1252), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "مسجدسلیمان" },
                    { new Guid("df8b22c5-ba19-423c-92aa-b51a3c0e6f63"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1246), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "کاشمر" },
                    { new Guid("e0113f75-a811-4a0f-8f06-e1acbc13f6e4"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1362), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "صالح آباد" },
                    { new Guid("e0a17bd3-b57a-4b9f-9430-b2b9322d5687"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1244), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "شوش" },
                    { new Guid("e0bba013-962e-43f2-98ed-5007ca0a244a"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(955), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "گنبکی" },
                    { new Guid("e0d57445-9c81-4a66-9db6-d2168a8f93c3"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1305), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "یزد" },
                    { new Guid("e0dd945c-1207-43f6-8654-29276ffb73b9"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(820), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "مرودشت" },
                    { new Guid("e124c53d-df8a-4964-8a99-5ed5402f190f"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(983), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "فیروزه" },
                    { new Guid("e134b9b1-b2b0-4c8a-a791-16fa8d360c62"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(746), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "فهرج" },
                    { new Guid("e15be4e5-d2d9-41d4-ace0-8235c0207abd"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1113), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "فاروج" },
                    { new Guid("e167cf99-05cd-4f02-adff-c3cdb940eeab"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1276), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "مریوان" },
                    { new Guid("e2bde3fb-6387-4468-b779-c3fe3070c152"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1279), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "آغاجاری" },
                    { new Guid("e2c8c809-a372-4117-96a3-622e8f0f893d"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(995), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بافق" },
                    { new Guid("e2cbc268-1ad1-4803-9e1e-60b7ca05e406"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(988), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ملارد" },
                    { new Guid("e3cefae1-cb29-4bc1-9935-c07864d5cc1f"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1272), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "کرخه" },
                    { new Guid("e57dcb48-1069-4bb7-9979-2044b37b7627"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(768), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خوسف" },
                    { new Guid("e60192fd-9b36-4582-87a4-db1a25aa8487"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1325), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "فامنین" },
                    { new Guid("e62ba946-3c11-43a9-837b-8c2e3ad90fe7"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1138), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "تفتان" },
                    { new Guid("e6713da9-5ca0-426c-93f2-b163f3860480"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1243), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "دنا" },
                    { new Guid("e741f5d6-6b10-4534-b7da-5990fdc7b13d"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(967), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بویین زهرا" },
                    { new Guid("e78de827-4839-43f4-9b1a-a28913f3e010"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1179), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "اردبیل" },
                    { new Guid("e78ef1ac-52f5-4995-9a21-96314db14472"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1155), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "انار" },
                    { new Guid("e7e1162f-3f61-419a-a25a-1dd3f704e103"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(764), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "تاكستان" },
                    { new Guid("e7eb9b06-1db2-4d4f-9a27-83a2ffd90edf"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1117), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "گلپایگان" },
                    { new Guid("e8c62d4a-d82a-46a0-9c0b-f6b6408cfe55"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1398), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "گتوند" },
                    { new Guid("eaa30acf-ef2c-43ae-ab71-be0f6cc09d9e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1263), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خلخال" },
                    { new Guid("eecad343-a835-4f23-835f-21c7dfc9de15"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(802), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "چالدران" },
                    { new Guid("eed0ee6b-e63a-4e25-9457-7f97d5a7ab93"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1101), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "دهاقان" },
                    { new Guid("efaaae37-dd9a-41c6-a70d-13c30ca04fab"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(742), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "لاهیجان" },
                    { new Guid("efe8ac42-c1c9-4be0-bf34-009b89180464"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(686), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "شهربابك" },
                    { new Guid("f0c63ea9-55ec-47c8-94f7-74255b6962be"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1043), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "طرقبه شاندیز" },
                    { new Guid("f136f9ed-0437-49d2-b069-42766c5255fb"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(889), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بجنورد" },
                    { new Guid("f16ec5d4-2f03-49d4-9e12-5d3359d9abee"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(979), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "کازرون" },
                    { new Guid("f179658f-afcd-4d8e-b590-21047b839a7c"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(769), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "چادگان" },
                    { new Guid("f1a79572-116b-46b3-920e-05e6b3874be3"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(701), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "طوالش" },
                    { new Guid("f3e5b666-7911-46c6-8c9b-8ecb9437555b"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1144), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "گناوه" },
                    { new Guid("f4185865-1c77-4409-bb1c-2bfd81efaa80"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(825), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "کنارک" },
                    { new Guid("f47b956a-b45f-4d72-9696-87392188634a"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1126), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "نیر" },
                    { new Guid("f5efe0eb-c3be-4b31-be01-1ac440602852"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(754), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "هامون" },
                    { new Guid("f664532a-3c07-4b61-ba9d-0d1698a85a3e"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(716), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "كهگیلویه" },
                    { new Guid("f7966ced-3414-4571-82be-1a36d6181c8f"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(752), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "مانه" },
                    { new Guid("f7ca52aa-6da3-4652-8126-210b889d4a93"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(797), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بناب" },
                    { new Guid("f810cba1-0d99-4186-9a69-d88e281afbf7"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1318), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "خفر" },
                    { new Guid("f8ac95d0-fcac-4f7d-ad5b-b86cb247db1a"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1254), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "شاهین دژ" },
                    { new Guid("f8d14618-77d2-4a54-9745-a7fe9f233a93"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1224), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "فریدن" },
                    { new Guid("f8f08c85-686f-439a-a0ec-cc1183cf2bcf"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1295), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "گنبدكاووس" },
                    { new Guid("f9162287-5ad4-4b47-a67b-8b217728fdfa"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1135), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "گلبهار" },
                    { new Guid("f9b5bd83-c700-42a6-bdf7-d269a028cc00"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1307), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "گراش" },
                    { new Guid("f9e78e0b-c9db-4e6e-999f-07a3cc8181ab"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(702), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "ساوجبلاغ" },
                    { new Guid("fa4b91c8-c1c9-42d1-911d-4e2a3971c4a6"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(949), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "دشت آزادگان" },
                    { new Guid("faabbc6e-a373-49cd-a01c-3f6ab18207bb"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(881), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "فنوج" },
                    { new Guid("fad0f60d-2272-4076-a3e5-1ae5404b98e6"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(756), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "لالی" },
                    { new Guid("fb7ee740-ff98-4675-9e9b-66d253eab5ed"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1006), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بوكان" },
                    { new Guid("fc14fcc0-8814-4fc3-bf46-733c2a190aeb"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1040), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "جازموریان" },
                    { new Guid("fe1e10ef-b8a1-4ca6-9f6f-9eb5f1a3e258"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1169), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "دلفان" },
                    { new Guid("fe84ccf1-04c0-4205-9ba9-492f5470c8ac"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(905), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "بستك" },
                    { new Guid("ff5e5d8a-d286-4807-8f7f-71028c398aef"), new DateTime(2024, 9, 25, 22, 8, 39, 891, DateTimeKind.Local).AddTicks(1033), false, new Guid("89798567-a31a-43e9-9608-aa726eea6167"), "کوهدشت" }
                });

            migrationBuilder.InsertData(
                table: "ObjectStates",
                columns: new[] { "Id", "CancelNode", "Cancellable", "CategoryId", "Code", "CreatedDate", "IsFinalNode", "IsStartNode", "NextNode", "PreviousNode", "RoleId", "Title", "ToBackward", "ToForward" },
                values: new object[,]
                {
                    { new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb0"), null, false, new Guid("cd97c448-da11-4553-93e3-cac2976eb64f"), -1, new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9417), true, false, null, null, "53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9", "لفو شده!", false, false },
                    { new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb1"), -1, true, new Guid("cd97c448-da11-4553-93e3-cac2976eb64f"), 0, new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9419), false, true, 1, null, "53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9", "رزرو شده", false, true },
                    { new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb2"), null, false, new Guid("bd97c448-da11-4553-93e3-cac2976eb64f"), 1, new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9455), false, false, 2, null, "dbd0d55e-6c75-45fa-9f33-303f06fb336d", "در انتظار تایید حضور", false, true },
                    { new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb3"), null, false, new Guid("bd97c448-da11-4553-93e3-cac2976eb64f"), 2, new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9457), true, false, null, null, "53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9", "حضور تایید شد!", false, false },
                    { new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb4"), null, false, new Guid("bd97c448-da11-4553-93e3-cac2976eb64f"), 3, new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9460), true, false, null, null, "53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9", "عدم حضور", false, false },
                    { new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6470"), null, false, new Guid("bd97c448-da11-4553-93e3-cac2976eb64f"), -1, new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9404), true, false, null, null, "53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9", "لفو شده!", false, false },
                    { new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6471"), -1, true, new Guid("bd97c448-da11-4553-93e3-cac2976eb64f"), 0, new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9407), false, true, 1, -1, "dbd0d55e-6c75-45fa-9f33-303f06fb336d", "رزرو شده", true, true },
                    { new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6472"), -1, true, new Guid("bd97c448-da11-4553-93e3-cac2976eb64f"), 1, new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9411), false, false, 2, -1, "dbd0d55e-6c75-45fa-9f33-303f06fb336d", "در انتظار تایید مجری...", true, true },
                    { new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6473"), null, false, new Guid("bd97c448-da11-4553-93e3-cac2976eb64f"), 2, new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9414), true, false, null, null, "53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9", "تایید شده!", false, false }
                });

            migrationBuilder.InsertData(
                table: "Relations",
                columns: new[] { "Id", "CreatedDate", "Maximum", "ParentId", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9223), 1, new Guid("00000000-9d33-4279-aed3-8f372907f27e"), "خود", (short)0 },
                    { new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9225), 1, new Guid("00000000-9d33-4279-aed3-8f372907f27e"), "همسر", (short)1 },
                    { new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9227), null, new Guid("00000000-9d33-4279-aed3-8f372907f27e"), "فرزند", (short)2 },
                    { new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9229), 1, new Guid("00000000-9d33-4279-aed3-8f372907f27e"), "پدر", (short)3 },
                    { new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9231), 1, new Guid("00000000-9d33-4279-aed3-8f372907f27e"), "مادر", (short)4 },
                    { new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9233), 1, new Guid("00000000-9d33-4279-aed3-8f372907f27e"), "پدر همسر", (short)5 },
                    { new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9235), 1, new Guid("00000000-9d33-4279-aed3-8f372907f27e"), "مادر همسر", (short)6 },
                    { new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9237), null, new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "عروس", (short)9 },
                    { new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9239), null, new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "داماد", (short)10 },
                    { new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9241), null, new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "خواهر", (short)8 },
                    { new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9243), null, new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "برادر", (short)7 },
                    { new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9245), null, new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "عمه", (short)14 },
                    { new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9247), null, new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "خاله", (short)13 },
                    { new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9249), null, new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "دایی", (short)12 },
                    { new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9250), null, new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "عمو", (short)11 },
                    { new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 9, 25, 22, 8, 39, 892, DateTimeKind.Local).AddTicks(9252), null, new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "بدون نسبت", (short)26 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PhoneNumber",
                table: "AspNetUsers",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CouponShares_PeriodId",
                table: "CouponShares",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_CouponShares_RelationId",
                table: "CouponShares",
                column: "RelationId");

            migrationBuilder.CreateIndex(
                name: "IX_Definitions_ParentId",
                table: "Definitions",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_CategoryId",
                table: "Entities",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_CityId",
                table: "Entities",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_PeriodId",
                table: "Entities",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_UserId",
                table: "Entities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityManagers_UserId",
                table: "EntityManagers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectStates_CategoryId",
                table: "ObjectStates",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectStates_RoleId",
                table: "ObjectStates",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Parameters_CategoryId",
                table: "Parameters",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterValues_EntityId",
                table: "ParameterValues",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterValues_ParameterId",
                table: "ParameterValues",
                column: "ParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_Relations_ParentId",
                table: "Relations",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Relatives_RelationId",
                table: "Relatives",
                column: "RelationId");

            migrationBuilder.CreateIndex(
                name: "IX_Relatives_UserId",
                table: "Relatives",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ObjectStateId",
                table: "Reservations",
                column: "ObjectStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_SlotId",
                table: "Reservations",
                column: "SlotId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationStates_ActorUserId",
                table: "ReservationStates",
                column: "ActorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationStates_CreatorUserId",
                table: "ReservationStates",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationStates_ObjectStateId",
                table: "ReservationStates",
                column: "ObjectStateId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationStates_ReservationId",
                table: "ReservationStates",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedRelatives_RelativeId",
                table: "SelectedRelatives",
                column: "RelativeId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedRelatives_ReservationId",
                table: "SelectedRelatives",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_EntityId",
                table: "Slots",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Tx_Coupons_PeriodId",
                table: "Tx_Coupons",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_Tx_Coupons_ReservationId",
                table: "Tx_Coupons",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tx_Coupons_UserId",
                table: "Tx_Coupons",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tx_Users_PeriodId",
                table: "Tx_Users",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_Tx_Users_ReservationId",
                table: "Tx_Users",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tx_Users_UserId",
                table: "Tx_Users",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCompanies_CompanyId",
                table: "UserCompanies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCompanies_UserId",
                table: "UserCompanies",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Attachments");

            migrationBuilder.DropTable(
                name: "CouponShares");

            migrationBuilder.DropTable(
                name: "EntityManagers");

            migrationBuilder.DropTable(
                name: "ParameterValues");

            migrationBuilder.DropTable(
                name: "ReservationStates");

            migrationBuilder.DropTable(
                name: "SelectedRelatives");

            migrationBuilder.DropTable(
                name: "Tx_Coupons");

            migrationBuilder.DropTable(
                name: "Tx_Users");

            migrationBuilder.DropTable(
                name: "UserCompanies");

            migrationBuilder.DropTable(
                name: "Parameters");

            migrationBuilder.DropTable(
                name: "Relatives");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Relations");

            migrationBuilder.DropTable(
                name: "ObjectStates");

            migrationBuilder.DropTable(
                name: "Slots");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Entities");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Definitions");

            migrationBuilder.DropTable(
                name: "Periods");
        }
    }
}
