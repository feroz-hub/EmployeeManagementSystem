using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeTypes",
                columns: table => new
                {
                    EmployeeTypeId = table.Column<Guid>(type: "TEXT", nullable: false),
                    EmpTypes = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTypes", x => x.EmployeeTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    EmployeeTypeId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PersonalDetailsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Salary = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_EmployeeTypes_EmployeeTypeId",
                        column: x => x.EmployeeTypeId,
                        principalTable: "EmployeeTypes",
                        principalColumn: "EmployeeTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Certifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CertificationName = table.Column<string>(type: "TEXT", nullable: false),
                    IssuingOrganization = table.Column<string>(type: "TEXT", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Certifications_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompanyName = table.Column<string>(type: "TEXT", nullable: false),
                    JobTitle = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Responsibilities = table.Column<string>(type: "TEXT", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experiences_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GovernmentDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DocumentType = table.Column<string>(type: "TEXT", nullable: false),
                    DocumentNumber = table.Column<string>(type: "TEXT", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GovernmentDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GovernmentDocuments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalDetails_Employees_Id",
                        column: x => x.Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Qualifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Degree = table.Column<string>(type: "TEXT", nullable: false),
                    Institution = table.Column<string>(type: "TEXT", nullable: false),
                    GraduationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Grade = table.Column<string>(type: "TEXT", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Qualifications_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EmployeeTypes",
                columns: new[] { "EmployeeTypeId", "EmpTypes" },
                values: new object[,]
                {
                    { new Guid("65423f4c-4ddd-4cc5-87c5-20608da7b3e3"), "Permanent" },
                    { new Guid("8bcbca09-e0d1-4357-8598-d57b6c648425"), "Temporary" }
                });

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
                table: "Certifications",
                columns: new[] { "Id", "CertificationName", "EmployeeId", "ExpiryDate", "IssueDate", "IssuingOrganization" },
                values: new object[,]
                {
                    { 1, "Certified Kubernetes Administrator", new Guid("0590c04e-87ec-4894-98fc-22ddf7ab50a2"), new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CNCF" },
                    { 2, "Project Management Professional", new Guid("0cac004e-66a0-4466-a88b-08872a205e7f"), new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PMI" }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "CompanyName", "EmployeeId", "EndDate", "JobTitle", "Responsibilities", "StartDate" },
                values: new object[,]
                {
                    { 1, "Tech Corp", new Guid("0590c04e-87ec-4894-98fc-22ddf7ab50a2"), new DateTime(2012, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Developer", "Developing software", new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Business Inc.", new Guid("0cac004e-66a0-4466-a88b-08872a205e7f"), new DateTime(2018, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing Manager", "Managing marketing campaigns", new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "GovernmentDocuments",
                columns: new[] { "Id", "DocumentNumber", "DocumentType", "EmployeeId", "ExpiryDate", "IssueDate" },
                values: new object[,]
                {
                    { 1, "A1234567", "Passport", new Guid("0590c04e-87ec-4894-98fc-22ddf7ab50a2"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "B7654321", "Driver's License", new Guid("0cac004e-66a0-4466-a88b-08872a205e7f"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Qualifications",
                columns: new[] { "Id", "Degree", "EmployeeId", "Grade", "GraduationDate", "Institution" },
                values: new object[,]
                {
                    { new Guid("af1851e6-a18b-4bb6-8ecb-103200240642"), "BSc Computer Science", new Guid("0590c04e-87ec-4894-98fc-22ddf7ab50a2"), "First Class", new DateTime(2007, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "University of Example" },
                    { new Guid("e06faf48-7945-40e8-a10f-eb441931ca70"), "MBA", new Guid("0cac004e-66a0-4466-a88b-08872a205e7f"), "Distinction", new DateTime(2012, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Business School Example" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Certifications_EmployeeId",
                table: "Certifications",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeTypeId",
                table: "Employees",
                column: "EmployeeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_EmployeeId",
                table: "Experiences",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_GovernmentDocuments_EmployeeId",
                table: "GovernmentDocuments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Qualifications_EmployeeId",
                table: "Qualifications",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certifications");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "GovernmentDocuments");

            migrationBuilder.DropTable(
                name: "PersonalDetails");

            migrationBuilder.DropTable(
                name: "Qualifications");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "EmployeeTypes");
        }
    }
}
