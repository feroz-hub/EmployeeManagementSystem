namespace EMS.Infrastructure.Repositories.Interfaces;

public interface IGenericRepository<T> where T:class
{
    public Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(Guid id);
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<bool> DeleteAsync(Guid id);
}