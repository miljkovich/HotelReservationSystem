using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelReservationSystem.Models
{
    public class Room
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [Display(Name = "Номер номера")]

        public string RoomNumber { get; set; } = null!;
        [Display(Name = "Тип Номера")]

        public int RoomTypeId { get; set; }
        public RoomType? RoomType { get; set; }
        [Display(Name = "Резервации")]
        public ICollection<Reservation> ?Reservations { get; set; }
    }
}