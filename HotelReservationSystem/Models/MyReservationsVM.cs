namespace HotelReservationSystem.Models
{
    public class MyReservationsVM
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public string RoomNumber { get; set; }
        public int RoomTypeId { get; set; }
        public string RoomTypeName { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public float Price { get; set; }
        public bool Paid { get; set;  }
    }
}
