using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon_Web_App.Models
{
    public class Team
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string description { get; set; } 
    }
}
