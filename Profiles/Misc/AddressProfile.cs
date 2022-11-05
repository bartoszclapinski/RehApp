using AutoMapper;
using server.Entities.Misc;
using server.Models.Misc;

namespace server.Profiles.Misc;

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