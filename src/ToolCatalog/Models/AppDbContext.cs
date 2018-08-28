using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToolCatalog.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Tool> Tools { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<SSCUnit> SSCUnits { get; set; }

        
    }
}
