using System;
using System.Threading.Tasks;
using HotelManagement.Application.Contracts;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs;
using HotelManagement.Application.DTOs.Account;
using HotelManagement.Domain;

namespace HotelManagement.Application.Services
{
    public class PasswordService : IPasswordService
    {
        private readonly IUnitOfWork _work;
        private readonly IEncrypt _encrypt;
        private ISendMail _isSendMail;
        private Account _account;
        private string _mss, rawPassword, _encryptPassword;

        public PasswordService(IUnitOfWork work, IEncrypt encrypt, ISendMail isSendMail)
        {
            _work = work;
            _encrypt = encrypt;
            _isSendMail = isSendMail;
        }
        #region Chức năng đổi mật khẩu

        public async Task<string> UpdatePassword(AccountDTO account)
        {
            _mss = account.check();
            _encryptPassword = _encrypt.Encrypt(account.Password);
            if (_mss != "Ok") return _mss;
            _account = await _work.Accounts.Get(c => c.UserName == account.UserName && c.Password == _encryptPassword);
            if (_account is null)
                return "Tài khoản không tồn tại";

            _account.Password = _encrypt.Encrypt(account.NewPassword);
            await _work.Accounts.Update(_account);
            await _work.Commit();
            return "Ok";
        }
        #endregion

        #region Chức năng quên mật khẩu
        public async Task<string> forgotPassword(string email)
        {
            _account = await _work.Accounts.Get(c => c.Employee.Email == email);
            if (_account != null)
            {
                rawPassword = new Random().password();
                _account.Password = _encrypt.Encrypt(rawPassword);
                await _work.Accounts.Update(_account);
                await _work.Commit();
                _isSendMail.sendMail(new AccountDTO()
                {
                    Email = email,
                    Password = rawPassword
                });
                return "Một email chứa password đã gửi tới Email của bạn\nBạn vui lòng kiếm tra email để lấy mật khẩu đăng nhập";
            }

            return "Email không tồn tại, vui lòng nhập lại email!";
        }

        #endregion
    }
}

