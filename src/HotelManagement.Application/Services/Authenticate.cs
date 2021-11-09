using System.Threading.Tasks;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs;
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
                c.UserName == account.UserName && c.Password == account.Password);
            if (_account != null)
            {
                Session.Username = _account.UserName;
            }

            return _account != null;
        }
    }
}