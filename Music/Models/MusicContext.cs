using Microsoft.EntityFrameworkCore;

namespace Music.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options)
            : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Artist>()
            .HasData(
                new Artist { ArtistId = 1, ArtistName = "NOFX", Genre = "Punk", YearFounded = 1990 }
            );
        }
    }
}