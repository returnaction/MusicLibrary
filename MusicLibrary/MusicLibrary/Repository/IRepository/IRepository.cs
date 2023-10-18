using MusicLibrary.Models;

namespace MusicLibrary.Repository.IRepository
{
    public interface IRepository<T>  where T: class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T item);
        void Update(int id, T item);
        void Delete(int id);
        void Save();
    }
}
