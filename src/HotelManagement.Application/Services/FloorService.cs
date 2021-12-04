using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;
using AutoMapper;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs.Room;
using HotelManagement.Domain;

namespace HotelManagement.Application.Services
{
    public class FloorService : IFloorService
    {
        private readonly IUnitOfWork _worker;
        private readonly IMapper _mapper;

        public FloorService(IUnitOfWork worker, IMapper mapper)
        {
            _worker = worker;
            _mapper = mapper;
        }

        public async Task<IList<FloorDTO>> Get()
        {
            var query = await _worker.Floors.GetAll();
            return _mapper.Map<IList<Floor>, IList<FloorDTO>>(query);
        }

        public async Task<IList<FloorDTO>> GetAll()
        {
            var query = await _worker.Floors.GetAll();
            var result = _mapper.Map<IList<Floor>, IList<FloorDTO>>(query);
            foreach (var floorDTO in result)
                foreach (var room in floorDTO.Rooms)
                {
                    room.Customer = await GetCurrentCustomerName(room.Id);
                    room.Type = await GetRoomTypeName(room.Id);
                    room.Price = await GetPrice(room.Id);
                }

            return result;
        }

        private async Task<string> GetCurrentCustomerName(int roomId)
        {
            var room = await _worker.Rooms.Get(x => x.Id == roomId);
            if (room.Status is 2 or 1) return string.Empty;
            try
            { 
                var receiptDetail = await _worker.ReceiptDetails
                    .Get(x => x.RoomId == roomId);
                return receiptDetail.Customers.First().Customer.Name;
            }
            catch
            {
                return string.Empty;
            }
        }

        private async Task<string> GetPrice(int roomId)
        {
            try
            {
                var rentType = await _worker.ReceiptDetails.GetCurrentRentType(x => x.RoomId == roomId);
                var room = await _worker.Rooms.Get(x => x.Id == roomId);
                if (rentType == 0)
                    return "Giá: " + room.Type.ByDay.ToString("C", new CultureInfo("vi-VN")) + "/ngày";
                return "Giá: " + room.Type.ByHour.ToString("C", new CultureInfo("vi-VN")) + "/giờ";
            }
            catch
            {
                return string.Empty;
            }
        }
        private async Task<string> GetRoomTypeName(int id)
        {
            var type = await _worker.Rooms.Get(x => x.Id == id);
            return type.Type.Name;
        }

        public async Task<string> Add(int number)
        {
            var query = await _worker.Floors.Get(x => x.Number == number);
            if (query is not null)
                return "Đã tồn tại";
            await _worker.Floors.Add(new Floor {Number = number});
            await _worker.Commit();
            return "Thêm thành công";
        }

        public async Task<string> Update(int id, int number)
        {
            var query = await _worker.Floors.Get(x => x.Id == id);
            if (query is null)
                return "Không tồn tại";
            query.Number = number;
            await _worker.Floors.Update(query);
            await _worker.Commit();
            return "Cập nhật thành công";
        }
    }
}