using Common.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.ViewModels.Comments
{
    public class CreateVM
    {
        public int TaskId { get; set; } 
        public string Topic { get; set; }
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
    }
}
