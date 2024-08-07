using EMS.Domain.Models;

namespace EMS.Application.Services.Interfaces;

public interface IExperienceService
{
    Task<IEnumerable<ExperienceModel>> GetExperiencesByEmployeeIdAsync(Guid employeeId);
    Task<ExperienceModel> GetExperienceByIdAsync(Guid id);
    Task AddExperienceAsync(Guid EmployeeId,ExperienceModel experience);
    Task UpdateExperienceAsync(Guid experienceId,ExperienceModel experience);
    Task<bool> DeleteExperienceAsync(Guid id);
}