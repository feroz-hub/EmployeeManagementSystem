using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class BandSalarySeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BandSalaries",
                columns: new[] { "Id", "Band", "BasicSalary", "ConveyanceAllowance", "DearnessAllowance", "DepartmentType", "EntertainmentAllowance", "HRA", "MedicalInsurance", "Stipend" },
                values: new object[,]
                {
                    { new Guid("02357dc4-b416-440c-bd93-b9ca4576d06e"), "E1", 33000m, 2300m, 3300m, 3, 1300m, 5300m, 1530m, 530m },
                    { new Guid("0482c5d2-e7f2-4a34-8039-cb0b82f75841"), "E4", 46000m, 3600m, 4600m, 1, 2600m, 6600m, 1810m, 810m },
                    { new Guid("1138c8de-6e8b-4ed4-b30a-f12dc6516571"), "E1", 32000m, 2200m, 3200m, 2, 1200m, 5200m, 1520m, 520m },
                    { new Guid("2883b7a1-7caf-4b66-acc1-90b14f2405f1"), "E3", 41000m, 3100m, 4100m, 1, 2100m, 6100m, 1710m, 710m },
                    { new Guid("353b546d-fc50-40c3-8d4e-ea0f666c8c8b"), "E5", 51000m, 4100m, 5100m, 1, 3100m, 7100m, 1910m, 910m },
                    { new Guid("37495332-1b36-4261-af4c-9d72eb03004d"), "E3", 43000m, 3300m, 4300m, 3, 2300m, 6300m, 1730m, 730m },
                    { new Guid("3bd45fc6-55b3-40a5-85e3-a2586f52de53"), "E5", 53000m, 4300m, 5300m, 3, 3300m, 7300m, 1930m, 930m },
                    { new Guid("4a0646c4-df34-461b-8711-1148c545a504"), "E1", 35000m, 2500m, 3500m, 5, 1500m, 5500m, 1550m, 550m },
                    { new Guid("4eb2d3e7-4538-4e78-b217-e5a3bfa52d79"), "E2", 35000m, 2500m, 3500m, 0, 1500m, 5500m, 1600m, 600m },
                    { new Guid("5488c7d3-32dc-46c2-8edc-73b7bc8336d2"), "E1", 34000m, 2400m, 3400m, 4, 1400m, 5400m, 1540m, 540m },
                    { new Guid("54960ba3-2d73-4fed-aed5-76687db263b5"), "E1", 31000m, 2100m, 3100m, 1, 1100m, 5100m, 1510m, 510m },
                    { new Guid("5bbd5c90-1512-4f9e-a001-ca77be9bfd02"), "E3", 44000m, 3400m, 4400m, 4, 2400m, 6400m, 1740m, 740m },
                    { new Guid("7dc73e18-524a-408e-9fb1-2f0ed7f40219"), "E4", 50000m, 4000m, 5000m, 5, 3000m, 7000m, 1850m, 850m },
                    { new Guid("85dae10c-3320-4a6e-a19f-ed54979da054"), "E3", 42000m, 3200m, 4200m, 2, 2200m, 6200m, 1720m, 720m },
                    { new Guid("8dc90bc1-75f6-40d0-8166-da741b028f4c"), "E2", 37000m, 2700m, 3700m, 2, 1700m, 5700m, 1620m, 620m },
                    { new Guid("98038f4a-c992-424e-835c-5f5e7aba505d"), "E2", 39000m, 2900m, 3900m, 4, 1900m, 5900m, 1640m, 640m },
                    { new Guid("a5626786-1491-44f2-9991-e437e1ce0acb"), "E4", 49000m, 3900m, 4900m, 4, 2900m, 6900m, 1840m, 840m },
                    { new Guid("b0ef34fd-d488-441f-b3ae-752c6a8383bd"), "E5", 55000m, 4500m, 5500m, 5, 3500m, 7500m, 1950m, 950m },
                    { new Guid("b12870be-d090-4d28-8228-a6a02800399d"), "E4", 48000m, 3800m, 4800m, 3, 2800m, 6800m, 1830m, 830m },
                    { new Guid("b27b5128-14e8-4056-afe5-5697e48e1c6d"), "E5", 52000m, 4200m, 5200m, 2, 3200m, 7200m, 1920m, 920m },
                    { new Guid("b46385c1-a711-43df-bb19-7b8f430fa83e"), "E4", 45000m, 3500m, 4500m, 0, 2500m, 6500m, 1800m, 800m },
                    { new Guid("b9242344-631a-4777-89a3-fd605f268049"), "E3", 40000m, 3000m, 4000m, 0, 2000m, 6000m, 1700m, 700m },
                    { new Guid("baf6893c-e56a-4655-9708-b5a240281e4d"), "E5", 50000m, 4000m, 5000m, 0, 3000m, 7000m, 1900m, 900m },
                    { new Guid("c0f318b3-a30f-46c2-9ba3-26051eaa822e"), "E1", 30000m, 2000m, 3000m, 0, 1000m, 5000m, 1500m, 500m },
                    { new Guid("d1d494f0-f826-4d52-83bf-500409946ab1"), "E5", 54000m, 4400m, 5400m, 4, 3400m, 7400m, 1940m, 940m },
                    { new Guid("e09cfed3-6a62-4a43-bb55-2536ac57c588"), "E3", 45000m, 3500m, 4500m, 5, 2500m, 6500m, 1750m, 750m },
                    { new Guid("e4895063-41cf-45a3-bcf1-e3c868b6339c"), "E4", 47000m, 3700m, 4700m, 2, 2700m, 6700m, 1820m, 820m },
                    { new Guid("e72e3a42-0bac-44ee-95a4-5f94c801e978"), "E2", 40000m, 3000m, 4000m, 5, 2000m, 6000m, 1650m, 650m },
                    { new Guid("e738b8f3-4be2-458f-aca4-7586f39b2de0"), "E2", 38000m, 2800m, 3800m, 3, 1800m, 5800m, 1630m, 630m },
                    { new Guid("ec97ea18-17cc-40ae-bacc-ede3dda78ea1"), "E2", 36000m, 2600m, 3600m, 1, 1600m, 5600m, 1610m, 610m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("02357dc4-b416-440c-bd93-b9ca4576d06e"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("0482c5d2-e7f2-4a34-8039-cb0b82f75841"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("1138c8de-6e8b-4ed4-b30a-f12dc6516571"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("2883b7a1-7caf-4b66-acc1-90b14f2405f1"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("353b546d-fc50-40c3-8d4e-ea0f666c8c8b"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("37495332-1b36-4261-af4c-9d72eb03004d"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("3bd45fc6-55b3-40a5-85e3-a2586f52de53"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("4a0646c4-df34-461b-8711-1148c545a504"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("4eb2d3e7-4538-4e78-b217-e5a3bfa52d79"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("5488c7d3-32dc-46c2-8edc-73b7bc8336d2"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("54960ba3-2d73-4fed-aed5-76687db263b5"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("5bbd5c90-1512-4f9e-a001-ca77be9bfd02"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("7dc73e18-524a-408e-9fb1-2f0ed7f40219"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("85dae10c-3320-4a6e-a19f-ed54979da054"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("8dc90bc1-75f6-40d0-8166-da741b028f4c"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("98038f4a-c992-424e-835c-5f5e7aba505d"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("a5626786-1491-44f2-9991-e437e1ce0acb"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("b0ef34fd-d488-441f-b3ae-752c6a8383bd"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("b12870be-d090-4d28-8228-a6a02800399d"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("b27b5128-14e8-4056-afe5-5697e48e1c6d"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("b46385c1-a711-43df-bb19-7b8f430fa83e"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("b9242344-631a-4777-89a3-fd605f268049"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("baf6893c-e56a-4655-9708-b5a240281e4d"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("c0f318b3-a30f-46c2-9ba3-26051eaa822e"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("d1d494f0-f826-4d52-83bf-500409946ab1"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("e09cfed3-6a62-4a43-bb55-2536ac57c588"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("e4895063-41cf-45a3-bcf1-e3c868b6339c"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("e72e3a42-0bac-44ee-95a4-5f94c801e978"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("e738b8f3-4be2-458f-aca4-7586f39b2de0"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("ec97ea18-17cc-40ae-bacc-ede3dda78ea1"));
        }
    }
}
