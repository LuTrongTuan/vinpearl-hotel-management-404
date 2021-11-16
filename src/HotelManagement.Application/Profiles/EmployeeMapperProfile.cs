using AutoMapper;
using HotelManagement.Application.DTOs;
using HotelManagement.Application.DTOs.Account;
using HotelManagement.Application.DTOs.Employee;
using HotelManagement.Domain;
namespace HotelManagement.Application.Profiles
{
    public class EmployeeMapperProfile : Profile
    {
        public EmployeeMapperProfile()
        {
            CreateMap<Role, RoleDTO>().ReverseMap();
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<Account, AccountDTO>().ReverseMap();
        }
    }
}