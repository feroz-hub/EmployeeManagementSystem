﻿// <auto-generated />
using System;
using EMS.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EMS.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("EMS.Domain.Entities.BandSalary", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Band")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("BasicSalary")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ConveyanceAllowance")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("DearnessAllowance")
                        .HasColumnType("TEXT");

                    b.Property<int>("DepartmentType")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("EntertainmentAllowance")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("HRA")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("MedicalInsurance")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Stipend")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BandSalaries");

                    b.HasData(
                        new
                        {
                            Id = new Guid("15080f9e-3b21-4c2c-94a1-bc9f80b5f056"),
                            Band = "E1",
                            BasicSalary = 30000m,
                            ConveyanceAllowance = 2000m,
                            DearnessAllowance = 3000m,
                            DepartmentType = 0,
                            EntertainmentAllowance = 1000m,
                            HRA = 5000m,
                            MedicalInsurance = 1500m,
                            Stipend = 500m
                        },
                        new
                        {
                            Id = new Guid("2a5f6f44-8d15-4027-aee2-ce26d4209f3f"),
                            Band = "E2",
                            BasicSalary = 35000m,
                            ConveyanceAllowance = 2500m,
                            DearnessAllowance = 3500m,
                            DepartmentType = 0,
                            EntertainmentAllowance = 1500m,
                            HRA = 5500m,
                            MedicalInsurance = 1600m,
                            Stipend = 600m
                        },
                        new
                        {
                            Id = new Guid("164935c3-baa6-4e81-b58c-d689065234e4"),
                            Band = "E3",
                            BasicSalary = 40000m,
                            ConveyanceAllowance = 3000m,
                            DearnessAllowance = 4000m,
                            DepartmentType = 0,
                            EntertainmentAllowance = 2000m,
                            HRA = 6000m,
                            MedicalInsurance = 1700m,
                            Stipend = 700m
                        },
                        new
                        {
                            Id = new Guid("f567a0dd-c851-43e7-8a7c-795cfd174a42"),
                            Band = "E4",
                            BasicSalary = 45000m,
                            ConveyanceAllowance = 3500m,
                            DearnessAllowance = 4500m,
                            DepartmentType = 0,
                            EntertainmentAllowance = 2500m,
                            HRA = 6500m,
                            MedicalInsurance = 1800m,
                            Stipend = 800m
                        },
                        new
                        {
                            Id = new Guid("1c98c44e-040f-4209-a50d-16ffed9a63b6"),
                            Band = "E5",
                            BasicSalary = 50000m,
                            ConveyanceAllowance = 4000m,
                            DearnessAllowance = 5000m,
                            DepartmentType = 0,
                            EntertainmentAllowance = 3000m,
                            HRA = 7000m,
                            MedicalInsurance = 1900m,
                            Stipend = 900m
                        },
                        new
                        {
                            Id = new Guid("cc1c3043-bd19-4882-86f6-976f6ff06191"),
                            Band = "E1",
                            BasicSalary = 31000m,
                            ConveyanceAllowance = 2100m,
                            DearnessAllowance = 3100m,
                            DepartmentType = 1,
                            EntertainmentAllowance = 1100m,
                            HRA = 5100m,
                            MedicalInsurance = 1510m,
                            Stipend = 510m
                        },
                        new
                        {
                            Id = new Guid("217eae5d-7c64-4aa1-b62c-a10f17dab11b"),
                            Band = "E2",
                            BasicSalary = 36000m,
                            ConveyanceAllowance = 2600m,
                            DearnessAllowance = 3600m,
                            DepartmentType = 1,
                            EntertainmentAllowance = 1600m,
                            HRA = 5600m,
                            MedicalInsurance = 1610m,
                            Stipend = 610m
                        },
                        new
                        {
                            Id = new Guid("768dc645-be74-4314-9058-7e9456d704d1"),
                            Band = "E3",
                            BasicSalary = 41000m,
                            ConveyanceAllowance = 3100m,
                            DearnessAllowance = 4100m,
                            DepartmentType = 1,
                            EntertainmentAllowance = 2100m,
                            HRA = 6100m,
                            MedicalInsurance = 1710m,
                            Stipend = 710m
                        },
                        new
                        {
                            Id = new Guid("0ba7a0f1-d864-41d0-a11d-54f082dd5f19"),
                            Band = "E4",
                            BasicSalary = 46000m,
                            ConveyanceAllowance = 3600m,
                            DearnessAllowance = 4600m,
                            DepartmentType = 1,
                            EntertainmentAllowance = 2600m,
                            HRA = 6600m,
                            MedicalInsurance = 1810m,
                            Stipend = 810m
                        },
                        new
                        {
                            Id = new Guid("66198ba1-94c9-4dcd-bfa0-3f237948337e"),
                            Band = "E5",
                            BasicSalary = 51000m,
                            ConveyanceAllowance = 4100m,
                            DearnessAllowance = 5100m,
                            DepartmentType = 1,
                            EntertainmentAllowance = 3100m,
                            HRA = 7100m,
                            MedicalInsurance = 1910m,
                            Stipend = 910m
                        },
                        new
                        {
                            Id = new Guid("8d690b35-2a23-4a6e-97a9-084fd713650a"),
                            Band = "E1",
                            BasicSalary = 32000m,
                            ConveyanceAllowance = 2200m,
                            DearnessAllowance = 3200m,
                            DepartmentType = 2,
                            EntertainmentAllowance = 1200m,
                            HRA = 5200m,
                            MedicalInsurance = 1520m,
                            Stipend = 520m
                        },
                        new
                        {
                            Id = new Guid("784f7716-8582-4914-963a-e5fff9d0eefa"),
                            Band = "E2",
                            BasicSalary = 37000m,
                            ConveyanceAllowance = 2700m,
                            DearnessAllowance = 3700m,
                            DepartmentType = 2,
                            EntertainmentAllowance = 1700m,
                            HRA = 5700m,
                            MedicalInsurance = 1620m,
                            Stipend = 620m
                        },
                        new
                        {
                            Id = new Guid("e6e6a071-0884-48a2-8497-7329e4227587"),
                            Band = "E3",
                            BasicSalary = 42000m,
                            ConveyanceAllowance = 3200m,
                            DearnessAllowance = 4200m,
                            DepartmentType = 2,
                            EntertainmentAllowance = 2200m,
                            HRA = 6200m,
                            MedicalInsurance = 1720m,
                            Stipend = 720m
                        },
                        new
                        {
                            Id = new Guid("d9cdfd40-860b-48a7-9d6d-bfaab04765f1"),
                            Band = "E4",
                            BasicSalary = 47000m,
                            ConveyanceAllowance = 3700m,
                            DearnessAllowance = 4700m,
                            DepartmentType = 2,
                            EntertainmentAllowance = 2700m,
                            HRA = 6700m,
                            MedicalInsurance = 1820m,
                            Stipend = 820m
                        },
                        new
                        {
                            Id = new Guid("78085b95-14b5-4966-85c6-7f9599d9aa04"),
                            Band = "E5",
                            BasicSalary = 52000m,
                            ConveyanceAllowance = 4200m,
                            DearnessAllowance = 5200m,
                            DepartmentType = 2,
                            EntertainmentAllowance = 3200m,
                            HRA = 7200m,
                            MedicalInsurance = 1920m,
                            Stipend = 920m
                        },
                        new
                        {
                            Id = new Guid("d7e03564-7113-42d7-a886-57b2d95f0507"),
                            Band = "E1",
                            BasicSalary = 33000m,
                            ConveyanceAllowance = 2300m,
                            DearnessAllowance = 3300m,
                            DepartmentType = 3,
                            EntertainmentAllowance = 1300m,
                            HRA = 5300m,
                            MedicalInsurance = 1530m,
                            Stipend = 530m
                        },
                        new
                        {
                            Id = new Guid("fd947f44-2dc3-4a70-9abc-1978e846f1bc"),
                            Band = "E2",
                            BasicSalary = 38000m,
                            ConveyanceAllowance = 2800m,
                            DearnessAllowance = 3800m,
                            DepartmentType = 3,
                            EntertainmentAllowance = 1800m,
                            HRA = 5800m,
                            MedicalInsurance = 1630m,
                            Stipend = 630m
                        },
                        new
                        {
                            Id = new Guid("0f15adb0-721c-409a-a90d-c93b0ee4f9a2"),
                            Band = "E3",
                            BasicSalary = 43000m,
                            ConveyanceAllowance = 3300m,
                            DearnessAllowance = 4300m,
                            DepartmentType = 3,
                            EntertainmentAllowance = 2300m,
                            HRA = 6300m,
                            MedicalInsurance = 1730m,
                            Stipend = 730m
                        },
                        new
                        {
                            Id = new Guid("c3b8409a-b9a2-42e1-a21a-32cb97885f81"),
                            Band = "E4",
                            BasicSalary = 48000m,
                            ConveyanceAllowance = 3800m,
                            DearnessAllowance = 4800m,
                            DepartmentType = 3,
                            EntertainmentAllowance = 2800m,
                            HRA = 6800m,
                            MedicalInsurance = 1830m,
                            Stipend = 830m
                        },
                        new
                        {
                            Id = new Guid("7d755052-f42d-4091-915b-7e072b0f5d6f"),
                            Band = "E5",
                            BasicSalary = 53000m,
                            ConveyanceAllowance = 4300m,
                            DearnessAllowance = 5300m,
                            DepartmentType = 3,
                            EntertainmentAllowance = 3300m,
                            HRA = 7300m,
                            MedicalInsurance = 1930m,
                            Stipend = 930m
                        },
                        new
                        {
                            Id = new Guid("fd47ae72-e00f-48b9-8b23-430f8d236ea1"),
                            Band = "E1",
                            BasicSalary = 34000m,
                            ConveyanceAllowance = 2400m,
                            DearnessAllowance = 3400m,
                            DepartmentType = 4,
                            EntertainmentAllowance = 1400m,
                            HRA = 5400m,
                            MedicalInsurance = 1540m,
                            Stipend = 540m
                        },
                        new
                        {
                            Id = new Guid("833bc2db-5cd7-4c29-840e-3af36f3c1060"),
                            Band = "E2",
                            BasicSalary = 39000m,
                            ConveyanceAllowance = 2900m,
                            DearnessAllowance = 3900m,
                            DepartmentType = 4,
                            EntertainmentAllowance = 1900m,
                            HRA = 5900m,
                            MedicalInsurance = 1640m,
                            Stipend = 640m
                        },
                        new
                        {
                            Id = new Guid("e4f59a0b-7783-48a9-a2c0-cba0d449ba12"),
                            Band = "E3",
                            BasicSalary = 44000m,
                            ConveyanceAllowance = 3400m,
                            DearnessAllowance = 4400m,
                            DepartmentType = 4,
                            EntertainmentAllowance = 2400m,
                            HRA = 6400m,
                            MedicalInsurance = 1740m,
                            Stipend = 740m
                        },
                        new
                        {
                            Id = new Guid("f630c36c-9b35-48f0-a17b-f2b505ccf2b7"),
                            Band = "E4",
                            BasicSalary = 49000m,
                            ConveyanceAllowance = 3900m,
                            DearnessAllowance = 4900m,
                            DepartmentType = 4,
                            EntertainmentAllowance = 2900m,
                            HRA = 6900m,
                            MedicalInsurance = 1840m,
                            Stipend = 840m
                        },
                        new
                        {
                            Id = new Guid("28604e6e-f840-4926-a0c0-4576328f8334"),
                            Band = "E5",
                            BasicSalary = 54000m,
                            ConveyanceAllowance = 4400m,
                            DearnessAllowance = 5400m,
                            DepartmentType = 4,
                            EntertainmentAllowance = 3400m,
                            HRA = 7400m,
                            MedicalInsurance = 1940m,
                            Stipend = 940m
                        },
                        new
                        {
                            Id = new Guid("b4b0e6ba-5cfd-4e03-8574-d32c326b89f2"),
                            Band = "E1",
                            BasicSalary = 35000m,
                            ConveyanceAllowance = 2500m,
                            DearnessAllowance = 3500m,
                            DepartmentType = 5,
                            EntertainmentAllowance = 1500m,
                            HRA = 5500m,
                            MedicalInsurance = 1550m,
                            Stipend = 550m
                        },
                        new
                        {
                            Id = new Guid("ea409282-2319-4bf0-826d-5daf0dcd7e7b"),
                            Band = "E2",
                            BasicSalary = 40000m,
                            ConveyanceAllowance = 3000m,
                            DearnessAllowance = 4000m,
                            DepartmentType = 5,
                            EntertainmentAllowance = 2000m,
                            HRA = 6000m,
                            MedicalInsurance = 1650m,
                            Stipend = 650m
                        },
                        new
                        {
                            Id = new Guid("c3d2b61c-2dbe-4521-b0fd-39f16501557e"),
                            Band = "E3",
                            BasicSalary = 45000m,
                            ConveyanceAllowance = 3500m,
                            DearnessAllowance = 4500m,
                            DepartmentType = 5,
                            EntertainmentAllowance = 2500m,
                            HRA = 6500m,
                            MedicalInsurance = 1750m,
                            Stipend = 750m
                        },
                        new
                        {
                            Id = new Guid("66aa5fd6-0f91-4410-82fc-493529ea2bbe"),
                            Band = "E4",
                            BasicSalary = 50000m,
                            ConveyanceAllowance = 4000m,
                            DearnessAllowance = 5000m,
                            DepartmentType = 5,
                            EntertainmentAllowance = 3000m,
                            HRA = 7000m,
                            MedicalInsurance = 1850m,
                            Stipend = 850m
                        },
                        new
                        {
                            Id = new Guid("66a97526-af02-4aa7-ab37-0a110e930297"),
                            Band = "E5",
                            BasicSalary = 55000m,
                            ConveyanceAllowance = 4500m,
                            DearnessAllowance = 5500m,
                            DepartmentType = 5,
                            EntertainmentAllowance = 3500m,
                            HRA = 7500m,
                            MedicalInsurance = 1950m,
                            Stipend = 950m
                        });
                });

            modelBuilder.Entity("EMS.Domain.Entities.Employee", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Band")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("DepartmentType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmployeeType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EMS.Domain.Entities.EmployeeDetails.Certification", b =>
                {
                    b.Property<Guid>("CertificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CertificationName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("IssuingOrganization")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CertificationId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Certifications");
                });

            modelBuilder.Entity("EMS.Domain.Entities.EmployeeDetails.Experience", b =>
                {
                    b.Property<Guid>("ExperienceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Responsibilities")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("ExperienceId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("EMS.Domain.Entities.EmployeeDetails.GovernmentDocument", b =>
                {
                    b.Property<Guid>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DocumentType")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("TEXT");

                    b.HasKey("DocumentId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("GovernmentDocuments");
                });

            modelBuilder.Entity("EMS.Domain.Entities.EmployeeDetails.PersonalDetails", b =>
                {
                    b.Property<Guid>("EmployeeId")
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

                    b.HasKey("EmployeeId");

                    b.ToTable("PersonalDetails");
                });

            modelBuilder.Entity("EMS.Domain.Entities.EmployeeDetails.Qualification", b =>
                {
                    b.Property<Guid>("QualificationId")
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

                    b.HasKey("QualificationId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Qualifications");
                });

            modelBuilder.Entity("EMS.Domain.Entities.EmployeeSalary", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Band")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CalculatedOn")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("NetSalary")
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeId");

                    b.ToTable("EmployeeSalaries");
                });

            modelBuilder.Entity("EMS.Domain.Entities.Leave", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RequestDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Leaves");
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
                        .HasForeignKey("EMS.Domain.Entities.EmployeeDetails.PersonalDetails", "EmployeeId")
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

            modelBuilder.Entity("EMS.Domain.Entities.EmployeeSalary", b =>
                {
                    b.HasOne("EMS.Domain.Entities.Employee", "Employee")
                        .WithOne("EmployeeSalary")
                        .HasForeignKey("EMS.Domain.Entities.EmployeeSalary", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EMS.Domain.Entities.Leave", b =>
                {
                    b.HasOne("EMS.Domain.Entities.Employee", "Employee")
                        .WithMany("Leaves")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EMS.Domain.Entities.Employee", b =>
                {
                    b.Navigation("Certifications");

                    b.Navigation("EmployeeSalary");

                    b.Navigation("Experiences");

                    b.Navigation("GovernmentDocuments");

                    b.Navigation("Leaves");

                    b.Navigation("PersonalDetails");

                    b.Navigation("Qualifications");
                });
#pragma warning restore 612, 618
        }
    }
}
