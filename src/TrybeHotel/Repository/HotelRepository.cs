using TrybeHotel.Models;
using TrybeHotel.Dto;

namespace TrybeHotel.Repository
{
    public class HotelRepository : IHotelRepository
    {
        protected readonly ITrybeHotelContext _context;
        public HotelRepository(ITrybeHotelContext context)
        {
            _context = context;
        }

        // 4. Desenvolva o endpoint GET /hotel
        public IEnumerable<HotelDto> GetHotels()
        {
            IEnumerable<HotelDto> hotels = from hotel in _context.Hotels
                                            select
                                                new HotelDto() {
                                                address = hotel.Address,
                                                name = hotel.Name,
                                                hotelId = hotel.HotelId,
                                                cityId = hotel.CityId,
                                                cityName = hotel.City.Name
                                                };
            return hotels.ToList();
        }
        
        // 5. Desenvolva o endpoint POST /hotel
        public HotelDto AddHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}