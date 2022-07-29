using System.ComponentModel.DataAnnotations;

namespace HotelReservationSystem.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        [Display(Name = "Пользователь Id")]
        public string ApplicationUserId { get; set; } = null!;
        [Display(Name = "Пользователь")]
        public ApplicationUser ApplicationUser { get; set; } = null!;
        [Display(Name = "Номер Id")]
        public int RoomId { get; set; }
        [Display(Name = "Номер")]
        public Room Room { get; set; } = null!;
        [Display(Name = "Дата заселения")]
        public DateTime DateIn { get; set; }
        [Display(Name = "Дата выселения")]
        public DateTime DateOut { get; set; }

    }
}