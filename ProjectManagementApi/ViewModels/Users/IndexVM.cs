using Common.Entities;
using ProjectManagementApi.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementApi.ViewModels.ApiUsers
{
    public class IndexVM
    {
        public FilterVM Filter { get; set; }
        public PagerVM Pager { get; set; }
        public List<User> Items { get; set; }

    }
}
