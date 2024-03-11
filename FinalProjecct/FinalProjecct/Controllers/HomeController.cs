using FinalProjecct.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MidtermProject;

namespace FinalProjecct.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //return View();
            return RedirectToAction("Books");
        }

        public IActionResult Privacy()
        {
            return View();
        }


        // FInal Project
        public IActionResult Books()
        {
            var bookList = MidtermBasicFunctions.GetAllBooksFull();
            return View(bookList);
        }

        public IActionResult Authors()
        {
            var authorList = MidtermBasicFunctions.GetAllAuthors();
            return View(authorList);
        }

        public IActionResult Genres()
        {
            var genreList = MidtermBasicFunctions.GetAllGenres();
            return View(genreList);
        }



        // End
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
