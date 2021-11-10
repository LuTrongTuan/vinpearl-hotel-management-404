using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs;
using HotelManagement.Domain;

namespace HotelManagement.Application.Services
{
    public class IdentificationService : IIdentificationService
    {
        private readonly IUnitOfWork _worker;
        private readonly IMapper _mapper;

        public IdentificationService(IUnitOfWork worker, IMapper mapper)
        {
            _worker = worker;
            _mapper = mapper;
        }

        public async Task<IList<IdentificationDTO>> Get()
        {
            var query = await _worker.Identifications.GetAll();
            return _mapper.Map<IList<Identification>, IList<IdentificationDTO>>(query);
        }
    }
}