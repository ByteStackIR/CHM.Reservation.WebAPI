using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class softdelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Definitions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("00426149-b220-4d2f-8a8c-7a0fd828ae63"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1088), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("00796d93-3bac-4438-800f-a517e1d25fb1"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1223), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0089da3e-e43d-4e95-a575-703e236f754e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1063), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("008b8712-9c18-409f-b800-59d810b8de56"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(999), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("010954e4-b6c9-43ae-a8c3-9408a664469a"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1190), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0232d0bd-ab11-4521-846e-63e2680ceadd"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1030), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0259f4b1-ce87-4c87-9563-ac2e0b5a592e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1245), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("037318bb-5724-41f7-8051-5d23548177c1"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1008), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("041e29fc-5a95-4ac5-a874-46a3a5a485a9"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(932), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("04d7614a-fd5b-43c0-997f-5d0bc6992c22"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1007), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("053c3572-09f0-4b19-a27a-9a3ab5603eea"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1197), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0551b1ae-02fb-4a85-8d6f-843c176ab185"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1158), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("05adef7a-da72-4cd6-a773-afdbc6856f30"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1275), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("06385e6d-71b8-4cc1-b674-f7d89dd51e3a"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1439), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("06495180-6ca0-4a80-adaa-0919c62d64c5"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(738), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("066c5ba4-db24-4508-9e2b-fff2e03cba04"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1452), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("07041287-5b65-496d-9321-038ae5726180"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(726), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("074db01f-a37f-4018-affa-279bf48bb0e9"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(823), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("07c74cb0-b861-49e3-98d5-f972fb6a3fdc"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1441), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("07d836c1-6b34-4672-bbfe-6726ba94d574"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1040), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("08861d0f-f9cd-4a3b-89ec-8c72ba8b5bcc"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1175), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("08c0780a-87db-4f7a-9d92-3cc15df8064c"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(903), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0928fab9-ab19-4046-8312-2d7252b61ffa"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(860), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("099ec0e6-db40-467b-9e74-2f5adab88e54"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(868), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("09e61570-9ae5-464c-85fa-8e4b07720f1c"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1178), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("09ff7859-d023-4f78-8821-e0d45af4fe3a"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1375), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0b2196a7-083b-4ac5-91d6-e4412f59a0c7"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1381), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0b82168f-89f5-47ba-98e0-83f5ebec0061"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1156), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0c0295cf-7a5c-45cb-b095-dd25da8476ea"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1361), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0dc49665-00a9-4d3d-a4e3-7b77fc90c92f"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1095), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0df6575d-b889-47a1-9351-76974fee3692"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1084), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0e19da8d-710d-4f4f-9fcd-244a46428058"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(812), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0e6e8a20-0b44-4f05-80a0-663be5021e1e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1034), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0f9967df-85fb-4da4-97d6-713f6fb9958c"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1067), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0ff09a27-a182-444d-b1e5-a63154bfcb5b"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1232), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("10f10dd8-c4ca-4a52-b7f4-fb2798115098"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1446), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("10fcf4e8-99a7-4a07-9e8c-dd390b752814"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1362), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("11931771-4c9d-4702-b9e5-38656e12faf1"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(891), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("11d4977a-2994-4cd9-a3d8-977f461970b5"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1194), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("11e4f171-9f82-460a-acd8-d1fc128b81c0"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1336), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("11fb93aa-6d4f-49a1-abc4-3dbe21405b7a"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(905), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("12129a02-7541-451d-8327-f104949f39c3"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1425), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1475c694-8485-424d-82b4-586a73a16cfc"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(964), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("14c4ff41-e7a8-4dad-a68e-254702ae1c7a"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(815), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("14c6146d-5e3f-4748-9ff6-c2d0c95cb2c4"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1309), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("15bcd116-32fb-4715-9828-e935fcc10a3b"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1413), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("165bebab-de98-4f5e-bfe6-efd0775c1029"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1424), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1689dd47-ef24-458a-a730-bbf7e06fe2eb"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1296), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("16fc89ad-e6e8-49e4-9e8b-564eb840238d"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(960), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("18570096-a785-4fb4-bcbe-334990a885ee"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(875), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("19383580-add1-4306-9c59-81c14fa7b8e6"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1148), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("199eaf80-692c-49ec-bd7c-12aac8404727"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(769), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("19a16bfa-42a6-440b-af73-88125a28fe30"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1165), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1a24e60e-a22b-49d2-a781-134ff662080f"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(774), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1a7a091e-51b7-4bcf-b87b-9f302cee1416"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1207), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1aaeace3-c873-41c7-b204-d7e056d98db9"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1347), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1ab6e719-eb6a-4cca-af09-ec33b883e938"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1419), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1b2284c8-286f-499d-992f-0d0073839155"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(747), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1b6493f4-0420-4d1a-9f4e-b8a28e329b08"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1290), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1b7ed58c-45da-4dc8-bbf9-fa323f0e749f"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1442), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1c7ab1a7-41c1-4034-aeb6-e049d2f8f942"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1371), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1d22f948-00f7-41e9-9417-895c18db51d8"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1166), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1d5607a4-0879-444f-a376-81105afea93b"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1142), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1ddde177-9c8b-4c97-a440-1f2a803f0365"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(799), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1e2ba14a-c065-4cf6-a3e6-4e1917784c0f"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(949), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1ea6a91f-3584-417d-9036-83c3a3b10926"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1155), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1f994a98-9dbd-486f-8d9b-ad854169d3c8"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1248), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("209858f9-abe6-4485-866d-7014badb77d8"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1062), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2261bb04-71f1-4e99-b2dc-8182d876f2dd"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1145), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("22b12edb-4818-42fd-94ae-6da9e55b4012"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1054), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("232e5aeb-c4bc-4fff-8667-5550631a69a3"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(959), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("24303819-1ee4-4ec2-b571-a407ec3aa378"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1222), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("25e19797-06ea-4696-a3f2-d1ab3248ab43"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1334), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2636492d-1cb3-4e50-8aac-0ee34ad8e4cd"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(759), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("26f94415-8b8f-45b4-8632-2d959cfeecf4"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(861), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2853f370-1546-47a0-b60d-6d528b73c92a"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1053), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("285b1d5c-e1c2-4a5b-a5dc-2b943f97f979"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(857), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("28a37e94-cad9-4f06-b2fc-4b67ed20fdfe"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(941), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2926410c-854d-4c8b-8245-0336496d6c00"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(725), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("29d54105-fffa-4a4a-ad98-175920430b51"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(783), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2a0b9a3c-7cd2-4716-bec9-73bba194cb09"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1074), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2a260d88-e538-4d80-92ad-aaf1240c8017"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1240), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2a8d107e-5f4c-4290-91a3-3e59be3d64ef"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(906), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2b38c454-1e24-4b98-9a0a-e03ff43301e2"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1370), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2b52d3fc-9cd8-486f-84c3-68b530f5463c"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1046), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2c88305d-e042-4557-91af-0d5ea2563679"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(754), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2ca68fb0-ab73-4463-8fa6-61d47cf15dac"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1022), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2d82efc8-b056-4577-8455-058946fb4c62"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(732), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2dc5dfd9-dc4e-445d-8e4d-91d57bbe5378"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1186), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2dd97c45-9749-4801-acc1-2340b1912ef4"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(810), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2e5a8cdd-36ab-49be-aa20-4da313576141"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(948), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2ecdcbd2-f9ed-4f09-80cd-43f2e4c5c76e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(922), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2f2f5da8-b6c3-495a-ad90-6b96b85c8892"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1049), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2fc0d02a-7cad-4bd8-9595-fa6c62304a24"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1443), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2ff82f99-9cc2-4f48-b232-594849157f93"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(994), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("33cd7e7a-eb2f-4f8d-98d9-72a5861254b5"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1071), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("344aaa4f-8e21-4b00-acde-c650227d3956"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1322), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("35aa4138-af76-45d9-abb2-9f434e90528f"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1208), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("35b52a43-0d0d-427f-9d77-a57f69b21c77"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1226), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("377d24c3-274d-4146-acaa-4c122928d6d1"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(942), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("378c9ddf-099e-4c8a-bdc6-9cbf5a396384"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1202), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3839bd7a-2883-4c4a-bd88-d01177941f0b"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1330), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("39c114bb-2f88-4ba7-ad93-6aed02fb4792"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1048), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3a75b685-2102-44ec-94dd-1145e926a0aa"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(764), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3a77157e-79ae-4bcc-8422-75f13225b1ba"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1082), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3a800b7e-03ce-46b8-b476-4d83c38fe68b"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(947), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3ac165e0-5697-4e5c-8f17-2e3e23e0c2c8"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(864), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3b5e911d-cf4d-400f-b5e6-2e6552467d49"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(867), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3b931ba7-43a3-48a2-b329-3ae34e663f3e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(900), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3cab5f0f-7a5f-4006-aacf-1b3f3b79dd54"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(792), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3d44850a-0910-4c76-bc22-edd9023e61bd"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1423), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3d580e2f-3e6c-40ea-b7fa-ba28d79ed42e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1293), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3d90f010-97f0-4c7f-bce9-0faebd657b9d"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(760), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3e6b1364-e6cc-429c-a265-2ff5531dad9b"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(871), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3ee8fa6e-581f-43d6-90ca-0325bb7d9bc3"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(724), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3fc83420-bc3a-4ca4-81f7-33c84c8e2069"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(879), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("405af3e9-caab-4956-b055-dfc53f541cf4"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1367), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("412002b6-64ba-4400-aca0-bb5313ff5b95"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1294), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("41316ba4-3dbc-4a09-a0a6-f6a11432d0cd"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1433), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4164c126-3206-436b-a5e2-0c7373f2bb1d"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(746), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("41c93f45-0521-4a5f-9d9f-6eaf23b39e61"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1056), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("41dbe593-b8e0-4d5a-b634-fec2197d5b46"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1449), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("43c86327-c931-46ea-b0ef-3162ffd5605f"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(872), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("44119950-4fcb-4679-b8f4-2e2bb9396d9e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(863), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("442d7441-cae3-4e56-b898-0d24e0803340"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(751), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4504062b-53bc-4fac-a0e6-5a02c50b21d8"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1000), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("459bbba3-4feb-4b55-bc7d-3c3c08ef474d"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(902), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("45a4b551-49ba-43a8-9030-c5d380d480c1"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1320), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("45ed2363-ab56-4bbc-80f2-6192e74e63b3"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1021), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("46f8cb0e-7b9c-44ee-bfdb-12db3c92bfd3"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(771), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4740fbff-245d-4578-813f-b9596a47523b"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1292), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("47c1432d-e35e-4510-833f-15f15a515190"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(778), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("47c91ea2-6350-437c-8142-388098ab3a18"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(892), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("48f9a0eb-6ccb-45e7-9168-951949718c83"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1191), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4915c4f4-e198-4ae7-8222-e4de91b431cb"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1382), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4955990b-4a8f-4075-8e88-5393913a49fa"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(957), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4a290d8f-a2c1-4b0f-8a32-a6144636f2d8"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1230), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4a477f19-9d9f-48d2-9aaf-f789109f565a"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1438), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4a52efe9-c9df-4b46-b6b2-12c804f83f14"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(770), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4b214e78-b72a-475d-9285-e5445c4e314e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1384), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4bb41681-6261-4b93-8116-40443ecfc2a0"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(916), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4bd86ffd-378f-4236-a3a5-91a4939148c9"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1185), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4c725dcb-dfe3-4586-8140-c02f24364d6d"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1304), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4dc6124a-1f25-4188-b032-d89cdb950870"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1352), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4e02d0ff-7259-44fe-9f60-122ddbfad80d"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(767), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4f0a3567-ae7d-4bd7-b2c4-405729e74a4e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(918), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4f3ab0c1-c6e2-445e-9cbf-6ba4cd49b208"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1051), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4fc7f33b-bd02-42d4-9c1a-bee66c120f47"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1299), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("50034e5a-64d2-4095-9c7e-2807a5825551"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(826), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("51453f26-0d50-4fff-9f05-1031be904c03"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(761), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5159bc0d-55a2-4d1e-a006-ab9d2233954e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1242), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("51913cdd-2e43-4085-9466-212b0a166774"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(806), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5293319b-cb27-4fbd-b96a-5992f8bf9c72"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(997), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("52f577d3-3580-4f86-bf71-ff2ad19379ae"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1451), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("534c9ad7-b833-4795-9ae1-b07a1ab0f2fb"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1276), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("538c8107-dfbc-435b-a2d5-19d625b1238b"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(784), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("540399d5-db8c-4b02-bb88-5765b64308f2"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(961), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5432100a-f7cb-438b-b4a2-dfcd96134ea0"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1368), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("548b413d-745a-4e5d-a4c1-43f749276931"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(923), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("54c193b1-e91d-4d01-9d67-ed5fccd0dbe8"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1421), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("555fa5da-2d59-4759-ae10-1669618732dd"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(779), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("564c4ad4-50ba-429c-be14-84ca4d6de76a"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1160), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("57f5b221-1645-4d1f-a715-e06135eedc47"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1372), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("584205ff-0cb3-41ba-b008-7c515ee6e8f9"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1098), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("588424d4-16a8-4298-b653-3384b578257f"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(876), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("590dfbe6-f65e-4e9d-b4a1-0d97fec342f8"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(755), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("59a3ab07-748a-4703-966c-68831566a8bb"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1043), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("59e9585d-257e-4ae7-918b-ac943ea4a649"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1247), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5a34f02a-5365-45a4-99ed-5dad342c92d7"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1012), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5b418601-a219-4336-9631-213a1c63a173"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(807), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5c83cdf5-ebd9-4742-a0ff-f535bd4b21cd"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1430), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5d649418-d9ba-4ed6-b2e3-0bef0d4eacb5"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(745), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5d8aa47c-09e9-4def-9bc4-4d641741e231"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(944), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5dae8288-5744-463c-b9d6-ec67e7914a31"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1420), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5e96761f-964d-48c0-a06e-a639a39eb6f3"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1233), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5e9fdd38-9287-4b65-a01c-719da8af2195"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1068), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5f173ca3-e8db-4b69-a094-622a3005544e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1024), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5f9b70ee-2032-4fb2-8a82-9e70c0a0c378"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1204), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5fec153d-7f95-42bd-a181-d1c1aa26040a"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1335), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("601324a7-28d3-46fa-9930-7d838d4e9a6e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1105), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("605672aa-f57f-4127-bd4d-4652d5ef49fa"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(931), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6148fee1-e591-468e-bc34-8fea673d9d53"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1183), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("618ef73c-963f-4a05-8ba6-e2f5352b598c"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1380), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("61b0bb61-71f7-4410-a637-3f41fc2538a0"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(912), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("62b06bbd-a5eb-47f7-a161-004979e6b7bc"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(718), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("636193a3-60a6-4a99-99c4-7808e60f4e08"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1087), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6378a661-d5c9-4e26-82f3-b598460f4045"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1283), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("63d7be55-628a-4e91-bfa3-c43762391e10"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1314), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("65231359-3eff-4dcb-8084-3191d940d1cc"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(874), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("664b8153-220d-4cce-83e0-03968a82de3d"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(728), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6736a71f-e1c4-4f60-af9c-01c1d07b6fa7"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(721), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("680627a4-9b06-44ff-835a-ac1b56664b5e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1244), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("68084055-595d-4fed-9dbe-a83448f1a745"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1238), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6841427a-ea2b-4bd5-9e89-7c5d91375ef3"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1100), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("68a00cda-e073-4d69-a723-3422accf583c"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(880), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("68f43971-e21b-4f0f-aadc-40510bce8270"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(917), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("691d68df-b213-4d1e-92f1-689e9bde48e5"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1044), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6a2b475a-b0f2-4d69-972b-d84893810f23"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1349), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6b05d2c9-dfec-49ac-9610-4f085d3958ec"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(953), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6b2a3600-7ec0-41e3-ad39-4605bbf00991"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(929), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6b573192-959b-4160-8ec7-e1dd11608d27"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1379), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6b950142-e5e0-4f0c-8452-880f58111dbb"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1164), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6c94ce6c-623f-4ff6-bbcc-344428e94ea7"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(882), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6dedc6c0-e18a-4d44-8ce1-3e66b000871d"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(907), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6f163dcf-679e-4659-b616-dd0358e63697"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1360), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6fde6bde-66bd-48f9-8648-7cd7832aa968"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1102), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6ff2ef85-1bbc-4664-8b3e-e5568b1a2329"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1385), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("70703c5b-1993-490e-8c03-66f6ba4e5e80"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1039), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("72232b06-cf3a-4200-b9f1-fb45d203123a"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1447), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("72416c7f-e6aa-43d5-a9b6-9fdda16919d4"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1210), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("7286f898-53be-407f-8484-11a400fdf5c5"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(765), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("73ca55a4-ad79-401f-aa66-1ab1e7761585"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(787), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("73e61618-eed1-4e3d-b646-907668627d56"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1184), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("74969d19-c778-4a50-890e-da2be6892417"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1354), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("749ca733-8bca-44f2-95cd-81ba1bc87f4c"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1146), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("74eb2c1f-2f67-4896-9264-348c4ca5fd7c"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(883), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("75fd1a32-ef64-4774-a580-9a9419828086"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1199), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("76224bd4-3d91-40b9-b108-8b6f050e76e3"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1173), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("76cbf49e-46e3-42b8-952c-c830a3ddfd4e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1326), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("7719a5b7-0e01-46b9-928e-adc07595b225"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1273), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("77d2e9e4-1f69-4490-a9cb-a5eb981edda1"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1227), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("7a1ba934-2e0b-4d44-814d-c4e1956876b8"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1317), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("7a203e5f-d23b-4a4c-88a1-53dc53a5309e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(958), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("7ab369fc-08d7-4d9c-8cbf-ac6ee062d865"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1246), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("7c11660d-d300-4ba6-96c7-9fe45b338299"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1211), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("7d957d4b-afc1-49aa-a66c-6248688c993a"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1026), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("7f2b7b59-c8eb-4d32-8fb0-60ea96ced12e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1019), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("7fbb49e1-2446-45c4-96a0-0b14fa6a7931"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(742), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8122ec18-d201-40c6-98c1-75bc96ba9d1c"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1080), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8137d9f1-f3d0-4ff3-aa7d-c4e6ef44e254"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1318), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("81af5828-0c57-491f-a9df-1b6844103d0f"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(795), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("821e99cd-ecbf-48d5-8b9c-cda26a0c1217"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1329), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("829dc30f-89be-47eb-b631-def292ceac3e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1366), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("82c8dba7-1d07-4ce9-bb70-7fdf10e0d312"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1138), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("833a7e30-5e22-495f-98d3-f43ef941897d"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1429), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("83b6e04a-4620-4611-8096-8300086877cc"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1150), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8439577c-357d-47e0-b936-5d64df897cf8"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1011), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8528dfa2-d7a5-4bc0-b270-2f8449635869"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(870), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("857274ca-a685-4ee3-be87-aa0302a75db6"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1239), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("862a304c-d467-4422-823f-7c5bc468dd54"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1099), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("86f16ef5-44b1-43eb-b078-2459cf32ed12"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(813), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8733fa11-09a7-4076-b7bc-f77c91c252ca"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1435), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("888b57ff-a8a4-4453-87a4-e12efd4024ba"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1376), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("88e90a64-e145-490f-8b84-dd78f39add25"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1365), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("88f0f31c-2fea-48e0-9bfd-7e0085afdff0"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1107), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("89798567-a31a-43e9-9608-aa726eea6167"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(704), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("89899a5e-9208-4bce-a5dd-26ecd170f99e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(822), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8a77f5e7-a432-41f4-a267-dd5c3adb8d06"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1364), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8aafe79c-f21f-4300-88c1-110d7b12a63f"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(763), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8bec7b32-7c49-44f1-b41a-7afa29574c05"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1091), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8bf94013-3ad7-4a0a-ae29-f40b0d869ba0"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1428), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8cc8f121-0bd0-4221-b33f-5ca8230a0e91"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1005), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8ce2b787-6f46-4241-8b61-5c982795f874"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1003), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8da0c156-4a01-42c6-ae16-45df213658c9"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(928), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8da77773-4c6f-4808-955a-d0231b87ca3b"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1331), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8eed45a8-0794-401a-8a3a-9989a3f4d739"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1195), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8ef09110-d213-46cd-8415-640260328351"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1032), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8efc5e47-4ad1-4817-9dee-da77cde668b7"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1356), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8f18fbc9-afbe-4506-a931-71ea5aa52755"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1069), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8f620fe1-67f6-4171-b999-99e40ea251cd"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1196), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("901331c0-f225-4bf6-b7ee-803c3965bcd8"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1140), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("90f8853b-c70c-4ed4-978d-5c8419d0f113"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1002), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("91d23f14-6ce2-47cb-a5de-38f23f833ef6"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(894), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("92742b8e-f2d6-4a69-afd2-442bc3709c64"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(924), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("932f2a1f-28b4-4293-8c23-7b5824386fcc"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1094), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("934a32c1-245e-4107-be03-23b19e7ca626"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(811), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("938d8591-ca9f-4318-adc0-2e4bf3c1aa38"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(866), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("93ac6bf7-e2fe-4b61-940a-3a0131e6a1b4"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(896), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("95664ee4-d31a-4be8-80c1-33c2373e689c"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(878), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9633ba15-c995-4a64-ae22-c1546ad877d0"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1307), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("96ad33c2-9686-41db-a738-447f7408d8be"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(926), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("97943ab1-ad20-4793-b803-73450088fc15"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1073), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("98fb1ad4-f0ef-4e0b-bb8a-3ef1cb977dcb"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(910), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("991944e9-ecbd-453c-977c-85ebced0561f"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1161), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9981464c-09e5-46ff-8df4-36b95b839412"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(886), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("99ed70e5-5982-4f75-9061-d75b087221cd"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1346), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("99f9e926-2c29-4507-b958-1f65811626a8"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(801), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9af6804f-53d9-4188-945e-c7a8c58ae0f4"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1325), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9b62d15d-6082-4257-9933-34cdbe7e07a8"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(885), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9c1b68f1-0a39-415e-bb48-6ef4ffe9cfc6"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1058), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9ce7903a-b9ee-4c17-b335-a3bcae305ed0"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1219), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9d4d09fd-827c-439a-b2c4-d6321306a4ff"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1344), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9d5b4be5-16c9-446e-bc2c-bf3f3bf92bdc"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1301), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9d62c008-cff2-4fbe-9024-27d4bfd4d4e6"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(825), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9de5395c-2c8e-4b2f-9e31-613c581bfdd4"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1020), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9e277330-5a23-433c-9aba-68c6a72ffd63"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1047), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9e2d5775-a0b5-46a1-b82a-fa7b2c3df732"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1444), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9e9c10e8-45ff-4c2f-96cd-745dbb403ad1"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1078), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9f0d0893-87db-4ed4-a7b4-9f2e3e66db59"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1206), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9f110333-8fc4-46fa-bbb6-6368e92952c7"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1028), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9f586c69-8ac7-412a-b4a6-eba1bfdc5e15"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1417), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a05e3b03-805f-484f-8230-a07ec5c94349"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1212), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a09907f0-785a-4a02-9e76-37002b2e0780"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(887), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a28e0572-f4cf-44cd-a34c-e556e5e07017"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1411), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a4c9f911-fc44-4596-a409-c4c374544450"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1315), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a4d8e50b-313e-4d9a-a64f-7e89c8ba3da0"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1108), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a59b04cc-c529-413e-8668-7a994598d7ac"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1090), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a7088dce-eaec-4741-be56-3a053b1ecf36"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(897), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a759f834-d067-4081-8779-0d2d899b4970"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(752), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a7986f26-74e9-4923-9511-476ac94425d1"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(933), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a7aadea1-5da8-4158-99a0-a21792f5eb62"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1213), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a7c51a86-324f-4c77-b417-38ed883f1a24"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(893), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a810680e-1483-48e2-a656-d1031cb47d55"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1332), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a829b01f-3742-4762-904c-6efcba063869"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1059), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a9e1688e-c3fb-4da0-bcb2-d46656b3f9b6"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1343), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("aa2316af-c055-45a7-9165-770bfff4009d"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1085), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ab0a83da-97fb-4861-bb46-b610cf202ae2"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1284), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ac49cded-beea-4688-ae3f-7b28fad146e7"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1093), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ac5d462b-8b1c-4d72-bbfd-fe2fd3e2e695"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1448), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ac7d043f-abaa-4bf8-a804-a2f8dc07da00"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1216), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ad4ebbd7-56fd-4aa0-9d1f-4940fe6c34f5"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(936), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("adc42d66-93dd-488b-8d7e-3f7841f4de17"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(914), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ae28e696-06a6-4e21-a7fa-1dcbbe9eef6b"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(796), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ae970bd4-e903-4e37-a2a4-a534107674e6"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1224), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("af8ddc88-816d-4f8b-a979-d80c9646a78f"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1348), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b05e85cf-ca1c-4427-ab73-07b9a5844537"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(737), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b0df6753-0e25-4c46-bb17-812af17eb18f"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1144), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b0ef7004-cb5a-485f-a4b0-d455a2cc5eab"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1342), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b13436ea-786a-44c1-8256-8448e3f18b2f"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1159), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b165f426-799c-42b5-be0a-37ebaa32823d"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(889), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b2a4a8e5-c640-4188-bda6-6f663ffd1e5e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1060), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b2c3e2ba-0f36-4f60-929c-929381702494"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1187), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b3276c4d-18ca-432a-ae4f-d229839ae842"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1338), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b41191e0-186b-475e-9719-b744c5d1765e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1286), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b41b2965-286a-4f3a-b8dd-89d13d0c268c"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1168), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b42fe311-4813-4d25-ab33-c715fcdd563b"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1323), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b45eefe3-c3da-4657-8929-6793f699dce7"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1042), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b863588a-143e-4a2e-aa3e-d987af6cb5c9"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1353), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b8bf91a1-beae-40d5-8c6f-c3eb6c1ef499"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1312), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("bba52d03-e307-42c0-97df-5ef87752e2a7"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1015), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("bc96900a-2867-43dc-81c3-13a68d65b815"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(775), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("bcc73ad5-aa8e-4abd-b620-a402ecbca59d"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1220), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("bde68f7a-f49a-4018-ba27-5fe9dc62f60f"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1016), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("bdfe397f-6a21-4309-b5e9-4b2c5a1432a5"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(939), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("be11cf1a-a368-4e35-876f-577319cf71f2"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(963), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("bf936a12-8a70-4c5f-afcc-7554a41a39ff"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1079), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c0560872-4974-42a6-a8f7-4e67fd3e1bac"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(952), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c1cadea9-1dd3-4df6-a30a-03bcd8efa0e6"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(729), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c234c4d3-557c-456e-94be-8a14bd8c3ae7"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1169), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c273e036-5431-42fb-a2df-eb10e5bb401d"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1416), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c2b69395-ecc6-45cc-8641-66e416a42e09"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1037), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c2df0c1c-b098-4597-8ba1-3a4e43215410"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(898), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c391d26e-56c8-4643-bb39-3b59693ea203"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(901), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c3d39ce8-e0ae-4326-b4e2-c5c685c985ca"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1319), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c49a09e1-ccd3-4a1c-a7bf-7bedb47aa6a2"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1097), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c5010a95-37c8-41ff-9f56-f785c67d69e7"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1436), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c5013e79-8583-479d-9fc8-49f61e26f513"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(937), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c573464d-8e69-4bf0-a8b3-0ba7e20c70f9"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(743), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c62ef4b9-8f48-47a7-8dfb-7d060c3bae0a"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1104), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c64b6774-af24-4f5d-a73d-0421a4c1a2c4"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(730), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c66f79c7-3ac6-407d-b4c7-e6ad2925f638"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1412), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c6893abb-dce4-4e02-80d9-771ae9f8c70d"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1086), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c6b98900-f55e-4570-b119-7f2a35996bef"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1110), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c7154589-f194-40a4-b0ff-a5f9ac7591db"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1228), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c76dfa6e-177e-40d5-aff6-ab769f86696c"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1241), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c7a40d3d-0015-4a61-8794-456c40111527"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(927), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c7ffb60a-331b-4de2-866d-eaaab33bf060"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1415), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c87a2bcf-8132-47c2-b728-63bf6c75098c"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1029), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c9307459-ed9c-4c54-8919-173a05534417"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(782), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ca30de93-b00f-4696-a049-9c0eb6a89b78"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1200), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("caade10f-09a7-4d18-b622-1b0ba777bb30"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(791), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("cb08827b-fa85-498f-a7c9-4c1d37a30d33"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(943), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("cb52606a-5774-44d9-96ce-dc7ceff8bc81"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1359), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("cbc71c17-2072-4161-9a87-bf42bb8b955e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1302), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("cbd2b6c9-2c52-4541-9a97-0ad35f27a0f7"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(741), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("cc61b7c1-b29b-48df-b9e2-02936e115422"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(722), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("cc802e83-3cd3-40b3-bd85-0e15580e313f"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(756), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("cddaf9b1-5622-4dc5-97d5-be2c3d45fbc9"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1298), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("cdfd5b7f-cd5c-48ef-bdbc-0e20c8f1296f"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(757), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ceadab37-a0c1-4016-b2d8-29a50b19bbc1"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(856), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("cebee0ae-d726-4ec4-a194-13490bcccd74"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(773), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ced5934e-d0b3-4577-aee7-a76d64648077"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1235), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ceffdf66-984d-4130-a99a-9c39bd0c1061"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1201), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("cf40b31e-2130-43fc-bad7-0a443f2eaa6a"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(739), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("cfe68a65-4e5d-4aae-ba96-2693f2adfb46"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(816), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("d0903197-7f82-4a86-9bd6-93a8042c2136"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1189), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("d1205b77-01a9-4db2-a9d8-810b5958a527"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1141), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("d1fbb0c5-ef37-4153-86ad-1b408ceb9c38"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(793), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("d21579b7-505b-4acc-acc0-26a94b9d48c3"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(821), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("d2c4a703-629c-4031-ba7f-4b20269e09aa"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(938), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("d34a61e2-2683-40ae-a18b-6d105dd00985"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1052), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("d3ff70df-b6ab-4dc1-9ad9-3ef9ec7038b7"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(911), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("d54ebb7f-dd5a-4325-8d57-a600f1cf816f"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1229), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("d671b031-ca23-4d39-aeb3-8ec89d38ef76"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1179), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("d7634bbe-ea83-4778-8eb2-83a1655aa9cb"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1153), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("d90754e4-69ad-4ee7-bd3b-bfc95320f232"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1303), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("da168a7c-5f78-4ed2-8564-4f8a1bcd6566"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(954), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("da66a52f-fbf3-400b-b529-00104c89b142"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(716), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("da91e3fc-b31a-4b41-b157-646e192f6274"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1033), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("dabcfb3a-540b-4b79-a0de-4d657673b072"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(946), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("daee79b8-9341-472d-82ef-7cf998fc7ff9"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1103), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("db1de636-0fc8-4fbb-b862-b3d611e5c291"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1280), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("db5daa1d-468e-4d75-9d8d-29929e6ce8d1"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(828), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("dc0a45e7-12aa-430a-90fe-4130ffcc21db"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(919), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("dd835106-65cc-4c01-8836-8a54221dbc5e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1170), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("dd96c9f7-3260-45e7-891c-f140a5643bb6"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1427), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("df0db550-abbc-48bf-a1d2-3ec0c1a848f1"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(908), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("df6450f7-f26b-40b8-964c-8d7f63f262ee"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1177), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("df71bd5b-9606-402c-ac30-b8091c367429"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1287), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("df8b22c5-ba19-423c-92aa-b51a3c0e6f63"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1282), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e0113f75-a811-4a0f-8f06-e1acbc13f6e4"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1377), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e0a17bd3-b57a-4b9f-9430-b2b9322d5687"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1279), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e0bba013-962e-43f2-98ed-5007ca0a244a"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(955), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e0d57445-9c81-4a66-9db6-d2168a8f93c3"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1337), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e0dd945c-1207-43f6-8654-29276ffb73b9"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(827), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e124c53d-df8a-4964-8a99-5ed5402f190f"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1013), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e134b9b1-b2b0-4c8a-a791-16fa8d360c62"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(780), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e15be4e5-d2d9-41d4-ace0-8235c0207abd"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1149), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e167cf99-05cd-4f02-adff-c3cdb940eeab"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1310), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e2bde3fb-6387-4468-b779-c3fe3070c152"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1313), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e2c8c809-a372-4117-96a3-622e8f0f893d"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1025), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e2cbc268-1ad1-4803-9e1e-60b7ca05e406"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1017), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e3cefae1-cb29-4bc1-9935-c07864d5cc1f"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1306), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e57dcb48-1069-4bb7-9979-2044b37b7627"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(802), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e60192fd-9b36-4582-87a4-db1a25aa8487"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1357), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e62ba946-3c11-43a9-837b-8c2e3ad90fe7"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1174), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e6713da9-5ca0-426c-93f2-b163f3860480"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1278), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e741f5d6-6b10-4534-b7da-5990fdc7b13d"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(996), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e78de827-4839-43f4-9b1a-a28913f3e010"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1214), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e78ef1ac-52f5-4995-9a21-96314db14472"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1192), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e7e1162f-3f61-419a-a25a-1dd3f704e103"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(797), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e7eb9b06-1db2-4d4f-9a27-83a2ffd90edf"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1154), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e8c62d4a-d82a-46a0-9c0b-f6b6408cfe55"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1434), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("eaa30acf-ef2c-43ae-ab71-be0f6cc09d9e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1297), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("eecad343-a835-4f23-835f-21c7dfc9de15"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(808), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("eed0ee6b-e63a-4e25-9457-7f97d5a7ab93"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1111), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("efaaae37-dd9a-41c6-a70d-13c30ca04fab"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(777), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("efe8ac42-c1c9-4be0-bf34-009b89180464"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(719), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f0c63ea9-55ec-47c8-94f7-74255b6962be"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1076), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f136f9ed-0437-49d2-b069-42766c5255fb"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(921), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f16ec5d4-2f03-49d4-9e12-5d3359d9abee"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1010), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f179658f-afcd-4d8e-b590-21047b839a7c"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(803), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f1a79572-116b-46b3-920e-05e6b3874be3"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(734), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f3e5b666-7911-46c6-8c9b-8ecb9437555b"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1181), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f4185865-1c77-4409-bb1c-2bfd81efaa80"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(859), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f47b956a-b45f-4d72-9696-87392188634a"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1163), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f5efe0eb-c3be-4b31-be01-1ac440602852"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(788), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f664532a-3c07-4b61-ba9d-0d1698a85a3e"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(748), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f7966ced-3414-4571-82be-1a36d6181c8f"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(786), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f7ca52aa-6da3-4652-8126-210b889d4a93"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(805), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f810cba1-0d99-4186-9a69-d88e281afbf7"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1350), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f8ac95d0-fcac-4f7d-ad5b-b86cb247db1a"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1288), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f8d14618-77d2-4a54-9745-a7fe9f233a93"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1236), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f8f08c85-686f-439a-a0ec-cc1183cf2bcf"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1328), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f9162287-5ad4-4b47-a67b-8b217728fdfa"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1171), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f9b5bd83-c700-42a6-bdf7-d269a028cc00"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1340), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f9e78e0b-c9db-4e6e-999f-07a3cc8181ab"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(735), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("fa4b91c8-c1c9-42d1-911d-4e2a3971c4a6"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(950), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("faabbc6e-a373-49cd-a01c-3f6ab18207bb"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(913), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("fad0f60d-2272-4076-a3e5-1ae5404b98e6"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(789), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("fb7ee740-ff98-4675-9e9b-66d253eab5ed"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1035), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("fc14fcc0-8814-4fc3-bf46-733c2a190aeb"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1072), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("fe1e10ef-b8a1-4ca6-9f6f-9eb5f1a3e258"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1205), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("fe84ccf1-04c0-4205-9ba9-492f5470c8ac"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(934), false });

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ff5e5d8a-d286-4807-8f7f-71028c398aef"),
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 50, 54, 758, DateTimeKind.Local).AddTicks(1064), false });

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb0"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb1"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb2"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb4"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6470"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6471"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6472"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6473"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11111111-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 50, 54, 759, DateTimeKind.Local).AddTicks(9190));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Definitions");

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("00426149-b220-4d2f-8a8c-7a0fd828ae63"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("00796d93-3bac-4438-800f-a517e1d25fb1"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0089da3e-e43d-4e95-a575-703e236f754e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("008b8712-9c18-409f-b800-59d810b8de56"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("010954e4-b6c9-43ae-a8c3-9408a664469a"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0232d0bd-ab11-4521-846e-63e2680ceadd"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0259f4b1-ce87-4c87-9563-ac2e0b5a592e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("037318bb-5724-41f7-8051-5d23548177c1"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("041e29fc-5a95-4ac5-a874-46a3a5a485a9"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("04d7614a-fd5b-43c0-997f-5d0bc6992c22"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("053c3572-09f0-4b19-a27a-9a3ab5603eea"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0551b1ae-02fb-4a85-8d6f-843c176ab185"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("05adef7a-da72-4cd6-a773-afdbc6856f30"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("06385e6d-71b8-4cc1-b674-f7d89dd51e3a"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("06495180-6ca0-4a80-adaa-0919c62d64c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("066c5ba4-db24-4508-9e2b-fff2e03cba04"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("07041287-5b65-496d-9321-038ae5726180"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("074db01f-a37f-4018-affa-279bf48bb0e9"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("07c74cb0-b861-49e3-98d5-f972fb6a3fdc"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("07d836c1-6b34-4672-bbfe-6726ba94d574"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("08861d0f-f9cd-4a3b-89ec-8c72ba8b5bcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("08c0780a-87db-4f7a-9d92-3cc15df8064c"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0928fab9-ab19-4046-8312-2d7252b61ffa"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("099ec0e6-db40-467b-9e74-2f5adab88e54"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("09e61570-9ae5-464c-85fa-8e4b07720f1c"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("09ff7859-d023-4f78-8821-e0d45af4fe3a"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0b2196a7-083b-4ac5-91d6-e4412f59a0c7"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0b82168f-89f5-47ba-98e0-83f5ebec0061"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0c0295cf-7a5c-45cb-b095-dd25da8476ea"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0dc49665-00a9-4d3d-a4e3-7b77fc90c92f"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0df6575d-b889-47a1-9351-76974fee3692"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0e19da8d-710d-4f4f-9fcd-244a46428058"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0e6e8a20-0b44-4f05-80a0-663be5021e1e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0f9967df-85fb-4da4-97d6-713f6fb9958c"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("0ff09a27-a182-444d-b1e5-a63154bfcb5b"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("10f10dd8-c4ca-4a52-b7f4-fb2798115098"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("10fcf4e8-99a7-4a07-9e8c-dd390b752814"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("11931771-4c9d-4702-b9e5-38656e12faf1"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("11d4977a-2994-4cd9-a3d8-977f461970b5"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("11e4f171-9f82-460a-acd8-d1fc128b81c0"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("11fb93aa-6d4f-49a1-abc4-3dbe21405b7a"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("12129a02-7541-451d-8327-f104949f39c3"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1475c694-8485-424d-82b4-586a73a16cfc"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("14c4ff41-e7a8-4dad-a68e-254702ae1c7a"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("14c6146d-5e3f-4748-9ff6-c2d0c95cb2c4"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("15bcd116-32fb-4715-9828-e935fcc10a3b"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("165bebab-de98-4f5e-bfe6-efd0775c1029"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1689dd47-ef24-458a-a730-bbf7e06fe2eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("16fc89ad-e6e8-49e4-9e8b-564eb840238d"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("18570096-a785-4fb4-bcbe-334990a885ee"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("19383580-add1-4306-9c59-81c14fa7b8e6"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("199eaf80-692c-49ec-bd7c-12aac8404727"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("19a16bfa-42a6-440b-af73-88125a28fe30"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1a24e60e-a22b-49d2-a781-134ff662080f"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1a7a091e-51b7-4bcf-b87b-9f302cee1416"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1aaeace3-c873-41c7-b204-d7e056d98db9"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1ab6e719-eb6a-4cca-af09-ec33b883e938"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1b2284c8-286f-499d-992f-0d0073839155"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1b6493f4-0420-4d1a-9f4e-b8a28e329b08"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1b7ed58c-45da-4dc8-bbf9-fa323f0e749f"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1c7ab1a7-41c1-4034-aeb6-e049d2f8f942"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1d22f948-00f7-41e9-9417-895c18db51d8"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1d5607a4-0879-444f-a376-81105afea93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1ddde177-9c8b-4c97-a440-1f2a803f0365"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1e2ba14a-c065-4cf6-a3e6-4e1917784c0f"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1ea6a91f-3584-417d-9036-83c3a3b10926"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("1f994a98-9dbd-486f-8d9b-ad854169d3c8"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("209858f9-abe6-4485-866d-7014badb77d8"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2261bb04-71f1-4e99-b2dc-8182d876f2dd"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("22b12edb-4818-42fd-94ae-6da9e55b4012"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("232e5aeb-c4bc-4fff-8667-5550631a69a3"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("24303819-1ee4-4ec2-b571-a407ec3aa378"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("25e19797-06ea-4696-a3f2-d1ab3248ab43"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2636492d-1cb3-4e50-8aac-0ee34ad8e4cd"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("26f94415-8b8f-45b4-8632-2d959cfeecf4"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2853f370-1546-47a0-b60d-6d528b73c92a"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("285b1d5c-e1c2-4a5b-a5dc-2b943f97f979"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("28a37e94-cad9-4f06-b2fc-4b67ed20fdfe"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2926410c-854d-4c8b-8245-0336496d6c00"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("29d54105-fffa-4a4a-ad98-175920430b51"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2a0b9a3c-7cd2-4716-bec9-73bba194cb09"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2a260d88-e538-4d80-92ad-aaf1240c8017"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2a8d107e-5f4c-4290-91a3-3e59be3d64ef"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2b38c454-1e24-4b98-9a0a-e03ff43301e2"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2b52d3fc-9cd8-486f-84c3-68b530f5463c"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2c88305d-e042-4557-91af-0d5ea2563679"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2ca68fb0-ab73-4463-8fa6-61d47cf15dac"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2d82efc8-b056-4577-8455-058946fb4c62"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2dc5dfd9-dc4e-445d-8e4d-91d57bbe5378"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2dd97c45-9749-4801-acc1-2340b1912ef4"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2e5a8cdd-36ab-49be-aa20-4da313576141"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2ecdcbd2-f9ed-4f09-80cd-43f2e4c5c76e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2f2f5da8-b6c3-495a-ad90-6b96b85c8892"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2fc0d02a-7cad-4bd8-9595-fa6c62304a24"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("2ff82f99-9cc2-4f48-b232-594849157f93"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("33cd7e7a-eb2f-4f8d-98d9-72a5861254b5"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("344aaa4f-8e21-4b00-acde-c650227d3956"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("35aa4138-af76-45d9-abb2-9f434e90528f"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("35b52a43-0d0d-427f-9d77-a57f69b21c77"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("377d24c3-274d-4146-acaa-4c122928d6d1"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("378c9ddf-099e-4c8a-bdc6-9cbf5a396384"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3839bd7a-2883-4c4a-bd88-d01177941f0b"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("39c114bb-2f88-4ba7-ad93-6aed02fb4792"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3a75b685-2102-44ec-94dd-1145e926a0aa"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3a77157e-79ae-4bcc-8422-75f13225b1ba"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3a800b7e-03ce-46b8-b476-4d83c38fe68b"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3ac165e0-5697-4e5c-8f17-2e3e23e0c2c8"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3b5e911d-cf4d-400f-b5e6-2e6552467d49"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3b931ba7-43a3-48a2-b329-3ae34e663f3e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3cab5f0f-7a5f-4006-aacf-1b3f3b79dd54"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3d44850a-0910-4c76-bc22-edd9023e61bd"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3d580e2f-3e6c-40ea-b7fa-ba28d79ed42e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3d90f010-97f0-4c7f-bce9-0faebd657b9d"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3e6b1364-e6cc-429c-a265-2ff5531dad9b"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3ee8fa6e-581f-43d6-90ca-0325bb7d9bc3"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("3fc83420-bc3a-4ca4-81f7-33c84c8e2069"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("405af3e9-caab-4956-b055-dfc53f541cf4"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("412002b6-64ba-4400-aca0-bb5313ff5b95"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("41316ba4-3dbc-4a09-a0a6-f6a11432d0cd"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4164c126-3206-436b-a5e2-0c7373f2bb1d"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("41c93f45-0521-4a5f-9d9f-6eaf23b39e61"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("41dbe593-b8e0-4d5a-b634-fec2197d5b46"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("43c86327-c931-46ea-b0ef-3162ffd5605f"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("44119950-4fcb-4679-b8f4-2e2bb9396d9e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("442d7441-cae3-4e56-b898-0d24e0803340"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4504062b-53bc-4fac-a0e6-5a02c50b21d8"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("459bbba3-4feb-4b55-bc7d-3c3c08ef474d"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("45a4b551-49ba-43a8-9030-c5d380d480c1"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("45ed2363-ab56-4bbc-80f2-6192e74e63b3"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("46f8cb0e-7b9c-44ee-bfdb-12db3c92bfd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4740fbff-245d-4578-813f-b9596a47523b"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("47c1432d-e35e-4510-833f-15f15a515190"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("47c91ea2-6350-437c-8142-388098ab3a18"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("48f9a0eb-6ccb-45e7-9168-951949718c83"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4915c4f4-e198-4ae7-8222-e4de91b431cb"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4955990b-4a8f-4075-8e88-5393913a49fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4a290d8f-a2c1-4b0f-8a32-a6144636f2d8"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4a477f19-9d9f-48d2-9aaf-f789109f565a"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4a52efe9-c9df-4b46-b6b2-12c804f83f14"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4b214e78-b72a-475d-9285-e5445c4e314e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4bb41681-6261-4b93-8116-40443ecfc2a0"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4bd86ffd-378f-4236-a3a5-91a4939148c9"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4c725dcb-dfe3-4586-8140-c02f24364d6d"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4dc6124a-1f25-4188-b032-d89cdb950870"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4e02d0ff-7259-44fe-9f60-122ddbfad80d"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4f0a3567-ae7d-4bd7-b2c4-405729e74a4e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4f3ab0c1-c6e2-445e-9cbf-6ba4cd49b208"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("4fc7f33b-bd02-42d4-9c1a-bee66c120f47"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("50034e5a-64d2-4095-9c7e-2807a5825551"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("51453f26-0d50-4fff-9f05-1031be904c03"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5159bc0d-55a2-4d1e-a006-ab9d2233954e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("51913cdd-2e43-4085-9466-212b0a166774"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5293319b-cb27-4fbd-b96a-5992f8bf9c72"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("52f577d3-3580-4f86-bf71-ff2ad19379ae"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("534c9ad7-b833-4795-9ae1-b07a1ab0f2fb"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("538c8107-dfbc-435b-a2d5-19d625b1238b"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("540399d5-db8c-4b02-bb88-5765b64308f2"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5432100a-f7cb-438b-b4a2-dfcd96134ea0"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("548b413d-745a-4e5d-a4c1-43f749276931"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("54c193b1-e91d-4d01-9d67-ed5fccd0dbe8"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("555fa5da-2d59-4759-ae10-1669618732dd"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("564c4ad4-50ba-429c-be14-84ca4d6de76a"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("57f5b221-1645-4d1f-a715-e06135eedc47"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("584205ff-0cb3-41ba-b008-7c515ee6e8f9"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("588424d4-16a8-4298-b653-3384b578257f"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("590dfbe6-f65e-4e9d-b4a1-0d97fec342f8"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("59a3ab07-748a-4703-966c-68831566a8bb"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("59e9585d-257e-4ae7-918b-ac943ea4a649"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5a34f02a-5365-45a4-99ed-5dad342c92d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5b418601-a219-4336-9631-213a1c63a173"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5c83cdf5-ebd9-4742-a0ff-f535bd4b21cd"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5d649418-d9ba-4ed6-b2e3-0bef0d4eacb5"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5d8aa47c-09e9-4def-9bc4-4d641741e231"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5dae8288-5744-463c-b9d6-ec67e7914a31"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5e96761f-964d-48c0-a06e-a639a39eb6f3"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5e9fdd38-9287-4b65-a01c-719da8af2195"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5f173ca3-e8db-4b69-a094-622a3005544e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5f9b70ee-2032-4fb2-8a82-9e70c0a0c378"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("5fec153d-7f95-42bd-a181-d1c1aa26040a"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("601324a7-28d3-46fa-9930-7d838d4e9a6e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("605672aa-f57f-4127-bd4d-4652d5ef49fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6148fee1-e591-468e-bc34-8fea673d9d53"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("618ef73c-963f-4a05-8ba6-e2f5352b598c"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("61b0bb61-71f7-4410-a637-3f41fc2538a0"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("62b06bbd-a5eb-47f7-a161-004979e6b7bc"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("636193a3-60a6-4a99-99c4-7808e60f4e08"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6378a661-d5c9-4e26-82f3-b598460f4045"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("63d7be55-628a-4e91-bfa3-c43762391e10"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("65231359-3eff-4dcb-8084-3191d940d1cc"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("664b8153-220d-4cce-83e0-03968a82de3d"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6736a71f-e1c4-4f60-af9c-01c1d07b6fa7"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("680627a4-9b06-44ff-835a-ac1b56664b5e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("68084055-595d-4fed-9dbe-a83448f1a745"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6841427a-ea2b-4bd5-9e89-7c5d91375ef3"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("68a00cda-e073-4d69-a723-3422accf583c"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("68f43971-e21b-4f0f-aadc-40510bce8270"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("691d68df-b213-4d1e-92f1-689e9bde48e5"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6a2b475a-b0f2-4d69-972b-d84893810f23"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6b05d2c9-dfec-49ac-9610-4f085d3958ec"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6b2a3600-7ec0-41e3-ad39-4605bbf00991"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6b573192-959b-4160-8ec7-e1dd11608d27"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6b950142-e5e0-4f0c-8452-880f58111dbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6c94ce6c-623f-4ff6-bbcc-344428e94ea7"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6dedc6c0-e18a-4d44-8ce1-3e66b000871d"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6f163dcf-679e-4659-b616-dd0358e63697"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6fde6bde-66bd-48f9-8648-7cd7832aa968"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("6ff2ef85-1bbc-4664-8b3e-e5568b1a2329"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("70703c5b-1993-490e-8c03-66f6ba4e5e80"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("72232b06-cf3a-4200-b9f1-fb45d203123a"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("72416c7f-e6aa-43d5-a9b6-9fdda16919d4"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("7286f898-53be-407f-8484-11a400fdf5c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("73ca55a4-ad79-401f-aa66-1ab1e7761585"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("73e61618-eed1-4e3d-b646-907668627d56"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("74969d19-c778-4a50-890e-da2be6892417"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("749ca733-8bca-44f2-95cd-81ba1bc87f4c"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("74eb2c1f-2f67-4896-9264-348c4ca5fd7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("75fd1a32-ef64-4774-a580-9a9419828086"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("76224bd4-3d91-40b9-b108-8b6f050e76e3"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("76cbf49e-46e3-42b8-952c-c830a3ddfd4e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("7719a5b7-0e01-46b9-928e-adc07595b225"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("77d2e9e4-1f69-4490-a9cb-a5eb981edda1"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("7a1ba934-2e0b-4d44-814d-c4e1956876b8"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("7a203e5f-d23b-4a4c-88a1-53dc53a5309e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("7ab369fc-08d7-4d9c-8cbf-ac6ee062d865"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("7c11660d-d300-4ba6-96c7-9fe45b338299"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("7d957d4b-afc1-49aa-a66c-6248688c993a"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("7f2b7b59-c8eb-4d32-8fb0-60ea96ced12e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("7fbb49e1-2446-45c4-96a0-0b14fa6a7931"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8122ec18-d201-40c6-98c1-75bc96ba9d1c"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8137d9f1-f3d0-4ff3-aa7d-c4e6ef44e254"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("81af5828-0c57-491f-a9df-1b6844103d0f"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("821e99cd-ecbf-48d5-8b9c-cda26a0c1217"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("829dc30f-89be-47eb-b631-def292ceac3e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("82c8dba7-1d07-4ce9-bb70-7fdf10e0d312"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("833a7e30-5e22-495f-98d3-f43ef941897d"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("83b6e04a-4620-4611-8096-8300086877cc"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8439577c-357d-47e0-b936-5d64df897cf8"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8528dfa2-d7a5-4bc0-b270-2f8449635869"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("857274ca-a685-4ee3-be87-aa0302a75db6"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("862a304c-d467-4422-823f-7c5bc468dd54"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("86f16ef5-44b1-43eb-b078-2459cf32ed12"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8733fa11-09a7-4076-b7bc-f77c91c252ca"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("888b57ff-a8a4-4453-87a4-e12efd4024ba"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("88e90a64-e145-490f-8b84-dd78f39add25"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("88f0f31c-2fea-48e0-9bfd-7e0085afdff0"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("89798567-a31a-43e9-9608-aa726eea6167"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("89899a5e-9208-4bce-a5dd-26ecd170f99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8a77f5e7-a432-41f4-a267-dd5c3adb8d06"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8aafe79c-f21f-4300-88c1-110d7b12a63f"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8bec7b32-7c49-44f1-b41a-7afa29574c05"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8bf94013-3ad7-4a0a-ae29-f40b0d869ba0"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8cc8f121-0bd0-4221-b33f-5ca8230a0e91"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8ce2b787-6f46-4241-8b61-5c982795f874"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8da0c156-4a01-42c6-ae16-45df213658c9"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8da77773-4c6f-4808-955a-d0231b87ca3b"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8eed45a8-0794-401a-8a3a-9989a3f4d739"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8ef09110-d213-46cd-8415-640260328351"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8efc5e47-4ad1-4817-9dee-da77cde668b7"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8f18fbc9-afbe-4506-a931-71ea5aa52755"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("8f620fe1-67f6-4171-b999-99e40ea251cd"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("901331c0-f225-4bf6-b7ee-803c3965bcd8"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("90f8853b-c70c-4ed4-978d-5c8419d0f113"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("91d23f14-6ce2-47cb-a5de-38f23f833ef6"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("92742b8e-f2d6-4a69-afd2-442bc3709c64"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("932f2a1f-28b4-4293-8c23-7b5824386fcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("934a32c1-245e-4107-be03-23b19e7ca626"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("938d8591-ca9f-4318-adc0-2e4bf3c1aa38"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("93ac6bf7-e2fe-4b61-940a-3a0131e6a1b4"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("95664ee4-d31a-4be8-80c1-33c2373e689c"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9633ba15-c995-4a64-ae22-c1546ad877d0"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("96ad33c2-9686-41db-a738-447f7408d8be"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("97943ab1-ad20-4793-b803-73450088fc15"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("98fb1ad4-f0ef-4e0b-bb8a-3ef1cb977dcb"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("991944e9-ecbd-453c-977c-85ebced0561f"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9981464c-09e5-46ff-8df4-36b95b839412"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("99ed70e5-5982-4f75-9061-d75b087221cd"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("99f9e926-2c29-4507-b958-1f65811626a8"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9af6804f-53d9-4188-945e-c7a8c58ae0f4"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9b62d15d-6082-4257-9933-34cdbe7e07a8"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9c1b68f1-0a39-415e-bb48-6ef4ffe9cfc6"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9ce7903a-b9ee-4c17-b335-a3bcae305ed0"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9d4d09fd-827c-439a-b2c4-d6321306a4ff"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9d5b4be5-16c9-446e-bc2c-bf3f3bf92bdc"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9d62c008-cff2-4fbe-9024-27d4bfd4d4e6"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9de5395c-2c8e-4b2f-9e31-613c581bfdd4"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9e277330-5a23-433c-9aba-68c6a72ffd63"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9e2d5775-a0b5-46a1-b82a-fa7b2c3df732"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9e9c10e8-45ff-4c2f-96cd-745dbb403ad1"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9f0d0893-87db-4ed4-a7b4-9f2e3e66db59"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9f110333-8fc4-46fa-bbb6-6368e92952c7"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("9f586c69-8ac7-412a-b4a6-eba1bfdc5e15"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a05e3b03-805f-484f-8230-a07ec5c94349"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a09907f0-785a-4a02-9e76-37002b2e0780"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a28e0572-f4cf-44cd-a34c-e556e5e07017"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a4c9f911-fc44-4596-a409-c4c374544450"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a4d8e50b-313e-4d9a-a64f-7e89c8ba3da0"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a59b04cc-c529-413e-8668-7a994598d7ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a7088dce-eaec-4741-be56-3a053b1ecf36"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a759f834-d067-4081-8779-0d2d899b4970"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a7986f26-74e9-4923-9511-476ac94425d1"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a7aadea1-5da8-4158-99a0-a21792f5eb62"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a7c51a86-324f-4c77-b417-38ed883f1a24"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a810680e-1483-48e2-a656-d1031cb47d55"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a829b01f-3742-4762-904c-6efcba063869"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("a9e1688e-c3fb-4da0-bcb2-d46656b3f9b6"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("aa2316af-c055-45a7-9165-770bfff4009d"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ab0a83da-97fb-4861-bb46-b610cf202ae2"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ac49cded-beea-4688-ae3f-7b28fad146e7"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ac5d462b-8b1c-4d72-bbfd-fe2fd3e2e695"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ac7d043f-abaa-4bf8-a804-a2f8dc07da00"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ad4ebbd7-56fd-4aa0-9d1f-4940fe6c34f5"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("adc42d66-93dd-488b-8d7e-3f7841f4de17"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ae28e696-06a6-4e21-a7fa-1dcbbe9eef6b"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ae970bd4-e903-4e37-a2a4-a534107674e6"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("af8ddc88-816d-4f8b-a979-d80c9646a78f"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b05e85cf-ca1c-4427-ab73-07b9a5844537"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b0df6753-0e25-4c46-bb17-812af17eb18f"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b0ef7004-cb5a-485f-a4b0-d455a2cc5eab"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b13436ea-786a-44c1-8256-8448e3f18b2f"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b165f426-799c-42b5-be0a-37ebaa32823d"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b2a4a8e5-c640-4188-bda6-6f663ffd1e5e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b2c3e2ba-0f36-4f60-929c-929381702494"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b3276c4d-18ca-432a-ae4f-d229839ae842"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b41191e0-186b-475e-9719-b744c5d1765e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b41b2965-286a-4f3a-b8dd-89d13d0c268c"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b42fe311-4813-4d25-ab33-c715fcdd563b"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b45eefe3-c3da-4657-8929-6793f699dce7"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b863588a-143e-4a2e-aa3e-d987af6cb5c9"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("b8bf91a1-beae-40d5-8c6f-c3eb6c1ef499"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("bba52d03-e307-42c0-97df-5ef87752e2a7"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("bc96900a-2867-43dc-81c3-13a68d65b815"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("bcc73ad5-aa8e-4abd-b620-a402ecbca59d"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("bde68f7a-f49a-4018-ba27-5fe9dc62f60f"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("bdfe397f-6a21-4309-b5e9-4b2c5a1432a5"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("be11cf1a-a368-4e35-876f-577319cf71f2"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("bf936a12-8a70-4c5f-afcc-7554a41a39ff"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c0560872-4974-42a6-a8f7-4e67fd3e1bac"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c1cadea9-1dd3-4df6-a30a-03bcd8efa0e6"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c234c4d3-557c-456e-94be-8a14bd8c3ae7"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c273e036-5431-42fb-a2df-eb10e5bb401d"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c2b69395-ecc6-45cc-8641-66e416a42e09"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c2df0c1c-b098-4597-8ba1-3a4e43215410"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c391d26e-56c8-4643-bb39-3b59693ea203"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c3d39ce8-e0ae-4326-b4e2-c5c685c985ca"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c49a09e1-ccd3-4a1c-a7bf-7bedb47aa6a2"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c5010a95-37c8-41ff-9f56-f785c67d69e7"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c5013e79-8583-479d-9fc8-49f61e26f513"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c573464d-8e69-4bf0-a8b3-0ba7e20c70f9"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c62ef4b9-8f48-47a7-8dfb-7d060c3bae0a"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c64b6774-af24-4f5d-a73d-0421a4c1a2c4"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c66f79c7-3ac6-407d-b4c7-e6ad2925f638"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c6893abb-dce4-4e02-80d9-771ae9f8c70d"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c6b98900-f55e-4570-b119-7f2a35996bef"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c7154589-f194-40a4-b0ff-a5f9ac7591db"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c76dfa6e-177e-40d5-aff6-ab769f86696c"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c7a40d3d-0015-4a61-8794-456c40111527"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c7ffb60a-331b-4de2-866d-eaaab33bf060"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c87a2bcf-8132-47c2-b728-63bf6c75098c"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("c9307459-ed9c-4c54-8919-173a05534417"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ca30de93-b00f-4696-a049-9c0eb6a89b78"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("caade10f-09a7-4d18-b622-1b0ba777bb30"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("cb08827b-fa85-498f-a7c9-4c1d37a30d33"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("cb52606a-5774-44d9-96ce-dc7ceff8bc81"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("cbc71c17-2072-4161-9a87-bf42bb8b955e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("cbd2b6c9-2c52-4541-9a97-0ad35f27a0f7"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("cc61b7c1-b29b-48df-b9e2-02936e115422"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("cc802e83-3cd3-40b3-bd85-0e15580e313f"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("cddaf9b1-5622-4dc5-97d5-be2c3d45fbc9"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("cdfd5b7f-cd5c-48ef-bdbc-0e20c8f1296f"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ceadab37-a0c1-4016-b2d8-29a50b19bbc1"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("cebee0ae-d726-4ec4-a194-13490bcccd74"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ced5934e-d0b3-4577-aee7-a76d64648077"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ceffdf66-984d-4130-a99a-9c39bd0c1061"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("cf40b31e-2130-43fc-bad7-0a443f2eaa6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("cfe68a65-4e5d-4aae-ba96-2693f2adfb46"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("d0903197-7f82-4a86-9bd6-93a8042c2136"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("d1205b77-01a9-4db2-a9d8-810b5958a527"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("d1fbb0c5-ef37-4153-86ad-1b408ceb9c38"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("d21579b7-505b-4acc-acc0-26a94b9d48c3"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("d2c4a703-629c-4031-ba7f-4b20269e09aa"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("d34a61e2-2683-40ae-a18b-6d105dd00985"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("d3ff70df-b6ab-4dc1-9ad9-3ef9ec7038b7"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("d54ebb7f-dd5a-4325-8d57-a600f1cf816f"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("d671b031-ca23-4d39-aeb3-8ec89d38ef76"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("d7634bbe-ea83-4778-8eb2-83a1655aa9cb"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("d90754e4-69ad-4ee7-bd3b-bfc95320f232"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("da168a7c-5f78-4ed2-8564-4f8a1bcd6566"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("da66a52f-fbf3-400b-b529-00104c89b142"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("da91e3fc-b31a-4b41-b157-646e192f6274"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("dabcfb3a-540b-4b79-a0de-4d657673b072"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("daee79b8-9341-472d-82ef-7cf998fc7ff9"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("db1de636-0fc8-4fbb-b862-b3d611e5c291"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("db5daa1d-468e-4d75-9d8d-29929e6ce8d1"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("dc0a45e7-12aa-430a-90fe-4130ffcc21db"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("dd835106-65cc-4c01-8836-8a54221dbc5e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("dd96c9f7-3260-45e7-891c-f140a5643bb6"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("df0db550-abbc-48bf-a1d2-3ec0c1a848f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("df6450f7-f26b-40b8-964c-8d7f63f262ee"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("df71bd5b-9606-402c-ac30-b8091c367429"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("df8b22c5-ba19-423c-92aa-b51a3c0e6f63"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e0113f75-a811-4a0f-8f06-e1acbc13f6e4"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e0a17bd3-b57a-4b9f-9430-b2b9322d5687"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e0bba013-962e-43f2-98ed-5007ca0a244a"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e0d57445-9c81-4a66-9db6-d2168a8f93c3"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e0dd945c-1207-43f6-8654-29276ffb73b9"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e124c53d-df8a-4964-8a99-5ed5402f190f"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e134b9b1-b2b0-4c8a-a791-16fa8d360c62"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e15be4e5-d2d9-41d4-ace0-8235c0207abd"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e167cf99-05cd-4f02-adff-c3cdb940eeab"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e2bde3fb-6387-4468-b779-c3fe3070c152"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e2c8c809-a372-4117-96a3-622e8f0f893d"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e2cbc268-1ad1-4803-9e1e-60b7ca05e406"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e3cefae1-cb29-4bc1-9935-c07864d5cc1f"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e57dcb48-1069-4bb7-9979-2044b37b7627"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e60192fd-9b36-4582-87a4-db1a25aa8487"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e62ba946-3c11-43a9-837b-8c2e3ad90fe7"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e6713da9-5ca0-426c-93f2-b163f3860480"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e741f5d6-6b10-4534-b7da-5990fdc7b13d"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e78de827-4839-43f4-9b1a-a28913f3e010"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e78ef1ac-52f5-4995-9a21-96314db14472"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e7e1162f-3f61-419a-a25a-1dd3f704e103"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e7eb9b06-1db2-4d4f-9a27-83a2ffd90edf"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("e8c62d4a-d82a-46a0-9c0b-f6b6408cfe55"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("eaa30acf-ef2c-43ae-ab71-be0f6cc09d9e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("eecad343-a835-4f23-835f-21c7dfc9de15"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("eed0ee6b-e63a-4e25-9457-7f97d5a7ab93"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("efaaae37-dd9a-41c6-a70d-13c30ca04fab"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("efe8ac42-c1c9-4be0-bf34-009b89180464"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f0c63ea9-55ec-47c8-94f7-74255b6962be"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f136f9ed-0437-49d2-b069-42766c5255fb"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f16ec5d4-2f03-49d4-9e12-5d3359d9abee"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f179658f-afcd-4d8e-b590-21047b839a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f1a79572-116b-46b3-920e-05e6b3874be3"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f3e5b666-7911-46c6-8c9b-8ecb9437555b"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f4185865-1c77-4409-bb1c-2bfd81efaa80"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f47b956a-b45f-4d72-9696-87392188634a"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f5efe0eb-c3be-4b31-be01-1ac440602852"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f664532a-3c07-4b61-ba9d-0d1698a85a3e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f7966ced-3414-4571-82be-1a36d6181c8f"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f7ca52aa-6da3-4652-8126-210b889d4a93"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f810cba1-0d99-4186-9a69-d88e281afbf7"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f8ac95d0-fcac-4f7d-ad5b-b86cb247db1a"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f8d14618-77d2-4a54-9745-a7fe9f233a93"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f8f08c85-686f-439a-a0ec-cc1183cf2bcf"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f9162287-5ad4-4b47-a67b-8b217728fdfa"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f9b5bd83-c700-42a6-bdf7-d269a028cc00"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("f9e78e0b-c9db-4e6e-999f-07a3cc8181ab"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("fa4b91c8-c1c9-42d1-911d-4e2a3971c4a6"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("faabbc6e-a373-49cd-a01c-3f6ab18207bb"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("fad0f60d-2272-4076-a3e5-1ae5404b98e6"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("fb7ee740-ff98-4675-9e9b-66d253eab5ed"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("fc14fcc0-8814-4fc3-bf46-733c2a190aeb"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("fe1e10ef-b8a1-4ca6-9f6f-9eb5f1a3e258"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("fe84ccf1-04c0-4205-9ba9-492f5470c8ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Definitions",
                keyColumn: "Id",
                keyValue: new Guid("ff5e5d8a-d286-4807-8f7f-71028c398aef"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 677, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb0"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb1"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb2"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("99cf7da7-838f-4899-bc2f-5f9fe137bdb4"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6470"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6471"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6472"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "ObjectStates",
                keyColumn: "Id",
                keyValue: new Guid("e790a6ce-6381-4b87-a157-5c6a73bc6473"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("10f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11111111-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("11f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("12f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("13f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("14f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("15f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("16f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("17f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("18f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("19f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("20f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("21f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("22f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("23f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("24f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Relations",
                keyColumn: "Id",
                keyValue: new Guid("25f944bb-9d33-4279-aed3-8f372907f27e"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 21, 48, 28, 678, DateTimeKind.Local).AddTicks(8923));
        }
    }
}
