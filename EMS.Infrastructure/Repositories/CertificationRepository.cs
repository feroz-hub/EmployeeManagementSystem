using EMS.Domain.Models;
using EMS.Infrastructure.Data;
using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Infrastructure.Repositories;

public class CertificationRepository(ApplicationDbContext context) :GenericRepository<Certification>(context),ICertificationRepository
{
    public async Task<IEnumerable<Certification>> UpcomingCertificationExpiry()
    {
        DateTime expiryThreshold = DateTime.Now.AddDays(30);
        return await context.Certifications
            .Where(c => c.ExpiryDate <= expiryThreshold).ToListAsync();
    }
}