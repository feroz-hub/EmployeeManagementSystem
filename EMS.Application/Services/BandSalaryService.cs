using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Application.Services;

public class BandSalaryService(IUnitOfWork unitOfWork):IBandSalaryService
{
    public async Task<IEnumerable<BandSalary>> GetAllBandSalaries()
    {
        return await unitOfWork.BandSalaryRepository.GetAllAsync();
    }

    public async Task<BandSalary> GetBandSalaryById(Guid id)
    {
        return await unitOfWork.BandSalaryRepository.GetByIdAsync(id);
    }

    public async Task AddBandSalary(BandSalary bandSalary)
    {
        await unitOfWork.BandSalaryRepository.AddAsync(bandSalary);
        await unitOfWork.CompleteAsync();
    }

    public async Task UpdateBandSalary(BandSalary bandSalary)
    {
        await unitOfWork.BandSalaryRepository.UpdateAsync(bandSalary);
        await unitOfWork.CompleteAsync();
    }

    public async Task<bool> DeleteBandSalary(Guid id)
    {
        return await unitOfWork.BandSalaryRepository.DeleteAsync(id);
    }
}