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
    public partial class AlbumList : UserControl
    {
        private readonly IAlbumRepository _albumRepo;
        private readonly IUserRepository _userRepo;
        public AlbumList(IAlbumRepository albumRepo, IUserRepository userRepo)
        {
            _albumRepo = albumRepo;
            _userRepo = userRepo;
            InitializeComponent();
            SettingsHelper.ApplyStandardSettingsGrid(dgvAlbum);
        }
        public async Task ReadAlbums(int artistId)
        {
            User? artist = await _userRepo.Get(artistId);
            if (artist == null)
            {
                return;
            }
            lblArtistName.Text = artist.ArtistName;
            DataTable AlbumsTable = new DataTable();
            AlbumsTable.Columns.Add("ID");
            AlbumsTable.Columns.Add("Artist");
            AlbumsTable.Columns.Add("Title");

            List<Album> albums = await _albumRepo.GetAlbumsByArtist(artistId);
            foreach (Album album in albums)
            {
                DataRow row = AlbumsTable.NewRow();
                row["ID"] = album.Id;
                row["Artist"] = album.Author?.ArtistName;
                row["Title"] = album.Title;

                AlbumsTable.Rows.Add(row);
            }
            dgvAlbum.DataSource = null;
            dgvAlbum.DataSource = AlbumsTable;
            if (dgvAlbum.Columns["ID"] != null)
            {
                dgvAlbum.Columns["ID"]!.Visible = false;
            }
        }
        public event Action<int>? AlbumSelected;
        private void dgvAlbum_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string? val = this.dgvAlbum.SelectedRows[0].Cells[0].Value!.ToString();
            if (val == null || val.Length == 0) return;
            int albumId = int.Parse(val);
            AlbumSelected?.Invoke(albumId);
        }
    }
}
