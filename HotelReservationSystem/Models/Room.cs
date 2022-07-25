namespace HotelReservationSystem.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int RoomTypeId { get; set; }
        public RoomType RoomType { get; set; } = null!;
        public Reservation[] ?Reservations { get; set; }
    }
}