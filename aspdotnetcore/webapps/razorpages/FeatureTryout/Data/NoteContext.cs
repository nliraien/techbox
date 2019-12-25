using Microsoft.EntityFrameworkCore;
using FeatureTryout.Models;

namespace FeatureTryout.Data
{
    public class NoteContext : DbContext
    {
        public NoteContext(DbContextOptions<NoteContext> options)
            : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }
    }
}