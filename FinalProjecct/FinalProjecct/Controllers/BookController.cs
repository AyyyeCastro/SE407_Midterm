using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MidtermProject;
using Microsoft.AspNetCore.Mvc.Rendering;
using MidtermProject.Models;
using SelectList = Microsoft.AspNetCore.Mvc.Rendering.SelectList; // had to do this after I messed up. Read below.

/// NOTE: I have the DeepFormatter logic complete, but I could not get it to work with 
/// "ViewBag.GenreId = DeepFormatter.FormatGenres();"    
/// or Authors. I believe I made a mistake with a Quick Actions on the Select List, in the DeepFormatter.cs 
/// and I've been unable to find what I clicked to cause it. (ctrl+z wouldnt undo it either) 
/// D:\NEIT\Winter 2024\SE407\repo\SE407_Midterm\MidtermProject\MidtermProject\DeepFormatter.cs
/// Included as project references with using MidtermProject;

namespace FinalProjecct.Controllers
{
    public class BookController : Controller
    {
        // GET: BookController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            var book = MidtermBasicFunctions.GetBookByID(id);
            return View(book);
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            var genres = new SelectList(MidtermBasicFunctions.GetAllGenres()
                .OrderBy(genre => genre.GenreType)
                .ToDictionary(genre => genre.GenreId, genre => genre.GenreType), "Key", "Value");
            ViewBag.GenreId = genres;

            var authors = new SelectList(MidtermBasicFunctions.GetAllAuthors()
                .OrderBy(author => author.AuthorLast)
                .ToDictionary(author => author.AuthorId, author => author.AuthorLast+", "+ author.AuthorFirst), "Key", "Value");
            ViewBag.AuthorId = authors;

            return View();

        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book bookToCreate)
        {
            try
            {
                FinalAdminFunctions.AddBook(bookToCreate);
                return RedirectToAction("Books", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {
            var book = MidtermBasicFunctions.GetBookByID(id);
            var genres = new SelectList(MidtermBasicFunctions.GetAllGenres()
            .OrderBy(genre => genre.GenreType)
            .ToDictionary(genre => genre.GenreId, genre => genre.GenreType), "Key", "Value");
            ViewBag.GenreId = genres;

            var authors = new SelectList(MidtermBasicFunctions.GetAllAuthors()
                .OrderBy(author => author.AuthorLast)
                .ToDictionary(author => author.AuthorId, author => author.AuthorLast + ", " + author.AuthorFirst), "Key", "Value");
            ViewBag.AuthorId = authors;

            return View(book);
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book bookToEdit)
        {
            try
            {
                FinalAdminFunctions.EditBook(bookToEdit);
                return RedirectToAction("Books", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            var book = MidtermBasicFunctions.GetBookByID(id);
            return View(book);
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Book book)
        {
            try
            {
                FinalAdminFunctions.DeleteBook(book.BookId);
                return RedirectToAction("Books", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
