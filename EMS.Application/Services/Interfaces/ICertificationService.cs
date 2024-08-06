using EMS.Domain.Models;

namespace EMS.Application.Services.Interfaces;

public interface ICertificationService
{
    Task<IEnumerable<Certification>> GetCertificationsByEmployeeIdAsync(Guid employeeId);
    Task<Certification> GetCertificationByIdAsync(Guid id);
    Task AddCertificationAsync(Guid EmployeeId,CertificationModel certification);
    Task UpdateCertificationAsync(Guid CertificationId,CertificationModel certification);
    Task<bool> DeleteCertificationAsync(Guid id);
}