using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Common.Entities;

namespace WebApplication.ViewModels.Tasks
{
    public class CreateVM
    {
        public int ProjectId { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "This field is required!")]
        public DateTime Deadline { get; set; }    
    }
}
