using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.Contracts.Ultilities;
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
        private readonly IPriceCalculate _calculator;
        private TransactionDTO _transaction;

        public Transacsion(IRoomService roomService,
            IService service,
            IIdentificationService identificationService,
            IMapper mapper, IUnitOfWork worker, IPriceCalculate calculator)
        {
            _service = service;
            _identificationService = identificationService;
            _roomService = roomService;
            _mapper = mapper;
            _worker = worker;
            _calculator = calculator;
        }

        public async Task<RoomDetailDTO> GetRoomDetail(int id) => await _roomService.GetDetail(id);
        public async Task<IList<ServiceDTO>> GetServices() => await _service.Get();
        public async Task<IList<IdentificationDTO>> GetIdentifications() => await _identificationService.Get();
        public async Task<string> Create(TransactionDTO source)
        {
            var room = await _worker.Rooms.GetDetail(source.RoomId);
            room.Status = 0;
            var receipt = _mapper.Map<Receipt>(source.Receipt);
            receipt.Customer = _mapper.Map<Customer>(source.Customer);
            receipt.Detail = _mapper.Map<ReceiptDetail>(source.ReceiptDetail);
            receipt.Detail.Rooms = new List<RoomReceipt>(1) {new() { RoomId = source.RoomId}};
            receipt.EmployeeId = 1; // only for test
            receipt.Detail.Services =
                _mapper.Map<IList<ServiceReceiptDTO>, IList<ServiceReceipt>>(source.ServiceReceipts);
            await _worker.Receipts.Add(receipt);
            await _worker.Rooms.Update(room);
            await _worker.Commit();
            return "Thành công";
        }

        public async Task<string> Update(TransactionDTO source)
        {
            //var room = await _worker.Rooms.GetDetail(source.RoomId);
            //var data = await _worker.ReceiptDetails.Get();
            //_mapper.Map(source.Receipt, data.Receipt);
            //_mapper.Map(source.ReceiptDetail, data);
            //_mapper.Map(source.Customer, data.Receipt.Customer);
            //_mapper.Map(source.ServiceReceipts, data.Services);
            //await _worker.ReceiptDetails.Update(data);
            //await _worker.Commit();
            return "Thành công";
        }

        public async Task<string> Checkout(int id)
        {
            var room = await _worker.Rooms.Get(x => x.Id == id);
            room.Status = 1;
            await _worker.Rooms.Update(room);
            await _worker.Commit();
            return "Thành công";
        }
        public async Task<string> CheckClean(int id)
        {
            var room = await _worker.Rooms.Get(x => x.Id == id);
            room.Status = 2;
            await _worker.Rooms.Update(room);
            await _worker.Commit();
            return "Thành công";
        }
        public async Task<TransactionDTO> Query(int roomId)
        {
            //try
            //{
            //    var data = await _worker.ReceiptDetails.GetDetail(roomId);
            //    _transaction = new TransactionDTO
            //    {
            //        Customer = _mapper.Map<CustomerDTO>(data.Receipt.Customer),
            //        Receipt = _mapper.Map<ReceiptDTO>(data.Receipt),
            //        ServiceReceipts = _mapper.Map<ICollection<ServiceReceipt>, IList<ServiceReceiptDTO>>(data.Services),
            //        EmployeeId = data.Receipt.EmployeeId,
            //        ReceiptDetail = _mapper.Map<ReceiptDetailDTO>(data)
            //    };
            //    await GetPrice(_transaction.ServiceReceipts);
            //    return _transaction;
            //}
            //catch
            //{
            //    return null;
            //}
            return default;
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

        private void RoomPayment(TransactionDTO transaction, Room room)
        {
            foreach (var receipt in transaction.RoomReceipts)
            {
                receipt.Payment = receipt.Status switch
                {
                    0 => _calculator.ByDay(transaction, room.Type.ByDay),
                    1 => _calculator.ByHour(transaction, room.Type.ByHour),
                    _ => receipt.Payment
                };
            }
        }
    }
}