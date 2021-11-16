using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs;
using HotelManagement.Application.DTOs.Receipt;
using HotelManagement.Application.DTOs.Room;
using HotelManagement.Application.DTOs.Service;
using HotelManagement.Domain;

namespace HotelManagement.Application.Services
{
    public class Transacsion : ITransacsion
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _worker;
        private readonly IRoomService _roomService;
        private readonly IService _service;
        private readonly IIdentificationService _identificationService;
        private readonly IServiceReceiptService _receiptService;
        private TransactionDTO _transaction;

        public Transacsion(ICustomerService customerService, IRoomService roomService,
            IService service, IServiceReceiptService receiptService,
            IIdentificationService identificationService,
            IMapper mapper, IUnitOfWork worker)
        {
            _service = service;
            _receiptService = receiptService;
            _identificationService = identificationService;
            _roomService = roomService;
            _mapper = mapper;
            _worker = worker;
        }

        public async Task<RoomDetailDTO> GetRoomDetail(int id) => await _roomService.GetDetail(id);
        public async Task<IList<ServiceDTO>> GetServices() => await _service.Get();
        public async Task<IList<IdentificationDTO>> GetIdentifications() => await _identificationService.Get();
        public async Task<string> Create(TransactionDTO source)
        {
            var room = await _worker.Rooms.Get(x => x.Id == source.RoomId);
            room.Status = 0;
            var receipt = _mapper.Map<Receipt>(source.Receipt);
            receipt.Customer = _mapper.Map<Customer>(source.Customer);
            receipt.ReceiptDetail = _mapper.Map<ReceiptDetail>(source.ReceiptDetail);
            receipt.ReceiptDetail.RoomId = source.RoomId;
            receipt.EmployeeId = 1; // only for test
            receipt.ReceiptDetail.ServiceReceipts =
                _mapper.Map<IList<ServiceReceiptDTO>, IList<ServiceReceipt>>(source.ServiceReceipts);
            await _worker.Receipts.Add(receipt);
            await _worker.Rooms.Update(room);
            await _worker.Commit();
            return "Thành công";
        }
        public async Task Update(TransactionDTO source){}
        public async Task<TransactionDTO> Query(int roomId)
        {
            try
            {
                var data = await _worker.ReceiptDetails.GetDetail(roomId);
                _transaction = new TransactionDTO
                {
                    Customer = _mapper.Map<CustomerDTO>(data.Receipt.Customer),
                    Receipt = _mapper.Map<ReceiptDTO>(data.Receipt),
                    ServiceReceipts = _mapper.Map<ICollection<ServiceReceipt>, IList<ServiceReceiptDTO>>(data.ServiceReceipts),
                    EmployeeId = data.Receipt.EmployeeId,
                    ReceiptDetail = _mapper.Map<ReceiptDetailDTO>(data)
                };
                await GetPrice(_transaction.ServiceReceipts);
                return _transaction;
            }
            catch
            {
                return null;
            }
        }
        private async Task GetPrice(IList<ServiceReceiptDTO> source)
        {
            foreach (var receipt in source)
            {
                var price = await _worker.Services.Get(x => x.Id == receipt.ServiceId);
                receipt.Price = price.Price;
                receipt.Name = price.Name;
            }
        }
    }
}