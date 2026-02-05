using Microsoft.EntityFrameworkCore;
using MusicHub.Data;
using MusicHub.Entities;
using MusicHub.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicHub.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MusicHubDbContext _db;
        public UserRepository(MusicHubDbContext db)
        {
            _db = db;
        }
        public async Task<User?> Get(int id)
        {
            return await _db.Users.FirstOrDefaultAsync(u => u.Id == id);
        } 
        public async Task<List<User>> GetAllMusicians()
        {
            return await _db.Users.Where(u => u.Role == "Musician").ToListAsync();
        }
        public async Task<User?> GetUserByUsername(string username)
        {
            return await _db.Users.FirstOrDefaultAsync(u => u.UserName == username);
        }
    }
}
