namespace EMS.Application.Services.Interfaces;

public interface ICertificationService
{
    Task<IEnumerable<Certification>> GetCertificationsByEmployeeIdAsync(Guid employeeId);
    Task<Certification> GetCertificationByIdAsync(Guid id);
    Task AddCertificationAsync(Certification certification);
    Task UpdateCertificationAsync(Certification certification);
    Task<bool> DeleteCertificationAsync(Guid id);
}