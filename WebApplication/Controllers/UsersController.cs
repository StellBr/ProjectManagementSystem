using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Data;
using Common.Entities;
using Common.Repositories;
using WebApplication.ViewModels.Users;

namespace WebApplication.Controllers
{
    public class UsersController : Controller
    {
        private UsersRepository repo = new UsersRepository();

     
        public IActionResult Index(IndexVM model)
        {
            if (String.IsNullOrEmpty(this.HttpContext.Session.GetString("loggedUser")))
                return RedirectToAction("Login", "Home");

             model.ItemsPerPage = model.ItemsPerPage <= 0 ? 10 : model.ItemsPerPage;
             model.Page = model.Page <= 0 ? 1 : model.Page;
             model.PagesCount = (int)Math.Ceiling(repo.Count() / (double)model.ItemsPerPage);
 

             model.Items = repo.GetAll<int>(null,null,model.Page,model.ItemsPerPage);
            
            return View(model);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            if (String.IsNullOrEmpty(this.HttpContext.Session.GetString("loggedUser")))
                return RedirectToAction("Login", "Home");
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {
         
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            User user = new User();
            user.Username = model.Username;
            user.Password = model.Password;
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Email = model.Email;
            user.Phone = model.Phone;
            user.Address = model.Address;

            repo.Save(user);
      
            return RedirectToAction("Index","Users");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (String.IsNullOrEmpty(this.HttpContext.Session.GetString("loggedUser")))
                return RedirectToAction("Login", "Home");

            User user = repo.GetFirstOrDefault(u => u.Id ==id);

            EditVM model = new EditVM();
            model.Id = user.Id;
            model.Username = user.Username;
            model.Password = user.Password;
            model.FirstName = user.FirstName;
            model.LastName = user.LastName;
            model.Email = user.Email;
            model.Phone = user.Phone;
            model.Address = user.Address;

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            User user = new User();
            user.Id = model.Id;
            user.Username = model.Username;
            user.Password = model.Password;
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Email = model.Email;
            user.Phone = model.Phone;
            user.Address = model.Address;

            repo.Save(user);

            return RedirectToAction("Index","Users");
        }

        public IActionResult Delete (int id)
        {
            if (String.IsNullOrEmpty(this.HttpContext.Session.GetString("loggedUser")))
                return RedirectToAction("Login", "Home");
          
            User user = repo.GetFirstOrDefault(u => u.Id == id);
            repo.Delete(user);

            return RedirectToAction("Index", "Users");
        }
    }
}
