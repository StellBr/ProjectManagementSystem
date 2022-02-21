using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Data;
using Common.Entities;
using Common.Repositories;
using WebApplication.ViewModels.Projects;

namespace WebApplication.Controllers
{
    public class ProjectsController : Controller
    {
        private ProjectsRepository repo = new ProjectsRepository();
        private UserToProjectsRepository upRepo = new UserToProjectsRepository();
        public IActionResult Index(IndexVM model)
        {
            if (String.IsNullOrEmpty(this.HttpContext.Session.GetString("loggedUser")))
                return RedirectToAction("Login", "Home");

            int loggedUserId = Convert.ToInt32(this.HttpContext.Session.GetString("loggedUser"));

             model.ItemsPerPage = model.ItemsPerPage <= 0 ? 5 : model.ItemsPerPage;
             model.Page = model.Page <= 0 ? 1 : model.Page;
             model.PagesCount = (int) Math.Ceiling(repo.Count(null) / (double)model.ItemsPerPage);

             model.Items = repo.GetAll<int>(i=>i.OwnerId==loggedUserId, null, model.Page, model.ItemsPerPage);

             model.Items.AddRange(upRepo.GetAll<int>(i => i.UserId == loggedUserId)
                                       .Select(i => i.Project));         
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
            if (String.IsNullOrEmpty(this.HttpContext.Session.GetString("loggedUser")))
                return RedirectToAction("Login", "Home");

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            int loggedUserId = Convert.ToInt32(this.HttpContext.Session.GetString("loggedUser"));

            Project item = new Project();
            item.Title = model.Title;
            item.OwnerId = loggedUserId;

            repo.Save(item);

            return RedirectToAction("Index", "Projects");
        }

        [HttpGet]
        public IActionResult Edit(int id )
        {
            if (String.IsNullOrEmpty(this.HttpContext.Session.GetString("loggedUser")))
                return RedirectToAction("Login", "Home");

            Project item = repo.GetFirstOrDefault(u => u.Id == id);

            EditVM model = new EditVM();
            model.Title = item.Title;

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            if (String.IsNullOrEmpty(this.HttpContext.Session.GetString("loggedUser")))
                return RedirectToAction("Login", "Home");

            int loggedUserId = Convert.ToInt32(this.HttpContext.Session.GetString("loggedUser"));

            if (!ModelState.IsValid)
            {
                return View(model);
            }                 

            Project item = repo.GetFirstOrDefault(u => u.Id == model.Id);
            item.Id = model.Id;
            item.OwnerId = loggedUserId;
            item.Title = model.Title;
       
            repo.Save(item);

            return RedirectToAction("Index", "Projects");
        }

        public IActionResult Delete(int id)
        {  
         
            Project item = repo.GetFirstOrDefault(u => u.Id == id);
            repo.Delete(item);

            return RedirectToAction("Index", "Projects");
        }

        [HttpGet]
        public IActionResult Share(int Id)
        {
            ShareVM model = new ShareVM();
            model.Project = repo.GetFirstOrDefault(i => i.Id == Id);
          
            model.Shares = upRepo.GetAll<int>(i => i.ProjectId == Id);

            List<int> usersSharedList = model.Shares
                                                    .Select(i => i.UserId)
                                                    .ToList();
            usersSharedList.Add(model.Project.OwnerId);

            UsersRepository uRepo = new UsersRepository();
            model.Users = uRepo.GetAll<int>(i => !usersSharedList
                                                                .Contains(i.Id));
            return View(model);
        }

        [HttpPost]
        public IActionResult Share(ShareVM model)
        {
            foreach(int userId in model.UserIds)
            {
                UserToProject item = new UserToProject();
                item.UserId = userId;
                item.ProjectId = model.ProjectId;

                upRepo.Save(item);
            }
            return RedirectToAction("Share", "Projects", new { Id = model.ProjectId });
        }

        [HttpGet]
        public IActionResult RevokeShare(int id)
        {
            UserToProject item = upRepo.GetFirstOrDefault(i => i.Id == id);
            upRepo.Delete(item);

            return RedirectToAction("Share", "Projects", new { Id = item.ProjectId });
        }
    }
}
