using System;
using System.Threading.Tasks;

namespace HotelManagement.Application.Contracts.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> Commit();
        IAccountRepository Accounts { get; set; }
        ICustomerRepository Customers { get; set; }
        IEmployeeRepository Employees { get; set; }
        IReceiptDetailRepository ReceiptDetails { get; set; }
        IReceiptRepository Receipts { get; set; }
        IRoleRepostiory Roles { get; set; }
        IRoomRepository Rooms { get; set; }
        IRoomTypeRepository RoomTypes { get; set; }
        IServiceReceiptRepository ServiceReceipts { get; set; }
        IServiceRepository Services { get; set; }
        IServiceTypeRepository ServiceTypes { get; set; }
        IFloorRepository Floors { get; set; }
        IIdentificationRepository Identifications { get; set; }
        IRoomReceiptRepository RoomReceipts { get; set; }
    }
}