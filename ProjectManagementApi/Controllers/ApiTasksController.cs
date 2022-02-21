using Common.Entities;
using Common.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectManagementApi.ViewModels.ApiTasks;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ProjectManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiTasksController : ControllerBase
    {
        private TasksRepository repo = new TasksRepository();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(repo.GetAll<int>(null,null));
        }

        [HttpGet("{projectId}")]
        public IActionResult Get(int projectId)
        {
            return Ok(repo.GetAll<int>(t => t.ProjectId == projectId));
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
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Post([FromBody] EditVM model)
        {
            Task item = repo.GetFirstOrDefault(i => i.Id == model.Id);

            item.Title = model.Title;
            item.Description = model.Description;
            item.Deadline = model.Deadline;

            repo.Save(item);
            return Ok(item);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Task item = repo.GetFirstOrDefault(t => t.Id == id);
            repo.Delete(item);
            return Ok(item);
        }
    }
}
