using MusicHub.UI;

namespace MusicHub
{
    partial class CreateEditSong
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
            tbSongTitle = new TextBox();
            label2 = new Label();
            lblAlbumAuthor = new Label();
            label3 = new Label();
            lblCreateEditTitle = new Label();
            lblAlbumTitle = new Label();
            label5 = new Label();
            btnCancel = new MyButton();
            btnSave = new MyButton();
            SuspendLayout();
            // 
            // tbSongTitle
            // 
            tbSongTitle.BackColor = Color.FromArgb(229, 231, 235);
            tbSongTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbSongTitle.ForeColor = Color.FromArgb(56, 189, 248);
            tbSongTitle.Location = new Point(193, 288);
            tbSongTitle.Name = "tbSongTitle";
            tbSongTitle.Size = new Size(301, 30);
            tbSongTitle.TabIndex = 15;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.FromArgb(229, 231, 235);
            label2.Location = new Point(254, 258);
            label2.Name = "label2";
            label2.Size = new Size(135, 27);
            label2.TabIndex = 14;
            label2.Text = "SONG TITLE";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // lblAlbumAuthor
            // 
            lblAlbumAuthor.BackColor = Color.FromArgb(229, 231, 235);
            lblAlbumAuthor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblAlbumAuthor.ForeColor = Color.FromArgb(56, 189, 248);
            lblAlbumAuthor.Location = new Point(193, 145);
            lblAlbumAuthor.Name = "lblAlbumAuthor";
            lblAlbumAuthor.Size = new Size(301, 26);
            lblAlbumAuthor.TabIndex = 13;
            lblAlbumAuthor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.FromArgb(229, 231, 235);
            label3.Location = new Point(266, 122);
            label3.Name = "label3";
            label3.Size = new Size(146, 23);
            label3.TabIndex = 12;
            label3.Text = "ALBUM AUTHOR";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // lblCreateEditTitle
            // 
            lblCreateEditTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCreateEditTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblCreateEditTitle.ForeColor = Color.FromArgb(56, 189, 248);
            lblCreateEditTitle.Location = new Point(12, 54);
            lblCreateEditTitle.Name = "lblCreateEditTitle";
            lblCreateEditTitle.Size = new Size(676, 48);
            lblCreateEditTitle.TabIndex = 9;
            lblCreateEditTitle.Text = "ACTION";
            lblCreateEditTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAlbumTitle
            // 
            lblAlbumTitle.BackColor = Color.FromArgb(229, 231, 235);
            lblAlbumTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblAlbumTitle.ForeColor = Color.FromArgb(56, 189, 248);
            lblAlbumTitle.Location = new Point(193, 219);
            lblAlbumTitle.Name = "lblAlbumTitle";
            lblAlbumTitle.Size = new Size(301, 28);
            lblAlbumTitle.TabIndex = 19;
            lblAlbumTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.FromArgb(229, 231, 235);
            label5.Location = new Point(271, 196);
            label5.Name = "label5";
            label5.Size = new Size(118, 23);
            label5.TabIndex = 18;
            label5.Text = "ALBUM TITLE";
            label5.TextAlign = ContentAlignment.TopRight;
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
            btnCancel.Location = new Point(352, 353);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
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
            btnSave.Location = new Point(229, 353);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 21;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // CreateEditSong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            ClientSize = new Size(700, 500);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(lblAlbumTitle);
            Controls.Add(label5);
            Controls.Add(tbSongTitle);
            Controls.Add(label2);
            Controls.Add(lblAlbumAuthor);
            Controls.Add(label3);
            Controls.Add(lblCreateEditTitle);
            MaximizeBox = false;
            MaximumSize = new Size(700, 500);
            MinimumSize = new Size(700, 500);
            Name = "CreateEditSong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateEditSong";
            Controls.SetChildIndex(lblCreateEditTitle, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(lblAlbumAuthor, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(tbSongTitle, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(lblAlbumTitle, 0);
            Controls.SetChildIndex(btnCancel, 0);
            Controls.SetChildIndex(btnSave, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbSongTitle;
        private Label label2;
        private Label lblAlbumAuthor;
        private Label label3;
        private Label lblCreateEditTitle;
        private Label lblAlbumTitle;
        private Label label5;
        private MyButton btnCancel;
        private MyButton btnSave;
    }
}