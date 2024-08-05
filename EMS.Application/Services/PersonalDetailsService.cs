using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Application.Services;

public class PersonalDetailsService(IUnitOfWork unitOfWork):IPersonalDetailsService
{
    public async Task<PersonalDetails> GetPersonalDetailsByEmployeeIdAsync(Guid employeeId)
    {
        return await unitOfWork.PersonalDetails.GetByIdAsync(employeeId);
    }

    public async Task UpdatePersonalDetailsAsync(PersonalDetails personalDetails)
    {
        await unitOfWork.PersonalDetails.UpdateAsync(personalDetails);
        await unitOfWork.CompleteAsync();
    }

    public async Task AddPersonalDetailsAsync( PersonalDetails personalDetails)
    {
        await unitOfWork.PersonalDetails.AddAsync(personalDetails);
        await unitOfWork.CompleteAsync();
    }

    public async Task<bool> DeletePersonalDetailsAsync(Guid employeeId)
    {
        return await unitOfWork.PersonalDetails.DeleteAsync(employeeId);
    }
}