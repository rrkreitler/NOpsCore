using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NOps.Models
{
    public class NOpsContext : DbContext
    {
        public NOpsContext(DbContextOptions<NOpsContext> options) : base(options)
        {
        }

        public DbSet<Railroad> Railroads { get; set; }
    }
}
