using Microsoft.Extensions.DependencyInjection;
using MusicHub.Helpers;
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
    public partial class MusicHub : BaseForm
    {
        private readonly IServiceProvider _serviceProvider;
        private UserControl? _currentControl;
        private int _currentArtistId;
        public MusicHub(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            lblCurrentUser.Text = AppSession.CurrentUser?.UserName;
            if (AppSession.IsUser)
            {
                btnManage.Enabled = false;
                btnManage.Visible = false;
            }
            ArtistList artistList = _serviceProvider.GetRequiredService<ArtistList>();
            artistList.ArtistSelected += ArtistList_ArtistSelected;
            ShowUserControl(artistList);
        }
        private void ShowUserControl(UserControl control)
        {
            mainPanel.Controls.Clear();
            _currentControl = control;
            control.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(control);
        }
        private async void ArtistList_ArtistSelected(int artistId)
        {
            _currentArtistId = artistId;
            AlbumList? albumList = _serviceProvider.GetRequiredService<AlbumList>();
            albumList.AlbumSelected += AlbumList_AlbumSelected;
            await albumList.ReadAlbums(artistId);
            ShowUserControl(albumList);
        }
        private async void AlbumList_AlbumSelected(int albumId)
        {
            SongList? songList = _serviceProvider.GetRequiredService<SongList>();
            await songList.ReadSongs(albumId);
            ShowUserControl(songList);
        }
        private async void btnBack_Click(object sender, EventArgs e)
        {
            if (_currentControl is SongList)
            {
                AlbumList? albumList = _serviceProvider.GetRequiredService<AlbumList>();
                albumList.AlbumSelected += AlbumList_AlbumSelected;
                await albumList.ReadAlbums(_currentArtistId);
                ShowUserControl(albumList);
            }
            else if (_currentControl is AlbumList)
            {
                ArtistList? artistList = _serviceProvider.GetRequiredService<ArtistList>();
                artistList.ArtistSelected += ArtistList_ArtistSelected;
                ShowUserControl(artistList);
            }
        }

        private async void btnManage_Click(object sender, EventArgs e)
        {
            ManageMusicHub form = _serviceProvider.GetRequiredService<ManageMusicHub>();
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
