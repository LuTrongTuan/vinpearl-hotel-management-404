using System.Net;
using System.Net.Mail;
using System.Threading;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs;

namespace HotelManagement.Application.Services
{
    public class SendMail : ISendMail
    {
        private SmtpClient _client;
        private NetworkCredential cred;
        private MailMessage msg;
        private Thread _sendEmailThread;

        public SendMail()
        {
            //Tạo một ứng dụng khách smtp mới để gửi thư của chúng ta
            _client = new SmtpClient("smtp.gmail.com", 25);
            //Tài khoản và mật khẩu để cung cấp cho chương trình 1 nơi để gửi thư từ
            cred = new NetworkCredential("lutuan24102002@gmail.com", "3508205067310");
            //Để gửi một email, trước tiên chúng ta phải tạo một thư mới, một email để gửi
            msg = new MailMessage();
        }
        public void sendMail(AccountDTO acc)
        {
            _sendEmailThread = new Thread(() =>
            {
                //Địa chỉ email người gửi
                msg.From = new MailAddress("lutuan24102002@gmail.com");
                //Địa chỉ email người nhận
                msg.To.Add(acc.Email);
                //Subject là chỉ định thông điệp chủ đề
                msg.Subject = "Bạn đã sử dụng tính năng quên mật khẩu";
                //Body là tạo một phần nội dung thông điệp khi mail đến người nhận
                msg.Body = "Chào anh/chị. Mật khẩu mới truy cập phần mềm là: " + acc.Password;
                //Gửi chi tiết đăng nhập tài khoản của chúng tôi cho khách hàng
                _client.Credentials = cred;
                //Bật lớp ổ cắm bảo mật ssl, mã hóa được hầu hết các nhà cung cấp dịch vụ email yêu cầu để gửi thư
                _client.EnableSsl = true;
                //Gửi thư của chúng tôi
                _client.Send(msg);
            });
            _sendEmailThread.Start();
        }
    }
}