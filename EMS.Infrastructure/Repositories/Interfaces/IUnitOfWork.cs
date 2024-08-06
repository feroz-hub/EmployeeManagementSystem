namespace EMS.Infrastructure.Repositories.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IEmployeeRepository Employees { get; }
    IPersonalDetailsRepository PersonalDetails { get; }
    ICertificationRepository Certifications { get; }
    IExperienceRepository Experiences { get; }
    IQualificationRepository Qualifications { get; }
    IGovernmentDocumentsRepository GovernmentDocuments { get; }
    ILeaveRepository Leaves { get; }
    IBandSalaryRepository BandSalary { get; }
    IEmployeeSalaryRepository EmployeeSalary { get; }
    Task<int> CompleteAsync();
}