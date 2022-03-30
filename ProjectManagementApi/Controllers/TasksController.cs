using Common.Entities;
using Common.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectManagementApi.ViewModels.ApiTasks;
using ProjectManagementApi.ViewModels.Shared;
using ProjectManagementApi.ViewModels.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ProjectManagementApi.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private TasksRepository repo = new TasksRepository();

        [HttpGet]
        public IActionResult Get([FromQuery] IndexVM model)
        {
            model.Pager ??= new PagerVM();
            model.Pager.Page = model.Pager.Page <= 0
                                      ? 1
                                      : model.Pager.Page;

            model.Pager.ItemsPerPage = model.Pager.ItemsPerPage <= 0
                                        ? 10
                                        : model.Pager.ItemsPerPage;

            model.Filter ??= new FilterVM();
            var filter = model.Filter.GetFilter();
            model.Items = repo.GetAll<int>(filter,null,model.Pager.Page,model.Pager.ItemsPerPage);
            return Ok(
                 new
                 {
                     success = true,
                     data = model
                 });
        }

        [HttpPut]
        public IActionResult Put([FromBody] CreateVM model)
        {
            Task item = new Task();

            item.ProjectId = model.ProjectId;
            item.Title = model.Title;
            item.Description = model.Description;
            item.Deadline = model.Deadline;

            repo.Save(item);
            return Ok(
                 new
                 {
                     success = true,
                     data = model
                 });
        }

        [HttpPost]
        public IActionResult Post([FromBody] EditVM model)
        {
            Task item = repo.GetFirstOrDefault(i => i.Id == model.Id);

            item.Title = model.Title;
            item.Description = model.Description;
            item.Deadline = model.Deadline;

            repo.Save(item);
            return Ok(
                   new
                   {
                       success = true,
                       data = model
                   });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Task item = repo.GetFirstOrDefault(t => t.Id == id);
            repo.Delete(item);
            return Ok(
                 new
                 {
                     success = true,
                     data = item
                 });
        }
    }
}
