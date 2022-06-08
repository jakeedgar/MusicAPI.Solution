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
                new Artist { ArtistId = 1, ArtistName = "NOFX", Genre = "Punk", YearFounded = 1990 },
                new Artist { ArtistId = 2, ArtistName = "Tupac Shakur", Genre = "Hip Hop", YearFounded = 1989 },
                new Artist { ArtistId = 3, ArtistName = "Phil Ochs", Genre = "Folk", YearFounded = 1962 },
                new Artist { ArtistId = 4, ArtistName = "The Coup", Genre = "Hip Hop", YearFounded = 1991 },
                new Artist { ArtistId = 5, ArtistName = "Refused", Genre = "Punk", YearFounded = 1991 }
            );
        }
    }
}