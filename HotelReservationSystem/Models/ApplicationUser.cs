using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HotelReservationSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Имя")]
        public string FirstName { get; set; } = null!;
        [Display(Name = "Фамилия")]
        public string LastName { get; set; } = null!;
        [Display(Name = "Полное Имя")]
        public string FullName { get { return FirstName + " " + LastName; } }
        [Display(Name = "Дата Рождения")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Гражданство")]
        public String Nationality { get; set; } = null!;
        [Display(Name = "Пасспорт")]
        public String Passport { get; set; } = null!;
        [Display(Name = "Город")]
        public string City { get; set; } = null!;
        [Display(Name = "Адрес")]
        public string? Address { get; set; }
        [Display(Name = "Почтовой Индекс")]
        public string? ZipCode { get; set; }
        public int UsernameChangeLimit { get; set; } = 10;
        [Display(Name = "Фото профиля")]
        public byte[] ?ProfilePicture { get; set; }
        [Display(Name = "Резервации")]
        public ICollection<Reservation> ?Reservations { get; set; }

    }
}
