using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToolShed.Models;

namespace ToolShed3.Models
{
    public class ToolShedContext : DbContext
    {
        public ToolShedContext (DbContextOptions<ToolShedContext> options)
            : base(options)
        {
        }

        public DbSet<ToolShed.Models.Tool> Tool { get; set; }
    }
}
