using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_yama.Data;
using Microsoft.AspNetCore.Identity;

namespace e_yama.Models
{
    public class EYUsers : IdentityUser
    {
        public DateTime DateJoined { get; set; }
        public DateTime Modified { get; set; }
        public int Type { get; set; }
        public bool Deleted { get; set; }
    }
}
