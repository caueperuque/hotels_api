namespace TrybeHotel.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    // 1. Implemente as models da aplicação
    public class City {
        public int CityId { get; set; }

        public string Name { get; set; }

        public ICollection<Hotel> Hotels { get; set; }
    }
}