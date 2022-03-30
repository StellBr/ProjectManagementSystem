using Common.Entities;
using Common.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectManagementApi.ViewModels.ApiProjects;
using ProjectManagementApi.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementApi.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private ProjectsRepository repo = new ProjectsRepository();
        private UserToProjectsRepository upRepo = new UserToProjectsRepository();


        [HttpGet]
        public IActionResult Get( [FromQuery] IndexVM model)
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
            model.Filter.SharedProjects = upRepo.GetAll<int>(i => i.UserId == model.Filter.OwnerId)
                                                   .Select(i => i.Project.Title).ToList();          
            model.Items = repo.GetAll<int>(filter, null, model.Pager.Page, model.Pager.ItemsPerPage);

            return Ok(new
            {
                success = true,
                data = model
            });
        }
   
        [HttpPut]
        public IActionResult Put([FromBody] CreateVM model)
        {
            Project item = new Project();

            item.OwnerId = model.OwnerId;
            item.Title = model.Title;

            repo.Save(item);
            return Ok(new
            {
                success = true,
                data = model
            });
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
            return Ok(new
            {
                success = true,
                data = model
            });
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
            return Ok(new
            {
                success = true,
                data = item
            });
        }
    
    }
}
