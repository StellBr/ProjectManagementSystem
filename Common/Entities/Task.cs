using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Task : BaseEntity
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }

        [ForeignKey("ProjectId")]
        public virtual Project ParentProject { get; set; }
    }
}
