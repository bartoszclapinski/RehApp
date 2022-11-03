﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using server.Entities.Personal;
using server.Models.Personal;
using server.Services;
using AutoMapper;

namespace server.Controllers
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
            var mappedTherapists = _mapper.Map<IEnumerable<TherapistDTO>>(therapistEntities);
            
            return Ok(mappedTherapists);
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
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<TherapistDTO>> AddNewTherapist (TherapistForCreateDTO therapistToAdd)
        {
            var therapistEntity = new Therapist
            {
                PersonalDetails = new PersonalDetails
                {
                    FirstName = therapistToAdd.FirstName,
                    LastName = therapistToAdd.LastName
                }
            };
            await _repository.AddNewTherapist(therapistEntity);
            await _repository.SaveChangesAsync();
            var therapistFinal = _mapper.Map<TherapistDTO>(therapistEntity);

            return Ok(therapistFinal);
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
    }
}
