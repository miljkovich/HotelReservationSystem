using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelReservationSystem.Models
{
    public class Room
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string RoomNumber { get; set; } = null!;
        public int RoomTypeId { get; set; }
        public RoomType? RoomType { get; set; }
        public ICollection<Reservation> ?Reservations { get; set; }
    }
}