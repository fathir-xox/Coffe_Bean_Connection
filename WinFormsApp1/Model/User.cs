using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjek.Model
{
    public class User
    {
        public int idUser { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string namaLengkap { get; set; }
        public bool isActive { get; set; }

        public User(int idUser, string username, string password,
                    string role, string namaLengkap, bool isActive)
        {
            this.idUser = idUser;
            this.username = username;
            this.password = password;
            this.role = role;
            this.namaLengkap = namaLengkap;
            this.isActive = isActive;
        }
    }
}
