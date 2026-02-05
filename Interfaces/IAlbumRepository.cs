using MusicHub.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicHub.Interfaces
{
    public interface IAlbumRepository
    {
        Task<Album?> Get(int id);
        Task<List<Album>> GetAll();
        Task<List<Album>> GetAlbumsByArtist(int artistId);
        Task AddAlbum(Album album);
        Task DeleteAlbum(Album album);
        Task SaveChangesAsync();
    }
}
