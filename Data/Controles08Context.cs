using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Controles08.Models;

namespace Controles08.Data
{
    public class Controles08Context : DbContext
    {
        public Controles08Context (DbContextOptions<Controles08Context> options)
            : base(options)
        {
        }

        public DbSet<Controles08.Models.Movie> Movie { get; set; } = default!;
    }
}
