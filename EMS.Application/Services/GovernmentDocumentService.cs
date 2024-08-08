using AutoMapper;
using EMS.Domain.Models;

namespace EMS.Application.Services;

public class GovernmentDocumentService(IUnitOfWork unitOfWork,IMapper mapper):IGovernmentDocumentService
{
    public async Task<IEnumerable<GovernmentDocumentModel>> GetGovernmentDocumentsByEmployeeIdAsync(Guid employeeId)
    {
        var governmentDocuments= (await unitOfWork.GovernmentDocuments.GetAllAsync()).Where(e => e.EmployeeId == employeeId);
        return mapper.Map<IEnumerable<GovernmentDocumentModel>>(governmentDocuments);
    }

    public async Task<GovernmentDocumentModel> GetGovernmentDocumentByIdAsync(Guid id)
    {
        return mapper.Map<GovernmentDocumentModel> (await unitOfWork.GovernmentDocuments.GetByIdAsync(id));
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