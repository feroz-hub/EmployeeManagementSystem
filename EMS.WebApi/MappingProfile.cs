using EMS.Domain.Entities.EmployeeDetails;

namespace EMS.WebApi;

public class MappingProfile:Profile
{
    public MappingProfile()


    {
        CreateMap<Employee, EmployeeModel>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Certifications, opt => opt.MapFrom(src => src.Certifications))
            .ForMember(dest => dest.Experiences, opt => opt.MapFrom(src => src.Experiences));
        
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
        CreateMap<ExperienceModel, Experience>().ReverseMap();
            // .ForMember(dest => dest.EmployeeId, opt => opt.Ignore())
            // .ForMember(dest => dest.ExperienceId, opt => opt.MapFrom(src => Guid.NewGuid()));
        CreateMap<GovernmentDocumentModel, GovernmentDocument>()
            .ForMember(dest => dest.EmployeeId, opt => opt.Ignore())
            .ForMember(dest => dest.DocumentId, opt => opt.MapFrom(src => Guid.NewGuid()));
        CreateMap<CertificationModel, Certification>().ReverseMap();
        CreateMap<PersonalDetailsModel, PersonalDetails>()
            .ForMember(dest => dest.EmployeeId, opt => opt.Ignore());
    }
}