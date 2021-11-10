using System;
using HotelManagement.Application.DTOs.Service;

namespace HotelManagement.Application.ValidateFrom
{
    public static class ServiceValidate
    {
        public static string a = "không được để trống";

        public static string validateSer(ServiceDTO ser)
        {
            ValidateDTO a = new ValidateDTO();
            if (!a.number.IsMatch(ser.Price.ToString()))
                return "Price chỉ có số";
            if (ser.Name.Trim() == String.Empty)
                return "Name " + a;
            if (ser.Price.ToString().Trim() == String.Empty)
                return "Price " + a;
            return "ok";
        }
    }
}