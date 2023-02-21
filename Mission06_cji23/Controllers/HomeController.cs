using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        private AddMovieContext daContext { get; set; }

        public HomeController(AddMovieContext someName)
        {
            daContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Categories = daContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(AddMovie ar)
        {
            if (ModelState.IsValid)
            {
                daContext.Add(ar);
                daContext.SaveChanges();
                return View("Confirmation", ar);
            }
            else //if invalid
            {
                ViewBag.Categories = daContext.Categories.ToList();

                return View(ar);
            }
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        public IActionResult MovieList()
        {
            var applications = daContext.Responses
                .Include(x => x.Category)
                .ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = daContext.Categories.ToList();

            var movie = daContext.Responses.Single(x => x.MovieId == movieid);

            return View("AddMovie", movie);
        }

        [HttpPost]
        public IActionResult Edit(AddMovie blah)
        {
            daContext.Update(blah);
            daContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var application = daContext.Responses.Single(x => x.MovieId == movieid);

            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(AddMovie ar)
        {
            daContext.Responses.Remove(ar);
            daContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
