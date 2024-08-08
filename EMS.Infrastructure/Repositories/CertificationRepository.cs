using EMS.Domain.Models;
using EMS.Infrastructure.Data;
using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Infrastructure.Repositories;

public class CertificationRepository(ApplicationDbContext context) :GenericRepository<Certification>(context),ICertificationRepository
{
    public async Task<List<UpcomingCertificationExpiryModel>> UpcomingCertificationExpiry()
    {
        DateTime expiryThreshold = DateTime.Now.AddDays(30);

        var upcomingCertifications = await (from certification in context.Certifications
                join employee in context.Employees
                    on certification.EmployeeId equals employee.EmployeeId
                where certification.ExpiryDate <= expiryThreshold
                select new UpcomingCertificationExpiryModel
                {
                    CertificationId = certification.CertificationId,
                    EmployeeId = certification.EmployeeId,
                    CertificationName = certification.CertificationName,
                    IssuingOrganization = certification.IssuingOrganization,
                    IssueDate = certification.IssueDate,
                    ExpiryDate = certification.ExpiryDate,
                    EmployeeName = employee.Name
                })
            .ToListAsync();

        return upcomingCertifications;
    }

}