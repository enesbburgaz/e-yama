using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace e_yama.Models
{
    public class Users
    {
        public int Id { get; set; } //pk
        public string Email { get; set; } //unique
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public DateTime DateJoined { get; set; }
        public DateTime Modified { get; set; }
        public int Type { get; set; }
        public bool Deleted { get; set; }
    }
}
