using Microsoft.AspNetCore.Mvc;
using cemeteryServices.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace cemeteryServices.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }
    }
}
