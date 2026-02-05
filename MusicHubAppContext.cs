using Microsoft.Extensions.DependencyInjection;
using MusicHub.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicHub
{
    public class MusicHubAppContext : ApplicationContext
    {
        private readonly IServiceProvider _services;

        public MusicHubAppContext(IServiceProvider services)
        {
            _services = services;
            ShowLogin();
        }

        private void ShowLogin()
        {
            var login = _services.GetRequiredService<LoginForm>();
            login.FormClosed += (s, e) =>
            {
                if (login.DialogResult == DialogResult.OK)
                    ShowMain();
                else
                    ExitThread();
            };
            login.Show();
        }

        private void ShowMain()
        {
            var main = _services.GetRequiredService<MusicHub>();
            main.FormClosed += (s, e) =>
            {
                AppSession.Logout();
                ShowLogin();
            };
            main.Show();
        }
    }
}
