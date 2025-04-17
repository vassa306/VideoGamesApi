using Microsoft.EntityFrameworkCore;
using VideoGameApi.NewFolder;

namespace VideoGameApi.Data
{
    public class VideoGameDbContext(DbContextOptions<VideoGameDbContext> options) : DbContext(options)
    {
        public DbSet<VideoGame> VideoGames => Set<VideoGame>();
        
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VideoGame>().HasData(
            new VideoGame
            {
                Id = 1,
                Title = "The Legend of Zelda: Breath of the Wild",
                Genre = "Action-adventure",
                Platform = "Nintendo Switch",
                Developer = "Nintendo EPD",
                Publisher = "Nintendo"
            },
            new VideoGame
            {
                Id = 2,
                Title = "The Witcher 3: Wild Hunt",
                Genre = "Action role-playing",
                Platform = "PC, PS4, Xbox One, Nintendo Switch",
                Developer = "CD Projekt Red",
                Publisher = "CD Projekt"
            },
            new VideoGame
            {
                Id = 3,
                Title = "Dark Souls III",
                Genre = "Action role-playing",
                Platform = "PC, PS4, Xbox One",
                Developer = "FromSoftware",
                Publisher = "Bandai Namco Entertainment"
            }
            );
        }
    }
}
