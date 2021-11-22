using System.Collections.Generic;
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
            CreateMap<Floor, FloorDTO>()
                .ForMember(x => x.Rooms, d => d.MapFrom<ICollection<Room>>(e => e.Rooms))
                .ForMember(x => x.Floor, d => d.MapFrom(e => e.Number));
            CreateMap<Room, RoomDetailDTO>()
                .ForMember(x => x.RoomType, d => d.MapFrom(e => e.Type));
        }
    }
}