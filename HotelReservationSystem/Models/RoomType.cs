using System.ComponentModel.DataAnnotations;

namespace HotelReservationSystem.Models
{
    public class RoomType
    {
        public int Id { get; set; }
        [Display(Name = "Имя")]
        public string Name { get; set; } = null!;

        [Display(Name = "Цена")]
        public int Price { get; set; }

        [Display(Name = "Вместимость Взрослых")]
        public int AdultsCapacity { get; set; }
        [Display(Name = "Вместимость Детей")]
        public int KidsCapacity { get; set; }

        [Display(Name = "Описание")]
        public string ?Description { get; set; }

        [Display(Name = "Площадь")]
        public int RoomArea { get; set; }

        [Display(Name = "Фото URL")]
        public string? RoomImageURL { get; set; }
        [Display(Name = "Имеет ванную")]
        public bool HasBath { get; set; }
        [Display(Name = "Имеет телефон")]
        public bool HasPhone { get; set; }
        [Display(Name = "Имеет Wi-Fi")]
        public bool HasWiFi { get; set; }
        [Display(Name = "Имеет Телевизор")]
        public bool HasTV { get; set; }
        public ICollection<Room>? Rooms { get; set; }

    }
}
