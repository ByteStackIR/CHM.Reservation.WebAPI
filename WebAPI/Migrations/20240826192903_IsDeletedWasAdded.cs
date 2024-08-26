using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class IsDeletedWasAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26acd88e-a936-4d97-8ce0-942d1e96c46e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "414aea08-f883-4b2e-a9cb-4cd769301bf3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cf74d66-9047-4b76-a946-624871c69d2f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c1e952d-0f94-43c2-81c3-374dff323a43");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Entities",
                newName: "IsDeleted");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Relatives",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Companies",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Relatives");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Entities",
                newName: "IsActive");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26acd88e-a936-4d97-8ce0-942d1e96c46e", null, "Manager", "MANAGER" },
                    { "414aea08-f883-4b2e-a9cb-4cd769301bf3", null, "Administrator", "ADMINISTRATOR" },
                    { "4cf74d66-9047-4b76-a946-624871c69d2f", null, "User", "User" },
                    { "8c1e952d-0f94-43c2-81c3-374dff323a43", null, "Operator", "OPERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 20, 54, 46, 420, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 20, 54, 46, 420, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11111111-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 20, 54, 46, 420, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 20, 54, 46, 420, DateTimeKind.Local).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 20, 54, 46, 420, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 20, 54, 46, 420, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 20, 54, 46, 420, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 20, 54, 46, 420, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 20, 54, 46, 420, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 20, 54, 46, 420, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 20, 54, 46, 420, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 20, 54, 46, 420, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 20, 54, 46, 420, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 20, 54, 46, 420, DateTimeKind.Local).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 20, 54, 46, 420, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 20, 54, 46, 420, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 20, 54, 46, 420, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 26, 20, 54, 46, 420, DateTimeKind.Local).AddTicks(845));
        }
    }
}
