using AutoMapper;
using server.Entities.Corporations;
using server.Models.Corporational;

namespace server.Profiles.Corporational;

public class CorporationProfile : Profile
{
    public CorporationProfile()
    {
        /*
         *  Mapping corporation entity and corporation dto
         */
        CreateMap<Corporation, CorporationDTO>();
        CreateMap<CorporationDTO, Corporation>();
    }
}