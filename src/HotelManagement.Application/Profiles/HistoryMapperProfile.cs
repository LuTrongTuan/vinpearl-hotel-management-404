using AutoMapper;
using HotelManagement.Application.DTOs;
using HotelManagement.Domain;

namespace HotelManagement.Application.Profiles
{
    public class HistoryMapperProfile : Profile
    {
        public HistoryMapperProfile()
        {
            CreateMap<History, HistoryDTO>().ReverseMap();
        }
    }
}