using HotelReservationSystem.Data;
using Microsoft.AspNetCore.Mvc;
using HotelReservationSystem.Models;
using Microsoft.AspNetCore.Authorization;

namespace HotelReservationSystem.Controllers
{
    [Authorize(Roles = "Basic")]
    public class ReservationController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ReservationController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
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
                AdultsIn = 0,
                KidsIn = 0,
            };
            return View(ViewModel);

        }
    }
}
