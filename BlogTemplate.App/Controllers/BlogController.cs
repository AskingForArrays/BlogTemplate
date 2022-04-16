using BlogTemplate.App.Models;
using BlogTemplate.BLL;
using BlogTemplate.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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
            var blogModel = blogs.Select(b => new BlogViewModel
            {
                BlogID = b.BlogID,
                Title = b.Title,
                Date = b.Date.ToString(),
                UserID = b.UserID.ToString(),
                Content = b.Content,
                Url = b.Url,
                Summary = b.Summary,
                HeadImage = b.HeadImage,
            }).ToList();

            return View(blogModel);
        }


        // GET: BlogController/Details/5
        public ActionResult Details(int id)
        {
            var blog = BlogManager.Find(id);
            return View(blog);
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


        [Authorize(Roles = "1")]
        // GET: BlogController/Edit/5
        public ActionResult Edit(int id)
        {
            var blog = BlogManager.Find(id);
            return View(blog);
        }

        [Authorize(Roles = "1")]
        // POST: BlogController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Blog updatedBlog)
        {
            try
            {
                /*              var originalBlog = BlogManager.Find(id);
                                originalBlog.Title = incomingChanges.Title;
                                originalBlog.Date = incomingChanges.Date.ToString();
                                originalBlog.Content = incomingChanges.Content;
                                originalBlog.Url = incomingChanges.Url;
                                originalBlog.Summary = incomingChanges.Summary;*/
                /*HeadImage = collection.HeadImage,*/
                BlogManager.update(updatedBlog);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        [Authorize(Roles = "1")]
        // GET: BlogController/Delete/5
        public ActionResult Delete(int id)
        {
            var blog = BlogManager.Find(id);
            return View(blog);
        }


        [Authorize(Roles = "1")]
        // POST: BlogController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Blog blog)
        {

            try
            {
                BlogManager.Delete(blog);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
