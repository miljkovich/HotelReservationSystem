// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using HotelReservationSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelReservationSystem.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public string Username { get; set; }


        [TempData]
        public string StatusMessage { get; set; }


        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel
        {
            [Display(Name = "Имя")]
            public string FirstName { get; set; }
            [Display(Name = "Фамилия")]
            public string LastName { get; set; }

            [Phone]
            [Display(Name = "Телефон")]
            public string PhoneNumber { get; set; }


            [DataType(DataType.Date)]
            [Display(Name = "Дата рождения")]
            public DateTime BirthDate { get; set; }

            [Required]
            [Display(Name = "Национальность")]
            public string Nationality { get; set; }

            [Required]
            [Display(Name = "Номер пасспорта")]
            public string Passport { get; set; }


            [Display(Name = "Город")]
            public string City { get; set; }

            [Display(Name = "Адресс")]
            public string Address { get; set; }

            [Display(Name = "Zip-код")]
            public string ZipCode { get; set; }

            [Display(Name = "Фото профиля")]
            public byte[] ProfilePicture { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var birthDate = user.BirthDate;
            var nationality = user.Nationality;
            var passport = user.Passport;
            var city = user.City;
            var address = user.Address;
            var zipCode = user.ZipCode;
            var firstName = user.FirstName;
            var lastName = user.LastName;
            var profilePicture = user.ProfilePicture;


            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                BirthDate = birthDate,
                Nationality = nationality,
                Passport = passport,    
                City = city,
                Address = address,
                ZipCode = zipCode,
                FirstName = firstName,
                LastName = lastName,
                ProfilePicture = profilePicture
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            var birthDate = user.BirthDate;
            if (Input.BirthDate != birthDate)
            {
                user.BirthDate = Input.BirthDate;
                await _userManager.UpdateAsync(user);
            }
            var nationality = user.Nationality;
            if (Input.Nationality != nationality)
            {
                user.Nationality = Input.Nationality;
                await _userManager.UpdateAsync(user);
            }
            var passport = user.Passport;
            if (Input.Passport != passport)
            {
                user.Passport = Input.Passport;
                await _userManager.UpdateAsync(user);
            }
            var city = user.City;
            if (Input.City != city)
            {
                user.City = Input.City;
                await _userManager.UpdateAsync(user);
            }
            var address = user.Address;
            if (Input.Address != address)
            {
                user.Address = Input.Address;
                await _userManager.UpdateAsync(user);
            }
            var zipCode = user.ZipCode;
            if (Input.ZipCode != zipCode)
            {
                user.ZipCode = Input.ZipCode;
                await _userManager.UpdateAsync(user);
            }
            var firstName = user.FirstName;
            if (Input.FirstName != firstName)
            {
                user.FirstName = Input.FirstName;
                await _userManager.UpdateAsync(user);
            }

            var lastName = user.LastName;
            if (Input.LastName != lastName)
            {
                user.LastName = Input.LastName;
                await _userManager.UpdateAsync(user);
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Ваш профиль успешно обновлен!";
            return RedirectToPage();
        }
    }
}
