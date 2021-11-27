using System;
using System.Linq;
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
            _account = new AccountDTO();
            var check = await _authenticate.GetList();
            if (check.Any(c => c.UserName != txb_username.Text))
            {
                MessageBox.Show("Bạn Nhập Sai UserName, Mời Bạn Nhập Lại", "Thông Báo");
                return;
            }
            _account.UserName = txb_username.Text;
            if (check.Any(c => c.Password != txb_password.Text))
            {
                MessageBox.Show("Bạn Nhập Sai PassWord, Mời Bạn Nhập Lại", "Thông Báo");
                return;
            }
            _account.Password = txb_password.Text;
            
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
