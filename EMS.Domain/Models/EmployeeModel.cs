namespace EMS.Domain.Models;

public class EmployeeModel
{
    public string Name { get; set; }
    public PersonalDetailsModel PersonalDetails { get; set; }
    public List<QualificationModel> Qualifications { get; set; }
    public List<ExperienceModel> Experiences { get; set; }
    public List<GovernmentDocumentModel> GovernmentDocuments { get; set; }
    public List<CertificationModel> Certifications { get; set; }
    public List<LeaveModel> Leaves { get; set; }
    public decimal NetSalary { get; set; }
    public string Band { get; set; }
}