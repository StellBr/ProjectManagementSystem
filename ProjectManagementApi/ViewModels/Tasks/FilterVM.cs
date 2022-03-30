using Common.Entities;
using ProjectManagementApi.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ProjectManagementApi.ViewModels.Tasks
{
    public class FilterVM
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public int AssigneeId { get; set; }

        public Expression<Func<Task, bool>> GetFilter()
        {
            return i =>
            (i.ProjectId == ProjectId) &&
            (AssigneeId <= 0 || i.AssigneeId==AssigneeId)&&
            (string.IsNullOrEmpty(Title) || i.Title.Contains(Title));
        }
    }
}
