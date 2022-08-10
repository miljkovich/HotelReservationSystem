using HotelReservationSystem.Data;
using Microsoft.AspNetCore.Mvc;
using HotelReservationSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HotelReservationSystem.Controllers
{
    [Authorize(Roles = "Basic")]
    public class ReservationController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public ReservationController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            IEnumerable<RoomType> objRoomTypeList = _db.RoomTypes.ToList();
            return View(objRoomTypeList);
        }

        public async Task<IActionResult> Create(int? id)
        {
            if (id == null)
                return NotFound();

            var RoomTypeModel =  _db.RoomTypes.FirstOrDefault(r => r.Id == id);
            if (RoomTypeModel == null)
            {
                return NotFound();
            }
            var ViewModel = new RoomTypeReservationViewModel
            {
                RoomTypeId = RoomTypeModel.Id,
                RoomTypeName = RoomTypeModel.Name,
                AdultsCapacity = RoomTypeModel.AdultsCapacity,
                KidsCapacity = RoomTypeModel.KidsCapacity,
                RoomTypeDescription = RoomTypeModel.Description,
                RoomTypeImageUrl = RoomTypeModel.RoomImageURL,
                DateIn = DateTime.Now,
                DateOut = DateTime.Now.AddDays(1),
                AdultsIn = 0,
                KidsIn = 0,
            };
            return View(ViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RoomTypeReservationViewModel model)
        {
            if (!InputDatesValid(model.DateIn, model.DateOut))
            {
                ModelState.AddModelError("DateError", "Неправильно введены даты.");
                return View(model);
            }
            var User = await _userManager.GetUserAsync(HttpContext.User);
            var availRooms = _db.Rooms.Where(
                room => room.RoomTypeId == model.RoomTypeId).ToList();
                //&&
                //(!room.Reservations.Any(b => (b.DateOut >= model.DateOut && b.DateIn<= model.DateIn))))
                //.ToList();

            return null;
        }

        private bool InputDatesValid(DateTime checkIn, DateTime checkOut)
        {
            if (checkIn >= checkOut) 
                return false;
            return true;
        }
    }
}
