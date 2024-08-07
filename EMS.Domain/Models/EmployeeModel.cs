namespace EMS.Domain.Models;

public class EmployeeModel
{
    public Guid EmployeeId { get; set; }
    public string Name { get; set; }
    public EmployeeType EmployeeType { get; set; }
    public DepartmentType DepartmentType { get; set; }
    public PersonalDetailsModel? PersonalDetails { get; set; }
    public ICollection<QualificationModel>? Qualifications { get; set; }
    public ICollection<ExperienceModel>? Experiences { get; set; }
    public ICollection<GovernmentDocumentModel>? GovernmentDocuments { get; set; }
    public ICollection<CertificationModel>? Certifications { get; set; }
}