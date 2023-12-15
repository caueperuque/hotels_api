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

        public IEnumerable<HotelDto> GetHotels()
        {
            IEnumerable<HotelDto> hotels = from hotel in _context.Hotels
                                           select
                                               new HotelDto()
                                               {
                                                   address = hotel.Address,
                                                   name = hotel.Name,
                                                   hotelId = hotel.HotelId,
                                                   cityId = hotel.CityId,
                                                   cityName = hotel.City.Name
                                               };
            return hotels.ToList();
        }

        public HotelDto AddHotel(Hotel hotel)
        {
            try
            {
                _context.Hotels.Add(hotel);
                _context.SaveChanges();

                var query = from reqHotel in _context.Hotels
                            where reqHotel.HotelId == hotel.HotelId
                            select new HotelDto()
                            {
                                hotelId = reqHotel.HotelId,
                                name = reqHotel.Name,
                                address = reqHotel.Address,
                                cityId = reqHotel.CityId,
                                cityName = reqHotel.City.Name
                            };

                return query.First();
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new HotelDto();
            }
        }
    }
}