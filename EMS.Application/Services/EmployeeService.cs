using AutoMapper;
using EMS.Domain.Models;
using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Application.Services;

public class EmployeeService(IUnitOfWork unitOfWork,IMapper mapper) : IEmployeeService
{
    public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
    {
        return await unitOfWork.Employees.GetAllAsync();
    }
    public async Task<Employee> GetEmployeeByIdAsync(Guid id)
    {
       return await unitOfWork.Employees.GetByIdAsync(id);
    }

    public async Task AddEmployeeAsync(EmployeeModel employeeModel)
    {
       
        // Generate a new EmployeeId
        var employeeId = Guid.NewGuid();

        // Map EmployeeDto to Employee entity and set the EmployeeId
        var employeeData = mapper.Map<Employee>(employeeModel);
        employeeData.EmployeeId = employeeId;

        // Set the EmployeeId for related entities
        if (employeeModel.PersonalDetails != null)
        {
            employeeModel.PersonalDetails.EmployeeId = employeeId;
            var personalDetails = mapper.Map<PersonalDetails>(employeeModel.PersonalDetails);
            await unitOfWork.PersonalDetails.AddAsync(personalDetails);
        }

        if (employeeModel.Qualifications != null)
        {
            foreach (var qualificationDto in employeeModel.Qualifications)
            {
                qualificationDto.EmployeeId = employeeId;
                var qualification = mapper.Map<Qualification>(qualificationDto);
                await unitOfWork.Qualifications.AddAsync(qualification);
            }
        }

        if (employeeModel.Experiences != null)
        {
            foreach (var experienceDto in employeeModel.Experiences)
            {
                experienceDto.EmployeeId = employeeId;
                var experience = mapper.Map<Experience>(experienceDto);
                await unitOfWork.Experiences.AddAsync(experience);
            }
        }

        if (employeeModel.GovernmentDocuments != null)
        {
            foreach (var documentDto in employeeModel.GovernmentDocuments)
            {
                documentDto.EmployeeId = employeeId;
                var document = mapper.Map<GovernmentDocument>(documentDto);
                await unitOfWork.GovernmentDocuments.AddAsync(document);
            }
        }

        if (employeeModel.Certifications != null)
        {
            foreach (var certificationDto in employeeModel.Certifications)
            {
                certificationDto.EmployeeId = employeeId;
                var certification = mapper.Map<Certification>(certificationDto);
                await unitOfWork.Certifications.AddAsync(certification);
            }
        }

        if (employeeModel.Leaves != null)
        {
            foreach (var leaveDto in employeeModel.Leaves)
            {
                leaveDto.EmployeeId = employeeId;
                var leave = mapper.Map<Leave>(leaveDto);
                await unitOfWork.Leaves.AddAsync(leave);
            }
        }

        // Add the Employee entity
        await unitOfWork.Employees.AddAsync(employeeData);
    }

    public async Task UpdateEmployeeAsync(Employee employee)
    {
        await unitOfWork.Employees.UpdateAsync(employee);
        await unitOfWork.CompleteAsync();
    }

    public async Task<bool> DeleteEmployeeAsync(Guid id)
    {
      return  await unitOfWork.Employees.DeleteAsync(id);
    }
}