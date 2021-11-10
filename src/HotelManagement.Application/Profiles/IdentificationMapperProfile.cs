using AutoMapper;
using HotelManagement.Application.DTOs;
using HotelManagement.Domain;

namespace HotelManagement.Application.Profiles
{
    public class IdentificationMapperProfile : Profile
    {
        public IdentificationMapperProfile()
        {
            CreateMap<Identification, IdentificationDTO>();
        }
    }
}