using System.Text;
using HotelManagement.Application.Contracts.Ultilities;

namespace HotelManagement.Application.Utilities
{
    public class Generator : IGenerator
    {
        private StringBuilder _name;

        public string Name(int floor, int number)
        {
            _name = new StringBuilder();
            _name.Append('P');
            _name.Append(floor);
            if (number < 10) _name.Append(0);
            _name.Append(number);
            return _name.ToString();
        }
    }
}