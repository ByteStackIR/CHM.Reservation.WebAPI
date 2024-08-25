using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class relatives : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relatives_Persons_PersonId",
                table: "Relatives");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Relatives_PersonId",
                table: "Relatives");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0825cf66-7bab-4baa-9f88-cef280af7046");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "360174a5-9b6d-493d-b328-03f219007b4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f981821-1f98-45aa-b1a6-faae72de6d53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e62f098c-d822-432b-969c-9f384b8a5db0");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd97c448-da11-4553-93e3-cac2976eb64f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cd97c448-da11-4553-93e3-cac2976eb64f"));

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"));

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"));

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"));

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"));

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"));

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"));

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"));

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"));

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"));

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"));

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"));

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"));

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"));

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"));

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"));

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"));

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9d33-4279-aed3-8f372907f27e"));

            migrationBuilder.DeleteData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11111111-9d33-4279-aed3-8f372907f27e"));

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Relatives");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Relatives",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FamilyName",
                table: "Relatives",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Relatives",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<short>(
                name: "Gender",
                table: "Relatives",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<string>(
                name: "IdentityCode",
                table: "Relatives",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "Relatives",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Relatives",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Relatives_UserId",
                table: "Relatives",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Relatives_AspNetUsers_UserId",
                table: "Relatives",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relatives_AspNetUsers_UserId",
                table: "Relatives");

            migrationBuilder.DropIndex(
                name: "IX_Relatives_UserId",
                table: "Relatives");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Relatives");

            migrationBuilder.DropColumn(
                name: "FamilyName",
                table: "Relatives");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Relatives");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Relatives");

            migrationBuilder.DropColumn(
                name: "IdentityCode",
                table: "Relatives");

            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "Relatives");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Relatives");

            migrationBuilder.AddColumn<Guid>(
                name: "PersonId",
                table: "Relatives",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    FamilyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<short>(type: "smallint", nullable: false),
                    IdentityCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0825cf66-7bab-4baa-9f88-cef280af7046", null, "Operator", "OPERATOR" },
                    { "360174a5-9b6d-493d-b328-03f219007b4b", null, "Manager", "MANAGER" },
                    { "8f981821-1f98-45aa-b1a6-faae72de6d53", null, "Administrator", "ADMINISTRATOR" },
                    { "e62f098c-d822-432b-969c-9f384b8a5db0", null, "User", "User" }
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
                table: "Relations",
                columns: new[] { "Id", "CreatedDate", "ParentId", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("00000000-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 17, 36, 12, 937, DateTimeKind.Local).AddTicks(2724), null, "تحت تکفل", (short)-1 },
                    { new Guid("11111111-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 17, 36, 12, 937, DateTimeKind.Local).AddTicks(2737), null, "سایر", (short)-2 },
                    { new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 17, 36, 12, 937, DateTimeKind.Local).AddTicks(2745), new Guid("00000000-9d33-4279-aed3-8f372907f27e"), "خود", (short)0 },
                    { new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 17, 36, 12, 937, DateTimeKind.Local).AddTicks(2747), new Guid("00000000-9d33-4279-aed3-8f372907f27e"), "همسر", (short)1 },
                    { new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 17, 36, 12, 937, DateTimeKind.Local).AddTicks(2749), new Guid("00000000-9d33-4279-aed3-8f372907f27e"), "فرزند", (short)2 },
                    { new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 17, 36, 12, 937, DateTimeKind.Local).AddTicks(2751), new Guid("00000000-9d33-4279-aed3-8f372907f27e"), "پدر", (short)3 },
                    { new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 17, 36, 12, 937, DateTimeKind.Local).AddTicks(2754), new Guid("00000000-9d33-4279-aed3-8f372907f27e"), "مادر", (short)4 },
                    { new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 17, 36, 12, 937, DateTimeKind.Local).AddTicks(2756), new Guid("00000000-9d33-4279-aed3-8f372907f27e"), "پدر همسر", (short)5 },
                    { new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 17, 36, 12, 937, DateTimeKind.Local).AddTicks(2758), new Guid("00000000-9d33-4279-aed3-8f372907f27e"), "مادر همسر", (short)6 },
                    { new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 17, 36, 12, 937, DateTimeKind.Local).AddTicks(2760), new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "عروس", (short)9 },
                    { new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 17, 36, 12, 937, DateTimeKind.Local).AddTicks(2762), new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "داماد", (short)10 },
                    { new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 17, 36, 12, 937, DateTimeKind.Local).AddTicks(2765), new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "خواهر", (short)8 },
                    { new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 17, 36, 12, 937, DateTimeKind.Local).AddTicks(2767), new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "برادر", (short)7 },
                    { new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 17, 36, 12, 937, DateTimeKind.Local).AddTicks(2769), new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "عمه", (short)14 },
                    { new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 17, 36, 12, 937, DateTimeKind.Local).AddTicks(2771), new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "خاله", (short)13 },
                    { new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 17, 36, 12, 937, DateTimeKind.Local).AddTicks(2773), new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "دایی", (short)12 },
                    { new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 17, 36, 12, 937, DateTimeKind.Local).AddTicks(2775), new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "عمو", (short)11 },
                    { new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 17, 36, 12, 937, DateTimeKind.Local).AddTicks(2777), new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "بدون نسبت", (short)26 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Relatives_PersonId",
                table: "Relatives",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Relatives_Persons_PersonId",
                table: "Relatives",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
