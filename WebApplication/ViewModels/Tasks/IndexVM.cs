using System;
using System.Collections.Generic;
using System.Linq;
using Common.Entities;

namespace WebApplication.ViewModels.Tasks
{
    public class IndexVM
    {
        public List<Task> Items { get; set; }
        public int ParentId { get; set; }
        public Project ParentProject { get; set; } 
    }
}
