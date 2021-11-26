using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Infrastructure.Repositories
{
    public class IdentificationRepository : GenericRepository<Identification>, IIdentificationRepository
    {
        public IdentificationRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}