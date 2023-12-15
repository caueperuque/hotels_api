using Microsoft.AspNetCore.Mvc;
using TrybeHotel.Models;
using TrybeHotel.Repository;

namespace TrybeHotel.Controllers
{
    [ApiController]
    [Route("room")]
    public class RoomController : Controller
    {
        private readonly IRoomRepository _repository;
        public RoomController(IRoomRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{HotelId}")]
        public IActionResult GetRoom(int HotelId){
            var rooms = _repository.GetRooms(HotelId);

            if (rooms.Count() <= 0)
            {
                return NotFound("Nenhum quarto foi encontrado.");
            }

            return Ok(rooms);
        }

        // 7. Desenvolva o endpoint POST /room
        [HttpPost]
        public IActionResult PostRoom([FromBody] Room room){
            var result = _repository.AddRoom(room);

            return Created("Quarto adicionado.", result);
        }

        [HttpDelete("{RoomId}")]
        public IActionResult Delete(int RoomId)
        {
            _repository.DeleteRoom(RoomId);

            return NoContent();
        }
    }
}