﻿using AutoMapper;
using HotelManagement.Application.DTOs.Service;
using HotelManagement.Domain;

namespace HotelManagement.Application.Profiles
{
    public class ServiceMapperProfile : Profile
    {
        public ServiceMapperProfile()
        {
            CreateMap<Service, ServiceDTO>();
            CreateMap<ServiceDTO, Service>()
                .ForMember(x => x.ServiceType, d => d.Ignore());
            CreateMap<ServiceType, ServicetypeDTO>();
            CreateMap<Service, ServiceDTO>().ReverseMap();
        }
    }
}