using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using e_yama.Areas.Identity.Data;
using e_yama.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace e_yama.Data
{
    public class EfDataContext : IdentityDbContext
    {
        public EfDataContext(DbContextOptions options):base(options)
        {
            
        }
    }
}
