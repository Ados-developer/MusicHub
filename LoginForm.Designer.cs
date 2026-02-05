using MusicHub.UI;
namespace MusicHub
{
    partial class LoginForm
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
            label2 = new Label();
            tbLoginUsername = new TextBox();
            tbLoginPassword = new TextBox();
            label3 = new Label();
            btnLogin = new MyButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(56, 189, 248);
            label1.Location = new Point(12, 76);
            label1.Name = "label1";
            label1.Size = new Size(658, 51);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.FromArgb(229, 231, 235);
            label2.Location = new Point(272, 155);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 1;
            label2.Text = "USERNAME";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbLoginUsername
            // 
            tbLoginUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbLoginUsername.BackColor = Color.FromArgb(229, 231, 235);
            tbLoginUsername.BorderStyle = BorderStyle.FixedSingle;
            tbLoginUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbLoginUsername.ForeColor = Color.FromArgb(56, 189, 248);
            tbLoginUsername.Location = new Point(229, 186);
            tbLoginUsername.Name = "tbLoginUsername";
            tbLoginUsername.Size = new Size(215, 27);
            tbLoginUsername.TabIndex = 2;
            tbLoginUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // tbLoginPassword
            // 
            tbLoginPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbLoginPassword.BackColor = Color.FromArgb(229, 231, 235);
            tbLoginPassword.BorderStyle = BorderStyle.FixedSingle;
            tbLoginPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbLoginPassword.ForeColor = Color.FromArgb(56, 189, 248);
            tbLoginPassword.Location = new Point(229, 264);
            tbLoginPassword.Name = "tbLoginPassword";
            tbLoginPassword.Size = new Size(215, 27);
            tbLoginPassword.TabIndex = 4;
            tbLoginPassword.TextAlign = HorizontalAlignment.Center;
            tbLoginPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.FromArgb(229, 231, 235);
            label3.Location = new Point(272, 233);
            label3.Name = "label3";
            label3.Size = new Size(126, 28);
            label3.TabIndex = 3;
            label3.Text = "PASSWORD";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(229, 231, 235);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 189, 248);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 189, 248);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogin.ForeColor = Color.FromArgb(56, 189, 248);
            btnLogin.Location = new Point(272, 321);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(140, 29);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            ClientSize = new Size(682, 453);
            Controls.Add(btnLogin);
            Controls.Add(tbLoginPassword);
            Controls.Add(label3);
            Controls.Add(tbLoginUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaption;
            MaximizeBox = false;
            MaximumSize = new Size(700, 500);
            MinimumSize = new Size(700, 500);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbLoginUsername;
        private TextBox tbLoginPassword;
        private Label label3;
        private MyButton btnLogin;
    }
}