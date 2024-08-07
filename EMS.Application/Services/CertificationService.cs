using AutoMapper;
using EMS.Domain.Models;

namespace EMS.Application.Services;

public class CertificationService(IUnitOfWork unitOfWork,IMapper mapper):ICertificationService
{
    public async Task<IEnumerable<CertificationModel>> GetCertificationsByEmployeeIdAsync(Guid employeeId)
    {
        var certificates= (await unitOfWork.Certifications.GetAllAsync()).Where(c => c.EmployeeId == employeeId);
        var certificateModel = mapper.Map<IEnumerable<CertificationModel>>(certificates);
        return certificateModel;
    }
    

    public async Task<CertificationModel> GetCertificationByIdAsync(Guid id)
    {
        var certificate= await unitOfWork.Certifications.GetByIdAsync(id);
        var certificateModel = mapper.Map<CertificationModel>(certificate);
        return certificateModel;
    }

    public async Task AddCertificationAsync(Guid employeeId,CertificationModel certificationModel)
    { // Check if the employee exists
        var employee = await unitOfWork.Employees.GetByIdAsync(employeeId);
        if (employee == null)
        {
            throw new Exception("Employee does not exist.");
        }
        var certification = new Certification
        {
            EmployeeId = employeeId,
            CertificationId = Guid.NewGuid(),
            CertificationName = certificationModel.CertificationName,
             IssuingOrganization= certificationModel.IssuingOrganization,
            IssueDate = certificationModel.IssueDate,
            ExpiryDate = certificationModel.ExpiryDate
        };
        await unitOfWork.Certifications.AddAsync(certification);
        await unitOfWork.CompleteAsync();
    }

    public async Task UpdateCertificationAsync(Guid certificateId,CertificationModel certificationModel)
    {
        var certificate = await unitOfWork.Certifications.GetByIdAsync(certificateId);
        if (certificate == null)
            throw new Exception("Certificate does not exist.");
        mapper.Map(certificationModel, certificate);
        await unitOfWork.Certifications.UpdateAsync(certificate);
        await unitOfWork.CompleteAsync();
    }

    public async Task<bool> DeleteCertificationAsync(Guid id)
    {
        return await unitOfWork.Certifications.DeleteAsync(id);
    }
}