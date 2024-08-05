namespace EMS.Application.Services.Interfaces;

public interface IExperienceService
{
    Task<IEnumerable<Experience>> GetExperiencesByEmployeeIdAsync(Guid employeeId);
    Task<Experience> GetExperienceByIdAsync(Guid id);
    Task AddExperienceAsync(Experience experience);
    Task UpdateExperienceAsync(Experience experience);
    Task<bool> DeleteExperienceAsync(Guid id);
}