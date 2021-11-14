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
        
        public FrmEmployee(IEmployeeService emp,IConfirm con)
        {
            InitializeComponent();
            _employee = emp;
            _confirm = con;
            load();
        }

        async void load()
        {
            var result = await _employee.GetList();
            foreach (var x in result.ToList()) ;
            {
                cboVaitro.Items.Add(x.name);
            }
        }
        private async void button1_Click(object sender, System.EventArgs e)
        {
            var _emp = new EmployeeDTO()
            {
                Address =  TxtDiachi.Text,
                Birthday = dateTimePicker1.Value,
                Email = TxtEmail.Text,
                Gender = rdoNam.Checked,
                Name = TxtName.Text,
                PhoneNumber = TxtPhone.Text,
                Status = checked_HD.Checked
            };
            var _acc = new AccountDTO()
            {
                //EmployeeId = await _employee,
                Password = TxtPass.Text,
                RoleId = Convert.ToInt32(cboVaitro.SelectedValue),
                UserName = TxtUsername.Text
            };
            _emp.Address = TxtDiachi.Text;
            _emp.Birthday = dateTimePicker1.Value;
            _emp.Email = TxtEmail.Text;
            _emp.PhoneNumber = TxtPhone.Text;
            _emp.Status = checked_HD.Checked;
            _emp.Gender = rdoNam.Checked;

            if (_confirm.IsConfirm("Bạn chắc chắn muốn thêm "))
            {
                await _employee.AddEmployee(_emp, _acc);
                MessageBox.Show("Thêm thành công ");
            }
                    
        }
        
        private void checked_NHD_CheckedChanged(object sender, System.EventArgs e)
        {

        }
    }
}
