using EMS.Domain.Models;

namespace EMS.Application.Services.Interfaces;

public interface ICertificationService
{
    Task<IEnumerable<CertificationModel>> GetCertificationsByEmployeeIdAsync(Guid employeeId);
    Task<CertificationModel> GetCertificationByIdAsync(Guid id);
    Task AddCertificationAsync(Guid EmployeeId,CertificationModel certification);
    Task UpdateCertificationAsync(Guid CertificationId,CertificationModel certification);
    Task<bool> DeleteCertificationAsync(Guid id);
    Task<List<UpcomingCertificationExpiryModel>> GetUpcomingCertificateExpiry();
}