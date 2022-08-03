using HotelReservationSystem.Data;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservationSystem.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ReservationsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> RoomType(int? id)
        {
            if (id == null)
                return NotFound();

            var RoomTypeModel = _db.RoomTypes.FirstOrDefault(r => r.Id == id);

            return View(RoomTypeModel);
        }
    }
}
