using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NullForGD_ExpiryDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("00ac1ba5-a380-4574-a712-e0e337581270"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("18946ab4-c201-4092-b0a4-9fb1c8aeec79"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("1c532066-fdd6-4b6e-9531-a7b7263b70a6"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("216497b6-9537-4956-b6c3-ae2898a31870"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("29b07a1d-0686-4cf3-97a2-bd8fc7d1d96a"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("2daabeef-95f4-4560-b545-3ef6e37b6ec7"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("38023b2d-2eff-419a-8094-b0b75795a2bf"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("3d9503d5-ff56-4628-9b92-8536b0e56c7d"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("44902cd2-9f18-459d-871d-8cbbc8191962"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("4592dad7-6432-4de2-8f81-61bdbf291057"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("47df0fc2-331b-4f9c-a214-dfc1ce773333"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("47f7e9c2-6f09-4c01-be0a-b56ae20fa4b1"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("5017b4a3-715c-4826-910d-5b2914fc8b8e"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("5c2720c2-942f-45eb-bf1d-b7823dda6319"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("5f83d88a-f479-4182-ac67-f16e42b21c82"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("5fec1558-1140-4b70-be7e-415d82ca8e1c"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("72b668b7-b158-4a30-aea2-d2ee0ff74408"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("794a7fa7-bf37-4da4-b6c1-924f0998944e"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("863cfd07-e1be-418a-b085-e6f5ee3d6afd"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("8928ca57-843e-4b8b-8ae3-3c046b72cbd9"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("9770dacf-bc02-4dc4-9ed9-8ad144524f9e"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("a02b9ea5-7295-4539-98cd-faa1b84fd493"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("befd389f-8108-4faf-84ef-6d092e531865"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("c1fe262c-a642-4b4c-be40-091fc06a051c"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("d716f515-8b51-4198-9459-a36dc8e068a7"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("e5581fb2-1811-48fd-8fb7-8847175143ee"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("edf2f687-9237-425a-a11b-e8d2b1a8dec8"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("f17153d9-90d2-4d74-a134-5762e5d7c155"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("fc97666e-1b96-4446-b50c-4a40129ba54c"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("fcc645ad-bba5-4a3a-a603-8f7a8ad2e922"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryDate",
                table: "GovernmentDocuments",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryDate",
                table: "GovernmentDocuments",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "BandSalaries",
                columns: new[] { "Id", "Band", "BasicSalary", "ConveyanceAllowance", "DearnessAllowance", "DepartmentType", "EntertainmentAllowance", "HRA", "MedicalInsurance", "Stipend" },
                values: new object[,]
                {
                    { new Guid("00ac1ba5-a380-4574-a712-e0e337581270"), "E3", 42000m, 3200m, 4200m, 2, 2200m, 6200m, 1720m, 720m },
                    { new Guid("18946ab4-c201-4092-b0a4-9fb1c8aeec79"), "E1", 35000m, 2500m, 3500m, 5, 1500m, 5500m, 1550m, 550m },
                    { new Guid("1c532066-fdd6-4b6e-9531-a7b7263b70a6"), "E1", 34000m, 2400m, 3400m, 4, 1400m, 5400m, 1540m, 540m },
                    { new Guid("216497b6-9537-4956-b6c3-ae2898a31870"), "E5", 50000m, 4000m, 5000m, 0, 3000m, 7000m, 1900m, 900m },
                    { new Guid("29b07a1d-0686-4cf3-97a2-bd8fc7d1d96a"), "E2", 36000m, 2600m, 3600m, 1, 1600m, 5600m, 1610m, 610m },
                    { new Guid("2daabeef-95f4-4560-b545-3ef6e37b6ec7"), "E4", 49000m, 3900m, 4900m, 4, 2900m, 6900m, 1840m, 840m },
                    { new Guid("38023b2d-2eff-419a-8094-b0b75795a2bf"), "E4", 46000m, 3600m, 4600m, 1, 2600m, 6600m, 1810m, 810m },
                    { new Guid("3d9503d5-ff56-4628-9b92-8536b0e56c7d"), "E4", 45000m, 3500m, 4500m, 0, 2500m, 6500m, 1800m, 800m },
                    { new Guid("44902cd2-9f18-459d-871d-8cbbc8191962"), "E2", 40000m, 3000m, 4000m, 5, 2000m, 6000m, 1650m, 650m },
                    { new Guid("4592dad7-6432-4de2-8f81-61bdbf291057"), "E2", 35000m, 2500m, 3500m, 0, 1500m, 5500m, 1600m, 600m },
                    { new Guid("47df0fc2-331b-4f9c-a214-dfc1ce773333"), "E4", 50000m, 4000m, 5000m, 5, 3000m, 7000m, 1850m, 850m },
                    { new Guid("47f7e9c2-6f09-4c01-be0a-b56ae20fa4b1"), "E3", 44000m, 3400m, 4400m, 4, 2400m, 6400m, 1740m, 740m },
                    { new Guid("5017b4a3-715c-4826-910d-5b2914fc8b8e"), "E5", 55000m, 4500m, 5500m, 5, 3500m, 7500m, 1950m, 950m },
                    { new Guid("5c2720c2-942f-45eb-bf1d-b7823dda6319"), "E3", 45000m, 3500m, 4500m, 5, 2500m, 6500m, 1750m, 750m },
                    { new Guid("5f83d88a-f479-4182-ac67-f16e42b21c82"), "E1", 30000m, 2000m, 3000m, 0, 1000m, 5000m, 1500m, 500m },
                    { new Guid("5fec1558-1140-4b70-be7e-415d82ca8e1c"), "E5", 52000m, 4200m, 5200m, 2, 3200m, 7200m, 1920m, 920m },
                    { new Guid("72b668b7-b158-4a30-aea2-d2ee0ff74408"), "E4", 47000m, 3700m, 4700m, 2, 2700m, 6700m, 1820m, 820m },
                    { new Guid("794a7fa7-bf37-4da4-b6c1-924f0998944e"), "E5", 54000m, 4400m, 5400m, 4, 3400m, 7400m, 1940m, 940m },
                    { new Guid("863cfd07-e1be-418a-b085-e6f5ee3d6afd"), "E2", 39000m, 2900m, 3900m, 4, 1900m, 5900m, 1640m, 640m },
                    { new Guid("8928ca57-843e-4b8b-8ae3-3c046b72cbd9"), "E2", 38000m, 2800m, 3800m, 3, 1800m, 5800m, 1630m, 630m },
                    { new Guid("9770dacf-bc02-4dc4-9ed9-8ad144524f9e"), "E3", 43000m, 3300m, 4300m, 3, 2300m, 6300m, 1730m, 730m },
                    { new Guid("a02b9ea5-7295-4539-98cd-faa1b84fd493"), "E3", 40000m, 3000m, 4000m, 0, 2000m, 6000m, 1700m, 700m },
                    { new Guid("befd389f-8108-4faf-84ef-6d092e531865"), "E5", 51000m, 4100m, 5100m, 1, 3100m, 7100m, 1910m, 910m },
                    { new Guid("c1fe262c-a642-4b4c-be40-091fc06a051c"), "E5", 53000m, 4300m, 5300m, 3, 3300m, 7300m, 1930m, 930m },
                    { new Guid("d716f515-8b51-4198-9459-a36dc8e068a7"), "E1", 33000m, 2300m, 3300m, 3, 1300m, 5300m, 1530m, 530m },
                    { new Guid("e5581fb2-1811-48fd-8fb7-8847175143ee"), "E1", 32000m, 2200m, 3200m, 2, 1200m, 5200m, 1520m, 520m },
                    { new Guid("edf2f687-9237-425a-a11b-e8d2b1a8dec8"), "E4", 48000m, 3800m, 4800m, 3, 2800m, 6800m, 1830m, 830m },
                    { new Guid("f17153d9-90d2-4d74-a134-5762e5d7c155"), "E3", 41000m, 3100m, 4100m, 1, 2100m, 6100m, 1710m, 710m },
                    { new Guid("fc97666e-1b96-4446-b50c-4a40129ba54c"), "E2", 37000m, 2700m, 3700m, 2, 1700m, 5700m, 1620m, 620m },
                    { new Guid("fcc645ad-bba5-4a3a-a603-8f7a8ad2e922"), "E1", 31000m, 2100m, 3100m, 1, 1100m, 5100m, 1510m, 510m }
                });
        }
    }
}
