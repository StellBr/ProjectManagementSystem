using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Common.Data;
using Common.Entities;
using Common.Repositories;
using WebApplication.ViewModels.Tasks;

namespace WebApplication.Controllers
{
    public class TasksController : Controller
    {
        private TasksRepository repo = new TasksRepository();
        private ProjectsRepository projectRepo = new ProjectsRepository();
        
        public IActionResult Index(IndexVM model)
        {
            if (String.IsNullOrEmpty(this.HttpContext.Session.GetString("loggedUser")))
                return RedirectToAction("Login", "Home");

            model.ParentProject = projectRepo.GetFirstOrDefault(p=>p.Id==model.ParentId);

            model.Items = repo.GetAll<int>(t=>t.ProjectId==model.ParentId,null);

            return View(model);
        }

        [HttpGet]
        public IActionResult Create(int ParentId)
        {
            if (String.IsNullOrEmpty(this.HttpContext.Session.GetString("loggedUser")))
                return RedirectToAction("Login", "Home");

            CreateVM model = new CreateVM();
            model.ProjectId = ParentId;
            model.Deadline = DateTime.Now;

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {
            if (String.IsNullOrEmpty(this.HttpContext.Session.GetString("loggedUser")))
                return RedirectToAction("Login", "Home");

            if (!ModelState.IsValid)
                return View(model);

            Task item = new Task();
            item.ProjectId = model.ProjectId;
            item.Title = model.Title;
            item.Description = model.Description;
            item.Deadline = model.Deadline;

            repo.Save(item);

            return RedirectToAction("Index", "Tasks", new { ParentId = model.ProjectId });
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (String.IsNullOrEmpty(this.HttpContext.Session.GetString("loggedUser")))
                return RedirectToAction("Login", "Home");

            Task item = repo.GetFirstOrDefault(t => t.Id == id);
       
            EditVM model = new EditVM();
            model.Id = item.Id;
            model.ProjectId = item.ProjectId;
            model.Title = item.Title;
            model.Description = item.Description;
            model.Deadline = item.Deadline;

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            if (String.IsNullOrEmpty(this.HttpContext.Session.GetString("loggedUser")))
                return RedirectToAction("Login", "Home");

            Task item = new Task();
            item.Id = model.Id;
            item.ProjectId = model.ProjectId;
            item.Title = model.Title;
            item.Description = model.Description;
            item.Deadline = model.Deadline;

            repo.Save(item);

            return RedirectToAction("Index","Tasks", new { ParentId = model.ProjectId });
        }

        public IActionResult Delete(int id)
        {
            if (String.IsNullOrEmpty(this.HttpContext.Session.GetString("loggedUser")))
                return RedirectToAction("Login", "Home");

            Task item = repo.GetFirstOrDefault(t => t.Id == id);
            repo.Delete(item);  

            return RedirectToAction("Index", "Tasks" , new  { ParentId = item.ProjectId}); 
        }
    }
}
