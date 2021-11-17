using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs;
using HotelManagement.Application.DTOs.Receipt;
using HotelManagement.Application.DTOs.Room;
using HotelManagement.Application.DTOs.Service;

namespace HotelManagement.UI.Views.Receipt
{
    public partial class FrmReceipt : Form
    {
        private readonly ITransacsion _transacsion;
        private readonly IService _service;
        private IList<ServiceReceiptDTO> _serviceInOrder = new List<ServiceReceiptDTO>();
        private int _roomId;
        private int _serviceId;
        private ServiceDTO _serviceDTO;
        private RoomDetailDTO _room;

        // properties
        public int RoomId
        {
            get => _roomId;
            set
            {
                _roomId = value;
                Binding();
            }
        }
        public FrmReceipt(ITransacsion transacsion, IService service)
        {
            _transacsion = transacsion;
            _service = service;
            InitializeComponent();
        }

        #region Onload

        private async void LoadIdentification()
        {
            var query = await _transacsion.GetIdentifications();
            cbx_giayTo.DisplayMember = "Name";
            cbx_giayTo.ValueMember = "Id";
            cbx_giayTo.DataSource = query;
        }

        private async void LoadService()
        {
            var query = await _transacsion.GetServices();
            CmbService.DisplayMember = "Name";
            CmbService.ValueMember = "Id";
            CmbService.DataSource = query;
        }

        #endregion

        private async void Binding()
        {
            _room = await _transacsion.GetRoomDetail(_roomId);
            RoomName.Text = "Phòng: " + _room.Name;
            cbx_roomtype.Text = _room.RoomType.Name;
            CbxByDay.Checked = true;
            if (_room.Status == 0)
            {
                ShowReceipt();
                BtnConfirm.Click += Checkout_Click;
                BtnConfirm.Text = "Thanh toán";
            }
            else
            {
                BtnConfirm.Text = "Nhận phòng";
                BtnConfirm.Click += Checkin_Click;
            }
        }

        private async void ShowReceipt()
        {
            var query = await _transacsion.Query(_roomId);
            TbxDeposit.Text = query.Receipt.Deposit.ToString(CultureInfo.CurrentCulture);
            Dtpicker_checkIn.Value = query.ReceiptDetail.CheckIn;
            TbxNote.Text = query.Receipt.Note;
            PeopleAmount.Value = query.Receipt.Number;
            TbxIdentityNumber.Text = query.Customer.IdentityNumber;
            TbxCustomerName.Text = query.Customer.Name;
            TbxPhoneNumber.Text = query.Customer.PhoneNumber;
            TbxPayment.Text = query.Receipt.Payment.ToString(CultureInfo.InvariantCulture);
            if (query.Customer.Gender) RbtMale.Checked = true;
            else RbtFemale.Checked = true;
            if (query.Receipt.Status == 0) CbxByDay.Checked = true;
            if (query.Receipt.Status == 1) CbxByHour.Checked = true;
            LoadToGrid(query.ServiceReceipts);
        }

        private void LoadToGrid(IList<ServiceReceiptDTO> source)
        {
            _serviceInOrder = source;
            ServiceGridView.ColumnCount = 4;
            ServiceGridView.Columns[0].HeaderText = "Tên";
            ServiceGridView.Columns[1].HeaderText = "Số lượng";
            ServiceGridView.Columns[2].HeaderText = "Giá";
            ServiceGridView.Columns[3].HeaderText = "Tổng";

            ServiceGridView.Rows.Clear();

            foreach (var x in source)
            {
                ServiceGridView.Rows.Add(x.Name, x.Quantity, MoneyFormat(x.Price), MoneyFormat(x.Price * x.Quantity));
            }
        }
        private void FrmReceipt_Load(object sender, EventArgs e)
        {
            LoadIdentification();
            LoadService();
            ServiceQuantity.Value = 1;
        }

        #region Checkbox

        private void CbxByHour_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxByDay.Checked)
                CbxByDay.Checked = false;
            lbl_roomPrice.Text = "Giá phòng:" + MoneyFormat(_room.RoomType.ByHour);
        }

        private void CbxByDay_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxByHour.Checked)
                CbxByHour.Checked = false;

            lbl_roomPrice.Text = "Giá phòng:" + MoneyFormat(_room.RoomType.ByDay);
        }
        #endregion

        private async void Checkin_Click(object sender, EventArgs e)
        {
            var transaction = new TransactionDTO()
            {
                RoomId = _roomId,
                Customer = new()
                {
                    Name = TbxCustomerName.Text,
                    IdentityNumber = TbxIdentityNumber.Text,
                    PhoneNumber = TbxPhoneNumber.Text,
                    Gender = RbtMale.Checked
                },
                Receipt = new()
                {
                    Deposit = Convert.ToDouble(TbxDeposit.Text),
                    Note = TbxNote.Text,
                    Number = Convert.ToInt32(PeopleAmount.Text),
                    IdentificationId = Convert.ToInt32(cbx_giayTo.SelectedValue)
                },
                ServiceReceipts = _serviceInOrder
            };
            if (CbxByDay.Checked)
            {
                transaction.Receipt.Status = 0;
                transaction.ReceiptDetail = new ReceiptDetailDTO
                {
                    CheckIn = Dtpicker_checkIn.Value,
                    CheckOut = Dtpicker_checkOut.Value
                };
            }
            else if (CbxByHour.Checked)
            {
                transaction.Receipt.Status = 1;
                transaction.ReceiptDetail = new ReceiptDetailDTO
                {
                    CheckIn = Dtpicker_in.Value,
                    CheckOut = Dtpicker_out.Value
                };
            }
            else transaction.Receipt.Status = 2;
            MessageBox.Show(await _transacsion.Create(transaction));
        }

        private void Checkout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang phát triển");
        }
        private async void CmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            _serviceId = Convert.ToInt32(CmbService.SelectedValue);
            _serviceDTO = await _service.GetDetail(_serviceId);
            Price.Text = MoneyFormat(_serviceDTO.Price);
        }

        private void ServiceQuantity_ValueChanged(object sender, EventArgs e)
        {
            if(_serviceDTO is null) return;
            Price.Text = (Convert.ToInt32(ServiceQuantity.Value) * _serviceDTO.Price).ToString(CultureInfo.InvariantCulture);
        }

        private bool DuplicateHandler(ServiceReceiptDTO data)
        {
            var item = _serviceInOrder.FirstOrDefault(x => x.ServiceId == data.ServiceId);
            if (item != null)
            {
                item.Quantity += data.Quantity;
                item.Total += data.Total;
            }

            return item == null;
        }

        private void btb_cancel_Click(object sender, EventArgs e) => Close();

        private void BtnAddService_Click(object sender, EventArgs e)
        {
            var item = new ServiceReceiptDTO()
            {
                Name = CmbService.Text,
                Quantity = Convert.ToInt32(ServiceQuantity.Text),
                ServiceId = Convert.ToInt32(CmbService.SelectedValue),
                Price = _serviceDTO.Price,
                Total = Convert.ToDouble(Price.Text)
            };
            if(DuplicateHandler(item))
                _serviceInOrder.Add(item);
            LoadToGrid(_serviceInOrder);
        }

        private string MoneyFormat(double money) => money.ToString("C", new CultureInfo("vi-VN"));
    }
}