using System;
using System.Linq;
using System.Windows.Forms;
using HotelManagement.Application.Contracts.Services;

namespace HotelManagement.UI.Views.Check
{
    public partial class FrmStastical : Form
    {

        private readonly IRoomService _room;
        private readonly IRoomTypeService _roomType;
        private readonly IFloorService _floor;
        private ICustomerService _customer;
        public FrmStastical(IRoomService room,IRoomTypeService roomType,IFloorService floor, ICustomerService customer)
        {
            InitializeComponent();
            _room = room;
            _roomType = roomType;
            _floor = floor;
            _customer = customer;
            cmbtang();
            gridTk();
            LoadCustomer();
        }
        async void cmbtang()
        {
            var z = await _floor.Get();
            cmb_tang.Items.Add("");
            // cmb_tang.DataSource = z;
            // cmb_tang.DisplayMember = "tang";
            // cmb_tang.ValueMember = "id";
            foreach (var a in z)
            {
                cmb_tang.Items.Add(a.Floor);
            }
            if (cmb_tang.Text == "1")
            {
                dg_tkp.Rows.Clear();
                dg_tkp.ColumnCount = 4;
                dg_tkp.Columns[0].Name = "id";
                dg_tkp.Columns[0].Visible = false;
                dg_tkp.Columns[1].Name = "Tên phòng";
                dg_tkp.Columns[2].Name = "Tên loại phòng";
                dg_tkp.Columns[3].Name = "Trạng thái phòng";
                dg_tkp.Rows.Clear();
                var list = await _room.GetList();
                foreach (var x in list.Where(c=>c.FloorNumber == Convert.ToInt32(cmb_tang.Text)))
                {
                    var y = await _roomType.Get();
                    var name = y.Where(c => c.Id == x.typeId).Select(c => c.Name).FirstOrDefault();
                    dg_tkp.Rows.Add(x.Id, x.Name, name, x.Status == 0 ? "Hoạt động" : x.Status == 1 ? "Đang dọn dẹp" : "Không hoạt động");
                }
            }
            else if (cmb_tang.SelectedIndex == 2)
            {
                
            }

        }
        async void gridTk()
        {
            dg_tkp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_tkp.ColumnCount = 4;
            dg_tkp.Columns[0].Name = "id";
            dg_tkp.Columns[0].Visible = false;
            dg_tkp.Columns[1].Name = "Tên phòng";
            dg_tkp.Columns[2].Name = "Tên loại phòng";
            dg_tkp.Columns[3].Name = "Trạng thái phòng";
            dg_tkp.Rows.Clear();
            foreach (var x in await _room.GetList())
            {
                var y = await _roomType.Get();
                var name = y.Where(c => c.Id == x.typeId).Select(c => c.Name).FirstOrDefault();
                dg_tkp.Rows.Add(x.Id,x.Name,name,x.Status == 0? "Hoạt động":x.Status == 1 ?"Đang dọn dẹp":"Không hoạt động");
            }
        }

        async void LoadCustomer()
        {
            dataCustomer.ColumnCount = 8;
            dataCustomer.Columns[0].Name = "Name";
            dataCustomer.Columns[1].Name = "Giới Tính";
            dataCustomer.Columns[2].Name = "SĐT";
            dataCustomer.Columns[3].Name = "Status";
            dataCustomer.Columns[4].Name = "Số Giấy Tờ";
            dataCustomer.Columns[5].Name = "Loại giấy Tờ";
            //dataCustomer.Columns[6].Name = "Ngày Vào";
            //dataCustomer.Columns[7].Name = "Ngày Ra";
            dataCustomer.Rows.Clear();
            foreach (var x in  await _customer.GetList())
            {
                dataCustomer.Rows.Add(x.Name, x.Gender == true ? "Nam" : "Nữ", x.PhoneNumber,
                    x.Status == true ? "Hoạt Động" : "Không Hoạt Động", x.IdentityNumber,
                    x.Type);
                Cmb_Type.Items.Add(x.Type);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e) => LoadCustomer();

        private void Cmb_Type_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadCustomerType(Convert.ToInt32(Cmb_Type.Text));
        }
        async void LoadCustomerType(int type)
        {
            dataCustomer.ColumnCount = 8;
            dataCustomer.Columns[0].Name = "Name";
            dataCustomer.Columns[1].Name = "Giới Tính";
            dataCustomer.Columns[2].Name = "SĐT";
            dataCustomer.Columns[3].Name = "Status";
            dataCustomer.Columns[4].Name = "Số Giấy Tờ";
            dataCustomer.Columns[5].Name = "Loại giấy Tờ";
            //dataCustomer.Columns[6].Name = "Ngày Vào";
            //dataCustomer.Columns[7].Name = "Ngày Ra";
            dataCustomer.Rows.Clear();
            foreach (var x in await _customer.FindType(type))
            {
                dataCustomer.Rows.Add(x.Name, x.Gender == true ? "Nam" : "Nữ", x.PhoneNumber,
                    x.Status == true ? "Hoạt Động" : "Không Hoạt Động", x.IdentityNumber,
                    x.Type);
            }
        }
    }
}
