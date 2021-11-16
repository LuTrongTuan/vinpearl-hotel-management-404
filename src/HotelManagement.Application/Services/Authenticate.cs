using System.Threading.Tasks;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs;
using HotelManagement.Application.DTOs.Account;
using HotelManagement.Domain;

namespace HotelManagement.Application.Services
{
    public class Authenticate:IAuthenticate
    {
        private IEncrypt _encrypt;
        private IUnitOfWork _worker;
        private Account _account;
        private string _password;
        public Authenticate(IUnitOfWork worker, IEncrypt encrypt)
        {
            _worker = worker;
            _encrypt = encrypt;
        }
        public async Task<bool> authenticate(AccountDTO account)
        {
            _password = _encrypt.Encrypt(account.Password);
            _account = await _worker.Accounts.Get(c =>
                c.UserName == account.UserName && c.Password == _password);
            if (_account != null)
            {
                Session.Username = _account.UserName;
                Session.Role = _account.RoleId;
            }

            return _account != null;
        }
    }
}