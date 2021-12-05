using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs.Room;

namespace HotelManagement.UI.Views.Receipt
{
    public partial class FrmReceiptDetail : Form
    {
        private readonly ITransacsion _transacsion;
        private RoomDetailDTO _room;
        private int _roomId;
        private bool _check;
        public int RoomId
        {
            get => _roomId;
            set
            {
                _roomId = value;
                Binding();
            }
        }

        public bool Check 
        { 
            get => _check;
            set
            {
                _check = value;
            }

        }
        public FrmReceiptDetail(ITransacsion transacsion)
        {
            _transacsion = transacsion;
            InitializeComponent();
        }
        private async void Binding()
        {
            var query = await _transacsion.Query(_roomId);
            _room = await _transacsion.GetRoomDetail(_roomId);
            label24.Text = "Phòng: " + _room.Name;
            label13.Text = _room.RoomType.Name;
            label17.Text = query.Receipt.Note;
            label16.Text = query.Receipt.Deposit.ToString();
            if (Check == false)
            {
                label14.Text = query.Histories.First().Start.ToString();
                label15.Text = query.Histories.First().End.ToString();
                label18.Text = _room.RoomType.ByHour.ToString();
            }
            else
            {
                label14.Text = query.Histories.First().Start.ToString();
                label15.Text = query.Histories.First().End.ToString();
                label18.Text = _room.RoomType.ByDay.ToString();
            }
            
            var x = query.Customers;
            label19.Text = x.First().Name;
            label20.Text = x.First().PhoneNumber;
            label21.Text = x.First().Gender == true?"Nam":"Nữ";
            label22.Text = x.First().Type == 1?"CCCD":"Banking";
            label23.Text = x.First().IdentityNumber;
            label26.Text = query.Receipt.Payment.ToString();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Tên Dịch Vụ";
            dataGridView1.Columns[1].Name = "Số Lượng";
            dataGridView1.Columns[2].Name = "Tiền Dịch Vụ";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.ColumnCount = 1;
            dataGridView2.Columns[0].Name = "Tên Khách Hàng";
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (var service in query.Services)
            {
                dataGridView1.Rows.Add(service.Name,service.Quantity,service.Price);
            }
            foreach (var customer in x)
            {
                dataGridView2.Rows.Add(customer.Name);
            }
        }

        private async void customButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(await _transacsion.Checkout(_roomId));
            this.Close();
        }
    }
}
