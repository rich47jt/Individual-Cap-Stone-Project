using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Cap_Stone.Models
{
    public class Application
    {
        [Key]
        public int Id { get; set; }
        public string ApplicantName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string DesiredPosition { get; set; }
        public bool Voulenteer { get; set; }
        public string PersonalDescription { get; set; }
        public string Education { get; set; }
        public string References { get; set;  }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool Approval { get; set; }

    }
}
