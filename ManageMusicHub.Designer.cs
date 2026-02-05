using MusicHub.UI;

namespace MusicHub
{
    partial class ManageMusicHub
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
            ManagePanel = new Panel();
            btnBack = new MyButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(56, 189, 248);
            label1.Location = new Point(29, 80);
            label1.Name = "label1";
            label1.Size = new Size(1150, 53);
            label1.TabIndex = 1;
            label1.Text = "MusicHub";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManagePanel
            // 
            ManagePanel.Location = new Point(29, 138);
            ManagePanel.Name = "ManagePanel";
            ManagePanel.Size = new Size(1150, 600);
            ManagePanel.TabIndex = 5;
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
            btnBack.Location = new Point(29, 48);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(28, 29);
            btnBack.TabIndex = 7;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ManageMusicHub
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            ClientSize = new Size(1200, 750);
            Controls.Add(btnBack);
            Controls.Add(ManagePanel);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(229, 231, 235);
            MaximizeBox = false;
            MaximumSize = new Size(1200, 750);
            MinimumSize = new Size(1200, 750);
            Name = "ManageMusicHub";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ManageMusicHub";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(ManagePanel, 0);
            Controls.SetChildIndex(btnBack, 0);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel ManagePanel;
        private MyButton btnBack;
    }
}