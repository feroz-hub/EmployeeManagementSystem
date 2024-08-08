using AutoMapper;
using EMS.Domain.Models;

namespace EMS.Application.Services;

public class PersonalDetailsService(IUnitOfWork unitOfWork,IMapper mapper):IPersonalDetailsService
{
    public async Task<PersonalDetailsModel> GetPersonalDetailsByEmployeeIdAsync(Guid employeeId)
    {
        return mapper.Map<PersonalDetailsModel>(await unitOfWork.PersonalDetails.GetByIdAsync(employeeId));
    }

    public async Task UpdatePersonalDetailsAsync(Guid employeeId, PersonalDetailsModel personalDetails)
    {
        // Check if the employee exists
        var employee = await unitOfWork.Employees.GetByIdAsync(employeeId);
        if (employee == null)
        {
            throw new Exception("Employee does not exist.");
        }

        // Check if personal details for the employee already exist
        var existingPersonalDetails = await unitOfWork.PersonalDetails.GetByIdAsync(employeeId);

        if (existingPersonalDetails != null)
        {
            // Update existing personal details
            existingPersonalDetails.Address = personalDetails.Address;
            existingPersonalDetails.PhoneNumber = personalDetails.PhoneNumber;
            existingPersonalDetails.Email = personalDetails.Email;
            existingPersonalDetails.DateOfBirth = personalDetails.DateOfBirth;

            unitOfWork.PersonalDetails.UpdateAsync(existingPersonalDetails);
            await unitOfWork.CompleteAsync();
        }
        else
        {
            throw new Exception("Personal details do not exist for the employee.");
        }
    }


    public async Task AddPersonalDetailsAsync(Guid employeeId, PersonalDetailsModel personalDetails)
    {
        // Check if the employee exists
        var employee = await unitOfWork.Employees.GetByIdAsync(employeeId);
        if (employee == null)
        {
            throw new Exception("Employee does not exist.");
        }

        // Check if personal details for the employee already exist
        var existingPersonalDetails = await unitOfWork.PersonalDetails.GetByIdAsync(employeeId);

        if (existingPersonalDetails != null)
        {
            // Update existing personal details
            existingPersonalDetails.Address = personalDetails.Address;
            existingPersonalDetails.PhoneNumber = personalDetails.PhoneNumber;
            existingPersonalDetails.Email = personalDetails.Email;
            existingPersonalDetails.DateOfBirth = personalDetails.DateOfBirth;

            unitOfWork.PersonalDetails.UpdateAsync(existingPersonalDetails);
        }
        else
        {
            // Add new personal details
            var newPersonalDetails = new PersonalDetails
            {
                EmployeeId = employeeId,
                Address = personalDetails.Address,
                PhoneNumber = personalDetails.PhoneNumber,
                Email = personalDetails.Email,
                DateOfBirth = personalDetails.DateOfBirth
            };

            await unitOfWork.PersonalDetails.AddAsync(newPersonalDetails);
        }

        await unitOfWork.CompleteAsync();
    }


    public async Task<bool> DeletePersonalDetailsAsync(Guid employeeId)
    {
        return await unitOfWork.PersonalDetails.DeleteAsync(employeeId);
    }
}