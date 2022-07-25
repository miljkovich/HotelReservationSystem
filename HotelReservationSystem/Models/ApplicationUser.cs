using Microsoft.AspNetCore.Identity;

namespace HotelReservationSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int UsernameChangeLimit { get; set; } = 10;
        public byte[] ?ProfilePicture { get; set; }
        public Reservation[] ?Reservations { get; set; }

    }
}
