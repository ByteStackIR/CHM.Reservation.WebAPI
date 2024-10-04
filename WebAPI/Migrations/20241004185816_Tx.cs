using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Tx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatorUserId",
                table: "Tx_Users",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Tx_Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatorUserId",
                table: "Tx_Credit",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Tx_Credit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatorUserId",
                table: "Tx_Coupons",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Tx_Coupons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<short>(
                name: "TransactionMode",
                table: "Reservations",
                type: "smallint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb0"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb1"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb2"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb4"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6470"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6471"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6472"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6473"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11111111-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 22, 28, 15, 953, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.CreateIndex(
                name: "IX_Tx_Users_CreatorUserId",
                table: "Tx_Users",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tx_Credit_CreatorUserId",
                table: "Tx_Credit",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tx_Coupons_CreatorUserId",
                table: "Tx_Coupons",
                column: "CreatorUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tx_Coupons_AspNetUsers_CreatorUserId",
                table: "Tx_Coupons",
                column: "CreatorUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tx_Credit_AspNetUsers_CreatorUserId",
                table: "Tx_Credit",
                column: "CreatorUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tx_Users_AspNetUsers_CreatorUserId",
                table: "Tx_Users",
                column: "CreatorUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tx_Coupons_AspNetUsers_CreatorUserId",
                table: "Tx_Coupons");

            migrationBuilder.DropForeignKey(
                name: "FK_Tx_Credit_AspNetUsers_CreatorUserId",
                table: "Tx_Credit");

            migrationBuilder.DropForeignKey(
                name: "FK_Tx_Users_AspNetUsers_CreatorUserId",
                table: "Tx_Users");

            migrationBuilder.DropIndex(
                name: "IX_Tx_Users_CreatorUserId",
                table: "Tx_Users");

            migrationBuilder.DropIndex(
                name: "IX_Tx_Credit_CreatorUserId",
                table: "Tx_Credit");

            migrationBuilder.DropIndex(
                name: "IX_Tx_Coupons_CreatorUserId",
                table: "Tx_Coupons");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Tx_Users");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Tx_Users");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Tx_Credit");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Tx_Credit");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Tx_Coupons");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Tx_Coupons");

            migrationBuilder.DropColumn(
                name: "TransactionMode",
                table: "Reservations");

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb0"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb1"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb2"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb4"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6470"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6471"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6472"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6473"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11111111-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 4, 11, 17, 26, 344, DateTimeKind.Local).AddTicks(2448));
        }
    }
}
