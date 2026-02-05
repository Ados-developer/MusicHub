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
    public partial class CreateEditAlbum : BaseForm
    {
        private readonly IAlbumRepository _albumRepo;
        private readonly IUserRepository _userRepo;
        public CreateEditAlbum(IAlbumRepository albumRepo, IUserRepository userRepo)
        {
            _albumRepo = albumRepo;
            _userRepo = userRepo;
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }
        private int albumId = 0;
        private async void CreateEditAlbum_Load(object sender, EventArgs e)
        {
            if (AppSession.IsAdmin)
            {
                cbArtists.Visible = true;
                lblAlbumAuthor.Visible = false;

                List<User> artists = await _userRepo.GetAllMusicians();

                cbArtists.DataSource = artists;
                cbArtists.DisplayMember = "ArtistName";
                cbArtists.ValueMember = "Id";
            }
            else
            {
                cbArtists.Visible = false;
                lblAlbumAuthor.Text = AppSession.CurrentUser?.ArtistName;
            }
        }
        public void EditAlbum(Album album)
        {
            this.Text = "EDIT ALBUM";
            this.lblCreateEditTitle.Text = "EDIT ALBUM";
            this.lblAlbumAuthor.Text = album?.Author?.ArtistName;
            this.tbAlbumTitle.Text = album?.Title;
            this.albumId = album!.Id;
            cbArtists.Visible = false;
            lblAlbumAuthor.Visible = true;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(albumId == 0)
            {
                int authorId = 0;
                if (AppSession.IsAdmin)
                {
                    if (cbArtists.SelectedItem == null)
                    {
                        MessageBox.Show("Choose an Artist");
                        return;
                    }
                    authorId = (int)cbArtists.SelectedValue!;
                }
                else
                {
                    authorId = AppSession.CurrentUser!.Id;
                }
                Album album = new Album();
                album.Title = this.tbAlbumTitle.Text;
                album.AuthorId = authorId;
                await _albumRepo.AddAlbum(album);
            }
            else
            {
                Album? album = await _albumRepo.Get(albumId);
                if (album != null)
                {
                    album.Title = this.tbAlbumTitle.Text;
                }
            }
            await _albumRepo.SaveChangesAsync();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
