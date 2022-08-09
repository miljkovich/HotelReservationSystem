using System.ComponentModel.DataAnnotations;

namespace HotelReservationSystem.Models
{
    public class RoomTypeReservationViewModel
    {
        public int Id { get; set; }
        public int RoomTypeId { get; set; }
        public string RoomTypeName { get; set; } = null!;

        public int AdultsCapacity { get; set; }
        public int KidsCapacity { get; set; }
        public string? RoomTypeDescription { get; set; }
        public string? RoomTypeImageUrl { get; set; }
        
        [Required]
        [Display(Name ="Взрослые")]
        public int AdultsIn { get; set; }
        [Required]
        [Display(Name = "Дети")]
        public int KidsIn { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }

    }
}
