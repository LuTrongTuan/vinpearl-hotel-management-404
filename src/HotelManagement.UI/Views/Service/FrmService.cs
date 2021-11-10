using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs.Service;
<<<<<<< HEAD
using HotelManagement.Application.ValidateFrom;
=======
>>>>>>> aedac2ca5c67e726997c273c90795f72400a38a3
using HotelManagement.UI.Contracts;

namespace HotelManagement.UI.Views.Service
{
    public partial class FrmService : Form
    {
        private readonly IService _service;
        private readonly IConfirm _confirm;
        private readonly IServiceType _serviceType;
        private  int idClick;
        public FrmService(IServiceType sert, IConfirm con,IService ser)
        {
            InitializeComponent();
            _service = ser;
            _confirm = con;
            _serviceType = sert;
            LoadServiceType();
            Service();
        }

        async void LoadServiceType()
        {
            var result = await _serviceType.Get();
            cmb_LDV.DataSource = result.ToList();
            cmb_LDV.DisplayMember = "Name";
            cmb_LDV.ValueMember = "Id";
            dg_LDVview.ColumnCount = 1;
            dg_LDVview.Columns[0].Name = "name";
            dg_LDVview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_LDVview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_LDVview.Rows.Clear();
            foreach (var room in result.ToList())
            {
                dg_LDVview.Rows.Add(room.Name);
            }
        }
        async void Service()
        {
            var _list = await _service.Get();
<<<<<<< HEAD
            dg_DV.ColumnCount = 3;
            dg_DV.Columns[0].Name = "name";
            dg_DV.Columns[1].Name = "price";
            dg_DV.Columns[2].Name = "id";
            dg_DV.Columns[2].Visible = false;
=======
            dg_DV.ColumnCount = 2;
            dg_DV.Columns[0].HeaderText = "name";
            dg_DV.Columns[1].HeaderText = "price";
>>>>>>> aedac2ca5c67e726997c273c90795f72400a38a3
            dg_DV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_DV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_DV.Rows.Clear();
            foreach (var room in _list)
<<<<<<< HEAD
                dg_DV.Rows.Add(room.Name,room.Price + " đ",room.Id);
=======
                dg_DV.Rows.Add(room.Name,room.Price);
>>>>>>> aedac2ca5c67e726997c273c90795f72400a38a3
        }
        private async void btn_addLDV_Click(object sender, EventArgs e)
        {
            if (txt_LDV.Text == string.Empty)
            {
                txt_LDV.IsError = true;
                txt_LDV.ErrorMessage = "Không được để trống";
            }
            else
            {
                var sertype = new ServicetypeDTO { Name = txt_LDV.Text};
                if (_confirm.IsConfirm("bạn chắc chắn thêm"))
                {
                    await _serviceType.Add(sertype);
                    LoadServiceType();
                }
            }
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            var sertype = new ServiceDTO
            {
                Name = txt_DV.Text,
                ServiceTypeId = Convert.ToInt32(cmb_LDV.SelectedValue),
                Price = Convert.ToDouble(txt_price.Text)
            };
            if (ServiceValidate.validateSer(sertype) != "ok")
            {
                MessageBox.Show(ServiceValidate.validateSer(sertype));
                return;
            }
            if (_confirm.IsConfirm("bạn chắc chắn thêm"))
            {
<<<<<<< HEAD
                await _service.AddService(sertype);
                Service();
=======
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
>>>>>>> aedac2ca5c67e726997c273c90795f72400a38a3
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
                dg_DV.Rows.Add(x.Name,x.Price);
            }
        }
        private void txt_SeaDV_KeyUp(object sender, KeyEventArgs e)
        {
            // để xem qua đã
            MessageBox.Show("aaaa");
            loadserach(txt_DV.Text);
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

        private void txt_SeaDV_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("aaaa");
            loadserach(txt_DV.Text);
        }

        private void txt_SeaDV__TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
            loadserach(TbxSearch.Text);
        }

        private void dg_DV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == -1) return;
            idClick = dg_DV.Rows[rowIndex].Cells[2].Value.GetHashCode();
            txt_DV.Text = dg_DV.Rows[rowIndex].Cells[0].Value.ToString();
            txt_price.Text = dg_DV.Rows[rowIndex].Cells[1].Value.ToString();
        }
    }
}
