using Microsoft.EntityFrameworkCore;
using MusicHub.Data;
using MusicHub.Entities;
using MusicHub.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicHub.Repositories
{
    public class SongRepository : ISongRepository
    {
        private readonly MusicHubDbContext _db;
        public SongRepository(MusicHubDbContext db)
        {
            _db = db;
        }
        public async Task<Song?> Get(int id)
        {
            return await _db.Songs
                .Include(s => s.Album)
                .ThenInclude(a => a!.Author)
                .FirstOrDefaultAsync(s => s.Id == id);
        }
        public async Task<List<Song>> GetSongsFromAlbum(int albumId)
        {
            return await _db.Songs
                .Where(s => s.AlbumId == albumId)
                .Include(s => s.Album)
                .ThenInclude(a => a!.Author)
                .ToListAsync();                
        }
        public async Task AddSong(Song song)
        {
            await _db.Songs.AddAsync(song);
        }
        public Task DeleteSong(Song song)
        {
            _db.Songs.Remove(song);
            return Task.CompletedTask;
        }
        public async Task SaveChangesAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
