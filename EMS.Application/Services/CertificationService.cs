using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Application.Services;

public class CertificationService(IUnitOfWork unitOfWork):ICertificationService
{
    public async Task<IEnumerable<Certification>> GetCertificationsByEmployeeIdAsync(Guid employeeId) => (await unitOfWork.Certifications.GetAllAsync()).Where(c => c.EmployeeId == employeeId);

    public async Task<Certification> GetCertificationByIdAsync(Guid id)
    {
        return await unitOfWork.Certifications.GetByIdAsync(id);
    }

    public async Task AddCertificationAsync(Certification certification)
    {
        await unitOfWork.Certifications.AddAsync(certification);
        await unitOfWork.CompleteAsync();
    }

    public async Task UpdateCertificationAsync(Certification certification)
    {
        await unitOfWork.Certifications.UpdateAsync(certification);
        await unitOfWork.CompleteAsync();
    }

    public async Task<bool> DeleteCertificationAsync(Guid id)
    {
        return await unitOfWork.Certifications.DeleteAsync(id);
    }
}