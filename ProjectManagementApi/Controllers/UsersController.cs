using Common.Entities;
using Common.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectManagementApi.ViewModels.ApiUsers;
using ProjectManagementApi.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ProjectManagementApi.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private UsersRepository repo = new UsersRepository();

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

            model.Items = repo.GetAll<int>(filter, null, model.Pager.Page, model.Pager.ItemsPerPage);

            return Ok(
                new
                {
                    success = true,
                    data = model
                });
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            User item = repo.GetFirstOrDefault(i => i.Id == id);

            if (item == null)
            {
                return NotFound();
            }
            return Ok(
                new
                {
                    success = true,
                    data = item
                });
        }

        [HttpPut]
        public IActionResult Put([FromBody] CreateVM model)
        {
            User item = new User();

            item.Username = model.Username;
            item.Password = model.Password;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;
            item.Email = model.Email;
            item.Phone = model.Phone;
            item.Address = model.Address;

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
            User item = repo.GetFirstOrDefault(i => i.Id == model.Id);

            if (item == null)
            {
                return NotFound();
            }
            item.Username = model.Username;
            item.Password = model.Password;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;
            item.Email = model.Email;
            item.Phone = model.Phone;
            item.Address = model.Address;

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
            User item = repo.GetFirstOrDefault(u => u.Id == id);

            if (item == null)
            {
                return NotFound();
            }

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
