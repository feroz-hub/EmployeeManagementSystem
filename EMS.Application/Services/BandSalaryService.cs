namespace EMS.Application.Services;

public class BandSalaryService(IUnitOfWork unitOfWork):IBandSalaryService
{
    public async Task<IEnumerable<BandSalary>> GetAllBandSalaries()
    {
        return await unitOfWork.BandSalary.GetAllAsync();
    }

    public async Task<BandSalary> GetBandSalaryById(Guid id)
    {
        return await unitOfWork.BandSalary.GetByIdAsync(id);
    }

    public async Task AddBandSalary(BandSalary bandSalary)
    {
        await unitOfWork.BandSalary.AddAsync(bandSalary);
        await unitOfWork.CompleteAsync();
    }

    public async Task UpdateBandSalary(BandSalary bandSalary)
    {
        await unitOfWork.BandSalary.UpdateAsync(bandSalary);
        await unitOfWork.CompleteAsync();
    }

    public async Task<bool> DeleteBandSalary(Guid id)
    {
        return await unitOfWork.BandSalary.DeleteAsync(id);
    }
}