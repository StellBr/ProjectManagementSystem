using Common.Entities;
using Common.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.ActionFilters;
using WebApplication.ViewModels.Comments;

namespace WebApplication.Controllers
{
    [Authentication]
    public class CommentsController : Controller
    {
        CommentsRepository repo = new CommentsRepository();
        TasksRepository taskRepo = new TasksRepository();
        ProjectsRepository projectRepo = new ProjectsRepository();

        
        [HttpGet]
        public IActionResult Create(int ParentId)
        {
            CreateVM model = new CreateVM();
            model.TaskId = ParentId;
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(CreateVM model)
        {
            Comment item = new Comment();

            int loggedUserId = Convert.ToInt32(this.HttpContext.Session.GetString("loggedUser"));

            item.TaskId = model.TaskId;
            item.UserId = loggedUserId;
            item.Topic = model.Topic;
            item.Content = model.Content;
            item.DateTime = DateTime.Now;
        
            repo.Save(item);

            return RedirectToAction("Details", "Tasks", new { ParentId = model.TaskId } );
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Comment item = repo.GetFirstOrDefault(i => i.Id == id);

            EditVM model = new EditVM();
            model.TaskId = item.TaskId;
            model.Topic = item.Topic;
            model.Content = item.Content;

            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            int loggedUserId = Convert.ToInt32(this.HttpContext.Session.GetString("loggedUser"));

            Comment item = new Comment();
            item.Id = model.Id;
            item.UserId = loggedUserId;
            item.TaskId = model.TaskId;
            item.Topic = model.Topic;
            item.Content = model.Content;
            item.DateTime = DateTime.Now;

            repo.Save(item);

            return RedirectToAction("Details", "Tasks", new { ParentId = model.TaskId });
        }
        public IActionResult Delete(int id)
        {
            Comment item = repo.GetFirstOrDefault(i => i.Id == id);
            repo.Delete(item);
            return RedirectToAction("Details", "Tasks", new { ParentId = item.TaskId });
        }
    }
}
