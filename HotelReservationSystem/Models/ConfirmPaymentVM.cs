using System.ComponentModel.DataAnnotations;

namespace HotelReservationSystem.Models
{
    public class ConfirmPaymentVM
    {
        Reservation Reservation { get; set; }

        [Required]
        [Display(Name="ФИО")]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(200)]
        [Display(Name = "Адресс")]

        public string Address { get; set; }

        [Required]
        [MaxLength(200)]
        [Display(Name = "Город")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Государство")]
        public string State { get; set; }

        [Required]
        [Display(Name = "Имя на карте")]
        public string CardName { get; set; }

        [Required]
        [CreditCard]
        [Display(Name = "Номер Карты")]
        public string CardNumber { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(2)]
        [Display(Name = "Exp Month")]
        public string ExpMonth { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(4)]
        [Display(Name = "Exp Year")]
        public string ExpYear { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(3)]
        [Display(Name = "CVV")]
        public string CVV { get; set; }

    }
}
