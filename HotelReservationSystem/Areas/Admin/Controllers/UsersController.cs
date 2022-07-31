using HotelReservationSystem.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelReservationSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Admin/Users

        public async Task<IActionResult> Index()
        {
            return _context.Users != null ?
                View(await _context.Users.ToListAsync()) :
                Problem("Entity set 'ApplicationDbContext.Users'  is null.");
        }

    }
}
