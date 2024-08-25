using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class RelationData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d03bf4c-87de-4287-86fb-d401a376bd01");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ce2c942-50a8-4711-a45b-5deeade9791a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57237926-b402-4085-ba41-625eb6c8b265");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "781ec54f-a99b-4453-af53-959bb53d3a99");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d03bf4c-87de-4287-86fb-d401a376bd01", null, "Manager", "MANAGER" },
                    { "1ce2c942-50a8-4711-a45b-5deeade9791a", null, "User", "User" },
                    { "57237926-b402-4085-ba41-625eb6c8b265", null, "Administrator", "ADMINISTRATOR" },
                    { "781ec54f-a99b-4453-af53-959bb53d3a99", null, "Operator", "OPERATOR" }
                });
        }
    }
}
