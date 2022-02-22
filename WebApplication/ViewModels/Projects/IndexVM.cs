using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Entities;
using WebApplication.ViewModels.Shared;

namespace WebApplication.ViewModels.Projects
{
    public class IndexVM
    {
        public List<Project> Items { get; set; }
        public List<Project> sharedItems { get; set; }
        public PagerVM Pager { get; set; }
     
    }
}
