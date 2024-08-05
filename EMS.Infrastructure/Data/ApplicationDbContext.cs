namespace EMS.Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public virtual DbSet<Employee> Employees { get; set; }
    public virtual DbSet<Certification> Certifications { get; set; }
    public virtual DbSet<Experience> Experiences { get; set; }
    public virtual DbSet<GovernmentDocument> GovernmentDocuments { get; set; }
    public virtual DbSet<PersonalDetails> PersonalDetails { get; set; }
    public virtual DbSet<Qualification> Qualifications { get; set; }
    public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }
    public virtual DbSet<BandSalary> BandSalaries { get; set; }
    public virtual DbSet<EmployeeSalary> EmployeeSalaries { get; set; }
    public virtual DbSet<Department> Departments { get; set; }
    public virtual DbSet<Leave> Leaves { get; set; }
    public virtual DbSet<Report> Reports { get; set; }

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
        // Employee and EmployeeSalaries (1:N)
        modelBuilder.Entity<Employee>()
            .HasOne(e => e.EmployeeSalary)
            .WithOne(es => es.Employee)
            .HasForeignKey<EmployeeSalary>(es=>es.EmployeeId);

        // Employee and Leaves (1:N)
        modelBuilder.Entity<Employee>()
            .HasMany(e => e.Leaves)
            .WithOne(l => l.Employee)
            .HasForeignKey(l => l.EmployeeId);

        // Department and Employees (1:N)
        modelBuilder.Entity<Employee>()
            .HasOne(d => d.Department)
            .WithMany(d=>d.Employees).HasForeignKey(d => d.DepartmentId);

        // BandSalary configuration
        modelBuilder.Entity<BandSalary>()
            .HasKey(bs => bs.Id);

        // Reports and Departments (1:N)
        modelBuilder.Entity<Department>()
            .HasMany(d=>d.Reports)
            .WithOne(r=>r.Department)
            .HasForeignKey(r => r.DepartmentId);
        
        
        // BandSalary configuration
        modelBuilder.Entity<BandSalary>()
            .HasKey(bs => bs.Id);
        
        //SeedData(modelBuilder);
        
        
        // // Seed Data
        // var employeeTypeId1 = Guid.NewGuid();
        // var employeeTypeId2 = Guid.NewGuid();
        // var employeeTypeId3 = Guid.NewGuid();
        // var employeeTypeId4 = Guid.NewGuid();
        //
        // var employeeId1 = Guid.NewGuid();
        // var employeeId2 = Guid.NewGuid();
        //
        // modelBuilder.Entity<EmployeeType>().HasData(
        //     new EmployeeType { EmployeeTypeId = employeeTypeId1, EmpTypes = EmpTypes.Permanent },
        //     new EmployeeType { EmployeeTypeId = employeeTypeId2, EmpTypes = EmpTypes.Temporary },
        //     new EmployeeType { EmployeeTypeId = employeeTypeId3, EmpTypes = EmpTypes.Retailer },
        //     new EmployeeType { EmployeeTypeId = employeeTypeId4, EmpTypes = EmpTypes.Intern }
        // );
        //   var employee1 = new Employee
        //     {
        //         EmployeeId = employeeId1,
        //         Name = "John Doe",
        //         EmployeeTypeId = employeeTypeId1,
        //         Department = DepartmentType.IT,
        //         PersonalDetails = new PersonalDetails
        //         {
        //             EmployeeId = employeeId1,
        //             Address = "123 Main St",
        //             PhoneNumber = "123-456-7890",
        //             Email = "john.doe@example.com",
        //             DateOfBirth = new DateTime(1990, 1, 1)
        //         },
        //         Qualifications = new List<Qualification>
        //         {
        //             new Qualification
        //             {
        //                 QualificationId = Guid.NewGuid(),
        //                 EmployeeId = employeeId1,
        //                 Degree = "Bachelor's Degree",
        //                 Institution = "University X",
        //                 GraduationDate = new DateTime(2012, 5, 15),
        //                 Grade = "A"
        //             }
        //         },
        //         Experiences = new List<Experience>
        //         {
        //             new Experience
        //             {
        //                 ExperienceId = Guid.NewGuid(),
        //                 EmployeeId = employeeId1,
        //                 CompanyName = "Company A",
        //                 JobTitle = "Software Engineer",
        //                 StartDate = new DateTime(2015, 6, 1),
        //                 EndDate = new DateTime(2020, 12, 31),
        //                 Responsibilities = "Developed software solutions."
        //             }
        //         },
        //         GovernmentDocuments = new List<GovernmentDocument>
        //         {
        //             new GovernmentDocument
        //             {
        //                 DocumentId = Guid.NewGuid(),
        //                 EmployeeId = employeeId1,
        //                 DocumentType = "Passport",
        //                 DocumentNumber = "A1234567",
        //                 IssueDate = new DateTime(2010, 1, 1),
        //                 ExpiryDate = new DateTime(2020, 12, 31)
        //             }
        //         },
        //         Certifications = new List<Certification>
        //         {
        //             new Certification
        //             {
        //                 CertificationId = Guid.NewGuid(),
        //                 EmployeeId = employeeId1,
        //                 CertificationName = "Certified Developer",
        //                 IssuingOrganization = "Tech Org",
        //                 IssueDate = new DateTime(2016, 6, 1),
        //                 ExpiryDate = new DateTime(2021, 6, 1)
        //             }
        //         }
        //     };
        //     employee1.SetBand(); // Set the Band based on the experience
        //     modelBuilder.Entity<Employee>().HasData(employee1);
        //
        //     var employee2 = new Employee
        //     {
        //         EmployeeId = employeeId2,
        //         Name = "Jane Smith",
        //         EmployeeTypeId = employeeTypeId2,
        //         Department = DepartmentType.Sales,
        //         PersonalDetails = new PersonalDetails
        //         {
        //             EmployeeId = employeeId2,
        //             Address = "456 Elm St",
        //             PhoneNumber = "987-654-3210",
        //             Email = "jane.smith@example.com",
        //             DateOfBirth = new DateTime(1995, 5, 15)
        //         },
        //         Qualifications = new List<Qualification>
        //         {
        //             new Qualification
        //             {
        //                 QualificationId = Guid.NewGuid(),
        //                 EmployeeId = employeeId2,
        //                 Degree = "Master's Degree",
        //                 Institution = "University Y",
        //                 GraduationDate = new DateTime(2018, 5, 15),
        //                 Grade = "B"
        //             }
        //         },
        //         Experiences = new List<Experience>
        //         {
        //             new Experience
        //             {
        //                 ExperienceId = Guid.NewGuid(),
        //                 EmployeeId = employeeId2,
        //                 CompanyName = "Company B",
        //                 JobTitle = "HR Specialist",
        //                 StartDate = new DateTime(2020, 1, 1),
        //                 EndDate = null, // Current job
        //                 Responsibilities = "Managed HR operations."
        //             }
        //         },
        //         GovernmentDocuments = new List<GovernmentDocument>
        //         {
        //             new GovernmentDocument
        //             {
        //                 DocumentId = Guid.NewGuid(),
        //                 EmployeeId = employeeId2,
        //                 DocumentType = "Driver's License",
        //                 DocumentNumber = "B7654321",
        //                 IssueDate = new DateTime(2018, 5, 15),
        //                 ExpiryDate = new DateTime(2028, 5, 15)
        //             }
        //         },
        //         Certifications = new List<Certification>
        //         {
        //             new Certification
        //             {
        //                 CertificationId = Guid.NewGuid(),
        //                 EmployeeId = employeeId2,
        //                 CertificationName = "Certified HR Professional",
        //                 IssuingOrganization = "HR Org",
        //                 IssueDate = new DateTime(2019, 6, 1),
        //                 ExpiryDate = new DateTime(2024, 6, 1)
        //             }
        //         }
        //     };
        //     employee2.SetBand(); // Set the Band based on the experience
        //     modelBuilder.Entity<Employee>().HasData(employee2);
        // }
        //
        // modelBuilder.Entity<Employee>().HasData(
        //     new Employee { EmployeeId = employeeId1, Name = "John Doe", EmployeeTypeId = employeeTypeId1, Department = DepartmentType.IT },
        //     new Employee { EmployeeId = employeeId2, Name = "Jane Smith", EmployeeTypeId = employeeTypeId2, Department = DepartmentType.Finance }
        // );
        //
        //
        // modelBuilder.Entity<PersonalDetails>().HasData(
        //     new PersonalDetails { EmployeeId = employeeId1, Address = "123 Main St", PhoneNumber = "123-456-7890", Email = "john.doe@example.com", DateOfBirth = new DateTime(1985, 1, 1) },
        //     new PersonalDetails { EmployeeId = employeeId2, Address = "456 Elm St", PhoneNumber = "987-654-3210", Email = "jane.smith@example.com", DateOfBirth = new DateTime(1990, 2, 2) }
        // );
        //
        // modelBuilder.Entity<GovernmentDocument>().HasData(
        //     new GovernmentDocument { DocumentId = Guid.NewGuid(), EmployeeId = employeeId1, DocumentType = "Passport", DocumentNumber = "A1234567", IssueDate = new DateTime(2015, 1, 1), ExpiryDate = new DateTime(2025, 1, 1) },
        //     new GovernmentDocument { DocumentId = Guid.NewGuid(), EmployeeId = employeeId2, DocumentType = "Driver's License", DocumentNumber = "B9876543", IssueDate = new DateTime(2018, 1, 1), ExpiryDate = new DateTime(2028, 1, 1) }
        // );
        //
        // modelBuilder.Entity<Experience>().HasData(
        //     new Experience { ExperienceId = Guid.NewGuid(), EmployeeId = employeeId1, CompanyName = "ABC Corp", JobTitle = "Software Engineer", StartDate = new DateTime(2010, 1, 1), EndDate = new DateTime(2020, 1, 1), Responsibilities = "Developing software applications" },
        //     new Experience { ExperienceId = Guid.NewGuid(), EmployeeId = employeeId2, CompanyName = "XYZ Ltd", JobTitle = "Project Manager", StartDate = new DateTime(2012, 1, 1), EndDate = new DateTime(2022, 1, 1), Responsibilities = "Managing projects" }
        // );
        //
        // modelBuilder.Entity<Certification>().HasData(
        //     new Certification { CertificationId = Guid.NewGuid(), EmployeeId = employeeId1, CertificationName = "Certified Scrum Master", IssuingOrganization = "Scrum Alliance", IssueDate = new DateTime(2017, 1, 1), ExpiryDate = new DateTime(2020, 1, 1) },
        //     new Certification { CertificationId = Guid.NewGuid(), EmployeeId = employeeId2, CertificationName = "PMP", IssuingOrganization = "PMI", IssueDate = new DateTime(2016, 1, 1), ExpiryDate = new DateTime(2019, 1, 1) }
        // );
        //
        // modelBuilder.Entity<Qualification>().HasData(
        //     new Qualification { QualificationId = Guid.NewGuid(), EmployeeId = employeeId1, Degree = "B.Sc in Computer Science", Institution = "ABC University", GraduationDate = new DateTime(2007, 1, 1), Grade = "A" },
        //     new Qualification { QualificationId = Guid.NewGuid(), EmployeeId = employeeId2, Degree = "MBA", Institution = "XYZ University", GraduationDate = new DateTime(2010, 1, 1), Grade = "B+" }
        // );

       
    }
     private void SeedData(ModelBuilder modelBuilder)
        {
            // Seed Employee Types
            var permanentTypeId = Guid.NewGuid();
            var temporaryTypeId = Guid.NewGuid();

            modelBuilder.Entity<EmployeeType>().HasData(
                new EmployeeType { EmployeeTypeId = permanentTypeId, EmpTypes = EmpTypes.Permanent },
                new EmployeeType { EmployeeTypeId = temporaryTypeId, EmpTypes = EmpTypes.Temporary }
            );

            // Seed Employees
            var employee1Id = Guid.NewGuid();
            var employee2Id = Guid.NewGuid();

            var employee1 = new Employee
            {
                EmployeeId = employee1Id,
                Name = "John Doe",
                EmployeeTypeId = permanentTypeId,
                DepartmentType = DepartmentType.IT,
                PersonalDetails = new PersonalDetails
                {
                    EmployeeId = employee1Id,
                    Address = "123 Main St",
                    PhoneNumber = "123-456-7890",
                    Email = "john.doe@example.com",
                    DateOfBirth = new DateTime(1990, 1, 1)
                },
                Qualifications = new List<Qualification>
                {
                    new Qualification
                    {
                        QualificationId = Guid.NewGuid(),
                        EmployeeId = employee1Id,
                        Degree = "Bachelor's Degree",
                        Institution = "University X",
                        GraduationDate = new DateTime(2012, 5, 15),
                        Grade = "A"
                    }
                },
                Experiences = new List<Experience>
                {
                    new Experience
                    {
                        ExperienceId = Guid.NewGuid(),
                        EmployeeId = employee1Id,
                        CompanyName = "Company A",
                        JobTitle = "Software Engineer",
                        StartDate = new DateTime(2015, 6, 1),
                        EndDate = new DateTime(2020, 12, 31),
                        Responsibilities = "Developed software solutions."
                    }
                },
                GovernmentDocuments = new List<GovernmentDocument>
                {
                    new GovernmentDocument
                    {
                        DocumentId = Guid.NewGuid(),
                        EmployeeId = employee1Id,
                        DocumentType = "Passport",
                        DocumentNumber = "A1234567",
                        IssueDate = new DateTime(2010, 1, 1),
                        ExpiryDate = new DateTime(2020, 12, 31)
                    }
                },
                Certifications = new List<Certification>
                {
                    new Certification
                    {
                        CertificationId = Guid.NewGuid(),
                        EmployeeId = employee1Id,
                        CertificationName = "Certified Developer",
                        IssuingOrganization = "Tech Org",
                        IssueDate = new DateTime(2016, 6, 1),
                        ExpiryDate = new DateTime(2021, 6, 1)
                    }
                }
            };
            employee1.SetBand(); // Set the Band based on the experience

            var employee2 = new Employee
            {
                EmployeeId = employee2Id,
                Name = "Jane Smith",
                EmployeeTypeId = temporaryTypeId,
                DepartmentType = DepartmentType.HR,
                PersonalDetails = new PersonalDetails
                {
                    EmployeeId = employee2Id,
                    Address = "456 Elm St",
                    PhoneNumber = "987-654-3210",
                    Email = "jane.smith@example.com",
                    DateOfBirth = new DateTime(1995, 5, 15)
                },
                Qualifications = new List<Qualification>
                {
                    new Qualification
                    {
                        QualificationId = Guid.NewGuid(),
                        EmployeeId = employee2Id,
                        Degree = "Master's Degree",
                        Institution = "University Y",
                        GraduationDate = new DateTime(2018, 5, 15),
                        Grade = "B"
                    }
                },
                Experiences = new List<Experience>
                {
                    new Experience
                    {
                        ExperienceId = Guid.NewGuid(),
                        EmployeeId = employee2Id,
                        CompanyName = "Company B",
                        JobTitle = "HR Specialist",
                        StartDate = new DateTime(2020, 1, 1),
                        EndDate = null, // Current job
                        Responsibilities = "Managed HR operations."
                    }
                },
                GovernmentDocuments = new List<GovernmentDocument>
                {
                    new GovernmentDocument
                    {
                        DocumentId = Guid.NewGuid(),
                        EmployeeId = employee2Id,
                        DocumentType = "Driver's License",
                        DocumentNumber = "B7654321",
                        IssueDate = new DateTime(2018, 5, 15),
                        ExpiryDate = new DateTime(2028, 5, 15)
                    }
                },
                Certifications = new List<Certification>
                {
                    new Certification
                    {
                        CertificationId = Guid.NewGuid(),
                        EmployeeId = employee2Id,
                        CertificationName = "Certified HR Professional",
                        IssuingOrganization = "HR Org",
                        IssueDate = new DateTime(2019, 6, 1),
                        ExpiryDate = new DateTime(2024, 6, 1)
                    }
                }
            };
            employee2.SetBand(); // Set the Band based on the experience

            modelBuilder.Entity<Employee>().HasData(employee1, employee2);
        }

}
