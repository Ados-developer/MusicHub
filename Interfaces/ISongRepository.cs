using MusicHub.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicHub.Interfaces
{
    public interface ISongRepository
    {
        Task<Song?> Get(int id);
        Task<List<Song>> GetSongsFromAlbum(int albumId);
        Task AddSong(Song song);
        Task DeleteSong(Song song);
        Task SaveChangesAsync();
    }
}
