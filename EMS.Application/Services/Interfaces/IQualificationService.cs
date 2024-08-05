namespace EMS.Application.Services.Interfaces;

public interface IQualificationService
{
    Task<IEnumerable<Qualification>> GetQualificationsByEmployeeIdAsync(Guid employeeId);
    Task<Qualification> GetQualificationByIdAsync(Guid id);
    Task AddQualificationAsync(Qualification qualification);
    Task UpdateQualificationAsync(Qualification qualification);
    Task<bool> DeleteQualificationAsync(Guid id);
}