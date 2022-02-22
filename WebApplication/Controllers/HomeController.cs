using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Common.Data;
using Common.Entities;
using Common.Repositories;
using WebApplication.ViewModels.Home;
using WebApplication.ActionFilters;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            UsersRepository repo = new UsersRepository();
            User loggedUser = repo.GetFirstOrDefault(u => u.Username == model.Username &&
                                                          u.Password == model.Password);

            if (loggedUser == null)
            {
                ModelState.AddModelError("authFailed", "Incorrect username or password");
                return View(model);
            }

            this.HttpContext.Session.SetString("loggedUser", loggedUser.Id.ToString());

            return RedirectToAction("Index","Home");
        }

        [Authentication]
        public IActionResult Logout()
        {
            this.HttpContext.Session.Remove("loggedUser");

            return RedirectToAction("Index", "Home");
        }
    }
}
