using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using server.Models.Users;
using server.Services.Users;

namespace server.Controllers.Users
{
    [Route("api/users/patients")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientRepository _repository;
        private readonly IMapper _mapper;

        public PatientController(IPatientRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("get-all-patients")]
        public async Task<ActionResult<IEnumerable<PatientDTO>>> GetAllPatients()
        {
            var patientEntities = await _repository.GetAllPatientsAsync();
            return Ok(_mapper.Map<PatientDTO>(patientEntities));
        }

        [HttpGet("get-patient-by-id/{id}")]
        public async Task<ActionResult<PatientDTO>> GetPatientById(int id)
        {
            if (! await _repository.PatientExistsAsync(id))
            {
                return NotFound();
            }

            var patientEntity = await _repository.GetPatientByIdAsync(id);
            return (_mapper.Map<PatientDTO>(patientEntity));
        }
    }
    
}