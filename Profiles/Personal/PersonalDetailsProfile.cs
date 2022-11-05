using AutoMapper;
using server.Entities.Personal;
using server.Models.Personal;

namespace server.Profiles.Personal;

public class PersonalDetailsProfile : Profile
{
    public PersonalDetailsProfile()
    {
        /*
         *  Mapping personal details entity and personal details for create dto
         */
        CreateMap<PersonalDetails, PersonalDetailsForCreateDTO>();
        CreateMap<PersonalDetailsForCreateDTO, PersonalDetails>();
        
        /*
         *  Mapping personal details entity and personal details dto
         */
        CreateMap<PersonalDetails, PersonalDetailsDTO>();
        CreateMap<PersonalDetailsDTO, PersonalDetails>();
    }
}