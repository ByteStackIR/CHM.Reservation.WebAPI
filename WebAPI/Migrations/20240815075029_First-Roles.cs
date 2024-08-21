using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class FirstRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4e3d0c0c-6c74-4b4b-8e85-3cfbfed69f31", null, "Secretary", "SECRETARY" },
                    { "4fdbee55-4e82-4160-9d79-074d2a36346d", null, "User", "User" },
                    { "a7d9bb17-e9c4-4cec-8a8b-8d3bb50b9bc6", null, "Doctor", "DOCTOR" },
                    { "e16d438f-e750-40a0-b0e2-ab499e119d9b", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e3d0c0c-6c74-4b4b-8e85-3cfbfed69f31");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fdbee55-4e82-4160-9d79-074d2a36346d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7d9bb17-e9c4-4cec-8a8b-8d3bb50b9bc6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e16d438f-e750-40a0-b0e2-ab499e119d9b");
        }
    }
}
