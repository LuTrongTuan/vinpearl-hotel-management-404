using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Application.DTOs.Account
{
    public class AccountDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }
        public string EnterNewPassword { get; set; }
        public string Email { get; set; }

        public string check()
        {
            if (Password == string.Empty) return "Bạn chưa nhập mật khẩu cũ";
            if (NewPassword == string.Empty) return "Bạn chưa nhập mật khẩu mới";
            if (EnterNewPassword == string.Empty) return "Bạn chưa nhập lại mật khẩu mới";
            if (EnterNewPassword != NewPassword) return "Vui lòng nhập lại mật khẩu khớp với mật khẩu mới";
            return "Ok";
        }
    }
}
