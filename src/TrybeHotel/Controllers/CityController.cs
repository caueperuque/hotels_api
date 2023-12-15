using Microsoft.AspNetCore.Mvc;
using TrybeHotel.Models;
using TrybeHotel.Repository;

namespace TrybeHotel.Controllers
{
    [ApiController]
    [Route("city")]
    public class CityController : Controller
    {
        private readonly ICityRepository _repository;
        public CityController(ICityRepository repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        public IActionResult GetCities(){
            var cities = _repository.GetCities();

            if (cities.Count() <= 0)
            {
                return NotFound("Nenhuma cidade foi encontrada.");
            }
            
            return Ok(cities);
        }

        [HttpPost]
        public IActionResult PostCity([FromBody] City city){
            var result = _repository.AddCity(city);

            return Created("City added", result);
        }
    }
}