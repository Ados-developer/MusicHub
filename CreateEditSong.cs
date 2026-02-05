using MusicHub.Entities;
using MusicHub.Helpers;
using MusicHub.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicHub
{
    public partial class CreateEditSong : BaseForm
    {
        private readonly ISongRepository _songRepository;
        private readonly IAlbumRepository _albumRepository;
        public CreateEditSong(ISongRepository songRepository, IAlbumRepository albumRepository)
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            _songRepository = songRepository;
            _albumRepository = albumRepository;
        }
        private int _songId = 0;
        private int _albumId = 0;

        public async Task SetAlbum(int albumId)
        {
            _albumId = albumId;
            Album? album = await _albumRepository.Get(albumId);
            if (album == null) return;
            lblAlbumAuthor.Text = album.Author?.ArtistName;
            lblAlbumTitle.Text = album.Title;
        }
        public void EditSong(Song song)
        {
            this.Text = "EDIT SONG";
            this.lblCreateEditTitle.Text = "EDIT SONG";
            this.lblAlbumAuthor.Text = song.Album?.Author?.ArtistName;
            this.lblAlbumTitle.Text = song.Album?.Title;
            this.tbSongTitle.Text = song.Title;
            this._songId = song.Id;
            this._albumId = song.AlbumId;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_songId == 0)
            {
                Song song = new Song();
                song.Title = tbSongTitle.Text;
                song.AlbumId = _albumId;
                await _songRepository.AddSong(song);
            }
            else
            {
                Song? song = await _songRepository.Get(_songId);
                if (song != null)
                {
                    song.Title = this.tbSongTitle.Text;
                }
            }
            await _songRepository.SaveChangesAsync();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
