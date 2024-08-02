namespace EMS.Domain.Entities;

public  class Employee
{
    [Key]
    // Unique identifier for the employee
    public Guid Id { get; set; }
    // Name of the employee
    public string Name { get; set; }
    [ForeignKey("EmployeeType")]
    public Guid EmployeeTypeId  { get; set; }
    public EmployeeType EmployeeType { get; set; }
    public PersonalDetails PersonalDetails { get; set; }
    
    // List of qualifications the employee has
    public List<Qualification> Qualifications { get; set; }
    
    // List of work experiences the employee has
    public List<Experience> Experiences { get; set; }
    
    // List of government documents associated with the employee
    public List<GovernmentDocument> GovernmentDocuments { get; set; }
    
    // List of certifications the employee holds
    public List<Certification> Certifications { get; set; }
    public decimal Salary { get; set; }
}
public enum EmpTypes
{
    Permanent,
    Temporary,
    Retailer,
    Intern
}