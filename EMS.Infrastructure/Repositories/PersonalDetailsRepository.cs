using EMS.Infrastructure.Data;
using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Infrastructure.Repositories;

public class PersonalDetailsRepository(ApplicationDbContext context) :GenericRepository<PersonalDetails>(context),IPersonalDetailsRepository
{
    
}