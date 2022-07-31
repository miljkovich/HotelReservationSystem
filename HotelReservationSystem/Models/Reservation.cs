using System.ComponentModel.DataAnnotations;

namespace HotelReservationSystem.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        [Display(Name = "Пользователь Id")]
        public string ApplicationUserId { get; set; } = null!;
        [Display(Name = "Пользователь Id")]
        public ApplicationUser ?ApplicationUser { get; set; }
        [Display(Name = "Номер Id")]
        public string RoomNumber { get; set; } = null!;
        [Display(Name = "Номер")]
        public Room ?Room { get; set; }
        [Display(Name = "Дата заселения")]
        public DateTime DateIn { get; set; }
        [Display(Name = "Дата выселения")]
        public DateTime DateOut { get; set; }

    }
}