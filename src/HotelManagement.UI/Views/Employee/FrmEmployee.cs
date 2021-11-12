using System.Windows.Forms;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Domain;
using HotelManagement.UI.Contracts;

namespace HotelManagement.UI.Views.Employee
{
    public partial class FrmEmployee : Form
    {
        private readonly IEmployeeService _employee;
        private readonly IConfirm _confirm;
        private Account _acc;
        private Role _role;
        private Domain.Employee _emp;
        public FrmEmployee(IEmployeeService emp,IConfirm con)
        {
            InitializeComponent();
            _employee = emp;
            _confirm = con;
            load();
        }

        async void load()
        {
            //var result = await _employee.GetList();
            //cboVaitro.DataSource = result;
            //cboVaitro.DisplayMember = "Name";
            //cboVaitro.ValueMember = "Id";
        }
        private async void button1_Click(object sender, System.EventArgs e)
        {
            _acc= new Account();
            _role = new Role();
            _emp = new Domain.Employee();
            _acc.Employee = _emp;
            _acc.EmployeeId = _emp.Id;
            _acc.Password = TxtPass.Text;
            _acc.Role = _role;
            _acc.RoleId = _role.Id;
            _acc.UserName = TxtUsername.Text;
            _role.Accound = _acc;
            _role.Name = cboVaitro.Text;
            _emp.Account = _acc;
            _emp.Address = TxtDiachi.Text;
            _emp.Birthday = dateTimePicker1.Value;
            _emp.Email = TxtEmail.Text;
            _emp.Name = TxtName.Text;
            _emp.PhoneNumber = TxtPhone.Text;
            _emp.Status = checked_HD.Checked;
            _emp.Gender = rdoNam.Checked;
            if (_confirm.IsConfirm("bạn chắc chắn thêm"))
            {
                await _employee.AddEmployee(_emp, _acc, _role);
                MessageBox.Show("thêm thành công");
            }
        }
    }
}
