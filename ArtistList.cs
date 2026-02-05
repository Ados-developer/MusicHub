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
    public partial class ArtistList : UserControl
    {
        private readonly IUserRepository _userRepo;
        public ArtistList(IUserRepository userRepo)
        {
            _userRepo = userRepo;
            InitializeComponent();
            SettingsHelper.ApplyStandardSettingsGrid(dgvArtist);
        }
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await ReadMusicians();
        }
        public async Task ReadMusicians()
        {
            DataTable musiciansTable = new DataTable();
            musiciansTable.Columns.Add("ID");
            musiciansTable.Columns.Add("Username");
            musiciansTable.Columns.Add("Artist Name");

            List<User> musicians = await _userRepo.GetAllMusicians();
            foreach (User musician in musicians)
            {
                DataRow row = musiciansTable.NewRow();
                row["ID"] = musician.Id;
                row["Username"] = musician.UserName;
                row["Artist Name"] = musician.ArtistName;

                musiciansTable.Rows.Add(row);
            }
            dgvArtist.DataSource = null;
            dgvArtist.DataSource = musiciansTable;
            if (dgvArtist.Columns["ID"] != null)
            {
                dgvArtist.Columns["ID"]!.Visible = false;
            }
        }
        public event Action<int>? ArtistSelected;
        private void dgvArtist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string? val = this.dgvArtist.SelectedRows[0].Cells[0].Value!.ToString();
            if (val == null || val.Length == 0) return;
            int artistId = int.Parse(val);
            ArtistSelected?.Invoke(artistId);
        }
    }
}
