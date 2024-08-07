using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreatedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("0f6161c8-4be8-4f08-881a-cd4fdf1a22aa"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("10f9c4a2-2a64-459a-949a-919e18ac4e44"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("14794208-890c-494f-a4c8-7acf82970acd"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("1bd8605d-cae2-4d16-b96f-79c275ccb13c"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("28936bc3-a1a1-4cd0-93ca-64953721fe7d"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("29a1d0aa-00e5-497a-869f-efba8aa7ac37"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("38083aee-df85-45b8-891d-bf900dbdc123"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("3a0879e0-f742-4150-89f7-ab1b63f14b59"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("3cb287ed-9905-429e-b5f2-0c56c3ad5f1a"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("543f694a-f04e-4c61-b4d5-76a58822d01b"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("559f3494-220c-43f2-8760-526683532d93"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("575ad0e7-29b3-4c93-af09-871d92df3ef5"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("578d5995-b575-42de-b011-7fe7fdd11be4"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("6b9d76d1-c195-4b0c-9d39-e651553a4140"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("6cd600c4-fe1c-48d4-934c-ac6f8926e2f9"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("7f1e4be4-56c1-41ab-bc15-6c087cced52b"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("84c96b3a-56fc-4d9c-8229-94d9a341c989"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("8d550d9b-dabd-4fa9-a666-6a52ec09fa4a"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("90d552c6-ce4f-43dc-adaf-e12d18f7cc97"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("9402a541-1120-4230-8613-b4f1d1ce5578"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("ac19c131-90a3-40d4-abba-4d6a639b0358"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("c19ffa4b-1edc-46e4-beb5-92f3d6e17325"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("c9ea2f0c-02ea-4e21-8baa-984184e904ec"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("cb119bd5-95e0-4aa4-8899-e9c645779606"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("cca82bac-4b47-4d7c-bca7-953067fb1230"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("cd87a723-3536-409e-8449-eef1994f85f8"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("eafb488a-c3ff-449d-8a4d-7f8c1d7bf839"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("f7b96390-4610-4d15-89ae-c92f19e60164"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("f8e4dc0c-a0a6-46d3-a0a1-706e800cdf7c"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("fd62a570-d7be-45af-972f-dac0665e7b5e"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Leaves",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RequestDate",
                table: "Leaves",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Leaves");

            migrationBuilder.DropColumn(
                name: "RequestDate",
                table: "Leaves");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Employees");

            migrationBuilder.InsertData(
                table: "BandSalaries",
                columns: new[] { "Id", "Band", "BasicSalary", "ConveyanceAllowance", "DearnessAllowance", "DepartmentType", "EntertainmentAllowance", "HRA", "MedicalInsurance", "Stipend" },
                values: new object[,]
                {
                    { new Guid("0f6161c8-4be8-4f08-881a-cd4fdf1a22aa"), "E1", 35000m, 2500m, 3500m, 5, 1500m, 5500m, 1550m, 550m },
                    { new Guid("10f9c4a2-2a64-459a-949a-919e18ac4e44"), "E3", 43000m, 3300m, 4300m, 3, 2300m, 6300m, 1730m, 730m },
                    { new Guid("14794208-890c-494f-a4c8-7acf82970acd"), "E3", 41000m, 3100m, 4100m, 1, 2100m, 6100m, 1710m, 710m },
                    { new Guid("1bd8605d-cae2-4d16-b96f-79c275ccb13c"), "E3", 45000m, 3500m, 4500m, 5, 2500m, 6500m, 1750m, 750m },
                    { new Guid("28936bc3-a1a1-4cd0-93ca-64953721fe7d"), "E1", 30000m, 2000m, 3000m, 0, 1000m, 5000m, 1500m, 500m },
                    { new Guid("29a1d0aa-00e5-497a-869f-efba8aa7ac37"), "E5", 54000m, 4400m, 5400m, 4, 3400m, 7400m, 1940m, 940m },
                    { new Guid("38083aee-df85-45b8-891d-bf900dbdc123"), "E5", 51000m, 4100m, 5100m, 1, 3100m, 7100m, 1910m, 910m },
                    { new Guid("3a0879e0-f742-4150-89f7-ab1b63f14b59"), "E2", 37000m, 2700m, 3700m, 2, 1700m, 5700m, 1620m, 620m },
                    { new Guid("3cb287ed-9905-429e-b5f2-0c56c3ad5f1a"), "E3", 40000m, 3000m, 4000m, 0, 2000m, 6000m, 1700m, 700m },
                    { new Guid("543f694a-f04e-4c61-b4d5-76a58822d01b"), "E2", 40000m, 3000m, 4000m, 5, 2000m, 6000m, 1650m, 650m },
                    { new Guid("559f3494-220c-43f2-8760-526683532d93"), "E4", 47000m, 3700m, 4700m, 2, 2700m, 6700m, 1820m, 820m },
                    { new Guid("575ad0e7-29b3-4c93-af09-871d92df3ef5"), "E1", 33000m, 2300m, 3300m, 3, 1300m, 5300m, 1530m, 530m },
                    { new Guid("578d5995-b575-42de-b011-7fe7fdd11be4"), "E1", 34000m, 2400m, 3400m, 4, 1400m, 5400m, 1540m, 540m },
                    { new Guid("6b9d76d1-c195-4b0c-9d39-e651553a4140"), "E5", 53000m, 4300m, 5300m, 3, 3300m, 7300m, 1930m, 930m },
                    { new Guid("6cd600c4-fe1c-48d4-934c-ac6f8926e2f9"), "E4", 48000m, 3800m, 4800m, 3, 2800m, 6800m, 1830m, 830m },
                    { new Guid("7f1e4be4-56c1-41ab-bc15-6c087cced52b"), "E1", 31000m, 2100m, 3100m, 1, 1100m, 5100m, 1510m, 510m },
                    { new Guid("84c96b3a-56fc-4d9c-8229-94d9a341c989"), "E5", 55000m, 4500m, 5500m, 5, 3500m, 7500m, 1950m, 950m },
                    { new Guid("8d550d9b-dabd-4fa9-a666-6a52ec09fa4a"), "E1", 32000m, 2200m, 3200m, 2, 1200m, 5200m, 1520m, 520m },
                    { new Guid("90d552c6-ce4f-43dc-adaf-e12d18f7cc97"), "E3", 44000m, 3400m, 4400m, 4, 2400m, 6400m, 1740m, 740m },
                    { new Guid("9402a541-1120-4230-8613-b4f1d1ce5578"), "E4", 46000m, 3600m, 4600m, 1, 2600m, 6600m, 1810m, 810m },
                    { new Guid("ac19c131-90a3-40d4-abba-4d6a639b0358"), "E5", 52000m, 4200m, 5200m, 2, 3200m, 7200m, 1920m, 920m },
                    { new Guid("c19ffa4b-1edc-46e4-beb5-92f3d6e17325"), "E2", 35000m, 2500m, 3500m, 0, 1500m, 5500m, 1600m, 600m },
                    { new Guid("c9ea2f0c-02ea-4e21-8baa-984184e904ec"), "E2", 39000m, 2900m, 3900m, 4, 1900m, 5900m, 1640m, 640m },
                    { new Guid("cb119bd5-95e0-4aa4-8899-e9c645779606"), "E4", 50000m, 4000m, 5000m, 5, 3000m, 7000m, 1850m, 850m },
                    { new Guid("cca82bac-4b47-4d7c-bca7-953067fb1230"), "E5", 50000m, 4000m, 5000m, 0, 3000m, 7000m, 1900m, 900m },
                    { new Guid("cd87a723-3536-409e-8449-eef1994f85f8"), "E4", 45000m, 3500m, 4500m, 0, 2500m, 6500m, 1800m, 800m },
                    { new Guid("eafb488a-c3ff-449d-8a4d-7f8c1d7bf839"), "E4", 49000m, 3900m, 4900m, 4, 2900m, 6900m, 1840m, 840m },
                    { new Guid("f7b96390-4610-4d15-89ae-c92f19e60164"), "E2", 36000m, 2600m, 3600m, 1, 1600m, 5600m, 1610m, 610m },
                    { new Guid("f8e4dc0c-a0a6-46d3-a0a1-706e800cdf7c"), "E2", 38000m, 2800m, 3800m, 3, 1800m, 5800m, 1630m, 630m },
                    { new Guid("fd62a570-d7be-45af-972f-dac0665e7b5e"), "E3", 42000m, 3200m, 4200m, 2, 2200m, 6200m, 1720m, 720m }
                });
        }
    }
}
