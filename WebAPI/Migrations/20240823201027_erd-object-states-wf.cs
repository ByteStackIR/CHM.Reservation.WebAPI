using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class erdobjectstateswf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Values_Parameters_ParameterId",
                table: "Values");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Values",
                table: "Values");

            migrationBuilder.RenameTable(
                name: "Values",
                newName: "ParameterValues");

            migrationBuilder.RenameIndex(
                name: "IX_Values_ParameterId",
                table: "ParameterValues",
                newName: "IX_ParameterValues_ParameterId");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReservationId",
                table: "Tx_Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReservationId",
                table: "Tx_Coupons",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ObjectStateId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "IdentityCode",
                table: "Persons",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "EntityId",
                table: "ParameterValues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParameterValues",
                table: "ParameterValues",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ObjectStates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToForward = table.Column<bool>(type: "bit", nullable: false),
                    ToBackward = table.Column<bool>(type: "bit", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "ReservationStates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ObjectStateId",
                table: "Reservations",
                column: "ObjectStateId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterValues_EntityId",
                table: "ParameterValues",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectStates_CategoryId",
                table: "ObjectStates",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectStates_RoleId",
                table: "ObjectStates",
                column: "RoleId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ParameterValues_Entities_EntityId",
                table: "ParameterValues",
                column: "EntityId",
                principalTable: "Entities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParameterValues_Parameters_ParameterId",
                table: "ParameterValues",
                column: "ParameterId",
                principalTable: "Parameters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_ObjectStates_ObjectStateId",
                table: "Reservations",
                column: "ObjectStateId",
                principalTable: "ObjectStates",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParameterValues_Entities_EntityId",
                table: "ParameterValues");

            migrationBuilder.DropForeignKey(
                name: "FK_ParameterValues_Parameters_ParameterId",
                table: "ParameterValues");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_ObjectStates_ObjectStateId",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "ReservationStates");

            migrationBuilder.DropTable(
                name: "ObjectStates");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ObjectStateId",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParameterValues",
                table: "ParameterValues");

            migrationBuilder.DropIndex(
                name: "IX_ParameterValues_EntityId",
                table: "ParameterValues");

            migrationBuilder.DropColumn(
                name: "ObjectStateId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "EntityId",
                table: "ParameterValues");

            migrationBuilder.RenameTable(
                name: "ParameterValues",
                newName: "Values");

            migrationBuilder.RenameIndex(
                name: "IX_ParameterValues_ParameterId",
                table: "Values",
                newName: "IX_Values_ParameterId");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReservationId",
                table: "Tx_Users",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReservationId",
                table: "Tx_Coupons",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "IdentityCode",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Values",
                table: "Values",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Values_Parameters_ParameterId",
                table: "Values",
                column: "ParameterId",
                principalTable: "Parameters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
