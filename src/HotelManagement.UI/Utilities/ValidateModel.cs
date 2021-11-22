using System.Text.RegularExpressions;
using HotelManagement.UI.Components;

namespace HotelManagement.UI.Utilities
{
    public class ValidateModel
    {
        public TextBox Control { get; set; }
        public Regex Pattern { get; set; }
        public string Error { get; set; }
    }
}