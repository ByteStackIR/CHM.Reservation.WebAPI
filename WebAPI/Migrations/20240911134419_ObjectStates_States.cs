using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class ObjectStates_States : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9", null, "System", "SYSTEM" });

            migrationBuilder.InsertData(
                table: "ObjectStates",
                columns: new[] { "Id", "CancelNode", "Cancellable", "CategoryId", "Code", "CreatedDate", "IsFinalNode", "NextNode", "PreviousNode", "RoleId", "Title", "ToBackward", "ToForward" },
                values: new object[,]
                {
                    { new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb2"), null, false, new Guid("bd97c448-da11-4553-93e3-cac2976eb64f"), 1, new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(2141), false, 2, null, "dbd0d55e-6c75-45fa-9f33-303f06fb336d", "در انتظار تایید حضور", false, true },
                    { new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6471"), -1, true, new Guid("bd97c448-da11-4553-93e3-cac2976eb64f"), 0, new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(2129), false, 1, 1, "dbd0d55e-6c75-45fa-9f33-303f06fb336d", "در انتظار تایید مجری...", true, true }
                });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11111111-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.InsertData(
                table: "ObjectStates",
                columns: new[] { "Id", "CancelNode", "Cancellable", "CategoryId", "Code", "CreatedDate", "IsFinalNode", "NextNode", "PreviousNode", "RoleId", "Title", "ToBackward", "ToForward" },
                values: new object[,]
                {
                    { new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb0"), null, false, new Guid("cd97c448-da11-4553-93e3-cac2976eb64f"), -1, new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(2136), true, null, null, "53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9", "لفو شده!", false, false },
                    { new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb1"), -1, true, new Guid("cd97c448-da11-4553-93e3-cac2976eb64f"), 0, new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(2138), false, 1, null, "53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9", "رزرو شده", false, true },
                    { new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb3"), null, false, new Guid("bd97c448-da11-4553-93e3-cac2976eb64f"), 2, new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(2144), true, null, null, "53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9", "حضور تایید شد!", false, false },
                    { new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb4"), null, false, new Guid("bd97c448-da11-4553-93e3-cac2976eb64f"), 3, new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(2147), true, null, null, "53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9", "عدم حضور", false, false },
                    { new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6470"), null, false, new Guid("bd97c448-da11-4553-93e3-cac2976eb64f"), -1, new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(2125), true, null, null, "53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9", "لفو شده!", false, false },
                    { new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6472"), null, false, new Guid("bd97c448-da11-4553-93e3-cac2976eb64f"), 1, new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(2133), true, null, null, "53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9", "تایید شده!", false, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb0"));

            migrationBuilder.DeleteData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb1"));

            migrationBuilder.DeleteData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb2"));

            migrationBuilder.DeleteData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb3"));

            migrationBuilder.DeleteData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb4"));

            migrationBuilder.DeleteData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6470"));

            migrationBuilder.DeleteData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6471"));

            migrationBuilder.DeleteData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6472"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9");

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 8, 21, 420, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 8, 21, 420, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11111111-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 8, 21, 420, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 8, 21, 420, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 8, 21, 420, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 8, 21, 420, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 8, 21, 420, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 8, 21, 420, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 8, 21, 420, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 8, 21, 420, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 8, 21, 420, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 8, 21, 420, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 8, 21, 420, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 8, 21, 420, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 8, 21, 420, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 8, 21, 420, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 8, 21, 420, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 8, 21, 420, DateTimeKind.Local).AddTicks(8241));
        }
    }
}
