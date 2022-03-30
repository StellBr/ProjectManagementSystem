using Common.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;

namespace WebApplication.ViewModels.Tasks
{
    public class FilterVM
    {
        public int ProjectId { get; set; }
        [Display(Name="Assigneed User")]
        public int AssigneeId { get; set; }
        public string Title { get; set; }
         
        public IEnumerable<SelectListItem> Assignees { get; set; }
  
        public Expression<Func<Task, bool>> GetFilter()
        {
            return i =>
                        (i.ProjectId == ProjectId) &&
                        (AssigneeId<=0 || i.AssigneeId == AssigneeId) &&
                        (string.IsNullOrEmpty(Title) || i.Title.Contains(Title));
        }
    }
}
