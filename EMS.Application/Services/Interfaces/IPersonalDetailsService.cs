using EMS.Domain.Models;

namespace EMS.Application.Services.Interfaces;

public interface IPersonalDetailsService
{
    Task<PersonalDetailsModel> GetPersonalDetailsByEmployeeIdAsync(Guid employeeId);
    Task UpdatePersonalDetailsAsync(Guid employeeId,PersonalDetailsModel personalDetails);
    Task AddPersonalDetailsAsync(Guid employeeId, PersonalDetailsModel personalDetails);
    Task<bool> DeletePersonalDetailsAsync(Guid employeeId);
}