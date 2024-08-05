using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Application.Services;

public class ExperienceService(IUnitOfWork unitOfWork):IExperienceService
{
    public async Task<IEnumerable<Experience>> GetExperiencesByEmployeeIdAsync(Guid employeeId)
    {
        return (await unitOfWork.Experiences.GetAllAsync()).Where(e => e.EmployeeId == employeeId);
    }

    public async Task<Experience> GetExperienceByIdAsync(Guid id)
    {
        return await unitOfWork.Experiences.GetByIdAsync(id);
    }

    public async Task AddExperienceAsync(Experience experience)
    {
        await unitOfWork.Experiences.AddAsync(experience);
        await unitOfWork.CompleteAsync();
    }

    public async Task UpdateExperienceAsync(Experience experience)
    {
        await unitOfWork.Experiences.UpdateAsync(experience);
        await unitOfWork.CompleteAsync();
    }

    public async Task<bool> DeleteExperienceAsync(Guid id)
    {
        return await unitOfWork.Experiences.DeleteAsync(id);
    }
}