using AutoMapper;

namespace server.Profiles.Personal;

public class TherapistProfile : Profile
{
    public TherapistProfile()
    {
        /*
         *  Mapping therapist entity to therapist dto model
         */
        CreateMap<Entities.Personal.Therapist, Models.Personal.TherapistDTO>();

        /*
         *  Mapping therapist dto model to therapist entity
         */
        CreateMap<Models.Personal.TherapistDTO, Entities.Personal.Therapist>();
    }
}