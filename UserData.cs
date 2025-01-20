using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventaDesktop
{
    public static class UserData
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string Email { get; set; }

        public static void Clear()
        {
            UserId = 0;
            Username = string.Empty;
            Email = string.Empty;
        }
    }

}
