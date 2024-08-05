namespace EMS.Application.Services.Interfaces;

public interface IGovernmentDocumentService
{
    Task<IEnumerable<GovernmentDocument>> GetGovernmentDocumentsByEmployeeIdAsync(Guid employeeId);
    Task<GovernmentDocument> GetGovernmentDocumentByIdAsync(Guid id);
    Task AddGovernmentDocumentAsync(GovernmentDocument document);
    Task UpdateGovernmentDocumentAsync(GovernmentDocument document);
    Task<bool> DeleteGovernmentDocumentAsync(Guid id);
}