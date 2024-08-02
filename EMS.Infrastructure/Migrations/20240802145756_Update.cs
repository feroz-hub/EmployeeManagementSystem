using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4c998f9a-f4b8-45db-8812-74a6ee852c74"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("61ecba9c-52ce-4309-abd5-b4f3526b3efa"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e08293e2-1e51-4fd9-8094-7da9c63035bd"));

            migrationBuilder.DeleteData(
                table: "PersonalDetails",
                keyColumn: "Id",
                keyValue: new Guid("0b4e5088-c26d-4f0f-8260-dd50fb9c8304"));

            migrationBuilder.DeleteData(
                table: "PersonalDetails",
                keyColumn: "Id",
                keyValue: new Guid("2099c408-4442-4c8e-8e10-c10b32ab118c"));

            migrationBuilder.DeleteData(
                table: "PersonalDetails",
                keyColumn: "Id",
                keyValue: new Guid("53596b21-0dc6-4886-bdca-e36645078fa5"));

            migrationBuilder.DeleteData(
                table: "PersonalDetails",
                keyColumn: "Id",
                keyValue: new Guid("9fc34334-8181-4538-8e13-14044ac83cd2"));

            migrationBuilder.DeleteData(
                table: "PersonalDetails",
                keyColumn: "Id",
                keyValue: new Guid("e92cba51-b5d0-493c-ad3e-3fd4c8f501a9"));

            migrationBuilder.DeleteData(
                table: "Qualifications",
                keyColumn: "Id",
                keyValue: new Guid("af1851e6-a18b-4bb6-8ecb-103200240642"));

            migrationBuilder.DeleteData(
                table: "Qualifications",
                keyColumn: "Id",
                keyValue: new Guid("e06faf48-7945-40e8-a10f-eb441931ca70"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("0590c04e-87ec-4894-98fc-22ddf7ab50a2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("0cac004e-66a0-4466-a88b-08872a205e7f"));

            migrationBuilder.DeleteData(
                table: "EmployeeTypes",
                keyColumn: "EmployeeTypeId",
                keyValue: new Guid("65423f4c-4ddd-4cc5-87c5-20608da7b3e3"));

            migrationBuilder.DeleteData(
                table: "EmployeeTypes",
                keyColumn: "EmployeeTypeId",
                keyValue: new Guid("8bcbca09-e0d1-4357-8598-d57b6c648425"));

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "EmployeeId",
                value: new Guid("5b8c24a0-1816-4695-aa97-f6f7da949c9b"));

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "EmployeeId",
                value: new Guid("76f04adc-82d5-4469-8c3a-7d0273f80298"));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                column: "EmployeeId",
                value: new Guid("5b8c24a0-1816-4695-aa97-f6f7da949c9b"));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 2,
                column: "EmployeeId",
                value: new Guid("76f04adc-82d5-4469-8c3a-7d0273f80298"));

            migrationBuilder.UpdateData(
                table: "GovernmentDocuments",
                keyColumn: "Id",
                keyValue: 1,
                column: "EmployeeId",
                value: new Guid("5b8c24a0-1816-4695-aa97-f6f7da949c9b"));

            migrationBuilder.UpdateData(
                table: "GovernmentDocuments",
                keyColumn: "Id",
                keyValue: 2,
                column: "EmployeeId",
                value: new Guid("76f04adc-82d5-4469-8c3a-7d0273f80298"));

            migrationBuilder.InsertData(
                table: "Qualifications",
                columns: new[] { "Id", "Degree", "EmployeeId", "Grade", "GraduationDate", "Institution" },
                values: new object[,]
                {
                    { new Guid("99b40736-12ce-4b68-8975-25d36fe026d0"), "BSc Computer Science", new Guid("5b8c24a0-1816-4695-aa97-f6f7da949c9b"), "First Class", new DateTime(2007, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "University of Example" },
                    { new Guid("e650b528-5fb2-4ff1-b502-72f664717886"), "MBA", new Guid("76f04adc-82d5-4469-8c3a-7d0273f80298"), "Distinction", new DateTime(2012, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Business School Example" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Qualifications",
                keyColumn: "Id",
                keyValue: new Guid("99b40736-12ce-4b68-8975-25d36fe026d0"));

            migrationBuilder.DeleteData(
                table: "Qualifications",
                keyColumn: "Id",
                keyValue: new Guid("e650b528-5fb2-4ff1-b502-72f664717886"));

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "EmployeeId",
                value: new Guid("0590c04e-87ec-4894-98fc-22ddf7ab50a2"));

            migrationBuilder.UpdateData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "EmployeeId",
                value: new Guid("0cac004e-66a0-4466-a88b-08872a205e7f"));

            migrationBuilder.InsertData(
                table: "EmployeeTypes",
                columns: new[] { "EmployeeTypeId", "EmpTypes" },
                values: new object[,]
                {
                    { new Guid("65423f4c-4ddd-4cc5-87c5-20608da7b3e3"), "Permanent" },
                    { new Guid("8bcbca09-e0d1-4357-8598-d57b6c648425"), "Temporary" }
                });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                column: "EmployeeId",
                value: new Guid("0590c04e-87ec-4894-98fc-22ddf7ab50a2"));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 2,
                column: "EmployeeId",
                value: new Guid("0cac004e-66a0-4466-a88b-08872a205e7f"));

            migrationBuilder.UpdateData(
                table: "GovernmentDocuments",
                keyColumn: "Id",
                keyValue: 1,
                column: "EmployeeId",
                value: new Guid("0590c04e-87ec-4894-98fc-22ddf7ab50a2"));

            migrationBuilder.UpdateData(
                table: "GovernmentDocuments",
                keyColumn: "Id",
                keyValue: 2,
                column: "EmployeeId",
                value: new Guid("0cac004e-66a0-4466-a88b-08872a205e7f"));

            migrationBuilder.InsertData(
                table: "PersonalDetails",
                columns: new[] { "Id", "Address", "DateOfBirth", "Email", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("0b4e5088-c26d-4f0f-8260-dd50fb9c8304"), "123 Main St", new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "alice@example.com", "555-1234" },
                    { new Guid("2099c408-4442-4c8e-8e10-c10b32ab118c"), "321 Pine St", new DateTime(1995, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "diana@example.com", "555-4321" },
                    { new Guid("53596b21-0dc6-4886-bdca-e36645078fa5"), "456 Elm St", new DateTime(1990, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob@example.com", "555-5678" },
                    { new Guid("9fc34334-8181-4538-8e13-14044ac83cd2"), "789 Oak St", new DateTime(1988, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "charlie@example.com", "555-8765" },
                    { new Guid("e92cba51-b5d0-493c-ad3e-3fd4c8f501a9"), "654 Maple St", new DateTime(1992, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "eve@example.com", "555-6789" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "EmployeeTypeId", "Name", "PersonalDetailsId", "Salary" },
                values: new object[,]
                {
                    { new Guid("0590c04e-87ec-4894-98fc-22ddf7ab50a2"), new Guid("65423f4c-4ddd-4cc5-87c5-20608da7b3e3"), "Alice Johnson", new Guid("0b4e5088-c26d-4f0f-8260-dd50fb9c8304"), 60000m },
                    { new Guid("0cac004e-66a0-4466-a88b-08872a205e7f"), new Guid("8bcbca09-e0d1-4357-8598-d57b6c648425"), "Bob Smith", new Guid("53596b21-0dc6-4886-bdca-e36645078fa5"), 45000m },
                    { new Guid("4c998f9a-f4b8-45db-8812-74a6ee852c74"), new Guid("65423f4c-4ddd-4cc5-87c5-20608da7b3e3"), "Eve Adams", new Guid("e92cba51-b5d0-493c-ad3e-3fd4c8f501a9"), 62000m },
                    { new Guid("61ecba9c-52ce-4309-abd5-b4f3526b3efa"), new Guid("8bcbca09-e0d1-4357-8598-d57b6c648425"), "Diana Prince", new Guid("2099c408-4442-4c8e-8e10-c10b32ab118c"), 40000m },
                    { new Guid("e08293e2-1e51-4fd9-8094-7da9c63035bd"), new Guid("65423f4c-4ddd-4cc5-87c5-20608da7b3e3"), "Charlie Davis", new Guid("9fc34334-8181-4538-8e13-14044ac83cd2"), 55000m }
                });

            migrationBuilder.InsertData(
                table: "Qualifications",
                columns: new[] { "Id", "Degree", "EmployeeId", "Grade", "GraduationDate", "Institution" },
                values: new object[,]
                {
                    { new Guid("af1851e6-a18b-4bb6-8ecb-103200240642"), "BSc Computer Science", new Guid("0590c04e-87ec-4894-98fc-22ddf7ab50a2"), "First Class", new DateTime(2007, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "University of Example" },
                    { new Guid("e06faf48-7945-40e8-a10f-eb441931ca70"), "MBA", new Guid("0cac004e-66a0-4466-a88b-08872a205e7f"), "Distinction", new DateTime(2012, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Business School Example" }
                });
        }
    }
}
