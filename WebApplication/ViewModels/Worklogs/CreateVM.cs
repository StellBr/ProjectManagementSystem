using Common.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace WebApplication.ViewModels.Worklogs
{
    public class CreateVM
    {
        public int UserId { get; set; }
        public int TaskId { get; set; }
        public DateTime Date { get; set; }
        public int Hours { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
             
        public Task Task { get; set; }
       
    }
}
