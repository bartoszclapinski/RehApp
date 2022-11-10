using Microsoft.AspNetCore.Mvc;
using server.Services.Users;
using AutoMapper;
using server.Entities.Users;
using server.Models.Users;

namespace server.Controllers.Users
{
    [Route("api/persons/therapists")]
    [ApiController]
    public class TherapistController : ControllerBase
    {
        private readonly ITherapistsRepository _repository;
        private readonly IMapper _mapper;

        public TherapistController(ITherapistsRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("get-all-therapists")]
        public async Task<ActionResult<IEnumerable<TherapistDTO>>> GetTherapistsAsync ()
        {
            var therapistEntities = await _repository.GetAllTherapistsAsync();

            return Ok(_mapper.Map<IEnumerable<TherapistDTO>>(therapistEntities));
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("get-therapist-by-id/{id}")]
        public async Task<IActionResult> GetTherapistById (int id)
        {
            var therapist = await _repository.GetTherapistByIdAsync(id);
            return Ok(_mapper.Map<TherapistDTO>(therapist));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="therapistToAdd"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("{id}")]
        public async Task<ActionResult<TherapistDTO>> AddNewTherapist (TherapistForCreateDTO therapistToAdd, int id)
        {
            
            var therapistEntity = _mapper.Map<Therapist>(therapistToAdd);
            await _repository.AddNewTherapist(therapistEntity, id);
            await _repository.SaveChangesAsync();
            var therapistToReturn = _mapper.Map<TherapistDTO>(therapistEntity);

            return Ok(therapistToReturn);
        }

        [HttpPut("update-therapist-by-id/{id}")]
        public async Task<ActionResult<TherapistDTO>> UpdateTherapist (int id, TherapistForCreateDTO therapistToUpdate)
        {
            if (!await _repository.TherapistExistsAsync(id))
            {
                return NotFound();
            }
            
            var therapistEntity = await _repository.GetTherapistByIdAsync(id);
            _mapper.Map(therapistToUpdate, therapistEntity);
            await _repository.SaveChangesAsync();
            
            therapistEntity = await _repository.GetTherapistByIdAsync(id);

            return Ok(_mapper.Map<TherapistDTO>(therapistEntity));
        }

        [HttpDelete("delete-therapist-by-id/{id}")]
        public async Task<IActionResult> DeleteTherapistByIdAsync(int id)
        {
            await _repository.DeleteTherapistByIdAsync(id);
            return Ok();
        }
    }
}
