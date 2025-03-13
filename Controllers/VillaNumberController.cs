using System.Net;
using AutoMapper;
using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [ApiController]
    [Route("/api/villaNumberAPI")]
    public class VillaNumberController: ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IVillaNumberRepository _db;
        private readonly IVillaRepository _dbVilla;
        private readonly APIResponse _response;

        public VillaNumberController(IVillaNumberRepository db, IMapper mapper, IVillaRepository dbVilla)
        {
            _db = db;
            _mapper = mapper;
            _dbVilla = dbVilla;
            this._response = new();

        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task <ActionResult<APIResponse>> GetAllVillaNumbers()
        {
            IEnumerable<VillaNumber> villaNumbrList = await _db.GetAllAsync();
            _response.Result = _mapper.Map<List<VillaNumberDTO>>(villaNumbrList);
            _response.StatusCode = HttpStatusCode.OK;

            return Ok(_response);
        }

        [HttpGet("{villaNo}", Name = "GetVillaNumber")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<VillaNumberDTO>>> GetVillaNumber(int villaNo)
        {
            if (villaNo == 0)
            {
                return BadRequest();
            }

            var villaNumber = await _db.GetAsync(x => x.VillaNo == villaNo);

            if (villaNumber == null)
            {
                return NotFound();
            }

            _response.Result = _mapper.Map<VillaNumberDTO>(villaNumber);
            _response.StatusCode = HttpStatusCode.OK;


            return Ok(_response);
        }

        [HttpPut("{villaNo}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<VillaNumberUpdateDTO>> UpdateVillaNumber(int villaNo, [FromBody]VillaNumberUpdateDTO villaNumberUpdateNumberDTO)
        {
            if (villaNo == 0)
            {
                return BadRequest();
            }

            if (await _dbVilla.GetAsync(u => u.Id == villaNumberUpdateNumberDTO.VillaID) == null)
            {
                ModelState.AddModelError("CustomError", "Villa ID is invalid!");
                return BadRequest(ModelState);
            }

            VillaNumber model = _mapper.Map<VillaNumber>(villaNumberUpdateNumberDTO);
            await _db.UpdateAsync(model);
            await _db.SaveAsync(); 

            return Ok(model);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<VillaNumberCreateDTO>> CreateVillaNumber([FromBody] VillaNumberCreateDTO villaNumberCreateDTO)
        {
            if(await _db.GetAsync(x => x.VillaNo == villaNumberCreateDTO.VillaNo) != null)
            {
                ModelState.AddModelError("Error", "Villa Number already exists");
                return BadRequest(ModelState);
            }

            if(await _dbVilla.GetAsync(u => u.Id == villaNumberCreateDTO.VillaID) == null)
            {
                ModelState.AddModelError("CustomError", "Villa ID is invalid!");
                return BadRequest(ModelState);
            }

            if (villaNumberCreateDTO == null)
            {
                return BadRequest(villaNumberCreateDTO);
            }

            VillaNumber model = _mapper.Map<VillaNumber>(villaNumberCreateDTO);
            await _db.CreateAsync(model);
            await _db.SaveAsync();

            return Ok();
        }

        [HttpDelete("{villaNo}")]

        public async Task<ActionResult<VillaNumberDTO>> DeleteVillaNumber(int villaNo)
        {
            if(villaNo == 0)
            {
                return BadRequest();
            }
           var selectedVillaNumber =  await _db.GetAsync(x => x.VillaNo == villaNo);
            await _db.RemoveAsync(selectedVillaNumber);

            return NoContent();
        }


        //[HttpPost]

        //[HttpPost]
        //public IActionResult CreateVillaNumber([FromBody] VillaNumber villaNumber)
        //{
        //    if (villaNumber.VillaNo > 0)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError);
        //    }

        //    if (villaNumber == null)
        //    {
        //        return BadRequest();
        //    }
        //    return Created();
        //    //var villaNUM = _db.VillaNumbers.FirstOrDefault(u => u.VillaNo == villaNumber.VillaNo).VillaNo;

        //    //return Created();
        //}

        //[HttpDelete("{id}")]
        //public IActionResult DeleteHotel(int id)
        //{
        //    if (id == 0)
        //    {
        //        return BadRequest();
        //    }

        //    var hotelDelete = HotelStore.hotelList.FirstOrDefault(hotel => hotel.Id == id);

        //    if (hotelDelete?.Id == null)
        //    {
        //        return NotFound();
        //    }

        //    HotelStore.hotelList.Remove(hotelDelete);

        //    return NoContent();

        //}

        //[HttpPut("{id}")]

        //public ActionResult<HotelDTO> UpdateHotel(int id, [FromBody] HotelDTO hotel)
        //{
        //    if (id == 0)
        //    {
        //        return BadRequest();
        //    }

        //    var hotelUpdate = HotelStore.hotelList.FirstOrDefault(x => x.Id == id);

        //    if (hotelUpdate == null)
        //    {
        //        return NotFound();
        //    }

        //    hotel.Id = hotelUpdate.Id;

        //    HotelStore.hotelList.Remove(hotelUpdate);

        //    HotelStore.hotelList.Add(hotel);

        //    return Ok(hotel);
        //}
    }
}
