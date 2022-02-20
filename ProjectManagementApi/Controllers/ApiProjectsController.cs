using Common.Entities;
using Common.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectManagementApi.ViewModels.ApiProjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiProjectsController : ControllerBase
    {
        private ProjectsRepository repo = new ProjectsRepository();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(repo.GetAll<int>());

        }

        [HttpGet("{ownerId}")]
        public IActionResult Get(int ownerId)
        {
            return Ok(repo.GetAll<int>(i => i.OwnerId == ownerId));
        }

        [HttpPut]
        public IActionResult Put([FromBody] CreateVM model)
        {
            Project item = new Project();

            item.OwnerId = model.OwnerId;
            item.Title = model.Title;

            repo.Save(item);
            return Ok(item);

        }

        [HttpPost]
        public IActionResult Post([FromBody] EditVM model)
        {
            Project item = repo.GetFirstOrDefault(i => i.Id == model.Id);

            if (item == null)
            {
                return NotFound();
            }

            item.OwnerId = model.OwnerId;
            item.Title = model.Title;

            repo.Save(item);
            return Ok(item);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Project item = repo.GetFirstOrDefault(p => p.Id == id);
            if(item == null)
            {
                return NotFound();
            }
            repo.Delete(item);
            return Ok(item);
        }
    
    }
}
