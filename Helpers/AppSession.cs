using MusicHub.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicHub.Helpers
{
    public static class AppSession
    {
        public static User? CurrentUser { get; private set; }
        public static bool IsLoggedIn => CurrentUser != null;
        public static bool IsAdmin => CurrentUser?.Role == "Admin";
        public static bool IsMusician => CurrentUser?.Role == "Musician";
        public static bool IsUser => CurrentUser?.Role == "User";

        public static void Login(User user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }

    }
}
