using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationForm.Models
{
    public class User
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public String PhoneNumber { get; set; }

        public string Gender { get; set; }

        public String Age { get; set; }

        public string Address { get; set; }
    }
    
}