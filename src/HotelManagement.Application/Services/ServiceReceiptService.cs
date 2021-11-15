using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs.Receipt;
using HotelManagement.Domain;

namespace HotelManagement.Application.Services
{
    public class ServiceReceiptService : IServiceReceiptService
    {
        private readonly IUnitOfWork _worker;
        private readonly IMapper _mapper;
        private ServiceReceipt _receipt;

        public ServiceReceiptService(IUnitOfWork worker, IMapper mapper)
        {
            _worker = worker;
            _mapper = mapper;
        }

        public async Task Add(ServiceReceiptDTO souce)
        {
            var receipt = _mapper.Map<ServiceReceipt>(souce);
            await _worker.ServiceReceipts.Add(receipt);
            await _worker.Commit();
        }

        public async Task Update(IList<ServiceReceiptDTO> source)
        {
            foreach (var receipt in source)
            {
                var query = await _worker.ServiceReceipts.Get(x =>
                    x.ReceiptDetailId == receipt.ReceiptId && x.ServiceId == receipt.ServiceId);
                query.Quantity = receipt.Quantity;
                query.Total = receipt.Total;
                await _worker.ServiceReceipts.Update(query);
            }

            await _worker.Commit();
        }
    }
}