using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.ViewModels.Projects
{
    public class ShareVM
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public List<int> UserIds { get; set; }
        public List<User> Users { get; set; }
        public List<UserToProject> Shares { get; set; }
    }
}
