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
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication.Controllers
{
    [Authentication]
    public class TasksController : Controller
    {
        private TasksRepository repo = new TasksRepository();
        private ProjectsRepository projectRepo = new ProjectsRepository();
        private UsersRepository uRepo = new UsersRepository();

        public IActionResult Index(IndexVM model)
        {
            model.Filter ??= new FilterVM();
            model.Pager ??= new PagerVM();
            model.Pager.ItemsPerPage = model.Pager.ItemsPerPage <= 0
                                                                 ? 10
                                                                 : model.Pager.ItemsPerPage;
            model.Pager.Page = model.Pager.Page <= 0
                                                 ? 1
                                                 : model.Pager.Page;

            model.Filter.ProjectId = model.ParentId;
            var filter = model.Filter.GetFilter();

            model.Pager.PagesCount = (int)Math.Ceiling(repo.Count(filter) / (double)model.Pager.ItemsPerPage);

            model.ParentProject = projectRepo.GetFirstOrDefault(p => p.Id == model.ParentId);
           
            model.Filter.Assignees = uRepo.GetAll<int>(null, null, 1, Int32.MaxValue)
                                           .Select(i => new SelectListItem()
                                           {
                                               Text = i.Username + " " +(i.FirstName +" "+ i.LastName),
                                               Value = i.Id.ToString(),
                                               Selected = i.Id == model.Filter.AssigneeId
                                           });

            if (model.ParentProject == null)
            {
                return RedirectToAction("Index", "Projects");
            }

            model.Items = repo.GetAll<int>(filter, null, model.Pager.Page, model.Pager.ItemsPerPage);

            return View(model);
        }

        [HttpGet]
        public IActionResult Create(int ParentId)
        {
            int loggedUserId = Convert.ToInt32(this.HttpContext.Session.GetString("loggedUser"));

            CreateVM model = new CreateVM();
            model.ProjectId = ParentId;
            model.OwnerId = loggedUserId;
            model.AssigneeId = model.AssigneeId;
            model.Deadline = DateTime.Now;

            model.Users = uRepo.GetAll<int>();

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            Task item = new Task();
            item.OwnerId = model.OwnerId;
            item.AssigneeId = model.AssigneeId;
            item.ProjectId = model.ProjectId;
            item.Title = model.Title;
            item.Description = model.Description;
            item.Deadline = model.Deadline;
            item.Status = (Task.TaskStatus)model.Status;
            //Enum.GetNames(typeof(Task.TaskStatus));
            //Enum.Parse(typeof(Task.TaskStatus), "Pending");

            List<KeyValuePair<int, string>> items = new List<KeyValuePair<int, string>>();
            foreach (string name in Enum.GetNames(typeof(Task.TaskStatus)))
            {
                var kvp = new KeyValuePair<int, string>((int)Enum.Parse(typeof(Task.TaskStatus), name), name);

                items.Add(kvp);
            }


            repo.Save(item);

            return RedirectToAction("Index", "Tasks", new { ParentId = model.ProjectId });
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            int loggedUserId = Convert.ToInt32(this.HttpContext.Session.GetString("loggedUser"));

            Task item = repo.GetFirstOrDefault(t => t.Id == id);


            EditVM model = new EditVM();
            model.Id = item.Id;
            model.OwnerId = loggedUserId;
            model.ProjectId = item.ProjectId;
            model.AssigneeId = item.AssigneeId;
            model.Title = item.Title;
            model.Description = item.Description;
            model.Deadline = item.Deadline;
            model.Users = uRepo.GetAll<int>();

           /* List<KeyValuePair<int, string>> items = new List<KeyValuePair<int, string>>();
            foreach (string name in Enum.GetNames(typeof(Task.TaskStatus)))
            {
                var kvp = new KeyValuePair<int, string>((int)Enum.Parse(typeof(Task.TaskStatus), name), name);

                items.Add(kvp);
            }*/

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditVM model)
        {

            Task item = new Task();
            item.Id = model.Id;
            item.OwnerId = model.OwnerId;
            item.ProjectId = model.ProjectId;
            item.AssigneeId = model.AssigneeId;
            item.Title = model.Title;
            item.Description = model.Description;
            item.Deadline = model.Deadline;
            item.Status = (Task.TaskStatus)model.Status;
            model.Users = uRepo.GetAll<int>();

            repo.Save(item);

            return RedirectToAction("Index", "Tasks", new { ParentId = model.ProjectId });
        }

        public IActionResult Delete(int id)
        {
            Task item = repo.GetFirstOrDefault(t => t.Id == id);
            repo.Delete(item);

            return RedirectToAction("Index", "Tasks", new { ParentId = item.ProjectId });
        }

        public IActionResult Details(DetailsVM model)

        {
            CommentsRepository comRepo = new CommentsRepository();
            WorklogsRepository workRepo = new WorklogsRepository();

         
            model.Pager ??= new PagerVM();
            model.Pager.ItemsPerPage = model.Pager.ItemsPerPage <= 0
                                                                 ? 10
                                                                 : model.Pager.ItemsPerPage;
            model.Pager.Page = model.Pager.Page <= 0
                                                 ? 1
                                                 : model.Pager.Page;
            model.Pager.PagesCount = (int)Math.Ceiling(comRepo.Count() / (double)model.Pager.ItemsPerPage);


            model.ParentTask = repo.GetFirstOrDefault(i => i.Id == model.ParentId);
            model.Comments = comRepo.GetAll<int>(i => i.TaskId == model.ParentId,null,model.Pager.Page,model.Pager.ItemsPerPage);
            model.Worklogs = workRepo.GetAll<int>(i=>i.TaskId==model.ParentId,null);

            return View(model);

        }
    }
}
