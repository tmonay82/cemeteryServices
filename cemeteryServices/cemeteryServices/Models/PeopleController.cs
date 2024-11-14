   using Microsoft.AspNetCore.Mvc;
   using cemeteryServices.Data;
   using cemeteryServices.Models;
   using System.Threading.Tasks;
   using Microsoft.EntityFrameworkCore;

namespace cemeteryServices.Controllers
   {
       public class PeopleController : Controller
       {
           private readonly ApplicationDbContext _context;

           public PeopleController(ApplicationDbContext context)
           {
               _context = context;
           }

            public async Task<IActionResult> Index()
            {
                return View(await _context.People.ToListAsync());
            }

        public IActionResult Create()
           {
               return View();
           }

           [HttpPost]
           [ValidateAntiForgeryToken]
           public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,DateOfBirth")] Person person)
           {
               if (ModelState.IsValid)
               {
                   _context.Add(person);
                   await _context.SaveChangesAsync();
                   return RedirectToAction(nameof(Index));
               }
               return View(person);
           }
       }
   }
   