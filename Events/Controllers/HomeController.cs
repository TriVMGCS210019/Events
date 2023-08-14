using Events.Models;
using Events.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using SQLitePCL;

namespace Events.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            /* var events = _context.Event
                .OrderBy(e => e.Start)
                .Where(e => e.IsPublic);*/ 
            var events = (from e in _context.Event
                          join a in _context.Author on
                          e.Author.Id equals a.Id
                          select new Event
                          {
                              Id = e.Id,
                              Name = e.Name,
                              Start = e.Start,
                              End = e.End,
                              Author = a
                          });
            var upcomingEvents = events.Where(e => e.Start > DateTime.Now);
            var pastEvents = events.Where(e => e.Start <= DateTime.Now);
            return View(new EventsViewModel(upcomingEvents, pastEvents));
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}