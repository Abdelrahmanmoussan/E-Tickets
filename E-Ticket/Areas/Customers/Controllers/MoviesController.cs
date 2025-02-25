using E_Ticket.DataAccess;
using E_Ticket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Ticket.Areas.Customers.Controllers
{
    [Area("Customers")]
    public class MoviesController : Controller
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        public IActionResult Index()
        {
            IQueryable<Movie> movies = dbContext.Movies
                .Include(e=>e.Category)
                .Include(e=>e.Actors)
                .Include(e=>e.Cinema);

            return View(movies.ToList());
        }
    }
}
