using Microsoft.AspNetCore.Identity;

namespace HotelReservationSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public String Nationality { get; set; } = null!;
        public String Passport { get; set; } = null!;
        public string City { get; set; } = null!;
        public string? Address { get; set; }
        public string? ZipCode { get; set; }
        public int UsernameChangeLimit { get; set; } = 10;
        public byte[] ?ProfilePicture { get; set; }
        public ICollection<Reservation> ?Reservations { get; set; }

    }
}
