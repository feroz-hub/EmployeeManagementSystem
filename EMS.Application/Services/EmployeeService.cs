using EMS.Domain.Models;
using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Application.Services;

public class EmployeeService(IUnitOfWork unitOfWork) : IEmployeeService
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
         var employee = new Employee
    {
        EmployeeId = Guid.NewGuid(),
        Name = employeeModel.Name,
        EmployeeTypeId = employeeModel.EmployeeTypeId,
        PersonalDetails = new PersonalDetails
        {
            EmployeeId = Guid.NewGuid(), // Ensure to set the correct ID
            Address = employeeModel.PersonalDetails.Address,
            PhoneNumber = employeeModel.PersonalDetails.PhoneNumber,
            Email = employeeModel.PersonalDetails.Email,
            DateOfBirth = employeeModel.PersonalDetails.DateOfBirth
        },
        Qualifications = employeeModel.Qualifications.Select(q => new Qualification
        {
            QualificationId = Guid.NewGuid(),
            EmployeeId = Guid.NewGuid(), // Ensure to set the correct ID
            Degree = q.Degree,
            Institution = q.Institution,
            GraduationDate = q.GraduationDate,
            Grade = q.Grade
        }).ToList(),
        Experiences = employeeModel.Experiences.Select(e => new Experience
        {
            ExperienceId = Guid.NewGuid(),
            EmployeeId = Guid.NewGuid(), // Ensure to set the correct ID
            CompanyName = e.CompanyName,
            JobTitle = e.JobTitle,
            StartDate = e.StartDate,
            EndDate = e.EndDate,
            Responsibilities = e.Responsibilities
        }).ToList(),
        GovernmentDocuments = employeeModel.GovernmentDocuments.Select(g => new GovernmentDocument
        {
            DocumentId = Guid.NewGuid(),
            EmployeeId = Guid.NewGuid(), // Ensure to set the correct ID
            DocumentType = g.DocumentType,
            DocumentNumber = g.DocumentNumber,
            IssueDate = g.IssueDate,
            ExpiryDate = g.ExpiryDate
        }).ToList(),
        Certifications = employeeModel.Certifications.Select(c => new Certification
        {
            CertificationId = Guid.NewGuid(),
            EmployeeId = Guid.NewGuid(), // Ensure to set the correct ID
            CertificationName = c.CertificationName,
            IssuingOrganization = c.IssuingOrganization,
            IssueDate = c.IssueDate,
            ExpiryDate = c.ExpiryDate
        }).ToList(),
        Leaves = employeeModel.Leaves.Select(l => new Leave
        {
            Id = Guid.NewGuid(),
            EmployeeId = Guid.NewGuid(), // Ensure to set the correct ID
            StartDate = l.StartDate,
            EndDate = l.EndDate,
            Reason = l.Reason,
            Status = l.Status
        }).ToList(),
        DepartmentId = employeeModel.DepartmentId,
        EmployeeSalary = new EmployeeSalary
        {
            EmployeeId = Guid.NewGuid(), // Ensure to set the correct ID
            NetSalary = 
                employeeModel.NetSalary,
            Band = employeeModel.Band,
            CalculatedOn = DateTime.Now
        }
    };
    employee.SetBand();
    await unitOfWork.Employees.AddAsync(employee);
    await unitOfWork.CompleteAsync();
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