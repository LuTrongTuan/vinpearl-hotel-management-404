using System;
using System.Windows.Forms;
using HotelManagement.Application.Contracts;
using HotelManagement.Application.DTOs;

namespace HotelManagement.UI
{
    public partial class ChangePassWord : Form
    {
        private IPasswordService _iPasswordService;
        private AccountDTO _accountDto;
        private string _mss;
        public ChangePassWord(IPasswordService iPasswordService)
        {
            InitializeComponent();
            _iPasswordService = iPasswordService;
        }
        private async void customButton1_Click_1(object sender, EventArgs e)
        {
            _accountDto = new AccountDTO()
            {
                UserName = txt_name.Text,
                Password = txt_mk.Text,
                NewPassword = txt_newMK.Text,
                EnterNewPassword = txt_nlmk.Text
            };
            _mss = await _iPasswordService.UpdatePassword(_accountDto);
            MessageBox.Show(_mss);
        }
        private void customButton2_Click(object sender, EventArgs e) => this.Close();
    }
}
