using Microsoft.EntityFrameworkCore;
using MusicLibrary.Models;

namespace MusicLibrary.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    Id = 1,
                    Title = "I am back",
                    Artist = "Eminem",
                    Album = "The hood",
                    ReleaseDate = DateTime.Now,
                    Genre = "Rap"
                },
                new Song
                {
                    Id = 2,
                    Title = "Hello",
                    Artist = "Eminem",
                    Album = "The hood",
                    ReleaseDate = DateTime.Now,
                    Genre = "Rap"
                },
                new Song
                {
                    Id = 3,
                    Title = "Sacramento",
                    Artist = "Eminem",
                    Album = "Shady",
                    ReleaseDate = DateTime.Now,
                    Genre = "Rap"
                },
                new Song
                {
                    Id = 4,
                    Title = "Table on ",
                    Artist = "Eminem",
                    Album = "Shady",
                    ReleaseDate = DateTime.Now,
                    Genre = "Rap"
                },
                new Song
                {
                    Id = 5,
                    Title = "No more killing",
                    Artist = "Eminem",
                    Album = "Shady",
                    ReleaseDate = DateTime.Now,
                    Genre = "Rap"
                });
        }
    }
}
