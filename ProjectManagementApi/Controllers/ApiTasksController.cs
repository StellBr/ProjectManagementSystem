using Common.Entities;
using Common.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Put([FromBody] Task model)
        {
            repo.Save(model);
            return Created(model.Id.ToString(), model);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Task task = repo.GetFirstOrDefault(t => t.Id == id);
            repo.Delete(task);
            return Ok(task);
        }
    }
}
