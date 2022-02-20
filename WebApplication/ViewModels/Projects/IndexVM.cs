using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Entities;

namespace WebApplication.ViewModels.Projects
{
    public class IndexVM
    {
       public List<Project> Items { get; set; }
        public List<Project> sharedItems { get; set; }

        public int Page { get; set; }
        public int ItemsPerPage { get; set; }
        public int PagesCount { get; set; }
    }
}
