using MusicHub.UI;

namespace MusicHub
{
    partial class CreateEditAlbum
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCreateEditTitle = new Label();
            lblAlbumAuthor = new Label();
            label3 = new Label();
            label2 = new Label();
            tbAlbumTitle = new TextBox();
            cbArtists = new ComboBox();
            btnSave = new MyButton();
            btnCancel = new MyButton();
            SuspendLayout();
            // 
            // lblCreateEditTitle
            // 
            lblCreateEditTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCreateEditTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblCreateEditTitle.ForeColor = Color.FromArgb(56, 189, 248);
            lblCreateEditTitle.Location = new Point(12, 96);
            lblCreateEditTitle.Name = "lblCreateEditTitle";
            lblCreateEditTitle.Size = new Size(676, 48);
            lblCreateEditTitle.TabIndex = 0;
            lblCreateEditTitle.Text = "ADD ALBUM";
            lblCreateEditTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAlbumAuthor
            // 
            lblAlbumAuthor.BackColor = Color.FromArgb(229, 231, 235);
            lblAlbumAuthor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblAlbumAuthor.ForeColor = Color.FromArgb(56, 189, 248);
            lblAlbumAuthor.Location = new Point(181, 258);
            lblAlbumAuthor.Name = "lblAlbumAuthor";
            lblAlbumAuthor.Size = new Size(344, 23);
            lblAlbumAuthor.TabIndex = 4;
            lblAlbumAuthor.Text = "ALBUM";
            lblAlbumAuthor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.FromArgb(229, 231, 235);
            label3.Location = new Point(267, 210);
            label3.Name = "label3";
            label3.Size = new Size(146, 23);
            label3.TabIndex = 3;
            label3.Text = "ALBUM AUTHOR";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.FromArgb(229, 231, 235);
            label2.Location = new Point(278, 294);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 5;
            label2.Text = "ALBUM TITLE";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // tbAlbumTitle
            // 
            tbAlbumTitle.BackColor = Color.FromArgb(229, 231, 235);
            tbAlbumTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbAlbumTitle.ForeColor = Color.FromArgb(56, 189, 248);
            tbAlbumTitle.Location = new Point(181, 334);
            tbAlbumTitle.Name = "tbAlbumTitle";
            tbAlbumTitle.Size = new Size(344, 30);
            tbAlbumTitle.TabIndex = 6;
            tbAlbumTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // cbArtists
            // 
            cbArtists.BackColor = Color.FromArgb(229, 231, 235);
            cbArtists.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            cbArtists.ForeColor = Color.FromArgb(56, 189, 248);
            cbArtists.FormattingEnabled = true;
            cbArtists.Location = new Point(181, 250);
            cbArtists.Name = "cbArtists";
            cbArtists.Size = new Size(344, 31);
            cbArtists.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(229, 231, 235);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 189, 248);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 189, 248);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.FromArgb(56, 189, 248);
            btnSave.Location = new Point(230, 379);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(229, 231, 235);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 189, 248);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 189, 248);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(56, 189, 248);
            btnCancel.Location = new Point(343, 379);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreateEditAlbum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            ClientSize = new Size(700, 500);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cbArtists);
            Controls.Add(tbAlbumTitle);
            Controls.Add(label2);
            Controls.Add(lblAlbumAuthor);
            Controls.Add(label3);
            Controls.Add(lblCreateEditTitle);
            MaximizeBox = false;
            MaximumSize = new Size(700, 500);
            MinimumSize = new Size(700, 500);
            Name = "CreateEditAlbum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateEditAlbum";
            Load += CreateEditAlbum_Load;
            Controls.SetChildIndex(lblCreateEditTitle, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(lblAlbumAuthor, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(tbAlbumTitle, 0);
            Controls.SetChildIndex(cbArtists, 0);
            Controls.SetChildIndex(btnSave, 0);
            Controls.SetChildIndex(btnCancel, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreateEditTitle;
        private Label lblAlbumAuthor;
        private Label label3;
        private Label label2;
        private TextBox tbAlbumTitle;
        private ComboBox cbArtists;
        private MyButton btnSave;
        private MyButton btnCancel;
    }
}