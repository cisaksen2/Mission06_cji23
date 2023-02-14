using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_cji23.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_cji23.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private AddMovieContext blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, AddMovieContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(AddMovie ar)
        {
            blahContext.Add(ar);
            blahContext.SaveChanges();
            return View("Confirmation", ar);
        }

        public IActionResult Podcasts()
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
