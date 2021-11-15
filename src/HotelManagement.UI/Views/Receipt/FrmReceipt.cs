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
            CheckInTime.Value = query.ReceiptDetail.CheckIn;
            txb_note.Text = query.Receipt.Note;
            PeopleAmount.Value = query.Receipt.Number;
            txb_number.Text = query.Customer.IdentityNumber;
            txb_name.Text = query.Customer.Name;
            txb_numberPhone.Text = query.Customer.PhoneNumber;
            if (query.Customer.Gender) RbtMale.Checked = true;
            else RbtFemale.Checked = true;
            if (query.Receipt.Status == 0) CbxByDay.Checked = true;
            else if (query.Receipt.Status == 1) CbxByHour.Checked = true;
            else CbxByNight.Checked = true;
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
                ServiceGridView.Rows.Add(x.Name, x.Quantity, x.Price, x.Price * x.Quantity);
            }
        }

        #region 

        private void cbx_roomtype_Enter(object sender, EventArgs e)
        {
            if (cbx_roomtype.Text == "Loại phòng")
            {
                cbx_roomtype.Text = "";
            }
        }

        private void cbx_giayTo_Enter(object sender, EventArgs e)
        {
            if (cbx_giayTo.Text == "Giấy tờ")
            {
                cbx_giayTo.Text = "";
            }
        }

        private void txb_payments_Enter(object sender, EventArgs e)
        {
            if (TbxDeposit.Text == "Tiền trả trước")
            {
                TbxDeposit.Text = "";
            }
        }

        private void txb_note_Enter(object sender, EventArgs e)
        {
            if (txb_note.Text == "Ghi chú")
            {
                txb_note.Text = "";
            }
        }

        private void txb_deposits_Enter(object sender, EventArgs e)
        {
            if (TbxPayment.Text == "Thành tiền")
            {
                TbxPayment.Text = "";
            }
        }

        private void txb_number_Enter(object sender, EventArgs e)
        {
            if (txb_number.Text == "Số giấy tờ")
            {
                txb_number.Text = "";
            }
        }
        private void txb_name_Enter(object sender, EventArgs e)
        {
            if (txb_name.Text == "Tên khách hàng")
            {
                txb_name.Text = "";
            }
        }

        private void txb_numberPhone_Enter(object sender, EventArgs e)
        {
            if (txb_numberPhone.Text == "Số điện thoại")
            {
                txb_numberPhone.Text = "";
            }
        }

        private void CmbService_Enter(object sender, EventArgs e)
        {
            if (CmbService.Text == "Tên dịch vụ")
            {
                CmbService.Text = "";
            }
        }
        private void txb_hinhthuc_Enter(object sender, EventArgs e)
        {
            if (txb_hinhthuc.Text == "Hình thức thanh toán")
            {
                txb_hinhthuc.Text = "";
            }
        }
        #endregion

        private void FrmReceipt_Load(object sender, EventArgs e)
        {
            LoadIdentification();
            LoadService();
            ServiceQuantity.Value = 1;
        }

        #region Checkbox

        private void CbxByHour_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxByDay.Checked || CbxByNight.Checked)
            {
                CbxByDay.Checked = false;
                CbxByNight.Checked = false;
            }
            lbl_roomPrice.Text = "Giá phòng:" + _room.RoomType.ByHour.ToString("C", new CultureInfo("vi_VN"));
        }

        private void CbxByDay_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxByHour.Checked || CbxByNight.Checked)
            {
                CbxByHour.Checked = false;
                CbxByNight.Checked = false;
            }
            
            lbl_roomPrice.Text = "Giá phòng:" + _room.RoomType.ByDay.ToString("C", new CultureInfo("vi_VN"));
        }

        private void CbxByNight_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxByHour.Checked || CbxByDay.Checked)
            {
                CbxByHour.Checked = false;
                CbxByDay.Checked = false;
            }
            lbl_roomPrice.Text = "Giá phòng:" + _room.RoomType.ByNight.ToString("C", new CultureInfo("vi_VN"));
        }

        #endregion

        private async void Checkin_Click(object sender, EventArgs e)
        {
            var transaction = new TransactionDTO()
            {
                RoomId = _roomId,
                Customer = new()
                {
                    Name = txb_name.Text,
                    IdentityNumber = txb_number.Text,
                    PhoneNumber = txb_numberPhone.Text,
                    Gender = RbtMale.Checked
                },
                Receipt = new()
                {
                    Deposit = Convert.ToDouble(TbxDeposit.Text),
                    Note = txb_note.Text,
                    Number = Convert.ToInt32(PeopleAmount.Text),
                    IdentificationId = Convert.ToInt32(cbx_giayTo.SelectedValue)
                },
                ServiceReceipts = _serviceInOrder,
                
                ReceiptDetail = new ()
                {
                    CheckIn = Convert.ToDateTime(CheckInTime.Value),
                    CheckOut = Convert.ToDateTime(CheckOutTime.Value)
                }
            };
            if (CbxByDay.Checked) transaction.Receipt.Status = 0;
            else if (CbxByHour.Checked) transaction.Receipt.Status = 1;
            else transaction.Receipt.Status = 2;
            MessageBox.Show(await _transacsion.Create(transaction));
        }

        private void Checkout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang phát triển");
        }

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

        private async void CmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            _serviceId = Convert.ToInt32(CmbService.SelectedValue);
            _serviceDTO = await _service.GetDetail(_serviceId);
            Price.Text = _serviceDTO.Price.ToString(CultureInfo.InvariantCulture);
        }

        private void ServiceQuantity_ValueChanged(object sender, EventArgs e)
        {
            if(_serviceDTO is null) return;
            Price.Text = (Convert.ToInt32(ServiceQuantity.Value) * _serviceDTO.Price).ToString(CultureInfo.InvariantCulture);
        }

        private void BtnCancle_Click(object sender, EventArgs e) => Close();

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
    }
}