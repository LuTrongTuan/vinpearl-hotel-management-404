using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs;
using HotelManagement.Application.DTOs.Account;
using HotelManagement.Domain;

namespace HotelManagement.Application.Services
{
    public class Authenticate:IAuthenticate
    {
        private readonly IMapper _mapper;
        private IEncrypt _encrypt;
        private IUnitOfWork _worker;
        private Account _account;
        private string _password;
        public Authenticate(IMapper mapper,IUnitOfWork worker, IEncrypt encrypt)
        {
            _mapper = mapper;
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
                Session.Id = _account.Id;
                Session.Role = _account.RoleId;
            }
            return _account != null;
        }

        public async Task<IList<AccountDTO>> GetList()
        {
            var query = await _worker.Rooms.GetAll();
            return _mapper.Map<IList<Room>, IList<AccountDTO>>(query);
        }
    }
}