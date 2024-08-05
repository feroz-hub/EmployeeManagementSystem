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
        
        
        // Seed Data
        var employeeTypeId1 = Guid.NewGuid();
        var employeeTypeId2 = Guid.NewGuid();
        var employeeTypeId3 = Guid.NewGuid();
        var employeeTypeId4 = Guid.NewGuid();
        
        var employeeId1 = Guid.NewGuid();
        var employeeId2 = Guid.NewGuid();
        
        modelBuilder.Entity<EmployeeType>().HasData(
            new EmployeeType { EmployeeTypeId = employeeTypeId1, EmpTypes = EmpTypes.Permanent },
            new EmployeeType { EmployeeTypeId = employeeTypeId2, EmpTypes = EmpTypes.Temporary },
            new EmployeeType { EmployeeTypeId = employeeTypeId3, EmpTypes = EmpTypes.Retailer },
            new EmployeeType { EmployeeTypeId = employeeTypeId4, EmpTypes = EmpTypes.Intern }
        );
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
        
        modelBuilder.Entity<Employee>().HasData(
            new Employee { EmployeeId = employeeId1, Name = "John Doe", EmployeeTypeId = employeeTypeId1, DepartmentType = DepartmentType.IT,Band = "E2",},
            new Employee { EmployeeId = employeeId2, Name = "Jane Smith", EmployeeTypeId = employeeTypeId2, DepartmentType = DepartmentType.Finance,Band = "E3"}
        );
        modelBuilder.Entity<EmployeeSalary>().HasData(
            new EmployeeSalary { EmployeeId = employeeId1, NetSalary = 29000,Band = "E2", CalculatedOn = DateTime.Now},
            new EmployeeSalary { EmployeeId=employeeId2,NetSalary = 49000,Band = "E3", CalculatedOn =DateTime.Now});
        
        modelBuilder.Entity<PersonalDetails>().HasData(
            new PersonalDetails { EmployeeId = employeeId1, Address = "123 Main St", PhoneNumber = "123-456-7890", Email = "john.doe@example.com", DateOfBirth = new DateTime(1985, 1, 1) },
            new PersonalDetails { EmployeeId = employeeId2, Address = "456 Elm St", PhoneNumber = "987-654-3210", Email = "jane.smith@example.com", DateOfBirth = new DateTime(1990, 2, 2) }
        );
        
        modelBuilder.Entity<GovernmentDocument>().HasData(
            new GovernmentDocument { DocumentId = Guid.NewGuid(), EmployeeId = employeeId1, DocumentType = "Passport", DocumentNumber = "A1234567", IssueDate = new DateTime(2015, 1, 1), ExpiryDate = new DateTime(2025, 1, 1) },
            new GovernmentDocument { DocumentId = Guid.NewGuid(), EmployeeId = employeeId2, DocumentType = "Driver's License", DocumentNumber = "B9876543", IssueDate = new DateTime(2018, 1, 1), ExpiryDate = new DateTime(2028, 1, 1) }
        );
        
        modelBuilder.Entity<Experience>().HasData(
            new Experience { ExperienceId = Guid.NewGuid(), EmployeeId = employeeId1, CompanyName = "ABC Corp", JobTitle = "Software Engineer", StartDate = new DateTime(2010, 1, 1), EndDate = new DateTime(2020, 1, 1), Responsibilities = "Developing software applications" },
            new Experience { ExperienceId = Guid.NewGuid(), EmployeeId = employeeId2, CompanyName = "XYZ Ltd", JobTitle = "Project Manager", StartDate = new DateTime(2012, 1, 1), EndDate = new DateTime(2022, 1, 1), Responsibilities = "Managing projects" }
        );
        
        modelBuilder.Entity<Certification>().HasData(
            new Certification { CertificationId = Guid.NewGuid(), EmployeeId = employeeId1, CertificationName = "Certified Scrum Master", IssuingOrganization = "Scrum Alliance", IssueDate = new DateTime(2017, 1, 1), ExpiryDate = new DateTime(2020, 1, 1) },
            new Certification { CertificationId = Guid.NewGuid(), EmployeeId = employeeId2, CertificationName = "PMP", IssuingOrganization = "PMI", IssueDate = new DateTime(2016, 1, 1), ExpiryDate = new DateTime(2019, 1, 1) }
        );
        
        modelBuilder.Entity<Qualification>().HasData(
            new Qualification { QualificationId = Guid.NewGuid(), EmployeeId = employeeId1, Degree = "B.Sc in Computer Science", Institution = "ABC University", GraduationDate = new DateTime(2007, 1, 1), Grade = "A" },
            new Qualification { QualificationId = Guid.NewGuid(), EmployeeId = employeeId2, Degree = "MBA", Institution = "XYZ University", GraduationDate = new DateTime(2010, 1, 1), Grade = "B+" }
        );

        modelBuilder.Entity<Leave>().HasData(
            new Leave { Id = Guid.NewGuid(), StartDate = new DateTime(2024, 8, 4), EndDate = new DateTime(2024, 8, 8), EmployeeId = employeeId1, Reason = "Going Native", Status = LeaveStatus.Requested}, 
            new Leave { Id = Guid.NewGuid(), StartDate = new DateTime(2024, 8, 2), EndDate = new DateTime(2024, 8, 4), EmployeeId = employeeId2, Reason = "Going Native", Status = LeaveStatus.Requested }
        );
        
        modelBuilder.Entity<BandSalary>().HasData(
            new BandSalary { Id = Guid.NewGuid(), Band = "E1", DepartmentType = DepartmentType.Administration, BasicSalary = 30000, DearnessAllowance = 3000, HRA = 5000, ConveyanceAllowance = 2000, EntertainmentAllowance = 1000, MedicalInsurance = 1500, Stipend = 500 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E2", DepartmentType = DepartmentType.Administration, BasicSalary = 35000, DearnessAllowance = 3500, HRA = 5500, ConveyanceAllowance = 2500, EntertainmentAllowance = 1500, MedicalInsurance = 1600, Stipend = 600 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E3", DepartmentType = DepartmentType.Administration, BasicSalary = 40000, DearnessAllowance = 4000, HRA = 6000, ConveyanceAllowance = 3000, EntertainmentAllowance = 2000, MedicalInsurance = 1700, Stipend = 700 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E4", DepartmentType = DepartmentType.Administration, BasicSalary = 45000, DearnessAllowance = 4500, HRA = 6500, ConveyanceAllowance = 3500, EntertainmentAllowance = 2500, MedicalInsurance = 1800, Stipend = 800 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E5", DepartmentType = DepartmentType.Administration, BasicSalary = 50000, DearnessAllowance = 5000, HRA = 7000, ConveyanceAllowance = 4000, EntertainmentAllowance = 3000, MedicalInsurance = 1900, Stipend = 900 },
            // Repeat for each department type
            new BandSalary { Id = Guid.NewGuid(), Band = "E1", DepartmentType = DepartmentType.HR, BasicSalary = 31000, DearnessAllowance = 3100, HRA = 5100, ConveyanceAllowance = 2100, EntertainmentAllowance = 1100, MedicalInsurance = 1510, Stipend = 510 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E2", DepartmentType = DepartmentType.HR, BasicSalary = 36000, DearnessAllowance = 3600, HRA = 5600, ConveyanceAllowance = 2600, EntertainmentAllowance = 1600, MedicalInsurance = 1610, Stipend = 610 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E3", DepartmentType = DepartmentType.HR, BasicSalary = 41000, DearnessAllowance = 4100, HRA = 6100, ConveyanceAllowance = 3100, EntertainmentAllowance = 2100, MedicalInsurance = 1710, Stipend = 710 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E4", DepartmentType = DepartmentType.HR, BasicSalary = 46000, DearnessAllowance = 4600, HRA = 6600, ConveyanceAllowance = 3600, EntertainmentAllowance = 2600, MedicalInsurance = 1810, Stipend = 810 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E5", DepartmentType = DepartmentType.HR, BasicSalary = 51000, DearnessAllowance = 5100, HRA = 7100, ConveyanceAllowance = 4100, EntertainmentAllowance = 3100, MedicalInsurance = 1910, Stipend = 910 },
            // Add entries for Finance, Marketing, Sales, and IT similarly
            new BandSalary { Id = Guid.NewGuid(), Band = "E1", DepartmentType = DepartmentType.Finance, BasicSalary = 32000, DearnessAllowance = 3200, HRA = 5200, ConveyanceAllowance = 2200, EntertainmentAllowance = 1200, MedicalInsurance = 1520, Stipend = 520 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E2", DepartmentType = DepartmentType.Finance, BasicSalary = 37000, DearnessAllowance = 3700, HRA = 5700, ConveyanceAllowance = 2700, EntertainmentAllowance = 1700, MedicalInsurance = 1620, Stipend = 620 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E3", DepartmentType = DepartmentType.Finance, BasicSalary = 42000, DearnessAllowance = 4200, HRA = 6200, ConveyanceAllowance = 3200, EntertainmentAllowance = 2200, MedicalInsurance = 1720, Stipend = 720 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E4", DepartmentType = DepartmentType.Finance, BasicSalary = 47000, DearnessAllowance = 4700, HRA = 6700, ConveyanceAllowance = 3700, EntertainmentAllowance = 2700, MedicalInsurance = 1820, Stipend = 820 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E5", DepartmentType = DepartmentType.Finance, BasicSalary = 52000, DearnessAllowance = 5200, HRA = 7200, ConveyanceAllowance = 4200, EntertainmentAllowance = 3200, MedicalInsurance = 1920, Stipend = 920 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E1", DepartmentType = DepartmentType.Marketing, BasicSalary = 33000, DearnessAllowance = 3300, HRA = 5300, ConveyanceAllowance = 2300, EntertainmentAllowance = 1300, MedicalInsurance = 1530, Stipend = 530 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E2", DepartmentType = DepartmentType.Marketing, BasicSalary = 38000, DearnessAllowance = 3800, HRA = 5800, ConveyanceAllowance = 2800, EntertainmentAllowance = 1800, MedicalInsurance = 1630, Stipend = 630 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E3", DepartmentType = DepartmentType.Marketing, BasicSalary = 43000, DearnessAllowance = 4300, HRA = 6300, ConveyanceAllowance = 3300, EntertainmentAllowance = 2300, MedicalInsurance = 1730, Stipend = 730 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E4", DepartmentType = DepartmentType.Marketing, BasicSalary = 48000, DearnessAllowance = 4800, HRA = 6800, ConveyanceAllowance = 3800, EntertainmentAllowance = 2800, MedicalInsurance = 1830, Stipend = 830 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E5", DepartmentType = DepartmentType.Marketing, BasicSalary = 53000, DearnessAllowance = 5300, HRA = 7300, ConveyanceAllowance = 4300, EntertainmentAllowance = 3300, MedicalInsurance = 1930, Stipend = 930 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E1", DepartmentType = DepartmentType.Sales, BasicSalary = 34000, DearnessAllowance = 3400, HRA = 5400, ConveyanceAllowance = 2400, EntertainmentAllowance = 1400, MedicalInsurance = 1540, Stipend = 540 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E2", DepartmentType = DepartmentType.Sales, BasicSalary = 39000, DearnessAllowance = 3900, HRA = 5900, ConveyanceAllowance = 2900, EntertainmentAllowance = 1900, MedicalInsurance = 1640, Stipend = 640 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E3", DepartmentType = DepartmentType.Sales, BasicSalary = 44000, DearnessAllowance = 4400, HRA = 6400, ConveyanceAllowance = 3400, EntertainmentAllowance = 2400, MedicalInsurance = 1740, Stipend = 740 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E4", DepartmentType = DepartmentType.Sales, BasicSalary = 49000, DearnessAllowance = 4900, HRA = 6900, ConveyanceAllowance = 3900, EntertainmentAllowance = 2900, MedicalInsurance = 1840, Stipend = 840 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E5", DepartmentType = DepartmentType.Sales, BasicSalary = 54000, DearnessAllowance = 5400, HRA = 7400, ConveyanceAllowance = 4400, EntertainmentAllowance = 3400, MedicalInsurance = 1940, Stipend = 940 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E1", DepartmentType = DepartmentType.IT, BasicSalary = 35000, DearnessAllowance = 3500, HRA = 5500, ConveyanceAllowance = 2500, EntertainmentAllowance = 1500, MedicalInsurance = 1550, Stipend = 550 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E2", DepartmentType = DepartmentType.IT, BasicSalary = 40000, DearnessAllowance = 4000, HRA = 6000, ConveyanceAllowance = 3000, EntertainmentAllowance = 2000, MedicalInsurance = 1650, Stipend = 650 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E3", DepartmentType = DepartmentType.IT, BasicSalary = 45000, DearnessAllowance = 4500, HRA = 6500, ConveyanceAllowance = 3500, EntertainmentAllowance = 2500, MedicalInsurance = 1750, Stipend = 750 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E4", DepartmentType = DepartmentType.IT, BasicSalary = 50000, DearnessAllowance = 5000, HRA = 7000, ConveyanceAllowance = 4000, EntertainmentAllowance = 3000, MedicalInsurance = 1850, Stipend = 850 },
            new BandSalary { Id = Guid.NewGuid(), Band = "E5", DepartmentType = DepartmentType.IT, BasicSalary = 55000, DearnessAllowance = 5500, HRA = 7500, ConveyanceAllowance = 4500, EntertainmentAllowance = 3500, MedicalInsurance = 1950, Stipend = 950 }
        );



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
