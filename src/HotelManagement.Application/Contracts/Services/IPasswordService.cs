using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.Application.DTOs;

namespace HotelManagement.Application.Contracts
{
    public interface IPasswordService
    {
        Task<string> UpdatePassword(AccountDTO account);
    }
}
