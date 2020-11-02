using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class AddUser
    {
        [Required(ErrorMessage = "User Name Is Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "First Name Is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Is Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email Is Required")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Password Is Required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Location Is Required")]
        public string Location { get; set; }
            
        }
}
