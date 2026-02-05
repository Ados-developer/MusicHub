using Microsoft.Extensions.DependencyInjection;
using MusicHub.Entities;
using MusicHub.Helpers;
using MusicHub.Interfaces;
using MusicHub.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MusicHub
{
    public partial class SongManage : UserControl
    {
        private readonly ISongRepository _songRepo;
        private readonly IAlbumRepository _albumRepo;
        private readonly IServiceProvider _serviceProvider;

        private int _currentAlbumId;
        public SongManage(ISongRepository songRepo, IAlbumRepository albumRepo, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _songRepo = songRepo;
            _albumRepo = albumRepo;
            _serviceProvider = serviceProvider;
            SettingsHelper.ApplyStandardSettingsGrid(dgvSongs);
        }
        public async Task ReadSongs(int AlbumId)
        {
            _currentAlbumId = AlbumId;
            Album? album = await _albumRepo.Get(AlbumId);
            lblAlbumTitle.Text = album?.Title;
            DataTable SongsTable = new DataTable();
            SongsTable.Columns.Add("ID");
            SongsTable.Columns.Add("Artist");
            SongsTable.Columns.Add("Album");
            SongsTable.Columns.Add("Title");
            List<Song> songs = await _songRepo.GetSongsFromAlbum(AlbumId);
            foreach (Song song in songs)
            {
                DataRow row = SongsTable.NewRow();
                row["ID"] = song.Id;
                row["Artist"] = song.Album?.Author?.ArtistName;
                row["Album"] = song.Album?.Title;
                row["Title"] = song.Title;

                SongsTable.Rows.Add(row);
            }
            dgvSongs.DataSource = null;
            dgvSongs.DataSource = SongsTable;
            if (dgvSongs.Columns["ID"] != null)
            {
                dgvSongs.Columns["ID"]!.Visible = false;
            }
        }

        private async void btnAddSong_Click(object sender, EventArgs e)
        {
            CreateEditSong form = _serviceProvider.GetRequiredService<CreateEditSong>();
            await form.SetAlbum(_currentAlbumId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await ReadSongs(_currentAlbumId);
            }
        }

        private async void btnEditSong_Click(object sender, EventArgs e)
        {
            string? val = this.dgvSongs.SelectedRows[0].Cells[0].Value!.ToString();
            if (val == null || val.Length == 0) return;
            int songId = int.Parse(val);
            Song? song = await _songRepo.Get(songId);
            if (song == null) return;
            CreateEditSong form = _serviceProvider.GetRequiredService<CreateEditSong>();
            form.EditSong(song);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await ReadSongs(_currentAlbumId);
            }
        }

        private async void btnDeleteSong_Click(object sender, EventArgs e)
        {
            string? val = this.dgvSongs.SelectedRows[0].Cells[0].Value!.ToString();
            if (val == null || val.Length == 0) return;
            int songId = int.Parse(val);
            Song? song = await _songRepo.Get(songId);
            if (song == null) return;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Song ?", "Delete Song", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            await _songRepo.DeleteSong(song);
            await _songRepo.SaveChangesAsync();
            await ReadSongs(_currentAlbumId);
        }
    }
}
