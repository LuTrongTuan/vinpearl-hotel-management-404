using System;
using System.Collections.Generic;
using System.Linq;
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
        private readonly IList<ServiceDTO> _list = new List<ServiceDTO>();
        private readonly IList<ServicetypeDTO> _listtype = new List<ServicetypeDTO>();
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
            dg_DV.ColumnCount = 2;
            dg_DV.Columns[0].HeaderText = "name";
            dg_DV.Columns[1].HeaderText = "price";
            dg_DV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_DV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_DV.Rows.Clear();
            foreach (var room in _list)
                dg_DV.Rows.Add(room.Name,room.Price);
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
            if (txt_DV.Text == string.Empty)
            {
                txt_DV.IsError = true;
                txt_DV.ErrorMessage = "Không được để trống";
            }
            else
            {
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
        }
        public async void loadserach(string dv)
        {
            var name = await _service.Find(dv);
            dg_DV.Rows.Clear();
            foreach (var x in name)
            {
                dg_DV.Rows.Add(x.Name);
            }
        }
        private void txt_SeaDV_KeyUp(object sender, KeyEventArgs e)
        {
            loadserach(txt_DV.Text);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

        }
    }
}
