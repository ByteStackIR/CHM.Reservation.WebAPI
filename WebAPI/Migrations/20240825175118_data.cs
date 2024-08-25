using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04be803b-87c2-44e8-9bc9-fb395960b252", null, "User", "User" },
                    { "10366cec-9175-4b87-a7ca-16a486aaafa6", null, "Manager", "MANAGER" },
                    { "88700665-080b-431a-a8df-b9c6d26cf215", null, "Operator", "OPERATOR" },
                    { "8b1e25dc-1685-4ec0-890d-f1da2102b949", null, "Administrator", "ADMINISTRATOR" }
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
                    { new Guid("00000000-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 21, 21, 17, 23, DateTimeKind.Local).AddTicks(6936), null, "تحت تکفل", (short)-1 },
                    { new Guid("11111111-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 21, 21, 17, 23, DateTimeKind.Local).AddTicks(6950), null, "سایر", (short)-2 },
                    { new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 21, 21, 17, 23, DateTimeKind.Local).AddTicks(6953), new Guid("00000000-9d33-4279-aed3-8f372907f27e"), "خود", (short)0 },
                    { new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 21, 21, 17, 23, DateTimeKind.Local).AddTicks(6955), new Guid("00000000-9d33-4279-aed3-8f372907f27e"), "همسر", (short)1 },
                    { new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 21, 21, 17, 23, DateTimeKind.Local).AddTicks(6957), new Guid("00000000-9d33-4279-aed3-8f372907f27e"), "فرزند", (short)2 },
                    { new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 21, 21, 17, 23, DateTimeKind.Local).AddTicks(6969), new Guid("00000000-9d33-4279-aed3-8f372907f27e"), "پدر", (short)3 },
                    { new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 21, 21, 17, 23, DateTimeKind.Local).AddTicks(6971), new Guid("00000000-9d33-4279-aed3-8f372907f27e"), "مادر", (short)4 },
                    { new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 21, 21, 17, 23, DateTimeKind.Local).AddTicks(6973), new Guid("00000000-9d33-4279-aed3-8f372907f27e"), "پدر همسر", (short)5 },
                    { new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 21, 21, 17, 23, DateTimeKind.Local).AddTicks(6975), new Guid("00000000-9d33-4279-aed3-8f372907f27e"), "مادر همسر", (short)6 },
                    { new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 21, 21, 17, 23, DateTimeKind.Local).AddTicks(6978), new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "عروس", (short)9 },
                    { new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 21, 21, 17, 23, DateTimeKind.Local).AddTicks(6980), new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "داماد", (short)10 },
                    { new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 21, 21, 17, 23, DateTimeKind.Local).AddTicks(6986), new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "خواهر", (short)8 },
                    { new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 21, 21, 17, 23, DateTimeKind.Local).AddTicks(6998), new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "برادر", (short)7 },
                    { new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 21, 21, 17, 23, DateTimeKind.Local).AddTicks(7001), new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "عمه", (short)14 },
                    { new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 21, 21, 17, 23, DateTimeKind.Local).AddTicks(7003), new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "خاله", (short)13 },
                    { new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 21, 21, 17, 23, DateTimeKind.Local).AddTicks(7005), new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "دایی", (short)12 },
                    { new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 21, 21, 17, 23, DateTimeKind.Local).AddTicks(7007), new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "عمو", (short)11 },
                    { new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"), new DateTime(2024, 8, 25, 21, 21, 17, 23, DateTimeKind.Local).AddTicks(7009), new Guid("11111111-9d33-4279-aed3-8f372907f27e"), "بدون نسبت", (short)26 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04be803b-87c2-44e8-9bc9-fb395960b252");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10366cec-9175-4b87-a7ca-16a486aaafa6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88700665-080b-431a-a8df-b9c6d26cf215");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b1e25dc-1685-4ec0-890d-f1da2102b949");

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
        }
    }
}
