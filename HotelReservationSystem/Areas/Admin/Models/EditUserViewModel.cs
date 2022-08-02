namespace HotelReservationSystem.Areas.Admin.Models
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            Roles = new List<string>();
        }
        public string Id { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; } = null!;
        public string Passport { get; set; } = null!;
        public string City { get; set; } = null!;
        public string? Address { get; set; }
        public string? ZipCode { get; set; }
        public byte[]? ProfilePicture { get; set; }
        public IList<string>? Roles { get; set; }
    }
}
