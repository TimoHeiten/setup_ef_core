using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace simple_ef_core.Models
{
 
    public class TodoEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Date {get;set;}
        public bool IsDone { get; set; }
    }
}