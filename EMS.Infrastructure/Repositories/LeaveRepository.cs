using EMS.Infrastructure.Data;
using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Infrastructure.Repositories;

public class LeaveRepository(ApplicationDbContext context) :GenericRepository<Leave>(context),ILeaveRepository
{
    
}