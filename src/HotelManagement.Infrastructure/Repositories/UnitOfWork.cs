using System;
using System.Threading.Tasks;
using HotelManagement.Application.Contracts.Infrastructure;

namespace HotelManagement.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork()
        {
            _context = new ApplicationDbContext();
            Accounts = new AccountRepository(_context);
            Customers = new CustomerRepository(_context);
            Employees = new EmployeeRepository(_context);
            Receipts = new ReceiptRepository(_context);
            ReceiptDetails = new ReceiptDetailRepository(_context);
            Roles = new RoleRepository(_context);
            Rooms = new RoomRepository(_context);
            RoomTypes = new RoomTypeRepository(_context);
            RoomReceipts = new RoomReceiptRepository(_context);
            Services = new ServiceRepository(_context);
            ServiceTypes = new ServiceTypeRepository(_context);
            ServiceReceipts = new ServiceReceiptRepository(_context);
        }

        public Task<int> Commit() => _context.SaveChangesAsync();

        public IAccountRepository Accounts { get; set; }
        public ICustomerRepository Customers { get; set; }
        public IEmployeeRepository Employees { get; set; }
        public IReceiptDetailRepository ReceiptDetails { get; set; }
        public IReceiptRepository Receipts { get; set; }
        public IRoleRepostiory Roles { get; set; }
        public IRoomRepository Rooms { get; set; }
        public IRoomTypeRepository RoomTypes { get; set; }
        public IRoomReceiptRepository RoomReceipts { get; set; }
        public IServiceReceiptRepository ServiceReceipts { get; set; }
        public IServiceRepository Services { get; set; }
        public IServiceTypeRepository ServiceTypes { get; set; }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}