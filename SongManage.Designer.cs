using MusicHub.UI;

namespace MusicHub
{
    partial class SongManage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAlbumTitle = new Label();
            dgvSongs = new DataGridView();
            label1 = new Label();
            btnAddSong = new MyButton();
            btnEditSong = new MyButton();
            btnDeleteSong = new MyButton();
            ((System.ComponentModel.ISupportInitialize)dgvSongs).BeginInit();
            SuspendLayout();
            // 
            // lblAlbumTitle
            // 
            lblAlbumTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAlbumTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblAlbumTitle.ForeColor = Color.FromArgb(229, 231, 235);
            lblAlbumTitle.Location = new Point(14, 0);
            lblAlbumTitle.Name = "lblAlbumTitle";
            lblAlbumTitle.Size = new Size(1119, 52);
            lblAlbumTitle.TabIndex = 0;
            lblAlbumTitle.Text = "Album Title";
            lblAlbumTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvSongs
            // 
            dgvSongs.AllowUserToAddRows = false;
            dgvSongs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvSongs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSongs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSongs.Location = new Point(33, 97);
            dgvSongs.MultiSelect = false;
            dgvSongs.Name = "dgvSongs";
            dgvSongs.RowHeadersVisible = false;
            dgvSongs.RowHeadersWidth = 51;
            dgvSongs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSongs.Size = new Size(1100, 500);
            dgvSongs.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(229, 231, 235);
            label1.Location = new Point(444, 52);
            label1.Name = "label1";
            label1.Size = new Size(268, 42);
            label1.TabIndex = 11;
            label1.Text = "SONGS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddSong
            // 
            btnAddSong.BackColor = Color.FromArgb(229, 231, 235);
            btnAddSong.FlatAppearance.BorderSize = 0;
            btnAddSong.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 189, 248);
            btnAddSong.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 189, 248);
            btnAddSong.FlatStyle = FlatStyle.Flat;
            btnAddSong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddSong.ForeColor = Color.FromArgb(56, 189, 248);
            btnAddSong.Location = new Point(33, 63);
            btnAddSong.Name = "btnAddSong";
            btnAddSong.Size = new Size(94, 29);
            btnAddSong.TabIndex = 12;
            btnAddSong.Text = "ADD";
            btnAddSong.UseVisualStyleBackColor = false;
            btnAddSong.Click += this.btnAddSong_Click;
            // 
            // btnEditSong
            // 
            btnEditSong.BackColor = Color.FromArgb(229, 231, 235);
            btnEditSong.FlatAppearance.BorderSize = 0;
            btnEditSong.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 189, 248);
            btnEditSong.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 189, 248);
            btnEditSong.FlatStyle = FlatStyle.Flat;
            btnEditSong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditSong.ForeColor = Color.FromArgb(56, 189, 248);
            btnEditSong.Location = new Point(939, 62);
            btnEditSong.Name = "btnEditSong";
            btnEditSong.Size = new Size(94, 29);
            btnEditSong.TabIndex = 13;
            btnEditSong.Text = "EDIT";
            btnEditSong.UseVisualStyleBackColor = false;
            btnEditSong.Click += this.btnEditSong_Click;
            // 
            // btnDeleteSong
            // 
            btnDeleteSong.BackColor = Color.FromArgb(229, 231, 235);
            btnDeleteSong.FlatAppearance.BorderSize = 0;
            btnDeleteSong.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 189, 248);
            btnDeleteSong.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 189, 248);
            btnDeleteSong.FlatStyle = FlatStyle.Flat;
            btnDeleteSong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteSong.ForeColor = Color.FromArgb(56, 189, 248);
            btnDeleteSong.Location = new Point(1039, 62);
            btnDeleteSong.Name = "btnDeleteSong";
            btnDeleteSong.Size = new Size(94, 29);
            btnDeleteSong.TabIndex = 14;
            btnDeleteSong.Text = "DELETE";
            btnDeleteSong.UseVisualStyleBackColor = false;
            btnDeleteSong.Click += this.btnDeleteSong_Click;
            // 
            // SongManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            Controls.Add(btnDeleteSong);
            Controls.Add(btnEditSong);
            Controls.Add(btnAddSong);
            Controls.Add(label1);
            Controls.Add(dgvSongs);
            Controls.Add(lblAlbumTitle);
            Name = "SongManage";
            Size = new Size(1150, 600);
            ((System.ComponentModel.ISupportInitialize)dgvSongs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblAlbumTitle;
        private DataGridView dgvSongs;
        private Label label1;
        private MyButton btnAddSong;
        private MyButton btnEditSong;
        private MyButton btnDeleteSong;
    }
}
