using AutoMapper;
using HotelManagement.Application.DTOs.Receipt;
using HotelManagement.Domain;

namespace HotelManagement.Application.Profiles
{
    public class ReceiptMapperProfile : Profile
    {
        public ReceiptMapperProfile()
        {
            CreateMap<Receipt, ReceiptDTO>().ReverseMap();
            CreateMap<ReceiptDetail, ReceiptDetailDTO>().ReverseMap();
            CreateMap<ServiceReceipt, ServiceReceiptDTO>().ReverseMap();
        }
    }
}