using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Common.Entities
{
   public class Worklog : BaseEntity
    {
        public int UserId { get; set; }    
        public int TaskId { get; set; }  
        public DateTime Date { get; set; }
        public int Hours { get; set; }
        public string Description { get; set; }
       
        [ForeignKey("UserId")]
        public virtual User User { get; set; }    
        [ForeignKey("TaskId")]
        public virtual Task Task { get; set; }
    }
}
