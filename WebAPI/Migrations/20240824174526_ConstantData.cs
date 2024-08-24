using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class ConstantData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "50181687-cbf2-405e-8674-d3c9d10c38da", null, "User", "User" },
                    { "7c7160fd-dc7e-419d-aae2-95dc9215fb33", null, "Manager", "MANAGER" },
                    { "c3b7914e-9a8f-4ecf-a650-ed30391e138b", null, "Administrator", "ADMINISTRATOR" },
                    { "ca5a8291-cae3-46be-977e-065ec61dd43c", null, "Operator", "OPERATOR" }
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
                columns: new[] { "Id", "CreatedDate", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 24, 21, 15, 26, 187, DateTimeKind.Local).AddTicks(6743), "خود", (short)0 },
                    { new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 24, 21, 15, 26, 187, DateTimeKind.Local).AddTicks(6755), "همسر", (short)1 },
                    { new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 24, 21, 15, 26, 187, DateTimeKind.Local).AddTicks(6757), "فرزند", (short)2 },
                    { new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 24, 21, 15, 26, 187, DateTimeKind.Local).AddTicks(6758), "پدر", (short)3 },
                    { new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 24, 21, 15, 26, 187, DateTimeKind.Local).AddTicks(6761), "مادر", (short)4 },
                    { new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 24, 21, 15, 26, 187, DateTimeKind.Local).AddTicks(6788), "پدر همسر", (short)5 },
                    { new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 24, 21, 15, 26, 187, DateTimeKind.Local).AddTicks(6790), "مادر همسر", (short)6 },
                    { new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 24, 21, 15, 26, 187, DateTimeKind.Local).AddTicks(6792), "عروس", (short)9 },
                    { new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 24, 21, 15, 26, 187, DateTimeKind.Local).AddTicks(6793), "داماد", (short)10 },
                    { new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 24, 21, 15, 26, 187, DateTimeKind.Local).AddTicks(6795), "خواهر", (short)8 },
                    { new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 24, 21, 15, 26, 187, DateTimeKind.Local).AddTicks(6797), "برادر", (short)7 },
                    { new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 24, 21, 15, 26, 187, DateTimeKind.Local).AddTicks(6798), "عمه", (short)14 },
                    { new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 24, 21, 15, 26, 187, DateTimeKind.Local).AddTicks(6800), "خاله", (short)13 },
                    { new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 24, 21, 15, 26, 187, DateTimeKind.Local).AddTicks(6801), "دایی", (short)12 },
                    { new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 24, 21, 15, 26, 187, DateTimeKind.Local).AddTicks(6803), "عمو", (short)11 },
                    { new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 24, 21, 15, 26, 187, DateTimeKind.Local).AddTicks(6804), "آزاد", (short)26 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50181687-cbf2-405e-8674-d3c9d10c38da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c7160fd-dc7e-419d-aae2-95dc9215fb33");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3b7914e-9a8f-4ecf-a650-ed30391e138b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca5a8291-cae3-46be-977e-065ec61dd43c");

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
        }
    }
}
