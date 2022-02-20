using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.ViewModels.Tasks
{
    public class EditVM
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public string Description { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }
    }
}
