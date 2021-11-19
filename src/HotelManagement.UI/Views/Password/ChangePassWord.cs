using System;
using System.Windows.Forms;
using HotelManagement.Application.Contracts;
using HotelManagement.Application.DTOs;
using HotelManagement.Application.DTOs.Account;
using HotelManagement.Application.Services;

namespace HotelManagement.UI
{
    public partial class ChangePassWord : Form
    {
        private IPasswordService _iPasswordService;
        private AccountDTO _accountDto;
        private string _mss;
        public string name { get; set; }
        public ChangePassWord(IPasswordService iPasswordService)
        {
            InitializeComponent();
            _iPasswordService = iPasswordService;
            txt_name.Text = Session.Username;
            txt_name.Enabled = false;
        }
        private async void customButton1_Click_1(object sender, EventArgs e)
        {
            _accountDto = new AccountDTO();

            _accountDto.UserName = txt_name.Text;
            _accountDto.Password = txt_mk.Text;
            _accountDto.NewPassword = txt_newMK.Text;
            _accountDto.EnterNewPassword = txt_nlmk.Text;
            
            _mss = await _iPasswordService.UpdatePassword(_accountDto);
            MessageBox.Show(_mss);
        }

        private void customButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                customButton1_Click_1(null,null);
            }
        }
    }
}
