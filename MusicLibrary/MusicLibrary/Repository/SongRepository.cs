using Microsoft.EntityFrameworkCore;
using MusicLibrary.Data;
using MusicLibrary.Models;
using MusicLibrary.Repository.IRepository;

namespace MusicLibrary.Repository
{
    public class SongRepository : ISongRepository<Song>
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

        public async Task<Song> LikeASong(int id)
        {
            var existSong = await _context.Songs.FirstOrDefaultAsync(song => song.Id == id);

            if(existSong != null)
            {
                existSong.Likes++;
                await _context.SaveChangesAsync();
            }

            return await Task.FromResult(existSong);
        }

        public async Task<Song> Update(int id, Song item)
        {
            var existSong = await _context.Songs.FirstOrDefaultAsync(song => song.Id == id);

            if(existSong != null)
            {
                existSong.Title = item.Title;
                existSong.Artist = item.Artist;
                existSong.Album = item.Album;
                existSong.ReleaseDate = item.ReleaseDate;
                existSong.Genre = item.Genre;

                await _context.SaveChangesAsync();
            }

            return await Task.FromResult(existSong);
        }

        

        
    }
}
