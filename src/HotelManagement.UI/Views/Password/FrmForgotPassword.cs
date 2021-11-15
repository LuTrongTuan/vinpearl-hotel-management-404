using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Application.Contracts;
using HotelManagement.UI.Views.Login;

namespace HotelManagement.UI.Views.Password
{
    public partial class FrmForgotPassword : Form
    {
        private IPasswordService _iPasswordService;
        public FrmForgotPassword(IPasswordService iPasswordService)
        {
            InitializeComponent();
            _iPasswordService = iPasswordService;
        }

        private async void customButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(await _iPasswordService.forgotPassword(txt_email.Text));
            FrmLogin frm = Program.Container.GetInstance<FrmLogin>();
            frm.Show();
            this.Hide();
        }
    }
}
