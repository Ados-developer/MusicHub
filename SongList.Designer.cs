namespace MusicHub
{
    partial class SongList
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
            dgvSong = new DataGridView();
            lblAlbumTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSong).BeginInit();
            SuspendLayout();
            // 
            // dgvSong
            // 
            dgvSong.AllowUserToAddRows = false;
            dgvSong.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvSong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSong.Location = new Point(24, 76);
            dgvSong.MultiSelect = false;
            dgvSong.Name = "dgvSong";
            dgvSong.RowHeadersVisible = false;
            dgvSong.RowHeadersWidth = 51;
            dgvSong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSong.Size = new Size(900, 500);
            dgvSong.TabIndex = 4;
            // 
            // lblAlbumTitle
            // 
            lblAlbumTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAlbumTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblAlbumTitle.ForeColor = Color.FromArgb(229, 231, 235);
            lblAlbumTitle.Location = new Point(273, 12);
            lblAlbumTitle.Name = "lblAlbumTitle";
            lblAlbumTitle.Size = new Size(406, 48);
            lblAlbumTitle.TabIndex = 3;
            lblAlbumTitle.Text = "ALBUM TITLE";
            lblAlbumTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SongList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            Controls.Add(dgvSong);
            Controls.Add(lblAlbumTitle);
            Name = "SongList";
            Size = new Size(950, 600);
            ((System.ComponentModel.ISupportInitialize)dgvSong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSong;
        private Label lblAlbumTitle;
    }
}
