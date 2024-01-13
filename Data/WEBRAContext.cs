using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WEBRA.Models;

namespace WEBRA.Data
{
    public class WEBRAContext : DbContext
    {
        public WEBRAContext (DbContextOptions<WEBRAContext> options)
            : base(options)
        {
        }

        public DbSet<WEBRA.Models.Book> Book { get; set; } = default!;
        public DbSet<WEBRA.Models.Publisher> Publisher { get; set; } = default!;
    }
}
