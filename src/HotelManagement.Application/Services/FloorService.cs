using System.Threading.Tasks;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Domain;

namespace HotelManagement.Application.Services
{
    public class FloorService : IFloorService
    {
        private readonly IUnitOfWork _worker;

        public FloorService(IUnitOfWork worker)
        {
            _worker = worker;
        }

        public async Task<string> Add(int number)
        {
            var query = await _worker.Floors.Get(x => x.Number == number);
            if (query is null)
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