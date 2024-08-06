using AutoMapper;
using EMS.Domain.Models;

namespace EMS.Application.Services;

public class GovernmentDocumentService(IUnitOfWork unitOfWork,IMapper mapper):IGovernmentDocumentService
{
    public async Task<IEnumerable<GovernmentDocument>> GetGovernmentDocumentsByEmployeeIdAsync(Guid employeeId)
    {
        return (await unitOfWork.GovernmentDocuments.GetAllAsync()).Where(e => e.EmployeeId == employeeId);
    }

    public async Task<GovernmentDocument> GetGovernmentDocumentByIdAsync(Guid id)
    {
        return await unitOfWork.GovernmentDocuments.GetByIdAsync(id);
    }

    public async Task AddGovernmentDocumentAsync(Guid employeeId,GovernmentDocumentModel governmentDocumentModel)
    {
        var employee = await unitOfWork.Employees.GetByIdAsync(employeeId);
        if (employee == null)
        {
            throw new Exception("Employee does not exist.");
        }
        var governmentDocument = new GovernmentDocument()
        {
            EmployeeId = employeeId,
            DocumentId = Guid.NewGuid(),
            DocumentType = governmentDocumentModel.DocumentType,
            DocumentNumber = governmentDocumentModel.DocumentNumber,
            IssueDate = governmentDocumentModel.IssueDate,
            ExpiryDate = governmentDocumentModel.ExpiryDate
        };
        await unitOfWork.GovernmentDocuments.AddAsync(governmentDocument);
        await unitOfWork.CompleteAsync();
    }

    public async Task UpdateGovernmentDocumentAsync(Guid governmentDocumentId,GovernmentDocumentModel governmentDocumentModel)
    {
        var governmentDocument = await unitOfWork.GovernmentDocuments.GetByIdAsync(governmentDocumentId);
        if (governmentDocument == null)
            throw new Exception("GovernmentDocument does not exist.");
        mapper.Map(governmentDocumentModel, governmentDocument);
        await unitOfWork.GovernmentDocuments.UpdateAsync(governmentDocument);
        await unitOfWork.CompleteAsync();
    }

    public async Task<bool> DeleteGovernmentDocumentAsync(Guid id)
    {
        return await unitOfWork.GovernmentDocuments.DeleteAsync(id);
        
    }
}