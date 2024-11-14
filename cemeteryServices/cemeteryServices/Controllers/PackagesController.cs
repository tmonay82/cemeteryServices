using Microsoft.AspNetCore.Mvc;
using cemeteryServices.Data;
using cemeteryServices.Models;
using System.Linq;
using System.Threading.Tasks;

namespace cemeteryServices.Controllers
{
    public class PackagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PackagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
    }
}
