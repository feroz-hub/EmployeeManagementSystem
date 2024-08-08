using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCreateAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("039f72e1-3db1-47d7-9b71-cae27118165b"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("088197f4-3a4b-40a6-920d-8fe94224d408"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("18fc8831-f9df-44d0-9038-9c288d6ff0ab"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("1ae1d382-fa34-4a41-9b39-29d33302f353"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("1f05f235-354d-404f-9142-8ff0bb61f476"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("29f626ef-2dd0-448d-a317-a0d54f4885a7"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("3bd0fb5b-b440-48e5-8947-b4812dd674f9"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("4f3d495a-5179-47c6-8183-20a5998bb913"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("691f3038-9df4-4601-a858-9b4eacd80a36"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("6be2e9ba-7079-4d0d-aa2f-19d95e9abeb4"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("7b92f247-0ebe-4128-87a8-93d40d2343cd"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("805cbfb4-8604-4da3-9196-2f732f5de2d6"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("809286bf-1e74-4cbe-8fc4-bf8ca3b0cde3"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("84ccb4f0-9bd4-443d-a0fc-4347f8efafca"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("86edf469-3dc0-458d-abde-be0e7deacf0c"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("895699ea-6d39-42c1-bbfc-3e45329edee8"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("8bfa2454-2b6b-43ca-8b5b-43dc614565a2"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("9669e225-a259-499f-8d70-928a3526aa01"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("a50afa04-b81a-4f16-8aff-9cc57372115e"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("a55a0268-38f5-4f1c-8467-23c0a4dfa436"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("b32366a1-119d-4810-a7c5-f93b06ae307d"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("c53a3f98-545e-46b6-b9c8-983594a78e30"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("cb794f86-21e1-45d4-b71c-6cef84f466f5"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("d2ec559d-feaa-4ca3-9809-bc1691a0c2ce"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("e47dea8c-b485-4e30-a4fa-52276a7d620a"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("eaca25ea-c675-4219-a902-d7599abb6b01"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("f8d7ba81-22b0-4a70-9cf1-6bd7d489bac0"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("fa8fb68c-f850-418f-8d8d-9eba6ca6d619"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("fc180e5f-9011-4b44-8245-5903672b4367"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("fd09c1c1-0eb4-44d7-8e91-f8b6ec4cbdd0"));

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Leaves");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RequestDate",
                table: "Leaves",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "BandSalaries",
                columns: new[] { "Id", "Band", "BasicSalary", "ConveyanceAllowance", "DearnessAllowance", "DepartmentType", "EntertainmentAllowance", "HRA", "MedicalInsurance", "Stipend" },
                values: new object[,]
                {
                    { new Guid("0ba7a0f1-d864-41d0-a11d-54f082dd5f19"), "E4", 46000m, 3600m, 4600m, 1, 2600m, 6600m, 1810m, 810m },
                    { new Guid("0f15adb0-721c-409a-a90d-c93b0ee4f9a2"), "E3", 43000m, 3300m, 4300m, 3, 2300m, 6300m, 1730m, 730m },
                    { new Guid("15080f9e-3b21-4c2c-94a1-bc9f80b5f056"), "E1", 30000m, 2000m, 3000m, 0, 1000m, 5000m, 1500m, 500m },
                    { new Guid("164935c3-baa6-4e81-b58c-d689065234e4"), "E3", 40000m, 3000m, 4000m, 0, 2000m, 6000m, 1700m, 700m },
                    { new Guid("1c98c44e-040f-4209-a50d-16ffed9a63b6"), "E5", 50000m, 4000m, 5000m, 0, 3000m, 7000m, 1900m, 900m },
                    { new Guid("217eae5d-7c64-4aa1-b62c-a10f17dab11b"), "E2", 36000m, 2600m, 3600m, 1, 1600m, 5600m, 1610m, 610m },
                    { new Guid("28604e6e-f840-4926-a0c0-4576328f8334"), "E5", 54000m, 4400m, 5400m, 4, 3400m, 7400m, 1940m, 940m },
                    { new Guid("2a5f6f44-8d15-4027-aee2-ce26d4209f3f"), "E2", 35000m, 2500m, 3500m, 0, 1500m, 5500m, 1600m, 600m },
                    { new Guid("66198ba1-94c9-4dcd-bfa0-3f237948337e"), "E5", 51000m, 4100m, 5100m, 1, 3100m, 7100m, 1910m, 910m },
                    { new Guid("66a97526-af02-4aa7-ab37-0a110e930297"), "E5", 55000m, 4500m, 5500m, 5, 3500m, 7500m, 1950m, 950m },
                    { new Guid("66aa5fd6-0f91-4410-82fc-493529ea2bbe"), "E4", 50000m, 4000m, 5000m, 5, 3000m, 7000m, 1850m, 850m },
                    { new Guid("768dc645-be74-4314-9058-7e9456d704d1"), "E3", 41000m, 3100m, 4100m, 1, 2100m, 6100m, 1710m, 710m },
                    { new Guid("78085b95-14b5-4966-85c6-7f9599d9aa04"), "E5", 52000m, 4200m, 5200m, 2, 3200m, 7200m, 1920m, 920m },
                    { new Guid("784f7716-8582-4914-963a-e5fff9d0eefa"), "E2", 37000m, 2700m, 3700m, 2, 1700m, 5700m, 1620m, 620m },
                    { new Guid("7d755052-f42d-4091-915b-7e072b0f5d6f"), "E5", 53000m, 4300m, 5300m, 3, 3300m, 7300m, 1930m, 930m },
                    { new Guid("833bc2db-5cd7-4c29-840e-3af36f3c1060"), "E2", 39000m, 2900m, 3900m, 4, 1900m, 5900m, 1640m, 640m },
                    { new Guid("8d690b35-2a23-4a6e-97a9-084fd713650a"), "E1", 32000m, 2200m, 3200m, 2, 1200m, 5200m, 1520m, 520m },
                    { new Guid("b4b0e6ba-5cfd-4e03-8574-d32c326b89f2"), "E1", 35000m, 2500m, 3500m, 5, 1500m, 5500m, 1550m, 550m },
                    { new Guid("c3b8409a-b9a2-42e1-a21a-32cb97885f81"), "E4", 48000m, 3800m, 4800m, 3, 2800m, 6800m, 1830m, 830m },
                    { new Guid("c3d2b61c-2dbe-4521-b0fd-39f16501557e"), "E3", 45000m, 3500m, 4500m, 5, 2500m, 6500m, 1750m, 750m },
                    { new Guid("cc1c3043-bd19-4882-86f6-976f6ff06191"), "E1", 31000m, 2100m, 3100m, 1, 1100m, 5100m, 1510m, 510m },
                    { new Guid("d7e03564-7113-42d7-a886-57b2d95f0507"), "E1", 33000m, 2300m, 3300m, 3, 1300m, 5300m, 1530m, 530m },
                    { new Guid("d9cdfd40-860b-48a7-9d6d-bfaab04765f1"), "E4", 47000m, 3700m, 4700m, 2, 2700m, 6700m, 1820m, 820m },
                    { new Guid("e4f59a0b-7783-48a9-a2c0-cba0d449ba12"), "E3", 44000m, 3400m, 4400m, 4, 2400m, 6400m, 1740m, 740m },
                    { new Guid("e6e6a071-0884-48a2-8497-7329e4227587"), "E3", 42000m, 3200m, 4200m, 2, 2200m, 6200m, 1720m, 720m },
                    { new Guid("ea409282-2319-4bf0-826d-5daf0dcd7e7b"), "E2", 40000m, 3000m, 4000m, 5, 2000m, 6000m, 1650m, 650m },
                    { new Guid("f567a0dd-c851-43e7-8a7c-795cfd174a42"), "E4", 45000m, 3500m, 4500m, 0, 2500m, 6500m, 1800m, 800m },
                    { new Guid("f630c36c-9b35-48f0-a17b-f2b505ccf2b7"), "E4", 49000m, 3900m, 4900m, 4, 2900m, 6900m, 1840m, 840m },
                    { new Guid("fd47ae72-e00f-48b9-8b23-430f8d236ea1"), "E1", 34000m, 2400m, 3400m, 4, 1400m, 5400m, 1540m, 540m },
                    { new Guid("fd947f44-2dc3-4a70-9abc-1978e846f1bc"), "E2", 38000m, 2800m, 3800m, 3, 1800m, 5800m, 1630m, 630m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("0ba7a0f1-d864-41d0-a11d-54f082dd5f19"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("0f15adb0-721c-409a-a90d-c93b0ee4f9a2"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("15080f9e-3b21-4c2c-94a1-bc9f80b5f056"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("164935c3-baa6-4e81-b58c-d689065234e4"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("1c98c44e-040f-4209-a50d-16ffed9a63b6"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("217eae5d-7c64-4aa1-b62c-a10f17dab11b"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("28604e6e-f840-4926-a0c0-4576328f8334"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("2a5f6f44-8d15-4027-aee2-ce26d4209f3f"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("66198ba1-94c9-4dcd-bfa0-3f237948337e"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("66a97526-af02-4aa7-ab37-0a110e930297"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("66aa5fd6-0f91-4410-82fc-493529ea2bbe"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("768dc645-be74-4314-9058-7e9456d704d1"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("78085b95-14b5-4966-85c6-7f9599d9aa04"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("784f7716-8582-4914-963a-e5fff9d0eefa"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("7d755052-f42d-4091-915b-7e072b0f5d6f"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("833bc2db-5cd7-4c29-840e-3af36f3c1060"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("8d690b35-2a23-4a6e-97a9-084fd713650a"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("b4b0e6ba-5cfd-4e03-8574-d32c326b89f2"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("c3b8409a-b9a2-42e1-a21a-32cb97885f81"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("c3d2b61c-2dbe-4521-b0fd-39f16501557e"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("cc1c3043-bd19-4882-86f6-976f6ff06191"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("d7e03564-7113-42d7-a886-57b2d95f0507"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("d9cdfd40-860b-48a7-9d6d-bfaab04765f1"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("e4f59a0b-7783-48a9-a2c0-cba0d449ba12"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("e6e6a071-0884-48a2-8497-7329e4227587"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("ea409282-2319-4bf0-826d-5daf0dcd7e7b"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("f567a0dd-c851-43e7-8a7c-795cfd174a42"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("f630c36c-9b35-48f0-a17b-f2b505ccf2b7"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("fd47ae72-e00f-48b9-8b23-430f8d236ea1"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("fd947f44-2dc3-4a70-9abc-1978e846f1bc"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RequestDate",
                table: "Leaves",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Leaves",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "BandSalaries",
                columns: new[] { "Id", "Band", "BasicSalary", "ConveyanceAllowance", "DearnessAllowance", "DepartmentType", "EntertainmentAllowance", "HRA", "MedicalInsurance", "Stipend" },
                values: new object[,]
                {
                    { new Guid("039f72e1-3db1-47d7-9b71-cae27118165b"), "E5", 55000m, 4500m, 5500m, 5, 3500m, 7500m, 1950m, 950m },
                    { new Guid("088197f4-3a4b-40a6-920d-8fe94224d408"), "E1", 34000m, 2400m, 3400m, 4, 1400m, 5400m, 1540m, 540m },
                    { new Guid("18fc8831-f9df-44d0-9038-9c288d6ff0ab"), "E4", 47000m, 3700m, 4700m, 2, 2700m, 6700m, 1820m, 820m },
                    { new Guid("1ae1d382-fa34-4a41-9b39-29d33302f353"), "E2", 37000m, 2700m, 3700m, 2, 1700m, 5700m, 1620m, 620m },
                    { new Guid("1f05f235-354d-404f-9142-8ff0bb61f476"), "E5", 51000m, 4100m, 5100m, 1, 3100m, 7100m, 1910m, 910m },
                    { new Guid("29f626ef-2dd0-448d-a317-a0d54f4885a7"), "E4", 48000m, 3800m, 4800m, 3, 2800m, 6800m, 1830m, 830m },
                    { new Guid("3bd0fb5b-b440-48e5-8947-b4812dd674f9"), "E3", 40000m, 3000m, 4000m, 0, 2000m, 6000m, 1700m, 700m },
                    { new Guid("4f3d495a-5179-47c6-8183-20a5998bb913"), "E1", 30000m, 2000m, 3000m, 0, 1000m, 5000m, 1500m, 500m },
                    { new Guid("691f3038-9df4-4601-a858-9b4eacd80a36"), "E1", 32000m, 2200m, 3200m, 2, 1200m, 5200m, 1520m, 520m },
                    { new Guid("6be2e9ba-7079-4d0d-aa2f-19d95e9abeb4"), "E5", 53000m, 4300m, 5300m, 3, 3300m, 7300m, 1930m, 930m },
                    { new Guid("7b92f247-0ebe-4128-87a8-93d40d2343cd"), "E2", 38000m, 2800m, 3800m, 3, 1800m, 5800m, 1630m, 630m },
                    { new Guid("805cbfb4-8604-4da3-9196-2f732f5de2d6"), "E2", 35000m, 2500m, 3500m, 0, 1500m, 5500m, 1600m, 600m },
                    { new Guid("809286bf-1e74-4cbe-8fc4-bf8ca3b0cde3"), "E1", 31000m, 2100m, 3100m, 1, 1100m, 5100m, 1510m, 510m },
                    { new Guid("84ccb4f0-9bd4-443d-a0fc-4347f8efafca"), "E1", 35000m, 2500m, 3500m, 5, 1500m, 5500m, 1550m, 550m },
                    { new Guid("86edf469-3dc0-458d-abde-be0e7deacf0c"), "E4", 50000m, 4000m, 5000m, 5, 3000m, 7000m, 1850m, 850m },
                    { new Guid("895699ea-6d39-42c1-bbfc-3e45329edee8"), "E2", 36000m, 2600m, 3600m, 1, 1600m, 5600m, 1610m, 610m },
                    { new Guid("8bfa2454-2b6b-43ca-8b5b-43dc614565a2"), "E3", 41000m, 3100m, 4100m, 1, 2100m, 6100m, 1710m, 710m },
                    { new Guid("9669e225-a259-499f-8d70-928a3526aa01"), "E3", 42000m, 3200m, 4200m, 2, 2200m, 6200m, 1720m, 720m },
                    { new Guid("a50afa04-b81a-4f16-8aff-9cc57372115e"), "E2", 40000m, 3000m, 4000m, 5, 2000m, 6000m, 1650m, 650m },
                    { new Guid("a55a0268-38f5-4f1c-8467-23c0a4dfa436"), "E3", 45000m, 3500m, 4500m, 5, 2500m, 6500m, 1750m, 750m },
                    { new Guid("b32366a1-119d-4810-a7c5-f93b06ae307d"), "E5", 50000m, 4000m, 5000m, 0, 3000m, 7000m, 1900m, 900m },
                    { new Guid("c53a3f98-545e-46b6-b9c8-983594a78e30"), "E3", 43000m, 3300m, 4300m, 3, 2300m, 6300m, 1730m, 730m },
                    { new Guid("cb794f86-21e1-45d4-b71c-6cef84f466f5"), "E4", 45000m, 3500m, 4500m, 0, 2500m, 6500m, 1800m, 800m },
                    { new Guid("d2ec559d-feaa-4ca3-9809-bc1691a0c2ce"), "E4", 46000m, 3600m, 4600m, 1, 2600m, 6600m, 1810m, 810m },
                    { new Guid("e47dea8c-b485-4e30-a4fa-52276a7d620a"), "E5", 54000m, 4400m, 5400m, 4, 3400m, 7400m, 1940m, 940m },
                    { new Guid("eaca25ea-c675-4219-a902-d7599abb6b01"), "E3", 44000m, 3400m, 4400m, 4, 2400m, 6400m, 1740m, 740m },
                    { new Guid("f8d7ba81-22b0-4a70-9cf1-6bd7d489bac0"), "E2", 39000m, 2900m, 3900m, 4, 1900m, 5900m, 1640m, 640m },
                    { new Guid("fa8fb68c-f850-418f-8d8d-9eba6ca6d619"), "E5", 52000m, 4200m, 5200m, 2, 3200m, 7200m, 1920m, 920m },
                    { new Guid("fc180e5f-9011-4b44-8245-5903672b4367"), "E1", 33000m, 2300m, 3300m, 3, 1300m, 5300m, 1530m, 530m },
                    { new Guid("fd09c1c1-0eb4-44d7-8e91-f8b6ec4cbdd0"), "E4", 49000m, 3900m, 4900m, 4, 2900m, 6900m, 1840m, 840m }
                });
        }
    }
}
