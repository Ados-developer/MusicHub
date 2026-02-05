using Microsoft.Extensions.DependencyInjection;
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
    public partial class ManageMusicHub : BaseForm
    {
        private readonly IServiceProvider _serviceProvider;
        private UserControl? _currentControl;
        public ManageMusicHub(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            btnBack.Visible = false;
            btnBack.Enabled = false;
            AlbumManage albumManage = _serviceProvider.GetRequiredService<AlbumManage>();
            albumManage.AlbumSelected += AlbumManage_AlbumSelected;
            ShowUserControl(albumManage);
        }
        private void ShowUserControl(UserControl control)
        {
            ManagePanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            _currentControl = control;
            ManagePanel.Controls.Add(control);
        }
        private async void AlbumManage_AlbumSelected(int albumId)
        {
            btnBack.Visible = true;
            btnBack.Enabled = true;
            SongManage? songManage = _serviceProvider.GetRequiredService<SongManage>();
            await songManage.ReadSongs(albumId);
            ShowUserControl(songManage);
        }

        private async void btnBack_Click(object sender, EventArgs e)
        {
            if(_currentControl is SongManage)
            {
                AlbumManage? albumManage = _serviceProvider.GetRequiredService<AlbumManage>();
                albumManage.AlbumSelected += AlbumManage_AlbumSelected;
                await albumManage.ReadAlbums();
                ShowUserControl(albumManage);
            }
            if(_currentControl is AlbumManage)
            {
                btnBack.Enabled = false;
                btnBack.Visible = false;
            }
        }
    }
}
