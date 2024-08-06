using EMS.Domain.Models;

namespace EMS.Application.Services.Interfaces;

public interface IGovernmentDocumentService
{
    Task<IEnumerable<GovernmentDocument>> GetGovernmentDocumentsByEmployeeIdAsync(Guid employeeId);
    Task<GovernmentDocument> GetGovernmentDocumentByIdAsync(Guid id);
    Task AddGovernmentDocumentAsync(Guid employeeId,GovernmentDocumentModel governmentDocumentModel);
    Task UpdateGovernmentDocumentAsync(Guid governmentDocumentId,GovernmentDocumentModel governmentDocumentModel);
    Task<bool> DeleteGovernmentDocumentAsync(Guid id);
}