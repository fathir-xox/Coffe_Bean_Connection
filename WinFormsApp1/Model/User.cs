using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjek.Model
{
    public class User : BaseModel
    {
        public int id_user { get; set; }
        public string? full_name { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }
        public UserRole role { get; set; }

    }
    public enum UserRole
    {
        Admin, Kasir
    }
}
