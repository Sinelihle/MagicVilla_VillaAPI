using System.Net;
using AutoMapper;
using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/villaAPI")]

    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IVillaRepository _dbVilla;
        private readonly IMapper _mapper;
        public VillaAPIController(IVillaRepository dbVilla,IMapper mapper)
        {
            _mapper = mapper;
            _dbVilla = dbVilla;
            this._response = new();
        }

        //methods in a controller are referred to as endpoints
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetVillas()
        {
            IEnumerable<Villa> villaList = await _dbVilla.GetAllAsync();
            _response.Result = _mapper.Map<List<VillaDTO>>(villaList);
            _response.StatusCode = HttpStatusCode.OK;

            return Ok(_response);
        }

        [HttpGet("{id}", Name = "GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<VillaDTO>> GetVilla(int id)
        {
            if (id == 0)
            {

                return BadRequest();
            }
            var villa = await _dbVilla.GetAsync(u => u.Id == id);

            if (villa == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<VillaDTO>(villa));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<VillaDTO>> CreateVilla([FromBody] VillaCreateDTO createDTO)
        {

            if (await _dbVilla.GetAsync(villa => villa.Name.ToLower() == createDTO.Name.ToLower()) != null)
            {
                ModelState.AddModelError("DuplicateVilla", "Villa already exists");
                return  BadRequest(ModelState);
            }

            if (createDTO == null)
            {
                return BadRequest(createDTO);
            }

            Villa model = _mapper.Map<Villa>(createDTO);
           
           await _dbVilla.CreateAsync(model);

            return CreatedAtRoute("GetVilla",new { id = model.Id},createDTO);


        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteVilla(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }

            var selectVilla = await _dbVilla.GetAsync(delVilla => delVilla.Id == id);


            if (selectVilla == null)
            {
                return NotFound();
            }

            await _dbVilla.RemoveAsync(selectVilla);

            return NoContent();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> UpdateVilla(int id, [FromBody] VillaUpdateDTO updateDTO)
        {
            if(id == 0)
            {
                return BadRequest();
            }

            Villa model = _mapper.Map<Villa>(updateDTO);    

            await _dbVilla.UpdateAsync(model);
            await _dbVilla.SaveAsync();


            return NoContent();
        }


        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]

        public async Task<IActionResult> UpdatePartialVilla(int id, JsonPatchDocument<VillaUpdateDTO> patchDTO)
        {
            if(patchDTO == null || id == 0)
            {
                return BadRequest();
            }

            var villa = await _dbVilla.GetAsync(villa => villa.Id == id, tracked: false);

            if (villa?.Id == null) 
            {
                return NotFound();
            }

            VillaUpdateDTO villaUpdate = _mapper.Map<VillaUpdateDTO>(villa);

            patchDTO.ApplyTo(villaUpdate, ModelState);

            Villa model = _mapper.Map<Villa>(villaUpdate);

            await _dbVilla.UpdateAsync(model);
            await _dbVilla.SaveAsync();

            return NoContent();

        }
    }
}
