using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Application.Contracts.Infrastructure
{
    public interface IEncrypt
    {
       public string Encrypt(string rawMK);
    }
}
