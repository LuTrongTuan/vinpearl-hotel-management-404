using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs.Service;
using HotelManagement.UI.Contracts;

namespace HotelManagement.UI.Views.Service
{
    public partial class FrmService : Form
    {
        private readonly IService _service;
        private readonly IConfirm _confirm;
        private readonly IServiceType _serviceType;
        private int idClick;
        private Regex number;
        public FrmService(IServiceType sert, IConfirm con, IService ser)
        {
            InitializeComponent();
            _service = ser;
            _confirm = con;
            _serviceType = sert;
            number = new Regex(@"^[0-9]*$");
            LoadServiceType();
            Service();
        }
        async void LoadServiceType()
        {
            var result = await _serviceType.Get();
            cmb_LDV.DataSource = result.ToList();
            cmb_LDV.DisplayMember = "Name";
            cmb_LDV.ValueMember = "Id";
        }
        async void Service()
        {
            var _list = await _service.Get();
            dg_DV.ColumnCount = 3;
            dg_DV.Columns[0].Name = "name";
            dg_DV.Columns[1].Name = "price";
            dg_DV.Columns[2].Name = "id";
            dg_DV.Columns[2].Visible = false;
            dg_DV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_DV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_DV.Rows.Clear();
            foreach (var room in _list)
                dg_DV.Rows.Add(room.Name, room.Price, room.Id);
        }
        private async void btn_addLDV_Click(object sender, EventArgs e)
        {
            if (txt_LDV.Text == String.Empty)
            {
                txt_LDV.IsError = true;
                txt_LDV.ErrorMessage = "Không được để trống";
            }
            else
            {
                var sertype = new ServicetypeDTO { Name = txt_LDV.Text };
                if (_confirm.IsConfirm("bạn chắc chắn thêm"))
                {
                    await _serviceType.Add(sertype);
                    LoadServiceType();
                }
            }
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_DV.Text == string.Empty)
            {
                txt_DV.IsError = true;
                txt_DV.ErrorMessage = "Không được để trống";
                if (txt_price.Text == String.Empty)
                {
                    txt_price.IsError = true;
                    txt_price.ErrorMessage = "không được để trống";
                    return;
                }
                return;
            }
            if (!number.IsMatch(txt_price.Text))
            {
                txt_price.Text = "";
                MessageBox.Show("Không được để chữ");
                return;
            }
            var x =await _service.Get();
            if (x.Any(c => c.Name == txt_DV.Text))
            {
                MessageBox.Show("tên dịch vụ đã tồn tại");
                return;
            }
            var sertype = new ServiceDTO
            {
                Name = txt_DV.Text,
                ServiceTypeId = Convert.ToInt32(cmb_LDV.SelectedValue),
                Price = Convert.ToDouble(txt_price.Text)
            };
            if (_confirm.IsConfirm("bạn chắc chắn thêm"))
            {
                await _service.AddService(sertype);
                Service();
            }
        }
        public async void loadserach(string dv)
        {
            var name = await _service.Find(dv);
            dg_DV.ColumnCount = 2;
            dg_DV.Columns[0].Name = "name";
            dg_DV.Columns[1].Name = "price";
            dg_DV.Rows.Clear();
            foreach (var x in name.ToList())
            {
                dg_DV.Rows.Add(x.Name, x.Price);
            }
        }
        private async void btn_sua_Click(object sender, EventArgs e)
        {
            var x = await _service.Get();
            var ser = x.Where(c => c.Id == idClick).FirstOrDefault();
            ser.Name = txt_DV.Text;
            ser.Price = Convert.ToDouble(txt_price.Text);
            ser.ServiceTypeId = Convert.ToInt32(cmb_LDV.SelectedValue);
            if (_confirm.IsConfirm("bạn chắc chắn sửa"))
            {
                await _service.UpdateService(ser);
                Service();
            }
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)  => loadserach(TbxSearch.Text);
        private async void dg_DV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == -1) return;
            idClick = dg_DV.Rows[rowIndex].Cells[2].Value.GetHashCode();
            txt_DV.Text = dg_DV.Rows[rowIndex].Cells[0].Value.ToString();
            txt_price.Text = dg_DV.Rows[rowIndex].Cells[1].Value.ToString();
            var x = await _service.GetDetail(idClick);
            var y = await _serviceType.Get();
            cmb_LDV.Text = y.Where(c => c.Id == x.ServiceTypeId).Select(c => c.Name).FirstOrDefault();
        }

        
    }
}
