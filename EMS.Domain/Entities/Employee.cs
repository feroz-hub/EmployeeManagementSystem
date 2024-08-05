using EMS.Domain.Enums;

namespace EMS.Domain.Entities;

public class Employee
{
    public Guid EmployeeId { get; set; }
    public string Name { get; set; }
    public EmployeeType EmployeeType { get; set; }
    public PersonalDetails PersonalDetails { get; set; }
    public ICollection<Qualification> Qualifications { get; set; }
    public ICollection<Experience> Experiences { get; set; }
    public ICollection<GovernmentDocument> GovernmentDocuments { get; set; }
    public ICollection<Certification> Certifications { get; set; }
    public ICollection<Leave> Leaves { get; set; }
    public DepartmentType DepartmentType { get; set; }
    public EmployeeSalary EmployeeSalary { get; set; }
    public string Band { get; set; }
    public void SetBand()
    {
        var totalExperienceYears = Experiences?.Sum(e => (e.EndDate ?? DateTime.Now).Year - e.StartDate.Year) ?? 0;
        
        Band =totalExperienceYears switch
        {
            < 2 => "E1",
            >= 2 and < 5 => "E2",
            >= 5 and < 10 => "E3",
            >= 10 and < 15 => "E4",
            _ => "E5"
        };
    }
   

}

