using System;
using System.Collections.Generic;
using System.Text;

namespace MusicHub.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string ArtistName { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public List<Album> Albums { get; set; } = new();
    }
}
