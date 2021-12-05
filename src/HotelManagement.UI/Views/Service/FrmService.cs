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
            LoadService();
        }
        //async void LoadServiceType()
        //{
        //    var result = await _serviceType.Get();
        //    cmb_LDV.DataSource = result.ToList();
        //    cmb_LDV.DisplayMember = "Name";
        //    cmb_LDV.ValueMember = "Id";
        //}
        async void LoadService()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn cmb_ser = new DataGridViewComboBoxColumn();
            var result = await _serviceType.Get();
            cmb_LDV.DataSource = result.ToList();
            cmb_LDV.DisplayMember = "Name";
            cmb_LDV.ValueMember = "Id";
            btn.Name = "btn_confirm";
            btn.UseColumnTextForButtonValue = true;
            btn.HeaderText = "Confirm";
            btn.Text = "OK";
            btn.FlatStyle = FlatStyle.Popup;
            cmb.Name = "function";
            cmb.HeaderText = "Chức năng";
            cmb.Items.Add("thêm");
            cmb.Items.Add("sửa");
            cmb_ser.Name = "service";
            cmb_ser.HeaderText = "ServiceType";
            cmb_ser.DataSource = result.ToList();
            cmb_ser.DisplayMember = "Name";
            cmb_ser.ValueMember = "id";
            var _list = await _service.Get();
            dg_DV.ColumnCount = 3;
            dg_DV.Columns[0].Name = "name";
            dg_DV.Columns[1].Name = "price";
            dg_DV.Columns[2].Name = "id";
            dg_DV.Columns[2].Visible = false;
            dg_DV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_DV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_DV.Columns.Add(cmb_ser);
            dg_DV.Columns.Add(cmb);
            dg_DV.Columns.Add(btn);
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
                    LoadService();
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
                TypeId = Convert.ToInt32(cmb_LDV.SelectedValue),
                Price = Convert.ToDouble(txt_price.Text),
                Status = checkBox1.Checked
            };
            if (_confirm.IsConfirm("bạn chắc chắn thêm"))
            {
                await _service.AddService(sertype);
                LoadService();
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
            ser.TypeId = Convert.ToInt32(cmb_LDV.SelectedValue);
            if (_confirm.IsConfirm("bạn chắc chắn sửa"))
            {
                await _service.UpdateService(ser);
                LoadService();
            }
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)  => loadserach(TbxSearch.Text);
        private async void dg_DV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var service = await _service.Get();
            int rowIndex = e.RowIndex;
            if (rowIndex < service.Count && rowIndex > -1)
            {
                idClick = dg_DV.Rows[rowIndex].Cells[2].Value.GetHashCode();
                txt_DV.Text = dg_DV.Rows[rowIndex].Cells[0].Value.ToString();
                txt_price.Text = dg_DV.Rows[rowIndex].Cells[1].Value.ToString();
                var x = await _service.GetDetail(idClick);
                var y = await _serviceType.Get();
                cmb_LDV.Text = y.Where(c => c.Id == x.TypeId).Select(c => c.Name).FirstOrDefault();
                if (e.ColumnIndex == dg_DV.Columns["btn_confirm"].Index)
                {
                    if (dg_DV.Rows[rowIndex].Cells[6].Value.ToString() == "sửa")
                    {
                        var xs= await _service.Get();
                        var ser = xs.Where(c => c.Id == idClick).FirstOrDefault();
                        ser.Name = txt_DV.Text;
                        ser.Price = Convert.ToDouble(txt_price.Text);
                        ser.TypeId = Convert.ToInt32(cmb_LDV.SelectedValue);
                        if (_confirm.IsConfirm("bạn chắc chắn sửa"))
                        {
                            await _service.UpdateService(ser);
                            LoadService();
                        }
                    }
                }
            }
            else
            {
                if (e.ColumnIndex == dg_DV.Columns["btn_confirm"].Index)
                {
                    var sertype = new ServiceDTO
                    {
                        Name = txt_DV.Text,
                        TypeId = Convert.ToInt32(cmb_LDV.SelectedValue),
                        Price = Convert.ToDouble(txt_price.Text),
                        Status = checkBox1.Checked
                        //Id = x.Max(c=>c.Id) +1
                    };
                    if (_confirm.IsConfirm("bạn chắc chắn thêm"))
                    {
                        await _service.AddService(sertype);
                        LoadService();
                    }
                }
            }
        }
    }
}
