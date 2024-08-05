using EMS.Infrastructure.Data;
using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Infrastructure.Repositories;

public class ExperienceRepository(ApplicationDbContext context) :GenericRepository<Experience>(context),IExperienceRepository
{
    
}