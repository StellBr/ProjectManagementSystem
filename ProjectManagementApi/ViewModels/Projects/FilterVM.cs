using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectManagementApi.ViewModels.ApiProjects
{
    public class FilterVM
    {
        public string Title { get; set; }
        public int OwnerId { get; set; }
        public int ProjectId { get; set; }
        public List<string> SharedProjects { get; set; }

        public Expression<Func<Project, bool>> GetFilter()
        {
            return i =>
            (i.OwnerId == OwnerId || SharedProjects.Contains(i.Id.ToString())) &&
            (string.IsNullOrEmpty(Title) || i.Title.Contains(Title));
        }
    }
}
