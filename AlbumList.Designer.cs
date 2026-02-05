namespace MusicHub
{
    partial class AlbumList
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
            lblArtistName = new Label();
            dgvAlbum = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAlbum).BeginInit();
            SuspendLayout();
            // 
            // lblArtistName
            // 
            lblArtistName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblArtistName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblArtistName.ForeColor = Color.FromArgb(229, 231, 235);
            lblArtistName.Location = new Point(156, 15);
            lblArtistName.Name = "lblArtistName";
            lblArtistName.Size = new Size(845, 48);
            lblArtistName.TabIndex = 1;
            lblArtistName.Text = "ARTIST NAME";
            lblArtistName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvAlbum
            // 
            dgvAlbum.AllowUserToAddRows = false;
            dgvAlbum.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvAlbum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlbum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbum.Location = new Point(26, 76);
            dgvAlbum.MultiSelect = false;
            dgvAlbum.Name = "dgvAlbum";
            dgvAlbum.RowHeadersVisible = false;
            dgvAlbum.RowHeadersWidth = 51;
            dgvAlbum.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlbum.Size = new Size(1100, 500);
            dgvAlbum.TabIndex = 2;
            dgvAlbum.CellDoubleClick += dgvAlbum_CellDoubleClick;
            // 
            // AlbumList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            Controls.Add(dgvAlbum);
            Controls.Add(lblArtistName);
            Name = "AlbumList";
            Size = new Size(1150, 600);
            ((System.ComponentModel.ISupportInitialize)dgvAlbum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblArtistName;
        private DataGridView dgvAlbum;
    }
}
