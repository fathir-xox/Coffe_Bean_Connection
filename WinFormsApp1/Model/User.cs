using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjek.Model
{
    public class User
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string NamaLengkap { get; set; }
        public bool IsActive { get; set; }
        public string StatusText => IsActive ? "Aktif" : "Nonaktif";
    }
}
