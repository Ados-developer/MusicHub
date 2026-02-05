
using MusicHub.UI;

namespace MusicHub
{
    partial class MusicHub
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
            label1 = new Label();
            lblCurrentUser = new Label();
            mainPanel = new Panel();
            btnLogout = new MyButton();
            btnManage = new MyButton();
            btnBack = new MyButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(56, 189, 248);
            label1.Location = new Point(26, 80);
            label1.Name = "label1";
            label1.Size = new Size(1150, 57);
            label1.TabIndex = 0;
            label1.Text = "MusicHub";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblCurrentUser.ForeColor = Color.FromArgb(229, 231, 235);
            lblCurrentUser.Location = new Point(810, 48);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(205, 30);
            lblCurrentUser.TabIndex = 3;
            lblCurrentUser.Text = "Current Login";
            lblCurrentUser.TextAlign = ContentAlignment.TopRight;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.Location = new Point(26, 138);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1150, 600);
            mainPanel.TabIndex = 4;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(229, 231, 235);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 189, 248);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 189, 248);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.FromArgb(56, 189, 248);
            btnLogout.Location = new Point(1021, 48);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(155, 29);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnManage
            // 
            btnManage.BackColor = Color.FromArgb(229, 231, 235);
            btnManage.FlatAppearance.BorderSize = 0;
            btnManage.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 189, 248);
            btnManage.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 189, 248);
            btnManage.FlatStyle = FlatStyle.Flat;
            btnManage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnManage.ForeColor = Color.FromArgb(56, 189, 248);
            btnManage.Location = new Point(60, 48);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(94, 29);
            btnManage.TabIndex = 1;
            btnManage.Text = "MANAGE";
            btnManage.UseVisualStyleBackColor = false;
            btnManage.Click += btnManage_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(229, 231, 235);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 189, 248);
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 189, 248);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(56, 189, 248);
            btnBack.Location = new Point(26, 48);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(28, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // MusicHub
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            ClientSize = new Size(1200, 750);
            Controls.Add(btnLogout);
            Controls.Add(btnManage);
            Controls.Add(btnBack);
            Controls.Add(mainPanel);
            Controls.Add(lblCurrentUser);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaption;
            MaximizeBox = false;
            MaximumSize = new Size(1200, 750);
            MinimumSize = new Size(1200, 750);
            Name = "MusicHub";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MusicHub";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(lblCurrentUser, 0);
            Controls.SetChildIndex(mainPanel, 0);
            Controls.SetChildIndex(btnBack, 0);
            Controls.SetChildIndex(btnManage, 0);
            Controls.SetChildIndex(btnLogout, 0);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblCurrentUser;
        private Panel mainPanel;
        private MyButton btnLogout;
        private MyButton btnManage;
        private MyButton btnBack;
    }
}