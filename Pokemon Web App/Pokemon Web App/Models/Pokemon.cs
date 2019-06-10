using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon_Web_App.Models
{
    public class Pokemon
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public string Gender { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Abilities { get; set; }
        [DisplayName("Photo:")]
        public string ImageLocation { get; set; }
    }
}
