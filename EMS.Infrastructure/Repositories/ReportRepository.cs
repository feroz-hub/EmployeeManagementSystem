using EMS.Infrastructure.Data;
using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Infrastructure.Repositories;

public class ReportRepository(ApplicationDbContext context) :GenericRepository<Report>(context),IReportRepository{ }