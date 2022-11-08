using AutoMapper;
using server.Entities.Users;
using server.Models.Users;

namespace server.Profiles.Users;

public class TherapistProfile : Profile
{
    public TherapistProfile()
    {
        /*
         *  Mapping therapist entity and therapist dto model
         */
        CreateMap<Therapist, TherapistDTO>();
        CreateMap<TherapistDTO, Therapist>();

        /*
         * Mapping therapist entity and therapist for create dto
         */
        CreateMap<TherapistForCreateDTO, Therapist>();
        CreateMap<Therapist, TherapistForCreateDTO>();

    }
}