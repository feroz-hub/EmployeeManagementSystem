using AutoMapper;
using EMS.Domain.Models;

namespace EMS.Application.Services;

public class QualificationService(IUnitOfWork unitOfWork,IMapper mapper):IQualificationService
{
    public async Task<IEnumerable<QualificationModel>> GetQualificationsByEmployeeIdAsync(Guid employeeId)
    {
        var qualification= (await unitOfWork.Qualifications.GetAllAsync()).Where(e => e.EmployeeId == employeeId);
        return mapper.Map<IEnumerable<QualificationModel>>(qualification);
    }

    public async Task<QualificationModel> GetQualificationByIdAsync(Guid id)
    {
        var qualification= await unitOfWork.Qualifications.GetByIdAsync(id);
        return mapper.Map<QualificationModel>(qualification);
    }

    public async Task AddQualificationAsync(Guid employeeId,QualificationModel qualificationModel)
    {
        // Check if the employee exists
        var employee = await unitOfWork.Employees.GetByIdAsync(employeeId);
        if (employee == null)
        {
            throw new Exception("Employee does not exist.");
        }
        var qualification = new Qualification
        {
            EmployeeId = employeeId, 
            QualificationId = Guid.NewGuid(),
            Degree = qualificationModel.Degree,
            Grade = qualificationModel.Grade,
            Institution = qualificationModel.Institution,
            GraduationDate = qualificationModel.GraduationDate
        };
        //var qualification = mapper.Map<Qualification>(qualificationModel);
        await unitOfWork.Qualifications.AddAsync(qualification);
        await unitOfWork.CompleteAsync();
    }

    public async Task UpdateQualificationAsync(Guid qualificationId,QualificationModel qualificationModel)
    {
        var qualification = await unitOfWork.Qualifications.GetByIdAsync(qualificationId);
        if (qualification == null)
            throw new Exception("qualification does not exist.");
        mapper.Map(qualificationModel, qualification);
        await unitOfWork.Qualifications.UpdateAsync(qualification);
        await unitOfWork.CompleteAsync();
    }

    public async Task<bool> DeleteQualificationAsync(Guid id)
    {
        return await unitOfWork.Qualifications.DeleteAsync(id);
    }
}