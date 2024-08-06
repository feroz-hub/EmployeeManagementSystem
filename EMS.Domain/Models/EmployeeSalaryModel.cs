namespace EMS.Domain.Models;

public class EmployeeSalaryModel
{
    public decimal NetSalary { get; set; }
    public string Band { get; set; }
    public DateTime CalculatedOn { get; set; }
}