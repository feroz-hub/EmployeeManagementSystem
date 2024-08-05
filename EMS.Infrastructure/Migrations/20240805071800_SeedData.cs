using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
