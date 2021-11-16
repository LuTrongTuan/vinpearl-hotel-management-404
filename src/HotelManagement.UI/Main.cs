using System.Windows.Forms;
using HotelManagement.Application.Services;
using HotelManagement.UI.Components;
using HotelManagement.UI.Views.Check;
using HotelManagement.UI.Views.Customer;
using HotelManagement.UI.Views.Employee;
using HotelManagement.UI.Views.Login;
using HotelManagement.UI.Views.Receipt;
using HotelManagement.UI.Views.Room;
using HotelManagement.UI.Views.Service;


namespace HotelManagement.UI
{
    public partial class Main : Form
    {
        private CustomButton _current = new();
        private Form _activeForm;

        public Main() => InitializeComponent();

        public void SetColor(object sender)
        {
            SetDefaultColor();
            if (sender is null) return;
            if (_current == (CustomButton) sender) return;
            _current = (CustomButton) sender;
            _current.BackColor = ColorScheme.Blue;
        }

        private void SetDefaultColor()
        {
            foreach (Control control in sidebar.Controls)
            {
                if (control.GetType() == typeof(CustomButton))
                {
                    control.BackColor = ColorScheme.DarkPurple;
                }
            }
        }

        private void OpenForm(Form form, object sender)
        {
            _activeForm?.Close();

            SetColor(sender);

            _activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(form);
            PanelMain.Tag = form;
            form.BringToFront();
            form.Show();
            LblTittle.Text = form.Text;
        }
        private void BtnRoom_Click(object sender, System.EventArgs e)
        {
            OpenForm(Program.Container.GetInstance<FrmMainRoom>(), sender);
        }

        private void btnEmployee_Click(object sender, System.EventArgs e)
        {
            OpenForm(Program.Container.GetInstance<FrmEmployee>(), sender);
        }

        private void customButton3_Click(object sender, System.EventArgs e)
        {
            OpenForm(Program.Container.GetInstance<FrmService>(), sender);
        }

        private void customButton1_Click(object sender, System.EventArgs e)
        {
            OpenForm(Program.Container.GetInstance<FrmCustomer>(), sender);
        }

        private void customButton4_Click(object sender, System.EventArgs e)
        {
            OpenForm(Program.Container.GetInstance<ChangePassWord>(), sender);
        }

        private void Main_Load(object sender, System.EventArgs e)
        {
            
            if (Session.Role == 1)
            {
                this.btnEmployee.Visible = false;
                this.btn_thongke.Visible = false;
            }
        }

        private void customButton5_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FrmLogin frm = Program.Container.GetInstance<FrmLogin>();
                frm.Show();
                this.Hide();
            }
        }

        private void btn_thongke_Click(object sender, System.EventArgs e)
        {
            OpenForm(Program.Container.GetInstance<FrmStastical>(), sender);
        }

        private void customButton2_Click(object sender, System.EventArgs e)
        {
            OpenForm(Program.Container.GetInstance<FrmReceiptDetail>(), sender);
        }

        private void customButton6_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không","Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
