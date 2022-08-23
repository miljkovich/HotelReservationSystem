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

            var RoomTypeModel = _db.RoomTypes.FirstOrDefault(r => r.Id == id);
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
            var availabaleRooms = GetAvailabaleRooms(model);

            if (availabaleRooms.Count == 0)
                ModelState.AddModelError("NoFreeRoomError", $"К сожалению нет доступных номеров в период с: '{model.DateIn.ToString("dd/MM/yyyy")}' по: '{model.DateOut.ToString("dd/MM/yyyy")}'.");
            else
            {
                Reservation reservation = new Reservation(User.Id, availabaleRooms[0].RoomNumber, model.DateIn, model.DateOut, GetReservationPrice(model));
                _db.Add(reservation);
                await _db.SaveChangesAsync();
                return View("SuccessfullyCreated", reservation);
            }
            
            return View(model);
        }

        public async Task<IActionResult> MyReservations()
        {
            var User = await _userManager.GetUserAsync(HttpContext.User);
            IEnumerable<Reservation> allReservations = await _db.Reservations.Where(r => r.ApplicationUserId == User.Id).Include(r => r.Room).ThenInclude(r => r.RoomType).ToListAsync();
            IEnumerable<MyReservationsVM> model = new List<MyReservationsVM>();

            foreach (Reservation r in allReservations)
            {
                var modelItem = new MyReservationsVM
                {
                    Id = r.Id,
                    ApplicationUserId = r.ApplicationUserId,
                    RoomNumber = r.RoomNumber,
                    RoomTypeName = r.Room.RoomType.Name,
                    DateIn = r.DateIn,
                    DateOut = r.DateOut,
                    Price = r.Price,
                };
                model = model.Append(modelItem);
            }

            return View(model);
        }

        private bool InputDatesValid(DateTime checkIn, DateTime checkOut)
        {
            if (checkIn >= checkOut) 
                return false;
            return true;
        }

        private float GetReservationPrice(RoomTypeReservationViewModel model)
        {
            int totalDays = (int)Math.Round((model.DateOut - model.DateIn).TotalDays);
            float priceForDay = _db.RoomTypes.Find(model.RoomTypeId).Price;
            return totalDays * priceForDay;

        }

        private List<Room> GetAvailabaleRooms(RoomTypeReservationViewModel model)
        {
            return _db.Rooms.Where(
                room => room.RoomTypeId == model.RoomTypeId
                &&
                (!room.Reservations.Any(
                    res => ((res.DateIn >= model.DateIn && res.DateIn <= model.DateOut)
                            || (res.DateOut > model.DateIn && res.DateOut <= model.DateOut)
                            || (res.DateIn > model.DateIn && res.DateOut <= model.DateOut))))
                ).ToList();
        }

    }
}
