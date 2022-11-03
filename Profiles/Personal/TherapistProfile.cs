using AutoMapper;
using server.Entities.Personal;
using server.Models.Personal;

namespace server.Profiles.Personal;

public class TherapistProfile : Profile
{
    public TherapistProfile()
    {
        /*
         *  Mapping therapist entity to therapist dto model
         */
        CreateMap<PersonalDetails, PersonalDetailsDTO>();
        CreateMap<PersonalDetailsDTO, PersonalDetails>();
        CreateMap<Therapist, TherapistDTO>();
        CreateMap<TherapistDTO, Therapist>();

        /*
         *  Mapping therapist dto model to therapist entity
         */
        //CreateMap<Models.Personal.TherapistDTO, Entities.Personal.Therapist>();

        /*
         * Mapping therapist for create dto to therapist entity
         */
        CreateMap<TherapistForCreateDTO, Therapist>();
        
        
    }
}