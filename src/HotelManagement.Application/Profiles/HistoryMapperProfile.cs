using AutoMapper;
using HotelManagement.Application.DTOs;
using HotelManagement.Domain;

namespace HotelManagement.Application.Profiles
{
    public class HistoryMapperProfile : Profile
    {
        public HistoryMapperProfile()
        {
            CreateMap<History, HistoryDTO>()
                .ForMember(x => x.Start, d => d.MapFrom(e => e.CreateAt));
            CreateMap<HistoryDTO, History>();
        }
    }
}