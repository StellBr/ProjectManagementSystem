using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Entities;

namespace WebApplication.ViewModels.Users
{
    public class IndexVM
    {
        public List<User> Items { get; set; }

        public int Page { get; set; }
        public int ItemsPerPage { get; set; }
        public int PagesCount { get; set; }
    }
}
