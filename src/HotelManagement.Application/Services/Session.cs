﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Application.Services
{
    public static class Session
    {
        public static string Username;
        public static void CloseSeesion()
        {
            Username = string.Empty;
        }
    }
}
