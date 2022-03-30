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
using WebApplication.ActionFilters;
using WebApplication.ViewModels.Shared;

namespace WebApplication.Controllers
{
    [Authentication]
    public class UsersController : Controller
    {
        private UsersRepository repo = new UsersRepository();

        public IActionResult Index(IndexVM model)
        {
             model.Filter ??= new FilterVM();
             model.Pager  ??= new PagerVM();

             model.Pager.ItemsPerPage = model.Pager.ItemsPerPage <= 0 
                                         ? 10 
                                         : model.Pager.ItemsPerPage;
             model.Pager.Page = model.Pager.Page <= 0 
                                         ? 1 
                                         : model.Pager.Page;

            var filter = model.Filter.GetFilter();

             model.Pager.PagesCount = (int)Math.Ceiling(repo.Count(filter) / (double)model.Pager.ItemsPerPage);
 
             model.Items = repo.GetAll<int>(filter, null,model.Pager.Page,model.Pager.ItemsPerPage);
            
            return View(model);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
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
           
            User user = repo.GetFirstOrDefault(u => u.Id == id);
            repo.Delete(user);

            return RedirectToAction("Index", "Users");
        }
    }
}
