﻿using Microsoft.AspNetCore.Http;
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

            User item = new User();
            item.Username = model.Username;
            item.Password = model.Password;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;
            item.Email = model.Email;
            item.Phone = model.Phone;
            item.Address = model.Address;

            repo.Save(item);
      
            return RedirectToAction("Index","Users");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (String.IsNullOrEmpty(this.HttpContext.Session.GetString("loggedUser")))
                return RedirectToAction("Login", "Home");

            User item = repo.GetFirstOrDefault(u => u.Id ==id);

            EditVM model = new EditVM();
            model.Id = item.Id;
            model.Username = item.Username;
            model.Password = item.Password;
            model.FirstName = item.FirstName;
            model.LastName = item.LastName;
            model.Email = item.Email;
            model.Phone = item.Phone;
            model.Address = item.Address;

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            User item = new User();
            item.Id = model.Id;
            item.Username = model.Username;
            item.Password = model.Password;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;
            item.Email = model.Email;
            item.Phone = model.Phone;
            item.Address = model.Address;

            repo.Save(item);

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
