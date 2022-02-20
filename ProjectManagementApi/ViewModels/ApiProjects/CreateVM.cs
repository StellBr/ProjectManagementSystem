using Common.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementApi.ViewModels.ApiProjects
{
    public class CreateVM
    {
        public int OwnerId { get; set; }
        public string Title { get; set; }

    }
}
