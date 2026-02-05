using MusicHub.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicHub.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> Get(int id);
        Task<List<User>> GetAllMusicians();
        Task<User?> GetUserByUsername(string username);
    }
}
