using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Application.Services
{
    public static class RandomPassword
    {
        public static string randomString(this Random random,bool lawcase, int size)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                //append() là nối chuối
                builder.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))));
            }

            if (lawcase) return builder.ToString().ToLower();
            return builder.ToString();
        }
        public static string password(this Random random)
        {
            //Tạo ra lớp đối tượng để xây dựng chuỗi
            StringBuilder builder = new StringBuilder();
            builder.Append(random.randomString(false, 4));
            builder.Append(random.Next(0, 999));
            return builder.ToString();
        }
    }
}
