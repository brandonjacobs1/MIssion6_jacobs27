using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MIssion6_jacobs27.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;



namespace MIssion6_jacobs27.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext _movieContext { get; set; }
        public HomeController(ILogger<HomeController> logger, MovieContext MovieContext)
        {
            _logger = logger;
            _movieContext = MovieContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        //call podcasts page
        public IActionResult Podcasts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = _movieContext.Category.ToList();
            return View();
        }
        //store data from form
        [HttpPost]
        public IActionResult MovieForm(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movieContext.Add(movie);
                _movieContext.SaveChanges();
                return RedirectToAction("MovieList");
            }
            else
            {
                ViewBag.Categories = _movieContext.Category.ToList();
                return View(movie);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult MovieList()
        {
            List<Movie> movies = _movieContext.Movies
                .Include(mov => mov.Category)
                .ToList();
            return View(movies);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _movieContext.Category.ToList();

            Movie movie = _movieContext.Movies.Single(x => x.MovieID == id);

            return View("MovieForm", movie);
        }
        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            _movieContext.Update(movie);
            _movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Movie movie = _movieContext.Movies.Single(movie => movie.MovieID == id);

            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _movieContext.Movies.Remove(movie);
            _movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
