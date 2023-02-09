using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hardchord.Models;

namespace hardchord.Data
{
    public class hardchordContext : DbContext
    {
        public hardchordContext (DbContextOptions<hardchordContext> options)
            : base(options)
        {
        }

        public DbSet<Hardchord.Models.Usuarios> Usuarios { get; set; }

        public DbSet<Hardchord.Models.Prodcutos> Prodcutos { get; set; }

        public DbSet<Hardchord.Models.orders> orders { get; set; }

        public DbSet<Hardchord.Models.ventas> ventas { get; set; }
    }
}
