using MusicHub.Entities;
using MusicHub.Helpers;
using MusicHub.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MusicHub
{
    public partial class LoginForm : BaseForm
    {
        private readonly IUserRepository _userRepo;
        public LoginForm(IUserRepository userRepo)
        {
            InitializeComponent();
            _userRepo = userRepo;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbLoginUsername.Text;
            string password = tbLoginPassword.Text;
            User? user = await _userRepo.GetUserByUsername(username);
            if (user == null || !PasswordHelper.VerifyPassword(password, user.PasswordHash))
            {
                MessageBox.Show("Invalid username or password");
                return;
            }
            AppSession.Login(user);
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
