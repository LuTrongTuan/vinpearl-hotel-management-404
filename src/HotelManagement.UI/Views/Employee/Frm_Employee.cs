using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Domain;
using HotelManagement.UI.Contracts;

namespace HotelManagement.UI.Views.Employee
{
    public partial class Frm_Employee : Form
    {
        private readonly IEmployeeService _employee;
        private readonly IConfirm _confirm;
        private readonly IRoleService _roleService;
        private Regex number;
        public Frm_Employee(IEmployeeService emp,IConfirm con, IRoleService roleService)
        {
            InitializeComponent();
            _employee = emp;
            _confirm = con;
            _roleService = roleService;
            load();
            loadData();
            number = new Regex(@"^[0-9]*$");
        }
        async void load()
        {
            var result = await _roleService.GetRoles();
            cboVaitro.DataSource = result.ToList();
            cboVaitro.DisplayMember = "Name";
            cboVaitro.ValueMember = "Id";
        }
        public async void loadData()
        {
            var name = await _employee.GetList();
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Họ tên";
            dataGridView1.Columns[1].Name = "Ngày sinh";
            dataGridView1.Columns[2].Name = "email";
            dataGridView1.Columns[3].Name = "Địa chỉ";
            dataGridView1.Columns[4].Name = "Điện thoại";
            dataGridView1.Columns[5].Name = "Giới tính";
            dataGridView1.Columns[6].Name = "Trạng thái";
            dataGridView1.Columns[7].Name = "Vai trò";

            dataGridView1.Rows.Clear();
            foreach (var x in name.ToList())
            {
                dataGridView1.Rows.Add(x.Name, x.Birthday, x.Email, x.Address, x.PhoneNumber,
                    x.Gender ? "Nam" : "Nữ", x.Status ? "Hoạt động" : "Ngưng hoạt động", x.NameRole);
            }
        }
        private async void btn_addEmployee_Click(object sender, EventArgs e)
        {
            var _emp = new Account()
            {
                Employee = new Domain.Employee
                {
                    Name = TxtName.Text,
                    Email = TxtEmail.Text,
                    Birthday = dateTimePicker1.Value,
                    Address =  TxtDiachi.Text,
                    PhoneNumber = TxtPhone.Text,
                    Status = checked_HD.Checked,
                    Gender = rdoNam.Checked,
                    
                },
                UserName = TxtUsername.Text,
                RoleId = Convert.ToInt32(cboVaitro.SelectedValue)
            };

            if (!checkNull()) return;

            
            if (_confirm.IsConfirm("Bạn chắc chắn muốn thêm "))
            {
                await _employee.AddEmployee(_emp);
                MessageBox.Show("Thêm thành công ");
            }
            loadData();
        }
        bool checkNull()
        {
            if (string.IsNullOrEmpty(TxtName.Text) || string.IsNullOrEmpty(TxtEmail.Text) ||
                string.IsNullOrEmpty(TxtDiachi.Text) || string.IsNullOrEmpty(TxtPhone.Text) ||
                string.IsNullOrEmpty(TxtUsername.Text))
            {
                MessageBox.Show("Không được để trống thông tin \n Vui lòng nhập lại", "Thông báo");
                return false;
            }

            return true;
        }

        private void checked_HD_CheckedChanged(object sender, EventArgs e)
        {
            if (checked_HD.Checked)
            {
                checked_NHD.Checked = false;
            }
        }

        private void checked_NHD_CheckedChanged(object sender, EventArgs e)
        {
            if (checked_NHD.Checked)
            {
                checked_HD.Checked = false;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            TxtName.Text = "";
            TxtEmail.Text = "";
            TxtDiachi.Text = "";
            TxtPhone.Text = "";
            TxtUsername.Text = "";
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            checked_HD.Checked = false;
            checked_NHD.Checked = false;
        }
        public async void loadSeach(string dv)
        {
            var name = await _employee.Find(dv);
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Họ tên";
            dataGridView1.Columns[1].Name = "Ngày sinh";
            dataGridView1.Columns[2].Name = "email";
            dataGridView1.Columns[3].Name = "Địa chỉ";
            dataGridView1.Columns[4].Name = "Điện thoại";
            dataGridView1.Columns[5].Name = "Giới tính";
            dataGridView1.Columns[6].Name = "Trạng thái";
            dataGridView1.Columns[7].Name = "Vai trò";

            dataGridView1.Rows.Clear();
            foreach (var x in name.ToList())
            {
                var role = await _roleService.GetRoles();
                dataGridView1.Rows.Add(x.Name, x.Birthday, x.Email, x.Address, x.PhoneNumber,
                    x.Gender ? "Nam" : "Nữ", x.Status ? "Hoạt động" : "Ngưng hoạt động");
            }
        }

        private void tbx_search_KeyUp(object sender, KeyEventArgs e)
        {
            loadSeach(tbx_search.Text);
        }

        private async void btn_edit_Click(object sender, EventArgs e)
        {
        }
    }
}
