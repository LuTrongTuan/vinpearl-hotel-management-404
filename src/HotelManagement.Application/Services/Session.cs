using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Application.Services
{
    public static class Session
    {
        public static string Username { get; set; }
        public static int Id { get; set; }
        public static int Role{ get; set; }
        public static void CloseSeesion()
        {
            Username = string.Empty;
            Id = -1;
            Role = -1;
        }
    }
}
