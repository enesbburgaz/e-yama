using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_yama.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;

namespace e_yama.Data
{
    public class EfDataContext : IdentityDataContext
    {
        public EfDataContext(DbContextOptions<IdentityDataContext> options):base(options)
        {
            
        }
    }
}
