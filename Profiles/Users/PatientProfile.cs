using AutoMapper;
using server.Entities.Users;
using server.Models.Users;

namespace server.Profiles.Users;

public class PatientProfile : Profile
{
    public PatientProfile()
    {
        CreateMap<Patient, PatientDTO>();
        CreateMap<PatientDTO, Patient>();
    }
}