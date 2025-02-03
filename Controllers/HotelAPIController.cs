using AutoMapper;
using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/hotelAPI")]
    [ApiController]
    public class HotelAPIController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IHotelRepository _db;
        public HotelAPIController( IMapper mapper, IHotelRepository db)
        { 
            _db = db;
            _mapper = mapper;
        } 

        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelDTO>>> GetAllHotels() 
        {
            return Ok(await _db.GetAllAsync());
        }

        [HttpGet("{id}", Name = "GetHotel")]
        public async Task<ActionResult<IEnumerable<HotelDTO>>> GetHotel(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }

            var hotel = _db.GetAsync(x => x.Id == id);

            if(hotel == null)
            {
                return NotFound();
            }

            return Ok(await hotel);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<HotelDTO>> CreateHotel([FromBody] HotelDTO hotel)
        {
            if(hotel.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            if (_db.GetAsync(x => x.Name.ToLower() == hotel.Name.ToLower()) != null)
            {
                ModelState.AddModelError("DuplicateHotel", "Hotel already exists");
                return BadRequest(ModelState);
            }

            if(hotel == null)
            {
                return BadRequest();
            }
            var createdHotel = _mapper.Map<Hotel>(hotel);

            if(createdHotel == null)
            {
                return NotFound();
            }
            await _db.CreateAsync(createdHotel);
            await _db.SaveAsync();

            return CreatedAtRoute("GetHotel", new { id = createdHotel.Id }, hotel);

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteHotel(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }

            var hotelDelete = HotelStore.hotelList.FirstOrDefault(hotel => hotel.Id == id);

            if(hotelDelete?.Id == null)
            {
                return NotFound();
            }

            HotelStore.hotelList.Remove(hotelDelete);

            return NoContent();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult<HotelDTO> UpdateHotel(int id, [FromBody]HotelDTO hotel)
        {
            if(id == 0)
            {
                return BadRequest();
            }

            var hotelUpdate = HotelStore.hotelList.FirstOrDefault(x => x.Id == id);

            if(hotelUpdate == null)
            {
                return NotFound();
            }

            hotel.Id = hotelUpdate.Id;

            HotelStore.hotelList.Remove(hotelUpdate);

            HotelStore.hotelList.Add(hotel);

            return Ok(hotel);
        }
    }
}
