﻿using MusicLibrary.Models;

namespace MusicLibrary.Repository.IRepository
{
    public interface ISongRepository<T>  where T: class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Create(T item);
        Task<T> Update(int id, T item);
        Task Delete(int id);
        Task<T> LikeASong(int id);
    }
}


//IEnumerable<T> GetAll();
//T GetById(int id);
//void Create(T item);
//void Update(int id, T item);
//void Delete(int id);
//void Save();