using Microsoft.EntityFrameworkCore;
using MusicHub.Data;
using MusicHub.Entities;
using MusicHub.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicHub.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        private readonly MusicHubDbContext _db;
        public AlbumRepository(MusicHubDbContext db)
        {
            _db = db;
        }
        public async Task<Album?> Get(int id)
        {
            return await _db.Albums
                .Include(a => a.Author)
                .FirstOrDefaultAsync(a => a.Id == id);
        }
        public async Task<List<Album>> GetAll()
        {
            return await _db.Albums
                .Include(a => a.Author)
                .ToListAsync();
        }
        public async Task<List<Album>> GetAlbumsByArtist(int artistId)
        {
            return await _db.Albums
                .Where(a => a.AuthorId == artistId)
                .Include(a => a.Author)
                .ToListAsync();
        }
        public async Task AddAlbum(Album album)
        {
            await _db.Albums.AddAsync(album);    
        }
        public Task DeleteAlbum(Album album)
        {
            _db.Albums.Remove(album);
            return Task.CompletedTask;
        }
        public async Task SaveChangesAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
