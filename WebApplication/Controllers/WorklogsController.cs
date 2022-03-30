using Common.Entities;
using Common.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.ViewModels.Worklogs;

namespace WebApplication.Controllers
{
    public class WorklogsController : Controller
    {
        WorklogsRepository repo = new WorklogsRepository();

        [HttpGet]
        public IActionResult Create(int ParentId)
        {
          
            CreateVM model = new CreateVM();        
            model.TaskId = ParentId;

            return View(model);
        }

        [HttpPost]
        public IActionResult Create (CreateVM model)
        {
            int loggedUserId = Convert.ToInt32(this.HttpContext.Session.GetString("loggedUser"));

            Worklog item = new Worklog();
            item.UserId = loggedUserId;
            item.TaskId = model.TaskId;
            item.Hours = model.Hours;
            item.Date = DateTime.Now;
            item.Description = model.Description;

            repo.Save(item);

            return RedirectToAction("Details", "Tasks", new { ParentId = model.TaskId });
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Worklog item = repo.GetFirstOrDefault(i => i.Id == id);

            EditVM model = new EditVM();
            model.Id = item.Id;
            model.UserId = item.UserId;
            model.TaskId = item.TaskId;
            model.Hours = item.Hours;
            model.Description = item.Description;
           
            return View(model);
        }

        public IActionResult Edit(EditVM model)
        {
            Worklog item = new Worklog();
            item.Id = model.Id;
            item.UserId = model.UserId;
            item.TaskId = model.TaskId;
            item.Hours = model.Hours;
            item.Description = model.Description;
            item.Date = DateTime.Now;

            repo.Save(item);

            return RedirectToAction("Details", "Tasks", new { ParentId = model.TaskId });
        }

        public IActionResult Delete(int id)
        {
            Worklog item = repo.GetFirstOrDefault(i => i.Id == id);
            repo.Delete(item);

            return RedirectToAction("Details", "Tasks", new { ParentId = item.TaskId });

        }
    }
}
