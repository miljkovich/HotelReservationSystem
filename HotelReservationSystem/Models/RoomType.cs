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

        [Display(Name = "Вместимость")]
        public int Capacity { get; set; }

        [Display(Name = "Описание")]
        public string ?Description { get; set; }

        [Display(Name = "Площадь")]
        public int RoomArea { get; set; }

        [Display(Name = "Фото URL")]
        public string? RoomImageURL { get; set; }

        public ICollection<Room>? Rooms { get; set; }

    }
}
