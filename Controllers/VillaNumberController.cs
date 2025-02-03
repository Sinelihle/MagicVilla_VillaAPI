using AutoMapper;
using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [ApiController]
    [Route("/api/villaNumberAPI")]
    public class VillaNumberController: ControllerBase
    {
        protected ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public VillaNumberController(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<VillaNumber>> GetAllVillaNumbers()
        {
            return Ok(_db.VillaNumbers);
        }

        [HttpGet("{villaNo}", Name = "GetVillaNumber")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<VillaNumber>> GetVillaNumber(int villaNo)
        {
            if (villaNo == 0)
            {
                return BadRequest();
            }

            var villaNumber = _db.VillaNumbers.FirstOrDefault(x => x.VillaNo == villaNo);

            if (villaNumber == null)
            {
                return NotFound();
            }

            return Ok(villaNumber);
        }

        [HttpPut("{villaNo}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<VillaNumberUpdateDTO> UpdateVillaNumber(int villaNo, [FromBody]VillaNumberUpdateDTO villaNumberNumberDTO)
        {
            if (villaNo == 0)
            {
                return BadRequest();
            }

            VillaNumber model = _mapper.Map<VillaNumber>(villaNumberNumberDTO);
            _db.VillaNumbers.Update(model);
            _db.SaveChanges(); 

            return Ok(model);
        }


        [HttpPost]
        public ActionResult<VillaNumberCreateDTO> CreateVillaNumber([FromBody] VillaNumberCreateDTO villaNumberCreateDTO)
        {
            if(villaNumberCreateDTO.VillaNo > 0)
            {
                return BadRequest();
            }

            VillaNumber model = _mapper.Map<VillaNumber>(villaNumberCreateDTO);
            _db.VillaNumbers.Add(model);
            _db.SaveChanges();

            return Ok();
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
