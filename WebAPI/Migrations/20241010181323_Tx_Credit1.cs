using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Tx_Credit1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "ReservationId",
                table: "Tx_Users",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReservationId",
                table: "Tx_Credit",
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

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb0"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb1"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb2"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb4"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6470"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6471"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6472"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6473"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11111111-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 43, 22, 889, DateTimeKind.Local).AddTicks(1125));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Tx_Credit",
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

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb0"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb1"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb2"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb4"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6470"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6471"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6472"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6473"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11111111-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 21, 41, 17, 150, DateTimeKind.Local).AddTicks(7100));
        }
    }
}
