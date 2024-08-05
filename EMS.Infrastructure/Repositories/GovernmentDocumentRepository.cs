using EMS.Infrastructure.Data;
using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Infrastructure.Repositories;

public class GovernmentDocumentRepository(ApplicationDbContext context) :GenericRepository<GovernmentDocument>(context),IGovernmentDocumentsRepository
{
    
}