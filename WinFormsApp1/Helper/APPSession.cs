using FinalProjek.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace FinalProjek.Helper
{
    public static class APPSession
    {
        public static User CurrentUser { get; private set; }
        public static bool IsAuthenticated => CurrentUser != null;

        public static void SetUser(User user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
