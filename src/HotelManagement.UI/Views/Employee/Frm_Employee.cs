using System;
using System.Linq;


using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using System.Windows.Forms;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs.Employee;
using HotelManagement.Domain;
using HotelManagement.UI.Contracts;

namespace HotelManagement.UI.Views.Employee
{
    public partial class Frm_Employee : Form
    {
        private readonly IEmployeeService _employee;
        private readonly IConfirm _confirm;
        private readonly IRoleService _roleService;

        private int rowIndex, IdClick;
        private string _phone;
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

            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "Họ tên";
            dataGridView1.Columns[1].Name = "Ngày sinh";
            dataGridView1.Columns[2].Name = "email";
            dataGridView1.Columns[3].Name = "Địa chỉ";
            dataGridView1.Columns[4].Name = "Điện thoại";
            dataGridView1.Columns[5].Name = "Giới tính";
            dataGridView1.Columns[6].Name = "Trạng thái";
            dataGridView1.Columns[7].Name = "Vai trò";
            dataGridView1.Columns[8].Name = "Id";
            dataGridView1.Columns[8].Visible = false;

            dataGridView1.Rows.Clear();
            foreach (var x in name)
            {
                dataGridView1.Rows.Add(x.Name, x.Birthday, x.Email, x.Address, x.PhoneNumber,
                    x.Gender ? "Nam" : "Nữ", x.Status ? "Hoạt động" : "Không hoạt động", x.NameRole,x.Id);
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
                    Address = TxtDiachi.Text,
                    PhoneNumber = TxtPhone.Text,
                    Status = checked_HD.Checked,
                    Gender = rdoNam.Checked,

                },
                UserName = TxtUsername.Text,
                RoleId = Convert.ToInt32(cboVaitro.SelectedValue)
            };

            if (!checkNull()) return;
            if (!number.IsMatch(TxtPhone.Text))
            {
                MessageBox.Show("SĐT không được nhập chữ");
                return;
            }
            var load = await _employee.Get();
            if (load.Any(c => c.Email == TxtEmail.Text))
            {
                MessageBox.Show("Email đã có trong hệ thống ");
                return;
            }

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
                string.IsNullOrEmpty(TxtDiachi.Text) || string.IsNullOrEmpty(TxtPhone.Text))
            { MessageBox.Show("Không được để trống thông tin \n Vui lòng nhập lại", "Thông báo");
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
                dataGridView1.Rows.Add(x.Name, x.Birthday, x.Email, x.Address, x.PhoneNumber,
                    x.Gender ? "Nam" : "Nữ", x.Status ? "Hoạt động" : "Không hoạt động", x.NameRole);
            }
        }

        private void tbx_search_KeyUp(object sender, KeyEventArgs e)
        {
            loadSeach(tbx_search.Text);
        }

        private async void btn_edit_Click(object sender, EventArgs e)
        {

            var x = await _employee.GetList();
            var _employeeDTOs = x.FirstOrDefault(c => c.Id == IdClick);
            _employeeDTOs.Name = TxtName.Text;
            _employeeDTOs.Birthday = dateTimePicker1.Value;
            var load = await _employee.Get();
            if (load.Any(c => c.Email != TxtEmail.Text))
            {
                MessageBox.Show("Không Được Sửa Email");
                return;
            }
            _employeeDTOs.Email = TxtEmail.Text;
            _employeeDTOs.Address = TxtDiachi.Text;
            if (!number.IsMatch(TxtPhone.Text))
            {
                MessageBox.Show("SĐT không được nhập chữ");
                return;
            }
            _employeeDTOs.PhoneNumber = TxtPhone.Text;
            _employeeDTOs.Gender = rdoNam.Checked;
            _employeeDTOs.Status = checked_HD.Checked;
            if (!checkNull()) return;
            if (_confirm.IsConfirm("bạn chắc chắn muốn sửa:"))
            {
                MessageBox.Show(await _employee.UpdateEmployee(_employeeDTOs),"Thông báo");
                loadData();
            }

        } 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (rowIndex == -1) return;
            TxtName.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            TxtEmail.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            TxtDiachi.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            TxtPhone.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            rdoNam.Checked = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString() == "Nam"?true:false;
            rdoNu.Checked = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString() == "Nữ" ? true : false;
            if (dataGridView1.Rows[rowIndex].Cells[6].Value.ToString() == "Hoạt động")
            {
                checked_HD.Checked = true;
            }
            else
            {
                checked_NHD.Checked = true;
            }
            cboVaitro.Text = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
            IdClick = dataGridView1.Rows[rowIndex].Cells[8].Value.GetHashCode();

        }
    }
}
