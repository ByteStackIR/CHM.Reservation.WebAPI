using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class ObjectStates_States3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsStartNode",
                table: "ObjectStates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb0"),
                columns: new[] { "CreatedDate", "IsStartNode" },
                values: new object[] { new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8628), false });

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb1"),
                columns: new[] { "CreatedDate", "IsStartNode" },
                values: new object[] { new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8631), true });

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb2"),
                columns: new[] { "CreatedDate", "IsStartNode" },
                values: new object[] { new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8634), false });

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb3"),
                columns: new[] { "CreatedDate", "IsStartNode" },
                values: new object[] { new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8636), false });

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb4"),
                columns: new[] { "CreatedDate", "IsStartNode" },
                values: new object[] { new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8638), false });

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6470"),
                columns: new[] { "CreatedDate", "IsStartNode" },
                values: new object[] { new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8619), false });

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6471"),
                columns: new[] { "CreatedDate", "IsStartNode" },
                values: new object[] { new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8622), true });

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6472"),
                columns: new[] { "CreatedDate", "IsStartNode" },
                values: new object[] { new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8626), false });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11111111-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 19, 30, 47, 895, DateTimeKind.Local).AddTicks(8397));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsStartNode",
                table: "ObjectStates");

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb0"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb1"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb2"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb4"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6470"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6471"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6472"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 17, 14, 18, 185, DateTimeKind.Local).AddTicks(2133));

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
        }
    }
}
