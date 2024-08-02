namespace EMS.Domain.Entities;

public class Employee
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    [ForeignKey("EmployeeType")]
    public Guid EmployeeTypeId { get; set; }

    public EmployeeType EmployeeType { get; set; }

    [ForeignKey("PersonalDetails")]
    public Guid PersonalDetailsId { get; set; }

    [Required]
    public PersonalDetails PersonalDetails { get; set; }

    public ICollection<Qualification> Qualifications { get; set; }
    
    public ICollection<Experience> Experiences { get; set; }
    
    public ICollection<GovernmentDocument> GovernmentDocuments { get; set; }
    
    public ICollection<Certification> Certifications { get; set; }

    public decimal Salary { get; set; }
}

