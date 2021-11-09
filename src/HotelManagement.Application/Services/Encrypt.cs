using System.Security.Cryptography;
using System.Text;
using HotelManagement.Application.Contracts.Infrastructure;

namespace HotelManagement.Application.Services
{
    public class Encrypt : IEncrypt
    {
        private StringBuilder _password;
        private MD5CryptoServiceProvider _md5;
        private byte[] _encryptCharaters;
        string IEncrypt.Encrypt(string raw)
        {
            _password = new StringBuilder();
            _md5 = new MD5CryptoServiceProvider();
            _encryptCharaters = _md5.ComputeHash(Encoding.ASCII.GetBytes(raw));
            foreach (var x in _encryptCharaters)
            {
                _password.Append(x);
            }
            return _password.ToString();
        }
    }
}
