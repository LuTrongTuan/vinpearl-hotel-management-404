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
            foreach (var a in z)
            {
                cmb_tang.Items.Add(a.Floor);
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
                var tang = await _floor.GetAll();
                var load = tang.Where(c => c.Id == x.typeId).Select(c => c.Floor).FirstOrDefault();
                dg_tkp.Rows.Add(x.Id,x.Name, name, x.Status == 0? "Hoạt động":x.Status == 1 ?"Đang dọn dẹp":"Không hoạt động");
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

        private void cmb_tang_SelectedValueChanged(object sender, EventArgs e)
        {
            Search(Convert.ToInt32(cmb_tang.Text));
        }
        async void Search(int floor)
        {
            dg_tkp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_tkp.ColumnCount = 4;
            dg_tkp.Columns[0].Name = "id";
            dg_tkp.Columns[0].Visible = false;
            dg_tkp.Columns[1].Name = "Tên phòng";
            dg_tkp.Columns[2].Name = "Tên loại phòng";
            dg_tkp.Columns[3].Name = "Trạng thái phòng";
            dg_tkp.Rows.Clear();
            var room = await _room.GetList();
            foreach (var x in room.Where(c => c.FloorNumber == floor))
            {
                var y = await _roomType.Get();
                var name = y.Where(c => c.Id == x.typeId).Select(c => c.Name).FirstOrDefault();
                dg_tkp.Rows.Add(x.Id, x.Name, name, x.Status == 0 ? "Hoạt động" : x.Status == 1 ? "Đang dọn dẹp" : "Không hoạt động");
            }
        }

        private void BtnRefresh_Room_Click(object sender, EventArgs e) => gridTk();
        async void load()
        {
            dgrid_doanh.ColumnCount = 3;
            dgrid_doanh.Columns[0].Name = "Tên phòng";
            dgrid_doanh.Columns[1].Name = "Tên loại phòng";
            dgrid_doanh.Columns[2].Name = "Tiền";
            dgrid_doanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrid_doanh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrid_doanh.Rows.Clear();

            foreach (var x in await _room.GetList())
            {
                var m = await _roomType.Get();
                var nae = m.Where(c => c.Id == x.typeId).Select(c => c.Name).FirstOrDefault();

                var name = await _room.getTak(y => y.RoomId == x.Id);
                var money = name.Sum(c => c.Receipt.Payment);
                dgrid_doanh.Rows.Add(x.Name, nae, money);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
