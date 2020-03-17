using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Cap_Stone.Models
{
    public class Review
    {
        [Key]
        public int id { get; set; }
        public int rating { get; set; }
        public string Description { get; set; }
    }
}
