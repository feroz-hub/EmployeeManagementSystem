namespace EMS.Domain.Models;

public class EmployeeModel
{
    public Guid EmployeeId { get; set; }
    public string Name { get; set; }
    public EmployeeType EmployeeType { get; set; }
    public DepartmentType DepartmentType { get; set; }
    public PersonalDetailsModel? PersonalDetails { get; set; }
    public List<QualificationModel>? Qualifications { get; set; }
    public List<ExperienceModel>? Experiences { get; set; }
    public List<GovernmentDocumentModel>? GovernmentDocuments { get; set; }
    public List<CertificationModel>? Certifications { get; set; }
}