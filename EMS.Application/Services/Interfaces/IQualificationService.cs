using EMS.Domain.Models;

namespace EMS.Application.Services.Interfaces;

public interface IQualificationService
{
    Task<IEnumerable<QualificationModel>> GetQualificationsByEmployeeIdAsync(Guid employeeId);
    Task<QualificationModel> GetQualificationByIdAsync(Guid id);
    Task AddQualificationAsync(Guid employeeId,QualificationModel qualificationModel);
    Task UpdateQualificationAsync(Guid qualificationId,QualificationModel qualificationModel);
    Task<bool> DeleteQualificationAsync(Guid id);
}