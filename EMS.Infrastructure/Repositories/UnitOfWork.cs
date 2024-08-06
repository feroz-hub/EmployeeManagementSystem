using EMS.Infrastructure.Data;
using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Infrastructure.Repositories;

public class UnitOfWork(ApplicationDbContext context):IUnitOfWork
{
    public void Dispose()
    {
        context.Dispose();
    }

    public IEmployeeRepository Employees { get; } = new EmployeeRepository(context);
    public IPersonalDetailsRepository PersonalDetails { get; }=new PersonalDetailsRepository(context);
    public ICertificationRepository Certifications { get; }=new CertificationRepository(context);
    public IExperienceRepository Experiences { get; }=new ExperienceRepository(context);
    public IQualificationRepository Qualifications { get; }=new QualificationRepository(context);
    public IGovernmentDocumentsRepository GovernmentDocuments { get; }=new GovernmentDocumentRepository(context);
    public ILeaveRepository Leaves { get; }=new LeaveRepository(context);
    public IBandSalaryRepository BandSalary { get; } = new BandSalaryRepository(context);
    public IEmployeeSalaryRepository EmployeeSalary { get; } = new EmployeeSalaryRepository(context);

    public async Task<int> CompleteAsync()
    {
        return await context.SaveChangesAsync();
    }
}