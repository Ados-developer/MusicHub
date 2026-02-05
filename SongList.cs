using MusicHub.Entities;
using MusicHub.Helpers;
using MusicHub.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MusicHub
{
    public partial class SongList : UserControl
    {
        private readonly ISongRepository _songRepo;
        private readonly IAlbumRepository _albumRepo;
        public SongList(IAlbumRepository albumRepo, ISongRepository songRepo)
        {
            _albumRepo = albumRepo;
            _songRepo = songRepo;
            InitializeComponent();
            SettingsHelper.ApplyStandardSettingsGrid(dgvSong);
        }
        public async Task ReadSongs(int albumId)
        {
            Album? album = await _albumRepo.Get(albumId);
            if (album == null)
            {
                return;
            }
            lblAlbumTitle.Text = album.Title;
            DataTable SongsTable = new DataTable();
            SongsTable.Columns.Add("ID");
            SongsTable.Columns.Add("Artist");
            SongsTable.Columns.Add("Album");
            SongsTable.Columns.Add("Title");

            List<Song> songs = await _songRepo.GetSongsFromAlbum(albumId);
            foreach (Song song in songs)
            {
                DataRow row = SongsTable.NewRow();
                row["ID"] = album.Id;
                row["Artist"] = song.Album?.Author?.ArtistName;
                row["Album"] = song.Album?.Title;
                row["Title"] = song.Title;

                SongsTable.Rows.Add(row);
            }
            dgvSong.DataSource = null;
            dgvSong.DataSource = SongsTable;
            if (dgvSong.Columns["ID"] != null)
            {
                dgvSong.Columns["ID"]!.Visible = false;
            }
        }
    }
}
