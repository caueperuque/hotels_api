using TrybeHotel.Models;
using TrybeHotel.Dto;

namespace TrybeHotel.Repository
{
    public class RoomRepository : IRoomRepository
    {
        protected readonly ITrybeHotelContext _context;
        public RoomRepository(ITrybeHotelContext context)
        {
            _context = context;
        }

        // 6. Desenvolva o endpoint GET /room/:hotelId
        public IEnumerable<RoomDto> GetRooms(int HotelId)
        {
            var rooms = from room in _context.Rooms
                            where room.HotelId == HotelId
                            select new RoomDto() {
                                roomId = room.RoomId,
                                name = room.Name,
                                capacity = room.Capacity,
                                image = room.Image,
                                hotel = new HotelDto() {
                                    hotelId = room.HotelId,
                                    name = room.Hotel.Name,
                                    address = room.Hotel.Address,
                                    cityId = room.Hotel.CityId,
                                    cityName = room.Hotel.City.Name
                                }
                            };
            
            return rooms.ToList();
        }

        // 7. Desenvolva o endpoint POST /room
        public RoomDto AddRoom(Room room) {
            throw new NotImplementedException(); 
        }

        // 8. Desenvolva o endpoint DELETE /room/:roomId
        public void DeleteRoom(int RoomId) {
            throw new NotImplementedException();
        }
    }
}