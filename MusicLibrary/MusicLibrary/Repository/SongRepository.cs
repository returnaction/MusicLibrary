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

        public void Create(Song item)
        {
            _context.Songs.Add(item);
        }

        public void Delete(int id)
        {
            var song = _context.Songs.FirstOrDefault(song => song.Id == id);
            if (song != null)
                _context.Remove(song);
        }


        public IEnumerable<Song> GetAll()
        {
            return _context.Songs.ToList();
        }

        public Song GetById(int id)
        {
            return _context.Songs.FirstOrDefault(song => song.Id == id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(int id, Song item)
        {
            var existProduct = _context.Songs.FirstOrDefault(song => song.Id == id);

            if(existProduct != null)
            {
                existProduct.Title = item.Title;
                existProduct.Artist = item.Artist;
                existProduct.Album = item.Album;
                existProduct.ReleaseDate = item.ReleaseDate;
                existProduct.Genre = item.Genre;
            }
        }
    }
}
