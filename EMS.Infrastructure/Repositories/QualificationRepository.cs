using EMS.Infrastructure.Data;
using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Infrastructure.Repositories;

public class QualificationRepository(ApplicationDbContext context) :GenericRepository<Qualification>(context),IQualificationRepository{ }