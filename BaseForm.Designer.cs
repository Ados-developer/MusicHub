using MusicHub.UI;

namespace MusicHub
{
    partial class BaseForm
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
            panelTitleBar = new Panel();
            btnMinimize = new TitleBarButton();
            lblTitle = new Label();
            btnMaximize = new TitleBarButton();
            btnClose = new TitleBarButton();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1387, 42);
            panelTitleBar.TabIndex = 0;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(30, 41, 59);
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 189, 248);
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 189, 248);
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMinimize.ForeColor = Color.FromArgb(56, 189, 248);
            btnMinimize.Location = new Point(1183, -1);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(64, 35);
            btnMinimize.TabIndex = 6;
            btnMinimize.Text = "🗕";
            btnMinimize.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTitle.ForeColor = Color.FromArgb(56, 189, 248);
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(138, 34);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "MusicHub";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.FromArgb(30, 41, 59);
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 189, 248);
            btnMaximize.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 189, 248);
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMaximize.ForeColor = Color.FromArgb(56, 189, 248);
            btnMaximize.Location = new Point(1253, -1);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(64, 35);
            btnMaximize.TabIndex = 5;
            btnMaximize.Text = "🗖";
            btnMaximize.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(30, 41, 59);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 189, 248);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 189, 248);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(56, 189, 248);
            btnClose.Location = new Point(1323, -1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(64, 35);
            btnClose.TabIndex = 4;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            ClientSize = new Size(1390, 750);
            Controls.Add(panelTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BaseForm";
            Text = "BaseForm";
            panelTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitleBar;
        private Label lblTitle;
        private TitleBarButton btnClose;
        private TitleBarButton btnMaximize;
        private TitleBarButton btnMinimize;
    }
}