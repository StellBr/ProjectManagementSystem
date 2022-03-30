using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.ViewModels.Worklogs
{
    public class EditVM
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TaskId { get; set; }
        public DateTime Date { get; set; }
        public int Hours { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public Task Task { get; set; }
    }
}
