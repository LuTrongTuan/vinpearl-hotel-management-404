using AutoMapper;
using HotelManagement.Application.DTOs.Room;
using HotelManagement.Application.DTOs.Service;
using HotelManagement.Domain;

namespace HotelManagement.Application.Profiles
{
    public class RoomMapperProfile : Profile
    {
        public RoomMapperProfile()
        {
            CreateMap<CreateRoomDTO, Room>();
            CreateMap<Room, RoomListDTO>();
            CreateMap<RoomType, RoomTypeDTO>();

            CreateMap<Service, ServiceDTO>();
            CreateMap<ServiceType, ServicetypeDTO>();

            CreateMap<Room, RoomDetailDTO>().ReverseMap();

        }
    }
}