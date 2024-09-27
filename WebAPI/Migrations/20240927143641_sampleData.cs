using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class sampleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { new Guid("bd97c448-da11-4553-93e3-cac2976eb64f"), new DateTime(2024, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), false, "احیاء مستقیم" },
                    { new Guid("cd97c448-da11-4553-93e3-cac2976eb64f"), new DateTime(2024, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), false, "گندله سازی" }
                });

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb0"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb1"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb2"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb4"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6470"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6471"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6472"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6473"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.InsertData(
                table: "Parameters",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("3c6eb8a1-5d7a-4b9d-b3f3-0b3c6c7e8f8a"), new Guid("cd97c448-da11-4553-93e3-cac2976eb64f"), new DateTime(2024, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "صبحانه؟", (short)3 },
                    { new Guid("ab2b5f9e-df6e-4ef9-b8b1-0a1d0f9d0a1c"), new Guid("cd97c448-da11-4553-93e3-cac2976eb64f"), new DateTime(2024, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "سرویس ایاب و ذهاب", (short)3 },
                    { new Guid("c9eb3f7a-bd4e-4b1d-b7e8-0a1c5f5e3c8e"), new Guid("cd97c448-da11-4553-93e3-cac2976eb64f"), new DateTime(2024, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "ناهار؟", (short)3 },
                    { new Guid("c9eb3f7a-bd4e-4b1d-b7e8-cac2976eb64f"), new Guid("bd97c448-da11-4553-93e3-cac2976eb64f"), new DateTime(2024, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "تعداد روز", (short)1 },
                    { new Guid("d9b5f0d4-5e8a-4b2f-bf29-0b7a4a3e6c6f"), new Guid("cd97c448-da11-4553-93e3-cac2976eb64f"), new DateTime(2024, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "شام؟", (short)3 },
                    { new Guid("f47ac10b-58cc-4372-93e3-cac2976eb64f"), new Guid("cd97c448-da11-4553-93e3-cac2976eb64f"), new DateTime(2024, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "توضیحات", (short)2 },
                    { new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"), new Guid("cd97c448-da11-4553-93e3-cac2976eb64f"), new DateTime(2024, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "آدرس", (short)2 },
                    { new Guid("f47ac10b-58cc-4372-a567-cac2976eb64f"), new Guid("bd97c448-da11-4553-93e3-cac2976eb64f"), new DateTime(2024, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "توضیحات", (short)2 }
                });

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11111111-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 6, 40, 963, DateTimeKind.Local).AddTicks(3456));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("bd97c448-da11-4553-93e3-cac2976eb64f"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("cd97c448-da11-4553-93e3-cac2976eb64f"));

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "Id",
                keyValue: new Guid("3c6eb8a1-5d7a-4b9d-b3f3-0b3c6c7e8f8a"));

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "Id",
                keyValue: new Guid("ab2b5f9e-df6e-4ef9-b8b1-0a1d0f9d0a1c"));

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "Id",
                keyValue: new Guid("c9eb3f7a-bd4e-4b1d-b7e8-0a1c5f5e3c8e"));

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "Id",
                keyValue: new Guid("c9eb3f7a-bd4e-4b1d-b7e8-cac2976eb64f"));

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "Id",
                keyValue: new Guid("d9b5f0d4-5e8a-4b2f-bf29-0b7a4a3e6c6f"));

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "Id",
                keyValue: new Guid("f47ac10b-58cc-4372-93e3-cac2976eb64f"));

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "Id",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"));

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "Id",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-cac2976eb64f"));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb0"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb1"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb2"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb4"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6470"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6471"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6472"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6473"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11111111-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 18, 0, 38, 410, DateTimeKind.Local).AddTicks(3744));
        }
    }
}
