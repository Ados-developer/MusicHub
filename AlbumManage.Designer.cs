using MusicHub.UI;
namespace MusicHub
{
    partial class AlbumManage
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
            dgvAlbum = new DataGridView();
            lblArtistName = new Label();
            label1 = new Label();
            btnAddAlbum = new MyButton();
            btnDeleteAlbum = new MyButton();
            btnEditAlbum = new MyButton();
            ((System.ComponentModel.ISupportInitialize)dgvAlbum).BeginInit();
            SuspendLayout();
            // 
            // dgvAlbum
            // 
            dgvAlbum.AllowUserToAddRows = false;
            dgvAlbum.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvAlbum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlbum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbum.Location = new Point(23, 94);
            dgvAlbum.MultiSelect = false;
            dgvAlbum.Name = "dgvAlbum";
            dgvAlbum.RowHeadersVisible = false;
            dgvAlbum.RowHeadersWidth = 51;
            dgvAlbum.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlbum.Size = new Size(1100, 500);
            dgvAlbum.TabIndex = 9;
            dgvAlbum.CellDoubleClick += dgvAlbum_CellDoubleClick;
            // 
            // lblArtistName
            // 
            lblArtistName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblArtistName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblArtistName.ForeColor = Color.FromArgb(56, 189, 248);
            lblArtistName.Location = new Point(52, 0);
            lblArtistName.Name = "lblArtistName";
            lblArtistName.Size = new Size(1047, 49);
            lblArtistName.TabIndex = 5;
            lblArtistName.Text = "Artist Name";
            lblArtistName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(229, 231, 235);
            label1.Location = new Point(478, 49);
            label1.Name = "label1";
            label1.Size = new Size(196, 42);
            label1.TabIndex = 10;
            label1.Text = "ALBUMS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddAlbum
            // 
            btnAddAlbum.BackColor = Color.FromArgb(229, 231, 235);
            btnAddAlbum.FlatAppearance.BorderSize = 0;
            btnAddAlbum.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 189, 248);
            btnAddAlbum.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 189, 248);
            btnAddAlbum.FlatStyle = FlatStyle.Flat;
            btnAddAlbum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddAlbum.ForeColor = Color.FromArgb(56, 189, 248);
            btnAddAlbum.Location = new Point(23, 59);
            btnAddAlbum.Name = "btnAddAlbum";
            btnAddAlbum.Size = new Size(94, 29);
            btnAddAlbum.TabIndex = 13;
            btnAddAlbum.Text = "ADD";
            btnAddAlbum.UseVisualStyleBackColor = false;
            btnAddAlbum.Click += this.btnAddAlbum_Click;
            // 
            // btnDeleteAlbum
            // 
            btnDeleteAlbum.BackColor = Color.FromArgb(229, 231, 235);
            btnDeleteAlbum.FlatAppearance.BorderSize = 0;
            btnDeleteAlbum.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 189, 248);
            btnDeleteAlbum.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 189, 248);
            btnDeleteAlbum.FlatStyle = FlatStyle.Flat;
            btnDeleteAlbum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteAlbum.ForeColor = Color.FromArgb(56, 189, 248);
            btnDeleteAlbum.Location = new Point(1029, 59);
            btnDeleteAlbum.Name = "btnDeleteAlbum";
            btnDeleteAlbum.Size = new Size(94, 29);
            btnDeleteAlbum.TabIndex = 14;
            btnDeleteAlbum.Text = "DELETE";
            btnDeleteAlbum.UseVisualStyleBackColor = false;
            btnDeleteAlbum.Click += this.btnDeleteAlbum_Click;
            // 
            // btnEditAlbum
            // 
            btnEditAlbum.BackColor = Color.FromArgb(229, 231, 235);
            btnEditAlbum.FlatAppearance.BorderSize = 0;
            btnEditAlbum.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 189, 248);
            btnEditAlbum.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 189, 248);
            btnEditAlbum.FlatStyle = FlatStyle.Flat;
            btnEditAlbum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditAlbum.ForeColor = Color.FromArgb(56, 189, 248);
            btnEditAlbum.Location = new Point(929, 59);
            btnEditAlbum.Name = "btnEditAlbum";
            btnEditAlbum.Size = new Size(94, 29);
            btnEditAlbum.TabIndex = 15;
            btnEditAlbum.Text = "EDIT";
            btnEditAlbum.UseVisualStyleBackColor = false;
            btnEditAlbum.Click += this.btnEditAlbum_Click;
            // 
            // AlbumManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            Controls.Add(btnEditAlbum);
            Controls.Add(btnDeleteAlbum);
            Controls.Add(btnAddAlbum);
            Controls.Add(label1);
            Controls.Add(dgvAlbum);
            Controls.Add(lblArtistName);
            Name = "AlbumManage";
            Size = new Size(1150, 600);
            ((System.ComponentModel.ISupportInitialize)dgvAlbum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAlbum;
        private Button button3;
        private Button button2;
        private Label lblArtistName;
        private Label label1;
        private MyButton btnAddAlbum;
        private MyButton btnDeleteAlbum;
        private MyButton btnEditAlbum;
    }
}
