using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class maximumPersons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0502ddde-45dd-465b-9660-b114984be7fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18197179-4579-4b87-a203-469b72823501");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a2f3d52-cc53-464d-b683-0b957beefb7f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7cde0ba7-5d35-4dc9-b452-657a52468245");

            migrationBuilder.AddColumn<int>(
                name: "Maximum",
                table: "Relations",
                type: "int",
                nullable: true);

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
                columns: new[] { "CreatedDate", "Maximum" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3302), null });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"),
                columns: new[] { "CreatedDate", "Maximum" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3319), 1 });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11111111-9d33-4279-aed3-8f372907f27e"),
                columns: new[] { "CreatedDate", "Maximum" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3316), null });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"),
                columns: new[] { "CreatedDate", "Maximum" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3322), 1 });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"),
                columns: new[] { "CreatedDate", "Maximum" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3324), null });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"),
                columns: new[] { "CreatedDate", "Maximum" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3332), 1 });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"),
                columns: new[] { "CreatedDate", "Maximum" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3334), 1 });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"),
                columns: new[] { "CreatedDate", "Maximum" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3337), 1 });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"),
                columns: new[] { "CreatedDate", "Maximum" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3339), 1 });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"),
                columns: new[] { "CreatedDate", "Maximum" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3341), null });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"),
                columns: new[] { "CreatedDate", "Maximum" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3343), null });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"),
                columns: new[] { "CreatedDate", "Maximum" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3350), null });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"),
                columns: new[] { "CreatedDate", "Maximum" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3360), null });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"),
                columns: new[] { "CreatedDate", "Maximum" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3362), null });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"),
                columns: new[] { "CreatedDate", "Maximum" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3364), null });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"),
                columns: new[] { "CreatedDate", "Maximum" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3365), null });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"),
                columns: new[] { "CreatedDate", "Maximum" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3367), null });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"),
                columns: new[] { "CreatedDate", "Maximum" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 36, 44, 638, DateTimeKind.Local).AddTicks(3369), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Maximum",
                table: "Relations");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0502ddde-45dd-465b-9660-b114984be7fd", null, "User", "User" },
                    { "18197179-4579-4b87-a203-469b72823501", null, "Operator", "OPERATOR" },
                    { "3a2f3d52-cc53-464d-b683-0b957beefb7f", null, "Manager", "MANAGER" },
                    { "7cde0ba7-5d35-4dc9-b452-657a52468245", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 22, 59, 2, 169, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 22, 59, 2, 169, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11111111-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 22, 59, 2, 169, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 22, 59, 2, 169, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 22, 59, 2, 169, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 22, 59, 2, 169, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 22, 59, 2, 169, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 22, 59, 2, 169, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 22, 59, 2, 169, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 22, 59, 2, 169, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 22, 59, 2, 169, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 22, 59, 2, 169, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 22, 59, 2, 169, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 22, 59, 2, 169, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 22, 59, 2, 169, DateTimeKind.Local).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 22, 59, 2, 169, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 22, 59, 2, 169, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 22, 59, 2, 169, DateTimeKind.Local).AddTicks(651));
        }
    }
}
