using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Comment : BaseEntity
    {
        public int UserId { get; set; }
        public int TaskId { get; set; }
        public string Topic { get; set; }
        public string Content { get; set; }
        public DateTime DateTime { get; set; }

        [ForeignKey("TaskId")]
        public virtual Task Task { get; set; }
        [ForeignKey("UserId")]
        public virtual User Owner { get; set; }



    }
}
