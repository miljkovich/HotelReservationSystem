namespace HotelReservationSystem.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = null!;
        public int RoomId { get; set; }
        public Room Room { get; set; } = null!;
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }

    }
}