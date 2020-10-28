using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie_2.Models;

namespace RazorPagesMovie_2.Data
{
    public class RazorPagesMovie_2Context : DbContext
    {
        public RazorPagesMovie_2Context (DbContextOptions<RazorPagesMovie_2Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie_2.Models.Movie> Movie { get; set; }
    }
}
