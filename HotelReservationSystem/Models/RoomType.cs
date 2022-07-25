namespace HotelReservationSystem.Models
{
    public class RoomType
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int Capacity { get; set; }
        public string ?Description { get; set; }
        public int RoomArea { get; set; }
        public string? RoomImageURL { get; set; }

        public ICollection<Room>? Rooms { get; set; }

    }
}
