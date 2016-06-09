using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gogogo.Models
{
    public class Users
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone_Number { get; set; }
        public string Roles { get; set; }
        public string Date_Registration { get; set; }
        public string Date_Birth { get; set; }
        public string Follow { get; set; }
        public string Follower { get; set; }
        public string Sex { get; set; }
        public string Avatar { get; set; }
        public string Karma { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Job { get; set; }

    }
}