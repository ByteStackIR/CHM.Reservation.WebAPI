using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class fixBugInseedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationStates_ObjectStates_ObjectStateId",
                table: "ReservationStates");

            migrationBuilder.AddColumn<Guid>(
                name: "ReservationId",
                table: "ReservationStates",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb0"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb1"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb2"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb4"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6470"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6471"),
                columns: new[] { "CreatedDate", "PreviousNode", "Title" },
                values: new object[] { new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(2163), -1, "رزرو شده" });

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6472"),
                columns: new[] { "CancelNode", "Cancellable", "CreatedDate", "IsFinalNode", "NextNode", "PreviousNode", "RoleId", "Title", "ToBackward", "ToForward" },
                values: new object[] { -1, true, new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(2167), false, 2, -1, "dbd0d55e-6c75-45fa-9f33-303f06fb336d", "در انتظار تایید مجری...", true, true });

            migrationBuilder.InsertData(
                table: "ObjectStates",
                columns: new[] { "Id", "CancelNode", "Cancellable", "CategoryId", "Code", "CreatedDate", "IsFinalNode", "IsStartNode", "NextNode", "PreviousNode", "RoleId", "Title", "ToBackward", "ToForward" },
                values: new object[] { new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6473"), null, false, new Guid("bd97c448-da11-4553-93e3-cac2976eb64f"), 2, new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(2170), true, false, null, null, "53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9", "تایید شده!", false, false });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11111111-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 15, 17, 39, 18, 718, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.CreateIndex(
                name: "IX_ReservationStates_ReservationId",
                table: "ReservationStates",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationStates_ObjectStates_ObjectStateId",
                table: "ReservationStates",
                column: "ObjectStateId",
                principalTable: "ObjectStates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationStates_Reservations_ReservationId",
                table: "ReservationStates",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationStates_ObjectStates_ObjectStateId",
                table: "ReservationStates");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationStates_Reservations_ReservationId",
                table: "ReservationStates");

            migrationBuilder.DropIndex(
                name: "IX_ReservationStates_ReservationId",
                table: "ReservationStates");

            migrationBuilder.DeleteData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6473"));

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "ReservationStates");

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb0"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb1"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb2"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb4"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6470"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6471"),
                columns: new[] { "CreatedDate", "PreviousNode", "Title" },
                values: new object[] { new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2467), 1, "در انتظار تایید مجری..." });

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6472"),
                columns: new[] { "CancelNode", "Cancellable", "CreatedDate", "IsFinalNode", "NextNode", "PreviousNode", "RoleId", "Title", "ToBackward", "ToForward" },
                values: new object[] { null, false, new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2471), true, null, null, "53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9", "تایید شده!", false, false });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11111111-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 18, 11, 48, 292, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationStates_ObjectStates_ObjectStateId",
                table: "ReservationStates",
                column: "ObjectStateId",
                principalTable: "ObjectStates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
