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
        public VillaAPIController(IVillaRepository dbVilla, IMapper mapper)
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
            try
            {
                IEnumerable<Villa> villaList = await _dbVilla.GetAllAsync();
                _response.Result = _mapper.Map<List<VillaDTO>>(villaList);
                _response.StatusCode = HttpStatusCode.OK;

                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.ErrorMessages.Add(ex.Message);
                _response.isSuccess = false;
            }

            return _response;

        }

        [HttpGet("{id}", Name = "GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetVilla(int id)
        {
            try
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
                _response.Result = _mapper.Map<VillaDTO>(villa);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }

            catch (Exception ex)
            {
                _response.ErrorMessages.Add(ex.Message);
                _response.isSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;
            }

            return _response;

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> CreateVilla([FromBody] VillaCreateDTO createDTO)
        {

            try
            {
                if (await _dbVilla.GetAsync(villa => villa.Name.ToLower() == createDTO.Name.ToLower()) != null)
                {
                    ModelState.AddModelError("DuplicateVilla", "Villa already exists");
                    return BadRequest(ModelState);
                }

                if (createDTO == null)
                {
                    return BadRequest(createDTO);
                }

                Villa model = _mapper.Map<Villa>(createDTO);

                await _dbVilla.CreateAsync(model);
                _response.Result = _mapper.Map<VillaDTO>(model);
                _response.isSuccess = true;
                _response.StatusCode = HttpStatusCode.Created;
                //return Ok(_response);

                return Ok(_response);

            }

            catch (Exception ex)
            {
                _response.ErrorMessages.Add(ex.Message);
                _response.isSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;
            }

            return _response;

        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> DeleteVilla(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }

                var selectVilla = await _dbVilla.GetAsync(delVilla => delVilla.Id == id);


                if (selectVilla == null)
                {
                    return NotFound();
                }

                await _dbVilla.RemoveAsync(selectVilla);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.isSuccess = true;

                return Ok(_response);
            }

            catch (Exception ex)
            {
                _response.ErrorMessages.Add(ex.Message);
                _response.isSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;
            }

            return _response;
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<APIResponse>> UpdateVilla(int id, [FromBody] VillaUpdateDTO updateDTO)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }

                Villa model = _mapper.Map<Villa>(updateDTO);

                await _dbVilla.UpdateAsync(model);
                await _dbVilla.SaveAsync();
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.isSuccess = true;
                _response.Result = model;

                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.ErrorMessages.Add(ex.Message);
                _response.isSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;
            }

            return _response;
        }


        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]

        public async Task<ActionResult<APIResponse>> UpdatePartialVilla(int id, JsonPatchDocument<VillaUpdateDTO> patchDTO)
        {
            try
            {
                if (patchDTO == null || id == 0)
                {
                    return BadRequest();
                }

                var villa = await _dbVilla.GetAsync(villa => villa.Id == id, tracked: false);

                if (villa?.Id == null)
                {
                    return NotFound();
                }

                VillaUpdateDTO villaUpdate = _mapper.Map<VillaUpdateDTO>(villa);

                //patchDTO.ApplyTo(villaUpdate, ModelState);

                Villa model = _mapper.Map<Villa>(villaUpdate);

                await _dbVilla.UpdateAsync(model);
                await _dbVilla.SaveAsync();
                _response.Result = model;
                _response.isSuccess = true;
                _response.StatusCode = HttpStatusCode.NoContent;

                return Ok(_response);

            }

            catch (Exception ex)
            {
                _response.ErrorMessages.Add(ex.Message);
                _response.isSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;
            }

            return _response;
        }
    }
}
