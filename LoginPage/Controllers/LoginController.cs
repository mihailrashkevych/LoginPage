using LoginPage.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginPage.Controllers
{
    public class LoginController : Controller
    {
        AppDbContext _context;
        public LoginController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            
            if (_context.Users.Any(u=>u.Email == loginModel.Email && u.Password == loginModel.Password))
            {
                return RedirectToAction("Index","Home");
            } else
                return RedirectToAction(nameof(Login));
        }
    }
}
