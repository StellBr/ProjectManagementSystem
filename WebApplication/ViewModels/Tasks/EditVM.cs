using Common.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using static Common.Entities.Task;

namespace WebApplication.ViewModels.Tasks
{
    public class EditVM
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int OwnerId { get; set; }
        [Display(Name = "Assignee the Task")]
        public int AssigneeId { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }
        public enum TaskStatus
        {
            Pending,
            InProgress,
            InReview,
            Done
        }
        public TaskStatus Status { get; set; }
        public List<User> Users { get; set; }
    }
}
