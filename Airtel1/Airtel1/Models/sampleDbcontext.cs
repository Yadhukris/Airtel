using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airtel1.Models
{
    public class sampleDbcontext:DbContext
    {
        public sampleDbcontext(DbContextOptions<sampleDbcontext> options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<PhoneRecharge> phoneRecharges { get; set; }

        public DbSet<RoamingPlan> RoamingPlans { get; set; }

        public DbSet<International> internationals { get; set; }
    }
}
