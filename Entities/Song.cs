using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MusicHub.Entities
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int AlbumId { get; set; }
        [ForeignKey(nameof(AlbumId))]
        public Album? Album { get; set; }
        public string AlbumTitle { get; set; } = string.Empty;
        public string AuthorName { get; set; } = string.Empty;
    }
}
