using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Task : BaseEntity
    {
        public enum TaskStatus
        {
            Pending,
            InProgress,
            InReview,
            Done
        }

        public int ProjectId { get; set; }
        public int OwnerId { get; set; }
        public int AssigneeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }

        public TaskStatus Status { get; set; }

        [ForeignKey("ProjectId")]
        public virtual Project ParentProject { get; set; }

        [ForeignKey("OwnerId")]
        public virtual User Owner { get; set; }

        [ForeignKey("AssigneeId")]
        public virtual User Assignee { get; set; }
    }
}
