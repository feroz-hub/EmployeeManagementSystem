﻿// <auto-generated />
using System;
using EMS.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EMS.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240802145756_Update")]
    partial class Update
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("EMS.Domain.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("EmployeeTypeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PersonalDetailsId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Salary")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeTypeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EMS.Domain.Entities.EmployeeDetails.Certification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CertificationName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("IssuingOrganization")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Certifications");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CertificationName = "Certified Kubernetes Administrator",
                            EmployeeId = new Guid("5b8c24a0-1816-4695-aa97-f6f7da949c9b"),
                            ExpiryDate = new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IssueDate = new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IssuingOrganization = "CNCF"
                        },
                        new
                        {
                            Id = 2,
                            CertificationName = "Project Management Professional",
                            EmployeeId = new Guid("76f04adc-82d5-4469-8c3a-7d0273f80298"),
                            ExpiryDate = new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IssueDate = new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IssuingOrganization = "PMI"
                        });
                });

            modelBuilder.Entity("EMS.Domain.Entities.EmployeeDetails.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Responsibilities")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Experiences");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyName = "Tech Corp",
                            EmployeeId = new Guid("5b8c24a0-1816-4695-aa97-f6f7da949c9b"),
                            EndDate = new DateTime(2012, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            JobTitle = "Software Developer",
                            Responsibilities = "Developing software",
                            StartDate = new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CompanyName = "Business Inc.",
                            EmployeeId = new Guid("76f04adc-82d5-4469-8c3a-7d0273f80298"),
                            EndDate = new DateTime(2018, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            JobTitle = "Marketing Manager",
                            Responsibilities = "Managing marketing campaigns",
                            StartDate = new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("EMS.Domain.Entities.EmployeeDetails.GovernmentDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DocumentType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("GovernmentDocuments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DocumentNumber = "A1234567",
                            DocumentType = "Passport",
                            EmployeeId = new Guid("5b8c24a0-1816-4695-aa97-f6f7da949c9b"),
                            ExpiryDate = new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IssueDate = new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            DocumentNumber = "B7654321",
                            DocumentType = "Driver's License",
                            EmployeeId = new Guid("76f04adc-82d5-4469-8c3a-7d0273f80298"),
                            ExpiryDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IssueDate = new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("EMS.Domain.Entities.EmployeeDetails.PersonalDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PersonalDetails");
                });

            modelBuilder.Entity("EMS.Domain.Entities.EmployeeDetails.Qualification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("GraduationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Institution")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Qualifications");

                    b.HasData(
                        new
                        {
                            Id = new Guid("99b40736-12ce-4b68-8975-25d36fe026d0"),
                            Degree = "BSc Computer Science",
                            EmployeeId = new Guid("5b8c24a0-1816-4695-aa97-f6f7da949c9b"),
                            Grade = "First Class",
                            GraduationDate = new DateTime(2007, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Institution = "University of Example"
                        },
                        new
                        {
                            Id = new Guid("e650b528-5fb2-4ff1-b502-72f664717886"),
                            Degree = "MBA",
                            EmployeeId = new Guid("76f04adc-82d5-4469-8c3a-7d0273f80298"),
                            Grade = "Distinction",
                            GraduationDate = new DateTime(2012, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Institution = "Business School Example"
                        });
                });

            modelBuilder.Entity("EMS.Domain.Entities.EmployeeType", b =>
                {
                    b.Property<Guid>("EmployeeTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmpTypes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeTypeId");

                    b.ToTable("EmployeeTypes");
                });

            modelBuilder.Entity("EMS.Domain.Entities.Employee", b =>
                {
                    b.HasOne("EMS.Domain.Entities.EmployeeType", "EmployeeType")
                        .WithMany()
                        .HasForeignKey("EmployeeTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeType");
                });

            modelBuilder.Entity("EMS.Domain.Entities.EmployeeDetails.Certification", b =>
                {
                    b.HasOne("EMS.Domain.Entities.Employee", "Employee")
                        .WithMany("Certifications")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EMS.Domain.Entities.EmployeeDetails.Experience", b =>
                {
                    b.HasOne("EMS.Domain.Entities.Employee", "Employee")
                        .WithMany("Experiences")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EMS.Domain.Entities.EmployeeDetails.GovernmentDocument", b =>
                {
                    b.HasOne("EMS.Domain.Entities.Employee", "Employee")
                        .WithMany("GovernmentDocuments")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EMS.Domain.Entities.EmployeeDetails.PersonalDetails", b =>
                {
                    b.HasOne("EMS.Domain.Entities.Employee", "Employee")
                        .WithOne("PersonalDetails")
                        .HasForeignKey("EMS.Domain.Entities.EmployeeDetails.PersonalDetails", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EMS.Domain.Entities.EmployeeDetails.Qualification", b =>
                {
                    b.HasOne("EMS.Domain.Entities.Employee", "Employee")
                        .WithMany("Qualifications")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EMS.Domain.Entities.Employee", b =>
                {
                    b.Navigation("Certifications");

                    b.Navigation("Experiences");

                    b.Navigation("GovernmentDocuments");

                    b.Navigation("PersonalDetails")
                        .IsRequired();

                    b.Navigation("Qualifications");
                });
#pragma warning restore 612, 618
        }
    }
}
