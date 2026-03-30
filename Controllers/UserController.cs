using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ABCClinicSystem.Models;
using ABCClinicSystem.Data;   
using System.Linq;

namespace ABCClinicSystem.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            return View(users);
        }
    }
}