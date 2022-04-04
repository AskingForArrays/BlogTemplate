using BlogTemplate.Domain;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogTemplate.BLL;
using System.Security.Claims;

namespace BlogTemplate.App.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Login(string returnUrl = null)
        {
            if (returnUrl != null)
                TempData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            var usr = UserManager.Authenticate(user.Username, user.Password);

            if (user == null) return View();

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, usr.Username),
                new Claim("UserID", usr.UserID.ToString()),
                new Claim("FirstName", usr.FirstName),
                new Claim(ClaimTypes.Role, usr.AccessLevel.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(claims, "Cookies");
            HttpContext.SignInAsync("Cookies", new ClaimsPrincipal(claimsIdentity));

            if (TempData["ReturnUrl"] == null)
                return RedirectToAction("Index", "Home");
            else
                return Redirect(TempData["ReturnUrl"].ToString());

        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync("Cookies");
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        // GET: UsersController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            var userToCheck = User.Claims.FirstOrDefault(u => u.Type.Equals("UserID", StringComparison.OrdinalIgnoreCase)).Value.ToString();
            var userToView = UserManager.GetUserById(Convert.ToInt32(userToCheck));
            return View(userToView);
        }

        // GET: UsersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {

            if (!UserManager.CheckUsername(user.Username))
            {
                try
                {
                    user.AccessLevel = 2;
                    UserManager.Add(user);
                    return RedirectToAction("Index","Home");
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                ViewBag.Message = "UserName already exists.";
                return View();
            }

        }

        // GET: UsersController/Edit/5
        public ActionResult Edit(int id)
        {

            var userToCheck = User.Claims.FirstOrDefault(u => u.Type.Equals("UserID", StringComparison.OrdinalIgnoreCase)).Value.ToString();
            var userToView = UserManager.GetUserById(Convert.ToInt32(userToCheck));
            return View(userToView);
        }

        // POST: UsersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User user)
        {
            try
            {
                UserManager.Update(user);
                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersController/Delete/5
        public ActionResult Delete(int id)
        {
            var userToCheck = User.Claims.FirstOrDefault(u => u.Type.Equals("UserID", StringComparison.OrdinalIgnoreCase)).Value.ToString();
            var userToView = UserManager.GetUserById(Convert.ToInt32(userToCheck));
            return View(userToView);
        }

        // POST: UsersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(User user)
        {
            try
            {
                UserManager.Delete(user);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
