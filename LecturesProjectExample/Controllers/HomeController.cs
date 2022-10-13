using LecturesProjectExample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LecturesProjectExample.Example.Data.Context;
using LecturesProjectExample.Example.Data.Entities;

namespace LecturesProjectExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly JournalContextDb _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(JournalContextDb context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            // use query here
            List<StudentItemViewModel> model = new List<StudentItemViewModel>();

            foreach (StudentEntity entity in _context.Students)
            {
                model.Add(new StudentItemViewModel()
                {
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    YearOfStudying = entity.YearOfStudying
                });
            }

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}