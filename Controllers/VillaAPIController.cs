using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Logging;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/villaAPI")]

    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        private readonly ILogging _logger;
       
        public VillaAPIController(ILogging logger)
        {
            _logger = logger;
        }
        //methods in a controller are referred to as endpoints
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            _logger.Log("Getting all villas", "");
            return Ok(VillaStore.villaList);
        }

        [HttpGet("{id}", Name = "GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            if (id == 0)
            {

                _logger.Log("Error getting villa with id " + id , "error");
                return BadRequest();
            }
            var villa = VillaStore.villaList.FirstOrDefault(u => u.Id == id);

            if (villa == null)
            {
                return NotFound();
            }
            return Ok(villa);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<VillaDTO> CreateVilla([FromBody] VillaDTO villaDTO)
        {

            if (VillaStore.villaList.FirstOrDefault(villa => villa.Name.ToLower() == villaDTO.Name.ToLower()) != null)
            {
                ModelState.AddModelError("DuplicateVilla", "Villa already exists");
                return BadRequest(ModelState);
            }

            if (villaDTO == null)
            {
                return BadRequest(villaDTO);
            }

            //if the id already exists then it's not a POST cause POST only CREATE's
            if (villaDTO.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            villaDTO.Id = VillaStore.villaList.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
            VillaStore.villaList.Add(villaDTO);

            return CreatedAtRoute("GetVilla", new { id = villaDTO.Id }, villaDTO);


        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteVilla(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }

            var selectVilla = VillaStore.villaList.FirstOrDefault(delVilla => delVilla.Id == id);

            VillaStore.villaList.Remove(selectVilla);

            if (selectVilla == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public IActionResult UpdateVilla(int id, [FromBody] VillaDTO villa)
        {
            if(id == 0)
            {
                return BadRequest();
            }

            var selelectedVilla = VillaStore.villaList.FirstOrDefault(u => u.Id == id);

            if(selelectedVilla?.Id == null)
            {
                return NotFound();
            }

            villa.Id = selelectedVilla.Id;

            VillaStore.villaList.Remove(selelectedVilla);

            VillaStore.villaList.Add(villa);

            return NoContent();
        }


        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]

        public IActionResult UpdatePartialVilla(int id, JsonPatchDocument<VillaDTO> patchDTO)
        {
            if(patchDTO == null || id == 0)
            {
                return BadRequest();
            }

            var villa = VillaStore.villaList.FirstOrDefault(villa => villa.Id == id);

            if (villa?.Id == null) 
            {
                return NotFound();
            }

            patchDTO.ApplyTo(villa);

            return NoContent();

        }

        //[HttpPut("{id}")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public ActionResult<VillaDTO> UpdateVilla([FromBody]VillaDTO villaDto, int id)
        //{
        //    if(id == null)
        //    {
        //        return BadRequest();
        //    }

        //    villaDto.Id = id;

        //    return Ok(villaDto);
        //}

    }
}
