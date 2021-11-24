using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs;
using HotelManagement.Application.DTOs.Receipt;
using HotelManagement.Application.DTOs.Room;
using HotelManagement.Application.DTOs.Service;
using ZXing;

namespace HotelManagement.UI.Views.Receipt
{
    public partial class FrmReceipt : Form
    {
        private readonly Regex _pattern = new(@"\W|\.|₫");
        private readonly ITransacsion _transacsion;
        private readonly IService _service;
        private readonly ICustomerService _customerService;
        private IList<ServiceReceiptDTO> _serviceInOrder = new List<ServiceReceiptDTO>();
        private int _roomId;
        private int _serviceId;
        private ServiceDTO _serviceDTO;
        private RoomDetailDTO _room;
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;

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
        public FrmReceipt(ITransacsion transacsion, IService service,
            ICustomerService customerService)
        {
            _transacsion = transacsion;
            _service = service;
            _customerService = customerService;
            InitializeComponent();
            load();
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
            else if(_room.Status == 1)
            {
                BtnConfirm.Text = "Dọn xong";
                BtnConfirm.Click += CheckClean_Click;
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnConfirm.Text = "Nhận phòng";
                BtnConfirm.Click += Checkin_Click;
                BtnUpdate.Enabled = false;
            }
        }

        private async void ShowReceipt()
        {
            var query = await _transacsion.Query(_roomId);
            TbxDeposit.Text = query.Receipt.Deposit.ToString(CultureInfo.CurrentCulture);
            TbxNote.Text = query.Receipt.Note;
            PeopleAmount.Value = query.Receipt.Number;
            TbxIdentityNumber.Text = query.Customer.IdentityNumber;
            TbxCustomerName.Text = query.Customer.Name;
            TbxPhoneNumber.Text = query.Customer.PhoneNumber;
            LblPayment.Text = MoneyFormat(query.Receipt.Payment - query.Receipt.Deposit);
            if (query.Customer.Gender) RbtMale.Checked = true;
            else RbtFemale.Checked = true;
            if (query.Receipt.Status == 0)
            {
                CbxByDay.Checked = true;
                Dtpicker_checkIn.Value = query.ReceiptDetail.CheckIn;
                Dtpicker_checkOut.Value = query.ReceiptDetail.CheckOut;
            }

            if (query.Receipt.Status == 1)
            {
                CbxByHour.Checked = true;
                Dtpicker_in.Value = query.ReceiptDetail.CheckIn;
                Dtpicker_out.Value = query.ReceiptDetail.CheckOut;
            }
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
            if (_roomId == default)
            {
                Dtpicker_in.Value = DateTime.Now;
                Dtpicker_checkIn.Value = DateTime.Now;
            }
        }

        #region Checkbox

        private void CbxByHour_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxByHour.Checked)
                CbxByDay.Checked = false;
            lbl_roomPrice.Text = "Giá phòng:" + MoneyFormat(_room.RoomType.ByHour);
        }

        private void CbxByDay_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxByDay.Checked)
                CbxByHour.Checked = false;

            lbl_roomPrice.Text = "Giá phòng:" + MoneyFormat(_room.RoomType.ByDay);
        }
        #endregion

        private async void Checkin_Click(object sender, EventArgs e)
        {
            var transaction = GetTransaction();
            MessageBox.Show(await _transacsion.Create(transaction));
        }

        private async void Checkout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(await _transacsion.Checkout(_roomId));
        }

        private async void CheckClean_Click(object sender, EventArgs e)
        {
            MessageBox.Show(await _transacsion.CheckClean(_roomId));
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
            Price.Text = MoneyFormat(Convert.ToInt32(ServiceQuantity.Value) * _serviceDTO.Price);
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
                Total = Convert.ToDouble(Remove(Price.Text))
            };
            if(DuplicateHandler(item))
                _serviceInOrder.Add(item);
            LoadToGrid(_serviceInOrder);
            ServiceQuantity.Value = 1;
        }

        private TransactionDTO GetTransaction()
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

            return transaction;
        }

        private string MoneyFormat(double money) => money.ToString("C", new CultureInfo("vi-VN"));

        private string Remove(string money) => _pattern.Replace(money, "");

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(await _transacsion.Update(GetTransaction()));
            ShowReceipt();
        }

        private async void TbxIdentityNumber_KeyDown(object sender, KeyEventArgs e)
        {
            var request = await _customerService.GetDetail(TbxIdentityNumber.Text);
            if (request is null) return;
            TbxCustomerName.Text = request.Name;
            TbxPhoneNumber.Text = request.PhoneNumber;
            if (request.Gender)
                RbtMale.Checked = true;
            else RbtFemale.Checked = true;
            if (request.Status)
                CbxActive.Checked = true;
            else CbxDeactive.Checked = true;
        }

        #region Quét căn cước

        void load()
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filter in filterInfoCollection)
                cbo_webcam.Items.Add(filter.Name);
            cbo_webcam.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }
        private void FrmReceipt_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }
            }
            catch (Exception )
            {
                return;
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbo_webcam.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            timer1.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            ptb_quet.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (ptb_quet.Image != null)
                {
                    BarcodeReader barcodeReader = new BarcodeReader();
                    Result result = barcodeReader.Decode((Bitmap)ptb_quet.Image);
                    if (result != null)
                    {
                        txb_QR.Text = result.ToString().Trim();
                        var str = txb_QR.Text;
                        char[] chars = { '|' };
                        string[] strings = str.Split(chars);
                        TbxIdentityNumber.Text = strings[0];
                        TbxCustomerName.Text = strings[2];
                        if (strings[4] == "Nam")
                        {
                            RbtMale.Checked = true;
                        }
                        else
                        {
                            RbtFemale.Checked = true;
                        }
                        timer1.Stop();
                        if (videoCaptureDevice.IsRunning)
                        {
                            videoCaptureDevice.Stop();
                        }
                    }
                }
            }
            catch (Exception )
            {
            }
        }

        #endregion

    }
}