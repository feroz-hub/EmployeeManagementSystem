using EMS.Domain.Entities.EmployeeDetails;
using EMS.Domain.Models;

namespace EMS.WebApi;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<EmployeeModel, Employee>()
            .ForMember(dest => dest.EmployeeId, opt => opt.Ignore()) // Assuming EmployeeId is generated
            .ForMember(dest => dest.Band, opt => opt.Ignore()) // Band is set by the method
            .ForMember(dest => dest.EmployeeSalary, opt => opt.Ignore()) // Assuming EmployeeSalary is managed elsewhere
            .ForMember(dest => dest.Qualifications, opt => opt.MapFrom(src => src.Qualifications))
            .ForMember(dest => dest.Experiences, opt => opt.MapFrom(src => src.Experiences))
            .ForMember(dest => dest.GovernmentDocuments, opt => opt.MapFrom(src => src.GovernmentDocuments))
            .ForMember(dest => dest.Certifications, opt => opt.MapFrom(src => src.Certifications))
            .ForMember(dest => dest.PersonalDetails, opt => opt.MapFrom(src => src.PersonalDetails));

        CreateMap<QualificationModel, Qualification>()
            .ForMember(dest => dest.EmployeeId, opt => opt.Ignore())
            .ForMember(dest => dest.QualificationId, opt => opt.MapFrom(src => Guid.NewGuid()));
        CreateMap<ExperienceModel, Experience>()
            .ForMember(dest => dest.EmployeeId, opt => opt.Ignore())
            .ForMember(dest => dest.ExperienceId, opt => opt.MapFrom(src => Guid.NewGuid()));
        CreateMap<GovernmentDocumentModel, GovernmentDocument>()
            .ForMember(dest => dest.EmployeeId, opt => opt.Ignore())
            .ForMember(dest => dest.DocumentId, opt => opt.MapFrom(src => Guid.NewGuid()));
        CreateMap<CertificationModel, Certification>()
            .ForMember(dest => dest.EmployeeId, opt => opt.Ignore())
            .ForMember(dest => dest.CertificationId, opt => opt.MapFrom(src => Guid.NewGuid()));
        CreateMap<PersonalDetailsModel, PersonalDetails>()
            .ForMember(dest => dest.EmployeeId, opt => opt.Ignore());
    }
}