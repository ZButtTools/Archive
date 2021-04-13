using Microsoft.EntityFrameworkCore;
using Archive.Models;


namespace Archive.Data
{
    public class ArchiveContext : DbContext
    {
        public ArchiveContext(DbContextOptions<ArchiveContext> options)
            : base(options)
        {
        }

        public DbSet<Sculpt> Sculpts {get; set;}
    }
}
