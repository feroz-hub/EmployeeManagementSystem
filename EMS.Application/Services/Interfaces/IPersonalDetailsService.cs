namespace EMS.Application.Services.Interfaces;

public interface IPersonalDetailsService
{
    Task<PersonalDetails> GetPersonalDetailsByEmployeeIdAsync(Guid employeeId);
    Task UpdatePersonalDetailsAsync(PersonalDetails personalDetails);
    Task AddPersonalDetailsAsync( PersonalDetails personalDetails);
    Task<bool> DeletePersonalDetailsAsync(Guid employeeId);
}