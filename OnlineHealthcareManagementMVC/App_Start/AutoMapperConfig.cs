using OnlineHealthcareManagementMVC.Models;
using OnlineHealthcareManagement.Entity;

namespace OnlineHealthcareManagementMVC.App_Start
{
    public static class AutoMapperConfig
    {
        public static void RegisterMaps()
        {
            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<DoctorModel, DoctorDetails>()
                .ForMember(dest => dest.DoctorId, opt => opt.MapFrom(src => DoctorDetails.GenerateDoctorId(src.Name,src.MobileNumber)));
                config.CreateMap<SignUp, Account>()
                .ForMember(dest=>dest.PatientId ,opt=>opt.MapFrom(src=>Account.GeneratePatientId(src.MobileNumber,src.Name)));
                config.CreateMap<DoctorDetails, DoctorModel>();
                config.CreateMap<SigInModel, Account>();
            });
        }
    }
}