using Microsoft.EntityFrameworkCore;
using RPMovies.Models;

namespace RPMovies.Data
{
    public class RPMoviesContext : DbContext
    {
        public RPMoviesContext(DbContextOptions<RPMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}