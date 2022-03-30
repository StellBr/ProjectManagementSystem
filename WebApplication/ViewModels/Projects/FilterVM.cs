using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebApplication.ViewModels.Projects
{
    public class FilterVM
    {
        public List<int> SharedProjectIds { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }

        public Expression<Func<Project, bool>> GetFilter()
        {
            return i =>
                        (i.OwnerId == UserId || SharedProjectIds.Contains(i.Id)) &&
                        (string.IsNullOrEmpty(Title) || i.Title.Contains(Title));
        }
    }
}
