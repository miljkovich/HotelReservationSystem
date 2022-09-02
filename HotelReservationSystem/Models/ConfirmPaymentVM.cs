using System.ComponentModel.DataAnnotations;

namespace HotelReservationSystem.Models
{
    public class ConfirmPaymentVM
    {
        [Required]
        public int ReservationId { get; set; }

        public Reservation ?Reservation { get; set; }

        [Required(ErrorMessage = "Введите ФИО")]
        [Display(Name="ФИО")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Введите Почту")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введите Адресс")]
        [MaxLength(200)]
        [Display(Name = "Адресс")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Введите Город")]
        [MaxLength(200)]
        [Display(Name = "Город")]
        public string City { get; set; }

        [Required(ErrorMessage = "Введите Почтовый индекс")]
        [MaxLength(10)]
        [Display(Name = "Почтовый индекс")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Введите Государство")]
        [Display(Name = "Государство")]
        public string State { get; set; }

        [Required(ErrorMessage = "Введите 'Имя на карте'")]
        [Display(Name = "Имя на карте")]
        public string CardName { get; set; }

        [Required(ErrorMessage = "Введите Номер Карты")]
        [CreditCard(ErrorMessage = "Неправильно введён номер карты.")]
        [Display(Name = "Номер Карты")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "Введите Exp Month")]
        [StringLength(2)]
        [Display(Name = "Exp Month")]
        public string ExpMonth { get; set; }

        [Required(ErrorMessage = "Введите Exp Year")]
        [MinLength(4, ErrorMessage = "Неправильно введен год действия карты") ]
        [MaxLength(4, ErrorMessage = "Неправильно введен год действия карты")]
        [Display(Name = "Exp Year")]
        public string ExpYear { get; set; }

        [Required(ErrorMessage = "Введите CVV")]
        [MinLength(3,ErrorMessage = "CVV представляет собой трех или четырехзначный код.")]
        [MaxLength(4, ErrorMessage = "CVV представляет собой трех или четырехзначный код.")]
        [Display(Name = "CVV")]
        public string CVV { get; set; }

    }
}
