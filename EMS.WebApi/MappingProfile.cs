using EMS.Domain.Entities.EmployeeDetails;
using EMS.Domain.Models;

namespace EMS.WebApi;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<Employee, EmployeeModel>().ReverseMap();
        CreateMap<PersonalDetails, PersonalDetailsModel>().ReverseMap();
        CreateMap<Qualification, QualificationModel>().ReverseMap();
        CreateMap<Experience, ExperienceModel>().ReverseMap();
        CreateMap<GovernmentDocument, GovernmentDocumentModel>().ReverseMap();
        CreateMap<Certification, CertificationModel>().ReverseMap();
        CreateMap<Leave, LeaveModel>().ReverseMap();
    }
}