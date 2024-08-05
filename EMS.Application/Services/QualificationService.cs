using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Application.Services;

public class QualificationService(IUnitOfWork unitOfWork):IQualificationService
{
    public async Task<IEnumerable<Qualification>> GetQualificationsByEmployeeIdAsync(Guid employeeId)
    {
        return (await unitOfWork.Qualifications.GetAllAsync()).Where(e => e.EmployeeId == employeeId);
    }

    public async Task<Qualification> GetQualificationByIdAsync(Guid id)
    {
        return await unitOfWork.Qualifications.GetByIdAsync(id);
    }

    public async Task AddQualificationAsync(Qualification qualification)
    {
        await unitOfWork.Qualifications.AddAsync(qualification);
    }

    public async Task UpdateQualificationAsync(Qualification qualification)
    {
        await unitOfWork.Qualifications.UpdateAsync(qualification);
    }

    public async Task<bool> DeleteQualificationAsync(Guid id)
    {
        return await unitOfWork.Qualifications.DeleteAsync(id);
    }
}