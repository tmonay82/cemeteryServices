using Microsoft.AspNetCore.Mvc;

namespace cemeteryServices.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminHome()
        {
            return View();
        }
    }
}

