﻿using BlogTemplate.App.Models;
using BlogTemplate.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.IO;
using System.Linq;

namespace BlogTemplate.App.Controllers
{
    public class BlogController : Controller
    {
        // GET: BlogController
        public IActionResult Index()
        {
            var blogs = BlogManager.GetAll();
            var blogViewModel = blogs.Select(b => new BlogViewModel
            {
                BlogID = b.BlogID,
                Title = b.Title,
                Date = b.Date.ToString(),
                UserID = b.UserID.ToString(),
                Content = b.Content,
                Url = b.Url,
                MainImage = ConvertToImage(b.MainImage),
                Published = b.Published
            }).ToList();
            return View(blogViewModel);
        }

        // GET: BlogController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BlogController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlogController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlogController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public static Image ConvertToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes);
            Image returnImage = Image.FromStream(ms);
            return returnImage;

        }
    }
}
