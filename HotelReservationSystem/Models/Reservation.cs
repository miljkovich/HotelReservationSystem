﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelReservationSystem.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        [Display(Name = "Пользователь Id")]
        public string ApplicationUserId { get; set; } = null!;

        [Display(Name = "Пользователь Id")]
        public ApplicationUser ?ApplicationUser { get; set; }

        [StringLength(450)]
        [Display(Name = "Номер Id")]
        public string RoomNumber { get; set; } = null!;

        [ForeignKey("RoomNumber")]
        [Display(Name = "Номер")]
        public Room ?Room { get; set; }

        [Display(Name = "Дата заселения")]
        public DateTime DateIn { get; set; }

        [Display(Name = "Дата выселения")]
        public DateTime DateOut { get; set; }

        [Display(Name = "Цена")]
        public float Price { get; set; }

        [Display(Name = "Оплачено")]
        public bool Paid { get; set; } = false;

        public Reservation(string applicationUserId, string roomNumber, DateTime dateIn, DateTime dateOut, float price)
        {
            ApplicationUserId = applicationUserId;
            RoomNumber = roomNumber;
            DateIn = dateIn;
            DateOut = dateOut;
            Price = price;
        }
    }
}