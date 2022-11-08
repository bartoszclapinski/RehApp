using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using server.Services.Corporational;

namespace server.Controllers.Corporational;

public class CorporationController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly ICorporationRepository _repository;

    public CorporationController(IMapper mapper, ICorporationRepository repository)
    {
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }
    
    
}