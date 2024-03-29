﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MidtermProject;
using MidtermProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjecct.Controllers
{
    public class AuthorController : Controller
    {
        // GET: AuthorController
        public ActionResult Index()
        {
            return View();
        }


        // GET: AuthorController/Details/5
        public ActionResult Details(int id)
        {
            var author = MidtermBasicFunctions.GetAuthorByID(id);
            return View(author);
        }

        // GET: AuthorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Author authorToCreate)
        {
            try
            {
                FinalAdminFunctions.AddAuthor(authorToCreate);
                return RedirectToAction("Authors", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Edit/5
        public ActionResult Edit(int id)
        {
            var author = MidtermBasicFunctions.GetAuthorByID(id);
            return View(author);
        }

        // POST: AuthorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Author authorToEdit)
        {
            try
            {
                FinalAdminFunctions.EditAuthor(authorToEdit);
                return RedirectToAction("Authors", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Delete/5
        public ActionResult Delete(int id)
        {
            var author = MidtermBasicFunctions.GetAuthorByID(id);
            return View(author);
        }

        // POST: AuthorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Author author)
        {
            try
            {
                FinalAdminFunctions.DeleteAuthor(author.AuthorId);
                return RedirectToAction("Authors", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
