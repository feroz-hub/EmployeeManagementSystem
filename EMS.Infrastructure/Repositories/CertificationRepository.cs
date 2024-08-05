using EMS.Infrastructure.Data;
using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Infrastructure.Repositories;

public class CertificationRepository(ApplicationDbContext context) :GenericRepository<Certification>(context),ICertificationRepository
{
    
}