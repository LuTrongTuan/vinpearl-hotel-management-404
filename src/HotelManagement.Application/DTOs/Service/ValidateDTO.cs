using System.Text.RegularExpressions;

namespace HotelManagement.Application.DTOs.Service
{
    public class ValidateDTO
    {
        public Regex number { get; set; }

        public ValidateDTO()
        {
            number = new Regex(@"^[0-9]*$");
        }
    }
}