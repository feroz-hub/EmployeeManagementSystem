namespace EMS.Application.Services.Interfaces;

public interface IBandSalaryService
{
    Task<IEnumerable<BandSalary>> GetAllBandSalaries();
    Task<BandSalary> GetBandSalaryById(Guid id);
    Task AddBandSalary(BandSalary bandSalary);
    Task UpdateBandSalary(BandSalary bandSalary);
    Task<bool> DeleteBandSalary(Guid id);
}