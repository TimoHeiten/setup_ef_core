using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace simple_ef_core.Models
{
 
    public class TodoItem
    {
        [Required]
        public string Content { get; set; }
        [Required]
        public string Date {get;set;}
        public bool IsDone { get; set; }
    }
}