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

        //GET: Admin/Users/Details/<user_id>
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }    

            var user = await _context.Users
                .Include(u => u.Reservations)
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Id == id);
            if (user==null)
            {
                return NotFound();
            }

            return View(user);
        }
    }
}
