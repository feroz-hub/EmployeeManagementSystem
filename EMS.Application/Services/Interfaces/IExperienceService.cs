using EMS.Domain.Models;

namespace EMS.Application.Services.Interfaces;

public interface IExperienceService
{
    Task<IEnumerable<Experience>> GetExperiencesByEmployeeIdAsync(Guid employeeId);
    Task<Experience> GetExperienceByIdAsync(Guid id);
    Task AddExperienceAsync(Guid EmployeeId,ExperienceModel experience);
    Task UpdateExperienceAsync(Guid EmployeeId,ExperienceModel experience);
    Task<bool> DeleteExperienceAsync(Guid id);
}