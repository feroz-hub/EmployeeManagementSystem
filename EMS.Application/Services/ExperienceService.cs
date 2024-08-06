using AutoMapper;
using EMS.Domain.Models;

namespace EMS.Application.Services;

public class ExperienceService(IUnitOfWork unitOfWork,IMapper mapper):IExperienceService
{
    public async Task<IEnumerable<Experience>> GetExperiencesByEmployeeIdAsync(Guid employeeId)
    {
        return (await unitOfWork.Experiences.GetAllAsync()).Where(e => e.EmployeeId == employeeId);
    }

    public async Task<Experience> GetExperienceByIdAsync(Guid id)
    {
        return await unitOfWork.Experiences.GetByIdAsync(id);
    }
    

    public async Task AddExperienceAsync(Guid employeeId,ExperienceModel experienceModel)
    {
        // Check if the employee exists
        var employee = await unitOfWork.Employees.GetByIdAsync(employeeId);
        if (employee == null)
        {
            throw new Exception("Employee does not exist.");
        }

        var experience = new Experience()
        {
            EmployeeId = employeeId,
            ExperienceId = Guid.NewGuid(),
            CompanyName = experienceModel.CompanyName,
            JobTitle = experienceModel.JobTitle,
            StartDate = experienceModel.StartDate,
            EndDate = experienceModel.EndDate,
            Responsibilities = experienceModel.Responsibilities
        };
        
        await unitOfWork.Experiences.AddAsync(experience);
        employee.SetBand();
        await unitOfWork.Employees.UpdateAsync(employee);
        await unitOfWork.CompleteAsync();
    }

    public async Task UpdateExperienceAsync(Guid experienceId,ExperienceModel experienceModel)
    {
        var experience = await unitOfWork.Experiences.GetByIdAsync(experienceId);
        if (experience == null)
        {
            throw new Exception("Experience not found");
        }

        mapper.Map(experienceModel, experience);
        await unitOfWork.Experiences.UpdateAsync(experience);
        var employeeId = experience.EmployeeId;
        // Check if the employee exists
        var employee = await unitOfWork.Employees.GetByIdAsync(employeeId);
        if (employee == null)
        {
            throw new Exception("Employee does not exist.");
        }
        employee.SetBand();
        await unitOfWork.Employees.UpdateAsync(employee);
        await unitOfWork.CompleteAsync();
    }

    public async Task<bool> DeleteExperienceAsync(Guid id)
    {
        return await unitOfWork.Experiences.DeleteAsync(id);
    }
}