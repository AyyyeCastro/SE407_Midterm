using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MidtermProject;
using MidtermProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjecct.Controllers
{
    public class GenreController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Details(int id)
        {
            var genre = MidtermBasicFunctions.GetGenreByID(id);
            return View(genre);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Genre genreToCreate)
        {
            try
            {
                FinalAdminFunctions.AddGenre(genreToCreate);
                return RedirectToAction("Genres", "Home");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var genre = MidtermBasicFunctions.GetGenreByID(id);
            return View(genre);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Genre genreToEdit)
        {
            try
            {
                FinalAdminFunctions.EditGenres(genreToEdit);
                return RedirectToAction("Genres", "Home");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var genre = MidtermBasicFunctions.GetGenreByID(id);
            return View(genre);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Genre Genre)
        {
            try
            {
                FinalAdminFunctions.DeleteGenre(Genre.GenreId);
                return RedirectToAction("Genres", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}