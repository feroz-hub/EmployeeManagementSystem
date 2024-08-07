using EMS.Domain.Models;

namespace EMS.Infrastructure.Repositories.Interfaces;

public interface ICertificationRepository:IGenericRepository<Certification>
{
    Task<IEnumerable<Certification>> UpcomingCertificationExpiry();
}