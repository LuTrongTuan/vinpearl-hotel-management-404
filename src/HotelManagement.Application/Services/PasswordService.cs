using System;
using System.Threading.Tasks;
using HotelManagement.Application.Contracts;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs;
using HotelManagement.Domain;

namespace HotelManagement.Application.Services
{
    public class PasswordService : IPasswordService
    {
        private readonly IUnitOfWork _work;
        private readonly IEncrypt _encrypt;
        private ISendMail _isSendMail;
        private Account _account;
        private Employee _employee;
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
            _employee = await _work.Employees.Get(c => c.Email == email);
            if (_employee != null)
            {
                rawPassword = new Random().password();
                _account.Password = _encrypt.Encrypt(rawPassword);
                await _work.Accounts.Update(_account);
                _isSendMail.sendMail(new AccountDTO()
                {
                    Email = email,
                    Password = rawPassword
                });
                return "Một email chưa mật khẩu đã gửi tới email của bạn";
            }

            return "Email không tồn tại, vui lòng nhập lại email!";
        }

        #endregion
    }
}

