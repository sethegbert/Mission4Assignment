using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission4Assignment.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4Assignment.Controllers
{
    public class HomeController : Controller
    {
        private MoviesContext movieContext { get; set; }

        public HomeController(MoviesContext someName)
        {
            movieContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovies()
        {
            ViewBag.Categories = movieContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddMovies (NewMovie response)
        {
            if (ModelState.IsValid)
            {
                movieContext.Add(response);
                movieContext.SaveChanges();
                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Categories = movieContext.Categories.ToList();

                return View(response);
            }
            
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieList()
        {
            var applications = movieContext.Responses
                .Include(x => x.Category)
                .Where(x => x.Title != "Sharknado")
                .OrderBy(x => x.Title)
                .ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit (int movieid)
        {
            ViewBag.Categories = movieContext.Categories.ToList();

            var movie = movieContext.Responses.Single(x => x.MovieId == movieid);

            return View("AddMovies", movie);
        }

        [HttpPost]
        public IActionResult Edit (NewMovie response)
        {
            movieContext.Update(response);
            movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete (int movieid)
        {
            var application = movieContext.Responses.Single(x => x.MovieId == movieid);

            return View(application);
        }

        [HttpPost]
        public IActionResult Delete (NewMovie response)
        {
            movieContext.Responses.Remove(response);
            movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
