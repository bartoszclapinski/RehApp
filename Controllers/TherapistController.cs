using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using server.Entities.Personal;
using server.Models.Personal;
using server.Services;

namespace server.Controllers
{
    [Route("api/persons/therapists")]
    [ApiController]
    public class TherapistController : ControllerBase
    {
        private readonly ITherapistsRepository _repository;

        public TherapistController(ITherapistsRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet("get-all-therapists")]
        public async Task<ActionResult<IEnumerable<TherapistDTO>>> GetTherapistsAsync()
        {
            var therapistEntities = await _repository.GetAllTherapistsAsync();
            var results = new List<TherapistDTO>();
            foreach (var t in therapistEntities)
            {
                results.Add(new TherapistDTO
                {
                    personalDetails = t.PersonalDetails
                });
            }

            return Ok(results);
        }
    }
}
