using Common.Entities;
using ProjectManagementApi.ViewModels.Shared;
using ProjectManagementApi.ViewModels.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManagementApi.ViewModels.ApiTasks
{
    public class IndexVM
    {
        public List<Task> Items { get; set; }
        public FilterVM Filter { get; set; }
        public PagerVM Pager { get; set; }
    }
}
