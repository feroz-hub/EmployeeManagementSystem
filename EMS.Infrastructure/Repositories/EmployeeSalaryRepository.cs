using EMS.Infrastructure.Data;
using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Infrastructure.Repositories;

public class EmployeeSalaryRepository(ApplicationDbContext context) :GenericRepository<EmployeeSalary>(context),IEmployeeSalaryRepository
{
    
}