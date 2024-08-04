namespace EMS.Domain.Entities;

public class Employee
{
    public Guid EmployeeId { get; set; }
    public string Name { get; set; }
    public Guid EmployeeTypeId { get; set; }

    public EmployeeType EmployeeType { get; set; }
    public PersonalDetails PersonalDetails { get; set; }
    public ICollection<Qualification> Qualifications { get; set; }
    public ICollection<Experience> Experiences { get; set; }
    public ICollection<GovernmentDocument> GovernmentDocuments { get; set; }
    public ICollection<Certification> Certifications { get; set; }
}

