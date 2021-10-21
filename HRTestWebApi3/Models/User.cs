using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRTestWebApi3.Models
{
    public class User
    {
                public int ID { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        
        
        [DataType(DataType.Date)]
        [Display(Name = "Date Of birth")]
        [Required()]

        public DateTime? DateOfBirth { get; set; }
        

 
    }
}
