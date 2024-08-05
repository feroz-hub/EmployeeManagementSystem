using EMS.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EMS.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationService(this IServiceCollection services)
    {
        services.AddScoped<IBandSalaryService, BandSalaryService>();
        services.AddScoped<IEmployeeService, EmployeeService>();
        services.AddScoped<ICertificationService, CertificationService>();
        services.AddScoped<IExperienceService, ExperienceService>();
        services.AddScoped<IGovernmentDocumentService, GovernmentDocumentService>();
        services.AddScoped<ILeaveService, LeaveService>();
        services.AddScoped<IQualificationService, QualificationService>();
        services.AddScoped<IPersonalDetailsService, PersonalDetailsService>();
        services.AddScoped<ISalaryService, SalaryService>();
        services.AddScoped<IReportService, ReportService>();
        return services;
    }
}