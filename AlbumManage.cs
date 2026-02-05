using Microsoft.Extensions.DependencyInjection;
using MusicHub.Entities;
using MusicHub.Helpers;
using MusicHub.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicHub
{
    public partial class AlbumManage : UserControl
    {
        private readonly IAlbumRepository _albumRepository;
        private readonly IServiceProvider _serviceProvider;
        public AlbumManage(IAlbumRepository albumRepository, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            SettingsHelper.ApplyStandardSettingsGrid(dgvAlbum);
            _albumRepository = albumRepository;
            _serviceProvider = serviceProvider;
        }
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await ReadAlbums();
        }
        public async Task ReadAlbums()
        {
            if (AppSession.IsAdmin)
            {
                lblArtistName.Text = "All Artist's Albums";
                label1.Visible = false;
                List<Album> albums = await _albumRepository.GetAll();
                CreateFillAlbumTable(albums);
            }
            else if (AppSession.IsMusician)
            {
                label1.Visible = true;
                User? currentUser = AppSession.CurrentUser;
                lblArtistName.Text = currentUser?.ArtistName;
                List<Album> albums = await _albumRepository.GetAlbumsByArtist(currentUser!.Id);
                CreateFillAlbumTable(albums);
            }                
        }
        public void CreateFillAlbumTable(List<Album> albums)
        {
            DataTable albumTable = new DataTable();
            albumTable.Columns.Add("ID");
            albumTable.Columns.Add("Artist Name");
            albumTable.Columns.Add("Album Title");

            foreach (Album album in albums)
            {
                DataRow row = albumTable.NewRow();
                row["ID"] = album.Id;
                row["Artist Name"] = album.Author?.ArtistName;
                row["Album Title"] = album.Title;

                albumTable.Rows.Add(row);
            }
            dgvAlbum.DataSource = null;
            dgvAlbum.DataSource = albumTable;
            if (dgvAlbum.Columns["ID"] != null)
            {
                dgvAlbum.Columns["ID"]!.Visible = false;
            }
        }

        private async void btnAddAlbum_Click(object sender, EventArgs e)
        {
            CreateEditAlbum form = _serviceProvider.GetRequiredService<CreateEditAlbum>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                await ReadAlbums();
            }
        }

        private async void btnEditAlbum_Click(object sender, EventArgs e)
        {
            string? val = this.dgvAlbum.SelectedRows[0].Cells[0].Value!.ToString();
            if (val == null || val.Length == 0) return;
            int id = int.Parse(val);
            Album? album = await _albumRepository.Get(id);
            if (album == null) return;
            CreateEditAlbum form = _serviceProvider.GetRequiredService<CreateEditAlbum>();
            form.EditAlbum(album);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await ReadAlbums();
            }
        }

        private async void btnDeleteAlbum_Click(object sender, EventArgs e)
        {
            string? val = this.dgvAlbum.SelectedRows[0].Cells[0].Value!.ToString();
            if (val == null || val.Length == 0) return;
            int id = int.Parse(val);
            Album? album = await _albumRepository.Get(id);
            if (album == null) return;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this album ?", "Delete Album", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            await _albumRepository.DeleteAlbum(album);
            await _albumRepository.SaveChangesAsync();
            await ReadAlbums();
        }
        public event Action<int>? AlbumSelected;
        private async void dgvAlbum_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string? val = this.dgvAlbum.SelectedRows[0].Cells[0].Value!.ToString();
            if (val == null || val.Length == 0) return;
            int albumId = int.Parse(val);
            AlbumSelected?.Invoke(albumId);
        }
    }
}
