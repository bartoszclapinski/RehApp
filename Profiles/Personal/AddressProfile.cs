using AutoMapper;
using server.Entities.Personal;
using server.Models.Personal;

namespace server.Profiles.Personal;

public class AddressProfile : Profile
{
    public AddressProfile()
    {
        /*
         *  Mapping address entity and address dto
         */
        CreateMap<Address, AddressDTO>();
        CreateMap<AddressDTO, Address>();
    }
}