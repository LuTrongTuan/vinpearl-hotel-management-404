using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs;
using HotelManagement.Application.DTOs.Employee;
using HotelManagement.Domain;
using HotelManagement.UI.Contracts;


namespace HotelManagement.UI.Views.Employee
{
    public partial class FrmEmployee : Form
    {
        private readonly IEmployeeService _employee;
        private readonly IConfirm _confirm;
        private readonly IRoleService _roleService;
        
        public FrmEmployee(IEmployeeService emp,IConfirm con, IRoleService roleService)
        {
            InitializeComponent();
            _employee = emp;
            _confirm = con;
            _roleService = roleService;
            load();
        }

        async void load()
        {
            var result = await _roleService.GetRoles();
            cboVaitro.DataSource = result.ToList();
            cboVaitro.DisplayMember = "Name";
           cboVaitro.ValueMember = "Id";
        }
        private async void button1_Click(object sender, System.EventArgs e)
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
        private void checked_NHD_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checked_NHD.Checked)
            {
                checked_HD.Checked = false;
            }
        }

        private void checked_HD_CheckedChanged(object sender, EventArgs e)
        {
            if (checked_HD.Checked)
            {
                checked_NHD.Checked = false;
            }
        }
    }
}
