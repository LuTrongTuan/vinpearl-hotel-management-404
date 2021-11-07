using System.Threading.Tasks;
using HotelManagement.Application.Contracts;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.DTOs;
using HotelManagement.Domain;

namespace HotelManagement.Application.Services
{
    public class PasswordService : IPasswordService
    {
        private readonly IUnitOfWork _work;
        private readonly IEncrypt _encrypt;
        private Account _account;
        private string _mss, _encryptPassword;

        public PasswordService(IUnitOfWork work, IEncrypt encrypt)
        {
            _work = work;
            _encrypt = encrypt;
        }

        #region Chức năng đổi mật khẩu

        public async Task<string> UpdatePassword(AccountDTO account)
        {
            _mss = account.check();
            _encryptPassword =_encrypt.Encrypt(account.Password);
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
    }
}
