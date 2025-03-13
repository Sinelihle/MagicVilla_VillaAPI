using System.Net;
using AutoMapper;
using MagicVilla_VillaAPI.Commands;
using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Handlers;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using MagicVilla_VillaAPI.Queries;
using MagicVilla_VillaAPI.Repository.IRepository;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Forms;
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
        private readonly IMediator _mediator;

        public VillaAPIController(IVillaRepository dbVilla, IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _dbVilla = dbVilla;
            this._response = new();
            _mediator = mediator;

        }

        //methods in a controller are referred to as endpoints
        [HttpGet]
        [ResponseCache(CacheProfileName = "Default30")]
        //[Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetVillas([FromQuery] string? search, [FromQuery] int? occupancy, int pageSize = 2, int pageNumber = 1)
        {
            var query = new GetAllVillasQuery(search, occupancy,pageSize, pageNumber);
            var result = await _mediator.Send(query);
            return Ok(result);

        }

        ////overload for GetVillas 
        //public async Task<ActionResult<APIResponse>> GetVillas([FromQuery] string? search, [FromQuery] int? occupancy)
        //{
        //    var query = new GetAllVillasQuery(search, occupancy);
        //    var result = await _mediator.Send(query);
        //    return Ok(result);

        //}

        [HttpGet("{id}", Name = "GetVilla")]
        //[Authorize(Roles = "admin")]
        [ResponseCache(CacheProfileName ="Default30")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetVilla(int id)
        {

            var query = new GetVillaQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> CreateVilla([FromBody] VillaCreateDTO createDTO)
        {
            var command = new CreateVillaRequest(createDTO);
            var result = await _mediator.Send(command);
            return Ok(result);
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> DeleteVilla(int id)
        {

            var command = new DeleteVillaRequest(id);  
            var result = await _mediator.Send(command);
            return Ok(result);

            //try
            //{
            //    if (id == 0)
            //    {
            //        return BadRequest();
            //    }

            //    var selectVilla = await _dbVilla.GetAsync(delVilla => delVilla.Id == id);


            //    if (selectVilla == null)
            //    {
            //        return NotFound();
            //    }

            //    await _dbVilla.RemoveAsync(selectVilla);
            //    _response.StatusCode = HttpStatusCode.NoContent;
            //    _response.isSuccess = true;

            //    return Ok(_response);
            //}

            //catch (Exception ex)
            //{
            //    _response.ErrorMessages.Add(ex.Message);
            //    _response.isSuccess = false;
            //    _response.StatusCode = HttpStatusCode.BadRequest;
            //}

        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<APIResponse>> UpdateVilla([FromRoute]int id, [FromBody] VillaUpdateDTO updateDTO)
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
