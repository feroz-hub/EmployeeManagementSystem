using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Application.Services;

public class GovernmentDocumentService(IUnitOfWork unitOfWork):IGovernmentDocumentService
{
    public async Task<IEnumerable<GovernmentDocument>> GetGovernmentDocumentsByEmployeeIdAsync(Guid employeeId)
    {
        return (await unitOfWork.GovernmentDocuments.GetAllAsync()).Where(e => e.EmployeeId == employeeId);
    }

    public async Task<GovernmentDocument> GetGovernmentDocumentByIdAsync(Guid id)
    {
        return await unitOfWork.GovernmentDocuments.GetByIdAsync(id);
    }

    public async Task AddGovernmentDocumentAsync(GovernmentDocument document)
    {
        await unitOfWork.GovernmentDocuments.AddAsync(document);
        await unitOfWork.CompleteAsync();
    }

    public async Task UpdateGovernmentDocumentAsync(GovernmentDocument document)
    {
        await unitOfWork.GovernmentDocuments.UpdateAsync(document);
        await unitOfWork.CompleteAsync();
    }

    public async Task<bool> DeleteGovernmentDocumentAsync(Guid id)
    {
        return await unitOfWork.GovernmentDocuments.DeleteAsync(id);
        
    }
}