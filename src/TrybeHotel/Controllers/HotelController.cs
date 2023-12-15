using Microsoft.AspNetCore.Mvc;
using TrybeHotel.Models;
using TrybeHotel.Repository;

namespace TrybeHotel.Controllers
{
    [ApiController]
    [Route("hotel")]
    public class HotelController : Controller
    {
        private readonly IHotelRepository _repository;

        public HotelController(IHotelRepository repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        public IActionResult GetHotels(){
            var hotels = _repository.GetHotels();
            
            if (hotels.Count() <= 0)
            {
                return NotFound("Nenhum hotel foi encontrado.");
            }
            return Ok(hotels);
        }

        [HttpPost]
        public IActionResult PostHotel([FromBody] Hotel hotel){
            var result = _repository.AddHotel(hotel);

            return Created("Hotel adicionado.", result);
        }


    }
}