using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvcsimples.Models;

namespace mvcsimples.Models
{
    public class mvcsimplesContext : DbContext
    {
        public mvcsimplesContext (DbContextOptions<mvcsimplesContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
    }
}
