using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ViewInjectionTryout.Models;

namespace ViewInjectionTryout.Controllers
{
    public class UserProfilesController : Controller
    {
        public UserProfilesController()
        {
        }

        public IActionResult Index()
        {
            UserProfile up = new UserProfile()
            {
                ID = Guid.NewGuid(),
                Name = "Bill",
                Gender = "male",
                City = "Bellevue",
                State = "Washington"
            };

            return View(up);
        }
    }
}