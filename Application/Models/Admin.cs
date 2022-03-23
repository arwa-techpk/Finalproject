using System;
using System.Collections.Generic;

#nullable disable

namespace Ahaji.Models
{
    // user role
    public partial class Admin
    {
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }
        public string AEmail { get; set; }
        public string Role { get; set; }
    }

    public enum UserRoles 
    {
        Manager,
        Customer,
        GameMaster,
        Supervisior
    }
}
