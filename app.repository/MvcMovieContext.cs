using Microsoft.EntityFrameworkCore;
using System;
using app.domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.repository
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options) : base(options)
        {
       
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }

    }
}
