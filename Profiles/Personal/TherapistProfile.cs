using AutoMapper;
using server.Entities.Personal;
using server.Models.Personal;

namespace server.Profiles.Personal;

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