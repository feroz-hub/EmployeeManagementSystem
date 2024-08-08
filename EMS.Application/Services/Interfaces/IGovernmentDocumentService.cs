using EMS.Domain.Models;

namespace EMS.Application.Services.Interfaces;

public interface IGovernmentDocumentService
{
    Task<IEnumerable<GovernmentDocumentModel>> GetGovernmentDocumentsByEmployeeIdAsync(Guid employeeId);
    Task<GovernmentDocumentModel> GetGovernmentDocumentByIdAsync(Guid id);
    Task AddGovernmentDocumentAsync(Guid employeeId,GovernmentDocumentModel governmentDocumentModel);
    Task UpdateGovernmentDocumentAsync(Guid governmentDocumentId,GovernmentDocumentModel governmentDocumentModel);
    Task<bool> DeleteGovernmentDocumentAsync(Guid id);
}