using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestValidations.Models
{
    public class User
    {     

        [Required]
        public int RollNumber { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}