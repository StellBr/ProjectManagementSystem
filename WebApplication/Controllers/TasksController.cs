using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Common.Data;
using Common.Entities;
using Common.Repositories;
using WebApplication.ViewModels.Tasks;
using WebApplication.ActionFilters;
using WebApplication.ViewModels.Shared;

namespace WebApplication.Controllers
{
    [Authentication]
    public class TasksController : Controller
    {
        private TasksRepository repo = new TasksRepository();
        private ProjectsRepository projectRepo = new ProjectsRepository();
        
        public IActionResult Index(IndexVM model)
        {
            model.Pager ??= new PagerVM();
            model.Pager.ItemsPerPage = model.Pager.ItemsPerPage <= 0
                                                                 ? 10
                                                                 : model.Pager.ItemsPerPage;
            model.Pager.Page = model.Pager.Page <= 0
                                                 ? 1
                                                 : model.Pager.Page;

            model.Pager.PagesCount = (int)Math.Ceiling(repo.Count(t => t.ProjectId == model.ParentId) / (double)model.Pager.ItemsPerPage);

            model.ParentProject = projectRepo.GetFirstOrDefault(p=>p.Id==model.ParentId);

            model.Items = repo.GetAll<int>(t=>t.ProjectId==model.ParentId,null);

            return View(model);
        }

        [HttpGet]
        public IActionResult Create(int ParentId)
        {
            CreateVM model = new CreateVM();
            model.ProjectId = ParentId;
            model.Deadline = DateTime.Now;

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {
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
            Task item = repo.GetFirstOrDefault(t => t.Id == id);
            repo.Delete(item);  

            return RedirectToAction("Index", "Tasks" , new  { ParentId = item.ProjectId}); 
        }
    }
}
