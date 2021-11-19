using System;
using System.Windows.Forms;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs;
using HotelManagement.Application.DTOs.Account;
using HotelManagement.UI.Views.Password;

namespace HotelManagement.UI.Views.Login
{
    public partial class FrmLogin : Form
    {
        private AccountDTO _account;
        private IAuthenticate _authenticate;
        public FrmLogin(IAuthenticate authenticate)
        {
            InitializeComponent();
            _authenticate = authenticate;
        }
        private async void btn_login_Click(object sender, EventArgs e)
        {
            _account = new AccountDTO()
            {
                UserName = txb_username.Text,
                Password = txb_password.Text
            };
            if (await _authenticate.authenticate(_account))
            {
                Main main = new Main();
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                main.getTextBox(txb_username);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai thông tin tài khoản hoặc mật khẩu\nVui lòng nhập lại!", "Thông báo");
            }
        }
        private void btn_exit_Click(object sender, EventArgs e) => Close();

        private void btn_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(null,null);
            }
        }

        private void llb_quenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmForgotPassword frm = Program.Container.GetInstance<FrmForgotPassword>();
            frm.Show();
            this.Hide();
        }
    }
}
