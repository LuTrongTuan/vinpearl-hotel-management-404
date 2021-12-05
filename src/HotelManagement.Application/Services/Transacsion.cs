using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.Contracts.Ultilities;
using HotelManagement.Application.DTOs;
using HotelManagement.Application.DTOs.Receipt;
using HotelManagement.Application.DTOs.Room;
using HotelManagement.Application.DTOs.Service;
using HotelManagement.Application.Utilities;
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
        private readonly ICustomerService _customer;
        private TransactionDTO _transaction;
        private double _payment;

        public Transacsion(IRoomService roomService,
            IService service,
            IIdentificationService identificationService,
            IMapper mapper, IUnitOfWork worker, IPriceCalculate calculator,
            ICustomerService customer)
        {
            _service = service;
            _identificationService = identificationService;
            _roomService = roomService;
            _mapper = mapper;
            _worker = worker;
            _calculator = calculator;
            _customer = customer;
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
            receipt.Detail.RoomId = source.RoomId;
            receipt.Detail.Customers = await new NToN<CustomerDTO, Customer>(_mapper, _customer.IsExist)
                .Handle<CustomerReceipt>(source.Customers, nameof(CustomerReceipt.CustomerId), nameof(CustomerReceipt.Customer));
            receipt.Detail.Services =
                _mapper.Map<IList<ServiceReceiptDTO>, IList<ServiceReceipt>>(source.Services);
            receipt.Detail.Histories = _mapper.Map<ICollection<History>>(source.Histories);
            receipt.Payment += _payment + _calculator.ServiceCalculate(source.Services);
            room.Status = 0;
            await _worker.Receipts.Add(receipt);
            await _worker.Rooms.Update(room);
            await _worker.Commit();
            return "Thành công";
        }
        public async Task<string> Update(TransactionDTO source)
        {
            var room = await _worker.Rooms.Get(x => x.Id == source.RoomId);
            var detail = await _worker.ReceiptDetails.Get(x => x.RoomId == source.RoomId);
            _mapper.Map(source.Receipt, detail.Receipt);
            _mapper.Map(source.Detail, detail);
            _mapper.Map(source.Services, detail.Services);
            _mapper.Map(source.Histories, detail.Histories);
            RoomPayment(source.Histories, room.Type.ByDay, room.Type.ByHour);
            detail.Customers = await new NToN<CustomerDTO, Customer>(_mapper, _customer.IsExist)
                .Handle<CustomerReceipt>(source.Customers, nameof(CustomerReceipt.CustomerId), nameof(CustomerReceipt.Customer));
            detail.Receipt.Payment += _payment + _calculator.ServiceCalculate(source.Services);
            
            if (source.Histories.Count >= 2)
            {
                var history = source.Histories.OrderBy(x => x.Start).ToArray();
                detail.CreateAt = history[0].Start;
                detail.Checkout = history[^1].End;
            }
            await _worker.ReceiptDetails.Update(detail);
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
                var data = await _worker.ReceiptDetails.Get(x => x.RoomId == roomId);
                _transaction = new TransactionDTO
                {
                    Customers = new NToN<Customer, CustomerDTO>(_mapper, null)
                        .Get(data.Customers, nameof(CustomerReceipt.Customer)),
                    Receipt = _mapper.Map<ReceiptDTO>(data.Receipt),
                    Services = _mapper.Map<ICollection<ServiceReceipt>, IList<ServiceReceiptDTO>>(data.Services),
                    EmployeeId = data.Receipt.EmployeeId,
                    Detail = _mapper.Map<ReceiptDetailDTO>(data),
                    Histories = _mapper.Map<IList<HistoryDTO>>(data.Histories)
                };

                await GetPrice(_transaction.Services);
                return _transaction;
            }
            catch
            {
                return null;
            }
        }
        private async Task GetPrice(IEnumerable<ServiceReceiptDTO> source)
        {
            foreach (var receipt in source)
            {
                var price = await _worker.Services.Get(x => x.Id == receipt.ServiceId);
                receipt.Price = price.Price;
                receipt.Name = price.Name;
            }
        }
        private void RoomPayment(IEnumerable<HistoryDTO> data, double dayPrice, double hourPrice)
        {
            foreach (var history in data)
            {
                history.Payment = history.Status == 0 ? _calculator.ByDay(history.Start, history.End, dayPrice) : _calculator.ByHour(history.Start, history.End, hourPrice);
                _payment += history.Payment;
            }
        }
    }
}