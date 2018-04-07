using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Safa.SchoolManager.Web.FrontEnd.Models
{
    public class LoginViewModel
    {
        [Required( ErrorMessage="Email is required")]
        [DataType(DataType.EmailAddress, ErrorMessage="Should be email address")]
        public string Email { get; set; }

        [Required( ErrorMessage="Password is required")]
        [StringLength(255, ErrorMessage = "Must be between at least 5 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]        
        public string Password { get; set; }
    }
}