namespace EMS.Infrastructure.Data;
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):DbContext(options)
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Certification> Certifications { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<GovernmentDocument> GovernmentDocuments { get; set; }
    public DbSet<PersonalDetails> PersonalDetails { get; set; }
    public DbSet<Qualification> Qualifications { get; set; }
    public DbSet<EmployeeType> EmployeeTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Employee Type and Employee
        modelBuilder.Entity<Employee>().HasOne(e => e.EmployeeType).WithMany(et => et.Employees)
            .HasForeignKey(e => e.EmployeeTypeId);
        
        // Employee and PersonalDetails
        modelBuilder.Entity<Employee>().HasOne(e => e.PersonalDetails).WithOne(pd => pd.Employee)
            .HasForeignKey<PersonalDetails>(pd => pd.EmployeeId);
        
        // Employee and Qualifications
        modelBuilder.Entity<Employee>().HasMany(e => e.Qualifications).WithOne(q => q.Employee)
            .HasForeignKey(q => q.EmployeeId);
        
        // Employee and Experience
        modelBuilder.Entity<Employee>().HasMany(e => e.Experiences).WithOne(ex => ex.Employee)
            .HasForeignKey(ex => ex.EmployeeId);
        
        // Employee and GovernmentDetails
        modelBuilder.Entity<Employee>().HasMany(e => e.GovernmentDocuments).WithOne(gd => gd.Employee)
            .HasForeignKey(gd => gd.EmployeeId);
        
        // Employee and Certifications
        modelBuilder.Entity<Employee>().HasMany(e => e.Certifications).WithOne(ct => ct.Employee)
            .HasForeignKey(c => c.EmployeeId);

        // // Define fixed GUIDs for EmployeeTypes
        //     var permanentEmployeeTypeId = Guid.NewGuid();
        //     var temporaryEmployeeTypeId = Guid.NewGuid();
        //     var retailerEmployeeTypeId = Guid.NewGuid();
        //     var internEmployeeTypeId = Guid.NewGuid();
        //
        //     // Seed Employee Types
        //     modelBuilder.Entity<EmployeeType>().HasData(
        //         new EmployeeType { EmployeeTypeId = permanentEmployeeTypeId, EmpTypes = EmpTypes.Permanent },
        //         new EmployeeType { EmployeeTypeId = temporaryEmployeeTypeId, EmpTypes = EmpTypes.Temporary },
        //         new EmployeeType { EmployeeTypeId = retailerEmployeeTypeId, EmpTypes = EmpTypes.Retailer },
        //         new EmployeeType { EmployeeTypeId = internEmployeeTypeId, EmpTypes = EmpTypes.Intern }
        //     );
        //
        //     // Seed Employees with Personal Details
        //     var employeeId1 = Guid.NewGuid();
        //     var employeeId2 = Guid.NewGuid();
        //     var employeeId3 = Guid.NewGuid();
        //
        //     modelBuilder.Entity<Employee>().HasData(
        //         new Employee
        //         {
        //             Id = employeeId1,
        //             Name = "Alice",
        //             EmployeeTypeId = permanentEmployeeTypeId,
        //             Salary = 50000
        //         },
        //         new Employee
        //         {
        //             Id = employeeId2,
        //             Name = "Bob",
        //             EmployeeTypeId = temporaryEmployeeTypeId,
        //             Salary = 40000
        //         },
        //         new Employee
        //         {
        //             Id = employeeId3,
        //             Name = "Charlie",
        //             EmployeeTypeId = temporaryEmployeeTypeId,
        //             Salary = 45000
        //         }
        //     );
        //
        //     modelBuilder.Entity<PersonalDetails>().HasData(
        //         new PersonalDetails
        //         {
        //             Id = employeeId1,
        //             Address = "123 Main St",
        //             PhoneNumber = "555-1234",
        //             Email = "alice@example.com",
        //             DateOfBirth = new DateTime(1985, 5, 15)
        //         },
        //         new PersonalDetails
        //         {
        //             Id = employeeId2,
        //             Address = "456 Elm St",
        //             PhoneNumber = "555-5678",
        //             Email = "bob@example.com",
        //             DateOfBirth = new DateTime(1990, 8, 20)
        //         },
        //         new PersonalDetails
        //         {
        //             Id = employeeId3,
        //             Address = "789 Oak St",
        //             PhoneNumber = "555-8765",
        //             Email = "charlie@example.com",
        //             DateOfBirth = new DateTime(1988, 2, 25)
        //         }
        //     );
        //
        //     // Seed Qualifications
        //     modelBuilder.Entity<Qualification>().HasData(
        //         new Qualification
        //         {
        //             Id = Guid.NewGuid(),
        //             Degree = "B.Sc. Computer Science",
        //             Institution = "University A",
        //             GraduationDate = new DateTime(2007, 5, 15),
        //             Grade = "A",
        //             EmployeeId = employeeId1
        //         },
        //         new Qualification
        //         {
        //             Id = Guid.NewGuid(),
        //             Degree = "M.Sc. Software Engineering",
        //             Institution = "University B",
        //             GraduationDate = new DateTime(2011, 7, 20),
        //             Grade = "A",
        //             EmployeeId = employeeId2
        //         }
        //     );
        //
        //     // Seed Experiences
        //     modelBuilder.Entity<Experience>().HasData(
        //         new Experience
        //         {
        //             Id = Guid.NewGuid(),
        //             CompanyName = "Company X",
        //             JobTitle = "Software Developer",
        //             StartDate = new DateTime(2007, 8, 1),
        //             EndDate = new DateTime(2010, 7, 31),
        //             Responsibilities = "Developed software solutions.",
        //             EmployeeId = employeeId1
        //         },
        //         new Experience
        //         {
        //             Id = Guid.NewGuid(),
        //             CompanyName = "Company Y",
        //             JobTitle = "Senior Developer",
        //             StartDate = new DateTime(2010, 8, 1),
        //             EndDate = new DateTime(2015, 7, 31),
        //             Responsibilities = "Led development teams.",
        //             EmployeeId = employeeId2
        //         }
        //     );
        //
        //     // Seed Government Documents
        //     modelBuilder.Entity<GovernmentDocument>().HasData(
        //         new GovernmentDocument
        //         {
        //             Id = Guid.NewGuid(),
        //             DocumentType = "Passport",
        //             DocumentNumber = "P1234567",
        //             IssueDate = new DateTime(2015, 1, 1),
        //             ExpiryDate = new DateTime(2025, 1, 1),
        //             EmployeeId = employeeId1
        //         },
        //         new GovernmentDocument
        //         {
        //             Id = Guid.NewGuid(),
        //             DocumentType = "Driver's License",
        //             DocumentNumber = "D7654321",
        //             IssueDate = new DateTime(2010, 6, 1),
        //             ExpiryDate = new DateTime(2020, 6, 1),
        //             EmployeeId = employeeId2
        //         }
        //     );
        //
        //     // Seed Certifications
        //     modelBuilder.Entity<Certification>().HasData(
        //         new Certification
        //         {
        //             Id = Guid.NewGuid(),
        //             CertificationName = "Certified Scrum Master",
        //             IssuingOrganization = "Scrum Alliance",
        //             IssueDate = new DateTime(2012, 9, 15),
        //             ExpiryDate = new DateTime(2022, 9, 15),
        //             EmployeeId = employeeId1
        //         },
        //         new Certification
        //         {
        //             Id = Guid.NewGuid(),
        //             CertificationName = "Microsoft Certified: Azure Solutions Architect",
        //             IssuingOrganization = "Microsoft",
        //             IssueDate = new DateTime(2018, 3, 20),
        //             ExpiryDate = new DateTime(2021, 3, 20),
        //             EmployeeId = employeeId2
        //         }
        //     );
        // }
    }
}



    // private void SeedData(ModelBuilder modelBuilder)
    // {
    //     var employeeType1 = new EmployeeType { EmployeeTypeId = Guid.NewGuid(), EmpTypes = EmpTypes.Permanent };
    //     var employeeType2 = new EmployeeType { EmployeeTypeId = Guid.NewGuid(), EmpTypes = EmpTypes.Temporary };
    //
    //     var personalDetails1 = new PersonalDetails
    //     {
    //         Id = Guid.NewGuid(),
    //         Address = "123 Main St",
    //         PhoneNumber = "555-1234",
    //         Email = "alice@example.com",
    //         DateOfBirth = new DateTime(1985, 5, 15)
    //     };
    //
    //     var personalDetails2 = new PersonalDetails
    //     {
    //         Id = Guid.NewGuid(),
    //         Address = "456 Elm St",
    //         PhoneNumber = "555-5678",
    //         Email = "bob@example.com",
    //         DateOfBirth = new DateTime(1990, 8, 20)
    //     };
    //
    //     var personalDetails3 = new PersonalDetails
    //     {
    //         Id = Guid.NewGuid(),
    //         Address = "789 Oak St",
    //         PhoneNumber = "555-8765",
    //         Email = "charlie@example.com",
    //         DateOfBirth = new DateTime(1988, 2, 25)
    //     };
    //
    //     var personalDetails4 = new PersonalDetails
    //     {
    //         Id = Guid.NewGuid(),
    //         Address = "321 Pine St",
    //         PhoneNumber = "555-4321",
    //         Email = "diana@example.com",
    //         DateOfBirth = new DateTime(1995, 10, 30)
    //     };
    //
    //     var personalDetails5 = new PersonalDetails
    //     {
    //         Id = Guid.NewGuid(),
    //         Address = "654 Maple St",
    //         PhoneNumber = "555-6789",
    //         Email = "eve@example.com",
    //         DateOfBirth = new DateTime(1992, 3, 10)
    //     };
    //
    //     var employees = new[]
    //     {
    //     new Employee
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = "Alice Johnson",
    //         EmployeeTypeId = employeeType1.EmployeeTypeId,
    //         PersonalDetailsId = personalDetails1.Id,
    //         Salary = 60000m
    //     },
    //     new Employee
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = "Bob Smith",
    //         EmployeeTypeId = employeeType2.EmployeeTypeId,
    //         PersonalDetailsId = personalDetails2.Id,
    //         Salary = 45000m
    //     },
    //     new Employee
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = "Charlie Davis",
    //         EmployeeTypeId = employeeType1.EmployeeTypeId,
    //         PersonalDetailsId = personalDetails3.Id,
    //         Salary = 55000m
    //     },
    //     new Employee
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = "Diana Prince",
    //         EmployeeTypeId = employeeType2.EmployeeTypeId,
    //         PersonalDetailsId = personalDetails4.Id,
    //         Salary = 40000m
    //     },
    //     new Employee
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = "Eve Adams",
    //         EmployeeTypeId = employeeType1.EmployeeTypeId,
    //         PersonalDetailsId = personalDetails5.Id,
    //         Salary = 62000m
    //     }
    // };
    //
    //     var qualifications = new[]
    //     {
    //     new Qualification
    //     {
    //         Id = Guid.NewGuid(),
    //         Degree = "BSc Computer Science",
    //         Institution = "University of Example",
    //         GraduationDate = new DateTime(2007, 6, 15),
    //         Grade = "First Class",
    //         EmployeeId = employees[0].Id
    //     },
    //     new Qualification
    //     {
    //         Id = Guid.NewGuid(),
    //         Degree = "MBA",
    //         Institution = "Business School Example",
    //         GraduationDate = new DateTime(2012, 5, 20),
    //         Grade = "Distinction",
    //         EmployeeId = employees[1].Id
    //     }
    // };
    //
    //     var experiences = new[]
    //     {
    //     new Experience
    //     {
    //         Id = 1,
    //         CompanyName = "Tech Corp",
    //         JobTitle = "Software Developer",
    //         StartDate = new DateTime(2008, 1, 1),
    //         EndDate = new DateTime(2012, 12, 31),
    //         Responsibilities = "Developing software",
    //         EmployeeId = employees[0].Id
    //     },
    //     new Experience
    //     {
    //         Id = 2,
    //         CompanyName = "Business Inc.",
    //         JobTitle = "Marketing Manager",
    //         StartDate = new DateTime(2013, 1, 1),
    //         EndDate = new DateTime(2018, 12, 31),
    //         Responsibilities = "Managing marketing campaigns",
    //         EmployeeId = employees[1].Id
    //     }
    // };
    //
    //     var governmentDocuments = new[]
    //     {
    //     new GovernmentDocument
    //     {
    //         Id = 1,
    //         DocumentType = "Passport",
    //         DocumentNumber = "A1234567",
    //         IssueDate = new DateTime(2015, 1, 1),
    //         ExpiryDate = new DateTime(2025, 1, 1),
    //         EmployeeId = employees[0].Id
    //     },
    //     new GovernmentDocument
    //     {
    //         Id = 2,
    //         DocumentType = "Driver's License",
    //         DocumentNumber = "B7654321",
    //         IssueDate = new DateTime(2014, 1, 1),
    //         ExpiryDate = new DateTime(2024, 1, 1),
    //         EmployeeId = employees[1].Id
    //     }
    // };
    //
    //     var certifications = new[]
    //     {
    //     new Certification
    //     {
    //         Id = 1,
    //         CertificationName = "Certified Kubernetes Administrator",
    //         IssuingOrganization = "CNCF",
    //         IssueDate = new DateTime(2019, 7, 1),
    //         ExpiryDate = new DateTime(2022, 7, 1),
    //         EmployeeId = employees[0].Id
    //     },
    //     new Certification
    //     {
    //         Id = 2,
    //         CertificationName = "Project Management Professional",
    //         IssuingOrganization = "PMI",
    //         IssueDate = new DateTime(2018, 8, 1),
    //         ExpiryDate = new DateTime(2021, 8, 1),
    //         EmployeeId = employees[1].Id
    //     }
    // };
    //
    //     //modelBuilder.Entity<EmployeeType>().HasData(employeeType1, employeeType2);
    //     //modelBuilder.Entity<PersonalDetails>().HasData(personalDetails1, personalDetails2, personalDetails3, personalDetails4, personalDetails5);
    //     //modelBuilder.Entity<Employee>().HasData(employees);
    //     //modelBuilder.Entity<Qualification>().HasData(qualifications);
    //     //modelBuilder.Entity<Experience>().HasData(experiences);
    //     //modelBuilder.Entity<GovernmentDocument>().HasData(governmentDocuments);
    //     //modelBuilder.Entity<Certification>().HasData(certifications);
    // }
