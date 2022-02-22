using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Entities;
using WebApplication.ViewModels.Shared;

namespace WebApplication.ViewModels.Users
{
    public class IndexVM
    {
        public List<User> Items { get; set; }
        public PagerVM Pager { get; set; }
        public FilterVM Filter { get; set; }
    }
}
