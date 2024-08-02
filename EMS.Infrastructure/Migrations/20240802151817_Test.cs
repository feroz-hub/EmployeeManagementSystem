using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GovernmentDocuments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GovernmentDocuments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Qualifications",
                keyColumn: "Id",
                keyValue: new Guid("99b40736-12ce-4b68-8975-25d36fe026d0"));

            migrationBuilder.DeleteData(
                table: "Qualifications",
                keyColumn: "Id",
                keyValue: new Guid("e650b528-5fb2-4ff1-b502-72f664717886"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "CertificationName", "EmployeeId", "ExpiryDate", "IssueDate", "IssuingOrganization" },
                values: new object[,]
                {
                    { 1, "Certified Kubernetes Administrator", new Guid("5b8c24a0-1816-4695-aa97-f6f7da949c9b"), new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CNCF" },
                    { 2, "Project Management Professional", new Guid("76f04adc-82d5-4469-8c3a-7d0273f80298"), new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PMI" }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "CompanyName", "EmployeeId", "EndDate", "JobTitle", "Responsibilities", "StartDate" },
                values: new object[,]
                {
                    { 1, "Tech Corp", new Guid("5b8c24a0-1816-4695-aa97-f6f7da949c9b"), new DateTime(2012, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Developer", "Developing software", new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Business Inc.", new Guid("76f04adc-82d5-4469-8c3a-7d0273f80298"), new DateTime(2018, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing Manager", "Managing marketing campaigns", new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "GovernmentDocuments",
                columns: new[] { "Id", "DocumentNumber", "DocumentType", "EmployeeId", "ExpiryDate", "IssueDate" },
                values: new object[,]
                {
                    { 1, "A1234567", "Passport", new Guid("5b8c24a0-1816-4695-aa97-f6f7da949c9b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "B7654321", "Driver's License", new Guid("76f04adc-82d5-4469-8c3a-7d0273f80298"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Qualifications",
                columns: new[] { "Id", "Degree", "EmployeeId", "Grade", "GraduationDate", "Institution" },
                values: new object[,]
                {
                    { new Guid("99b40736-12ce-4b68-8975-25d36fe026d0"), "BSc Computer Science", new Guid("5b8c24a0-1816-4695-aa97-f6f7da949c9b"), "First Class", new DateTime(2007, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "University of Example" },
                    { new Guid("e650b528-5fb2-4ff1-b502-72f664717886"), "MBA", new Guid("76f04adc-82d5-4469-8c3a-7d0273f80298"), "Distinction", new DateTime(2012, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Business School Example" }
                });
        }
    }
}
