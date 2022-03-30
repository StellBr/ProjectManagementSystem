using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication.ViewModels.Shared;
using Task = Common.Entities.Task;

namespace WebApplication.ViewModels.Tasks
{
    public class DetailsVM
    {
        public List<Comment> Comments { get; set; }
        public List<Worklog> Worklogs { get; set; }      
        public int ParentId { get; set; }
        public Task ParentTask { get; set; }
        public PagerVM Pager { get; set; }
       
       
    }
}
