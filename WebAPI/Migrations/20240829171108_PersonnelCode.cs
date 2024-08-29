using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class PersonnelCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23aea259-ae2d-44df-9bd9-a92268d5f363");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6aeca451-9668-44fa-9e13-2c6682856b0d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9de5d847-3566-4aa0-bbd4-6b866afaf10a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b91d666a-fb3c-400c-82b0-737eff92538d");

            migrationBuilder.AddColumn<string>(
                name: "PersonnelCode",
                table: "UserCompanies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PersonnelCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05f73f15-08d6-4d55-8516-0d61976c31a2", null, "Manager", "MANAGER" },
                    { "245b1e78-64ad-436e-85d5-c9c8d3c5d6f7", null, "Operator", "OPERATOR" },
                    { "d700ab2c-2bf3-4903-8ad5-4596364d0f6e", null, "Administrator", "ADMINISTRATOR" },
                    { "ec3a5f63-0dcc-4569-896c-3f79027dc84f", null, "User", "User" }
                });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 20, 41, 7, 766, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 20, 41, 7, 766, DateTimeKind.Local).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11111111-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 20, 41, 7, 766, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 20, 41, 7, 766, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 20, 41, 7, 766, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 20, 41, 7, 766, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 20, 41, 7, 766, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 20, 41, 7, 766, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 20, 41, 7, 766, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 20, 41, 7, 766, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 20, 41, 7, 766, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 20, 41, 7, 766, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 20, 41, 7, 766, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 20, 41, 7, 766, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 20, 41, 7, 766, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 20, 41, 7, 766, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 20, 41, 7, 766, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 20, 41, 7, 766, DateTimeKind.Local).AddTicks(3129));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05f73f15-08d6-4d55-8516-0d61976c31a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "245b1e78-64ad-436e-85d5-c9c8d3c5d6f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d700ab2c-2bf3-4903-8ad5-4596364d0f6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec3a5f63-0dcc-4569-896c-3f79027dc84f");

            migrationBuilder.DropColumn(
                name: "PersonnelCode",
                table: "UserCompanies");

            migrationBuilder.DropColumn(
                name: "PersonnelCode",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "23aea259-ae2d-44df-9bd9-a92268d5f363", null, "User", "User" },
                    { "6aeca451-9668-44fa-9e13-2c6682856b0d", null, "Administrator", "ADMINISTRATOR" },
                    { "9de5d847-3566-4aa0-bbd4-6b866afaf10a", null, "Manager", "MANAGER" },
                    { "b91d666a-fb3c-400c-82b0-737eff92538d", null, "Operator", "OPERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11111111-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3369));
        }
    }
}
