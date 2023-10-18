using Microsoft.EntityFrameworkCore;
using MusicLibrary.Data;
using MusicLibrary.Models;
using MusicLibrary.Repository.IRepository;

namespace MusicLibrary.Repository
{
    public class SongRepository : IRepository<Song>
    {
        private readonly ApplicationDbContext _context;

        public SongRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(Song item)
        {
            await _context.Songs.AddAsync(item);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var song = await _context.Songs.FirstOrDefaultAsync(song => song.Id == id);
            if (song != null)
                _context.Remove(song);
                await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Song>> GetAll()
        {
            return await _context.Songs.ToListAsync();
        }

        public async Task<Song> GetById(int id)
        {
            return await _context.Songs.FirstOrDefaultAsync(song => song.Id == id);
        }

        public async Task Update(int id, Song item)
        {
            var existProduct = await _context.Songs.FirstOrDefaultAsync(song => song.Id == id);

            if(existProduct != null)
            {
                existProduct.Title = item.Title;
                existProduct.Artist = item.Artist;
                existProduct.Album = item.Album;
                existProduct.ReleaseDate = item.ReleaseDate;
                existProduct.Genre = item.Genre;

                await _context.SaveChangesAsync();
            }
        }

        
    }
}
