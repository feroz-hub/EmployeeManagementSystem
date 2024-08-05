namespace EMS.Infrastructure.Repositories.Interfaces;

public interface IBandSalaryRepository:IGenericRepository<BandSalary>
{
    Task<BandSalary> GetBandSalaryByBandAndDepartment(string band, DepartmentType departmentType);
}