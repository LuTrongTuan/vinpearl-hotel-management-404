using System.Windows.Forms;
using HotelManagement.UI.Contracts;

namespace HotelManagement.UI.Utilities
{
    public class Confirm : IConfirm
    {
        public bool IsConfirm(string message)
        {
            return MessageBox.Show(message, string.Empty, MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
    }
}