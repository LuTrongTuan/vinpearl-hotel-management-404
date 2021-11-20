using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs;
using HotelManagement.Domain;

namespace HotelManagement.Application.Services
{
    public class RoleService : IRoleService
    {
        private readonly IUnitOfWork _worker;
        private readonly IMapper _mapper;

        public RoleService(IUnitOfWork worker, IMapper mapper)
        {
            _worker = worker;
            _mapper = mapper;
        }

        public async Task<IList<RoleDTO>> GetRoles()
        {
            var query = await _worker.Roles.GetAll();
            return _mapper.Map<IList<Role>, IList<RoleDTO>>(query);
        }

        public async Task<string> GetRoleName(int id)
        {
            var role = await _worker.Roles.Get(x => x.Id == id);
            return role.Name;
        }

    }
}