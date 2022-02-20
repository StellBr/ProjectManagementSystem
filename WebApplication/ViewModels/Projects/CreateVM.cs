using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.ViewModels.Projects
{
    public class CreateVM
    {
        [Required(ErrorMessage = "This field is required!")]
        public string Title { get; set; }

        [Display(Name = "Owner")]
        public int OwnerId { get; set; }
    }
}
