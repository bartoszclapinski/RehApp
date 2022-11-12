using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using server.Entities.Corporational;
using server.Models.Corporational;
using server.Services.Corporational;

namespace server.Controllers.Corporational;

[Route("api/corporational/corporations")]
[ApiController]
public class CorporationController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly ICorporationRepository _repository;

    public CorporationController(IMapper mapper, ICorporationRepository repository)
    {
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    [HttpGet("get-all-corporations")]
    public async Task<ActionResult<IEnumerable<CorporationDTO>>> GetAllCorporations()
    {
        var corporationEntities = await _repository.GetAllCorporationsAsync();
        return Ok(_mapper.Map<IEnumerable<CorporationDTO>>(corporationEntities));
    }

    [HttpGet("get-corporation-by-id/{id}")]
    public async Task<IActionResult> GetCorporationById(int id)
    {
        var corporation = await _repository.GetCorporationByIdAsync(id);
        return Ok(_mapper.Map<CorporationDTO>(corporation));
    }

    [HttpPost("add-new-corporation")]
    public async Task<ActionResult<CorporationDTO>> AddNewCorporation (CorporationDTO corporationToAdd)
    {
        var corporationEntity = _mapper.Map<Corporation>(corporationToAdd);
        await _repository.AddNewCorporation(corporationEntity);
        return Ok(_mapper.Map<CorporationDTO>(corporationEntity));
    }

    [HttpPut("update-corporation/{id}")]
    public async Task<ActionResult<CorporationDTO>> UpdateCorporationById (CorporationDTO corporationToUpdate, int id)
    {
        if (! await _repository.CorporationExistsAsync(id))
        {
            return NotFound();
        }

        var corporationEntity = await _repository.GetCorporationByIdAsync(id);
        _mapper.Map(corporationToUpdate, corporationEntity);
        await _repository.SaveChangesAsync();

        return Ok(_mapper.Map<CorporationDTO>(corporationEntity));
    }
} 