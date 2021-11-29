using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.Contracts.Ultilities;
using HotelManagement.Application.DTOs;
using HotelManagement.Application.DTOs.Employee;
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
        private double _payment;

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
            var room = await _worker.Rooms.Get(x => x.Id == source.RoomId);
            var receipt = _mapper.Map<Receipt>(source.Receipt);
            RoomPayment(source.Histories, room.Type.ByDay, room.Type.ByHour);
            receipt.EmployeeId = 1; // only for test
            receipt.Detail = _mapper.Map<ReceiptDetail>(source.Detail);
            receipt.Detail.Customers = CustomerHandle(source.Customers);
            receipt.Detail.Rooms = new List<RoomReceipt>(1) {new()
            {
                RoomId = source.RoomId,
                Histories = _mapper.Map<IList<HistoryDTO>, ICollection<History>>(source.Histories)
            }};
            receipt.Detail.Services =
                _mapper.Map<IList<ServiceReceiptDTO>, IList<ServiceReceipt>>(source.Services);
            receipt.Payment += _payment + _calculator.ServiceCalculate(source.Services);
            room.Status = 0;
            await _worker.Receipts.Add(receipt);
            await _worker.Rooms.Update(room);
            await _worker.Commit();
            return "Thành công";
        }
        public async Task<string> Update(TransactionDTO source)
        {
            var receipt = await _worker.RoomReceipts
                .Get(x => x.Id == source.RoomId);
            var data = await _worker.ReceiptDetails
                .Get(x => x.Id == receipt.DetailId);
            _mapper.Map(source.Receipt, data.Receipt);
            _mapper.Map(source.Detail, data);
            _mapper.Map(source.Services, data.Services);
            _mapper.Map(source.Histories, receipt.Histories);
            await _worker.ReceiptDetails.Update(data);
            await _worker.RoomReceipts.Update(receipt);
            await _worker.Commit();
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
            try
            {
                var room = await _worker.RoomReceipts.Get(x => x.Id == roomId);
                var data = await _worker.ReceiptDetails.Get(x => x.Id == room.DetailId);
                _transaction = new TransactionDTO
                {
                    //Customer = _mapper.Map<CustomerDTO>(data.Receipt.Customer),
                    Receipt = _mapper.Map<ReceiptDTO>(data.Receipt),
                    Services = _mapper.Map<ICollection<ServiceReceipt>, IList<ServiceReceiptDTO>>(data.Services),
                    EmployeeId = data.Receipt.EmployeeId,
                    Detail = _mapper.Map<ReceiptDetailDTO>(data),
                    Rooms = _mapper.Map<ICollection<RoomReceipt>, IList<RoomReceiptDTO>>(data.Rooms)
                };

                await GetPrice(_transaction.Services);
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
        private void RoomPayment(IList<HistoryDTO> data, double dayPrice, double hourPrice)
        {
            foreach (var history in data)
            {
                history.Payment = history.Status == 0 ? _calculator.ByDay(history.Start, history.End, dayPrice) : _calculator.ByHour(history.Start, history.End, hourPrice);
                _payment += history.Payment;
            }
        }

        private IList<CustomerReceipt> CustomerHandle(IEnumerable<CustomerDTO> source)
            => source.Select(customer => _mapper.Map<Customer>(customer)).Select(stuff => new CustomerReceipt { Customer = stuff }).ToList();
    }
}