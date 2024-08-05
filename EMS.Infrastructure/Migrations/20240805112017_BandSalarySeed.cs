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
            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "CertificationId",
                keyValue: new Guid("db95eba7-3d33-49e4-a4b8-63225f464706"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a2c9c21a-cfee-4eb9-b54e-953a7b3e2b6d"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("c81a540a-108a-4d19-9544-ca1f67082353"));

            migrationBuilder.DeleteData(
                table: "EmployeeSalaries",
                keyColumn: "EmployeeId",
                keyValue: new Guid("f66df699-44af-4c8c-9c84-3517e579a488"));

            migrationBuilder.DeleteData(
                table: "EmployeeTypes",
                keyColumn: "EmployeeTypeId",
                keyValue: new Guid("68b4af2b-81b1-4171-bf30-f72ae52ebcaa"));

            migrationBuilder.DeleteData(
                table: "EmployeeTypes",
                keyColumn: "EmployeeTypeId",
                keyValue: new Guid("c6fb4587-251f-4620-8214-297c48ba8c43"));

            migrationBuilder.DeleteData(
                table: "EmployeeTypes",
                keyColumn: "EmployeeTypeId",
                keyValue: new Guid("cb40836a-2b07-4acf-a91f-3e5d0f0ab19f"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "ExperienceId",
                keyValue: new Guid("e725f42f-00de-42f0-a9ee-1d8a9fa8ba13"));

            migrationBuilder.DeleteData(
                table: "GovernmentDocuments",
                keyColumn: "DocumentId",
                keyValue: new Guid("ce86a93f-fb8b-4140-bd2f-1efaeff30503"));

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: new Guid("fa2c0d93-8eba-4cda-af99-b364c67ea17b"));

            migrationBuilder.DeleteData(
                table: "PersonalDetails",
                keyColumn: "EmployeeId",
                keyValue: new Guid("f66df699-44af-4c8c-9c84-3517e579a488"));

            migrationBuilder.DeleteData(
                table: "Qualifications",
                keyColumn: "QualificationId",
                keyValue: new Guid("8cbec964-28c0-4ea0-a0f8-b4e353fe7775"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("0cfe0a16-8aad-4493-a9e3-d25037ac3cc5"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f9e2fcce-12ad-4889-9bef-77a7d2ca22d4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("f66df699-44af-4c8c-9c84-3517e579a488"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a9bcbb61-b96b-4e2c-9af7-73beb9bfd969"));

            migrationBuilder.DeleteData(
                table: "EmployeeTypes",
                keyColumn: "EmployeeTypeId",
                keyValue: new Guid("d6fa2f29-009b-40ee-9d5f-be0a38ee5f0e"));

            migrationBuilder.InsertData(
                table: "BandSalaries",
                columns: new[] { "Id", "Band", "BasicSalary", "ConveyanceAllowance", "DearnessAllowance", "DepartmentType", "EntertainmentAllowance", "HRA", "MedicalInsurance", "Stipend" },
                values: new object[,]
                {
                    { new Guid("01bb09ee-9626-4684-8ead-1b8178ec73bd"), "E5", 53000m, 4300m, 5300m, 3, 3300m, 7300m, 1930m, 930m },
                    { new Guid("01fd65db-a5e0-405f-ac1a-b4c0fa3b1cd4"), "E5", 51000m, 4100m, 5100m, 1, 3100m, 7100m, 1910m, 910m },
                    { new Guid("129f0f4b-5bf8-4633-8dd3-9cee8830b347"), "E2", 35000m, 2500m, 3500m, 0, 1500m, 5500m, 1600m, 600m },
                    { new Guid("1e237a41-5d18-49d0-93b6-ded9c7170f46"), "E2", 40000m, 3000m, 4000m, 5, 2000m, 6000m, 1650m, 650m },
                    { new Guid("240f6a36-6b4f-4c31-a809-cb6ae903e16b"), "E1", 33000m, 2300m, 3300m, 3, 1300m, 5300m, 1530m, 530m },
                    { new Guid("28351979-df06-4fb2-a3d3-920ded00a1bc"), "E3", 43000m, 3300m, 4300m, 3, 2300m, 6300m, 1730m, 730m },
                    { new Guid("2b9367f0-bd76-488a-9751-62d57fd62ef0"), "E4", 46000m, 3600m, 4600m, 1, 2600m, 6600m, 1810m, 810m },
                    { new Guid("4a2bd1f6-ccd8-43d9-a68c-a578427cc934"), "E1", 30000m, 2000m, 3000m, 0, 1000m, 5000m, 1500m, 500m },
                    { new Guid("4f3ae2a7-cf5e-4c18-b15d-17327afd138d"), "E4", 50000m, 4000m, 5000m, 5, 3000m, 7000m, 1850m, 850m },
                    { new Guid("5684586c-de7d-476f-8aca-c776ff2d5716"), "E3", 42000m, 3200m, 4200m, 2, 2200m, 6200m, 1720m, 720m },
                    { new Guid("57d19cd0-6fd5-4fe7-b6de-0afde371a595"), "E1", 35000m, 2500m, 3500m, 5, 1500m, 5500m, 1550m, 550m },
                    { new Guid("615af6cb-4e7c-48c4-a8ae-2fe8fea15bc6"), "E4", 49000m, 3900m, 4900m, 4, 2900m, 6900m, 1840m, 840m },
                    { new Guid("741ff499-8f48-41bb-bc2d-93e0f593bf4e"), "E5", 55000m, 4500m, 5500m, 5, 3500m, 7500m, 1950m, 950m },
                    { new Guid("7549db0f-b0e5-4ced-9118-5a7f2a999dbd"), "E3", 45000m, 3500m, 4500m, 5, 2500m, 6500m, 1750m, 750m },
                    { new Guid("756a4d95-f696-48ab-aab3-f3c6760ebf42"), "E2", 39000m, 2900m, 3900m, 4, 1900m, 5900m, 1640m, 640m },
                    { new Guid("7affa64d-da13-4e89-8c8f-6001c51f75fa"), "E3", 44000m, 3400m, 4400m, 4, 2400m, 6400m, 1740m, 740m },
                    { new Guid("7f4c20f0-7d85-4121-9d59-f799d4be9275"), "E2", 38000m, 2800m, 3800m, 3, 1800m, 5800m, 1630m, 630m },
                    { new Guid("9272d969-c283-4e92-b819-030ca74962d7"), "E3", 41000m, 3100m, 4100m, 1, 2100m, 6100m, 1710m, 710m },
                    { new Guid("98537331-45b4-4ed9-a74d-a130036f1747"), "E2", 36000m, 2600m, 3600m, 1, 1600m, 5600m, 1610m, 610m },
                    { new Guid("a6256f03-db30-45d1-ac9b-9b7c20e48552"), "E3", 40000m, 3000m, 4000m, 0, 2000m, 6000m, 1700m, 700m },
                    { new Guid("a93efd29-172c-48f1-9839-cc4a15f6be4a"), "E5", 52000m, 4200m, 5200m, 2, 3200m, 7200m, 1920m, 920m },
                    { new Guid("c868b234-76a6-4a45-afc2-e9bc0517b3cd"), "E1", 32000m, 2200m, 3200m, 2, 1200m, 5200m, 1520m, 520m },
                    { new Guid("cc3427b2-d22a-4b54-ae3d-32bc306f9fbb"), "E2", 37000m, 2700m, 3700m, 2, 1700m, 5700m, 1620m, 620m },
                    { new Guid("d99405cd-1462-4f85-8f63-ea9778fd7b0b"), "E4", 45000m, 3500m, 4500m, 0, 2500m, 6500m, 1800m, 800m },
                    { new Guid("daecc282-80c2-4c2e-80d6-457ac6ce0833"), "E1", 31000m, 2100m, 3100m, 1, 1100m, 5100m, 1510m, 510m },
                    { new Guid("e57b40cb-57d8-4c1e-bac5-bcb945345c64"), "E1", 34000m, 2400m, 3400m, 4, 1400m, 5400m, 1540m, 540m },
                    { new Guid("f3e14d57-4005-418e-9dda-15f5f9f2c2ff"), "E4", 48000m, 3800m, 4800m, 3, 2800m, 6800m, 1830m, 830m },
                    { new Guid("f5bb4088-dcd7-47c4-8e30-71656eb7cc00"), "E4", 47000m, 3700m, 4700m, 2, 2700m, 6700m, 1820m, 820m },
                    { new Guid("fc17d898-70d0-491b-ae50-f397c9743629"), "E5", 50000m, 4000m, 5000m, 0, 3000m, 7000m, 1900m, 900m },
                    { new Guid("fe27c431-f69d-4a7a-8952-93b0bf07afeb"), "E5", 54000m, 4400m, 5400m, 4, 3400m, 7400m, 1940m, 940m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("01bb09ee-9626-4684-8ead-1b8178ec73bd"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("01fd65db-a5e0-405f-ac1a-b4c0fa3b1cd4"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("129f0f4b-5bf8-4633-8dd3-9cee8830b347"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("1e237a41-5d18-49d0-93b6-ded9c7170f46"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("240f6a36-6b4f-4c31-a809-cb6ae903e16b"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("28351979-df06-4fb2-a3d3-920ded00a1bc"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("2b9367f0-bd76-488a-9751-62d57fd62ef0"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("4a2bd1f6-ccd8-43d9-a68c-a578427cc934"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("4f3ae2a7-cf5e-4c18-b15d-17327afd138d"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("5684586c-de7d-476f-8aca-c776ff2d5716"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("57d19cd0-6fd5-4fe7-b6de-0afde371a595"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("615af6cb-4e7c-48c4-a8ae-2fe8fea15bc6"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("741ff499-8f48-41bb-bc2d-93e0f593bf4e"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("7549db0f-b0e5-4ced-9118-5a7f2a999dbd"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("756a4d95-f696-48ab-aab3-f3c6760ebf42"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("7affa64d-da13-4e89-8c8f-6001c51f75fa"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("7f4c20f0-7d85-4121-9d59-f799d4be9275"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("9272d969-c283-4e92-b819-030ca74962d7"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("98537331-45b4-4ed9-a74d-a130036f1747"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("a6256f03-db30-45d1-ac9b-9b7c20e48552"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("a93efd29-172c-48f1-9839-cc4a15f6be4a"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("c868b234-76a6-4a45-afc2-e9bc0517b3cd"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("cc3427b2-d22a-4b54-ae3d-32bc306f9fbb"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("d99405cd-1462-4f85-8f63-ea9778fd7b0b"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("daecc282-80c2-4c2e-80d6-457ac6ce0833"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("e57b40cb-57d8-4c1e-bac5-bcb945345c64"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("f3e14d57-4005-418e-9dda-15f5f9f2c2ff"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("f5bb4088-dcd7-47c4-8e30-71656eb7cc00"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("fc17d898-70d0-491b-ae50-f397c9743629"));

            migrationBuilder.DeleteData(
                table: "BandSalaries",
                keyColumn: "Id",
                keyValue: new Guid("fe27c431-f69d-4a7a-8952-93b0bf07afeb"));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a2c9c21a-cfee-4eb9-b54e-953a7b3e2b6d"), "IT" },
                    { new Guid("a9bcbb61-b96b-4e2c-9af7-73beb9bfd969"), "Administration" },
                    { new Guid("c81a540a-108a-4d19-9544-ca1f67082353"), "HR" },
                    { new Guid("f9e2fcce-12ad-4889-9bef-77a7d2ca22d4"), "Finance" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeTypes",
                columns: new[] { "EmployeeTypeId", "EmpTypes" },
                values: new object[,]
                {
                    { new Guid("68b4af2b-81b1-4171-bf30-f72ae52ebcaa"), 1 },
                    { new Guid("c6fb4587-251f-4620-8214-297c48ba8c43"), 2 },
                    { new Guid("cb40836a-2b07-4acf-a91f-3e5d0f0ab19f"), 3 },
                    { new Guid("d6fa2f29-009b-40ee-9d5f-be0a38ee5f0e"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Band", "DepartmentId", "DepartmentType", "EmployeeTypeId", "Name" },
                values: new object[] { new Guid("f66df699-44af-4c8c-9c84-3517e579a488"), "E3", new Guid("a9bcbb61-b96b-4e2c-9af7-73beb9bfd969"), 0, new Guid("d6fa2f29-009b-40ee-9d5f-be0a38ee5f0e"), "John Doe" });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Content", "DepartmentId", "GeneratedOn", "Title" },
                values: new object[] { new Guid("0cfe0a16-8aad-4493-a9e3-d25037ac3cc5"), "This is the annual report content.", new Guid("f9e2fcce-12ad-4889-9bef-77a7d2ca22d4"), new DateTime(2024, 8, 5, 12, 47, 59, 10, DateTimeKind.Local).AddTicks(862), "Annual Report" });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "CertificationId", "CertificationName", "EmployeeId", "ExpiryDate", "IssueDate", "IssuingOrganization" },
                values: new object[] { new Guid("db95eba7-3d33-49e4-a4b8-63225f464706"), "Microsoft Certified", new Guid("f66df699-44af-4c8c-9c84-3517e579a488"), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft" });

            migrationBuilder.InsertData(
                table: "EmployeeSalaries",
                columns: new[] { "EmployeeId", "Band", "CalculatedOn", "NetSalary" },
                values: new object[] { new Guid("f66df699-44af-4c8c-9c84-3517e579a488"), "E3", new DateTime(2024, 8, 5, 12, 47, 59, 10, DateTimeKind.Local).AddTicks(784), 60000m });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "ExperienceId", "CompanyName", "EmployeeId", "EndDate", "JobTitle", "Responsibilities", "StartDate" },
                values: new object[] { new Guid("e725f42f-00de-42f0-a9ee-1d8a9fa8ba13"), "XYZ Corp", new Guid("f66df699-44af-4c8c-9c84-3517e579a488"), new DateTime(2012, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Developer", "Developed web applications", new DateTime(2008, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "GovernmentDocuments",
                columns: new[] { "DocumentId", "DocumentNumber", "DocumentType", "EmployeeId", "ExpiryDate", "IssueDate" },
                values: new object[] { new Guid("ce86a93f-fb8b-4140-bd2f-1efaeff30503"), "123456789", "Passport", new Guid("f66df699-44af-4c8c-9c84-3517e579a488"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Leaves",
                columns: new[] { "Id", "EmployeeId", "EndDate", "Reason", "StartDate", "Status" },
                values: new object[] { new Guid("fa2c0d93-8eba-4cda-af99-b364c67ea17b"), new Guid("f66df699-44af-4c8c-9c84-3517e579a488"), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vacation", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "PersonalDetails",
                columns: new[] { "EmployeeId", "Address", "DateOfBirth", "Email", "PhoneNumber" },
                values: new object[] { new Guid("f66df699-44af-4c8c-9c84-3517e579a488"), "123 Main St", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", "123-456-7890" });

            migrationBuilder.InsertData(
                table: "Qualifications",
                columns: new[] { "QualificationId", "Degree", "EmployeeId", "Grade", "GraduationDate", "Institution" },
                values: new object[] { new Guid("8cbec964-28c0-4ea0-a0f8-b4e353fe7775"), "B.Sc. Computer Science", new Guid("f66df699-44af-4c8c-9c84-3517e579a488"), "A", new DateTime(2007, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ABC University" });
        }
    }
}
