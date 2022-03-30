using Common.Entities;
using ProjectManagementApi.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementApi.ViewModels.ApiProjects
{
    public class IndexVM
    {
        public List<Project> Items { get; set; }
        public PagerVM Pager { get; set; }
        public FilterVM Filter { get; set; }
    }
}
