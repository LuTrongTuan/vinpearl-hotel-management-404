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
using HotelManagement.UI.Contracts;
using HotelManagement.UI.Utilities;
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
        private IList<HistoryDTO> _history = new List<HistoryDTO>();
        private IValidate _validate;
        private int _roomId;
        private int _serviceId;
        private ServiceDTO _serviceDTO;
        private RoomDetailDTO _room;
        private CustomerDTO _customerDTO;
        private readonly IConfirm _confirm;
        private int _originStatus;
        private bool _isReceipt;
        /// <summary>
        /// add customer in room to _customers list.
        /// </summary>
        private IList<CustomerDTO> _customers = new List<CustomerDTO>();
        private FilterInfoCollection _filterInfoCollection;
        private VideoCaptureDevice _videoCaptureDevice;

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
            ICustomerService customerService, IConfirm confirm)
        {
            _transacsion = transacsion;
            _service = service;
            _customerService = customerService;
            _confirm = confirm;
            InitializeComponent();
            OpenCamera();
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
            LblType.Text = _room.RoomType.Name;
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
                BtnUpdate.Enabled = false;
                Dtpicker_in.Value = DateTime.Now;
            }
        }

        private async void ShowReceipt()
        {
            var query = await _transacsion.Query(_roomId);
            _originStatus = query.Histories.Last().Status;
            TbxDeposit.Text = query.Receipt.Deposit.ToString(CultureInfo.CurrentCulture);
            TbxNote.Text = query.Receipt.Note;
            LblPeople.Text = query.Receipt.Number.ToString();
            LblPayment.Text = MoneyFormat(query.Receipt.Payment);
            _history = query.Histories;
            _isReceipt = true;
            if (_originStatus == 0)
            {
                CbxByDay.Checked = true;
                Dtpicker_checkIn.Value = query.Detail.CheckIn;
                Dtpicker_checkOut.Value = query.Detail.CheckOut;
                Dtpicker_checkOut.MinDate = query.Detail.CheckOut;
            }

            if (_originStatus == 1)
            {
                CbxByHour.Checked = true;
                Dtpicker_in.Value = query.Detail.CheckIn;
                //Dtpicker_out.Value = DateTime.Now;
                Dtpicker_out.Value = query.Detail.CheckOut;
            }

            if (_originStatus == 2)
            {
                Dtpicker_checkOut.MinDate = DateTime.Now;
            }

            _customers = query.Customers;
            LoadCustomer();
            LoadToGrid(query.Services);
        }

        private void LoadCustomer()
        {
            GridViewCustomer.ColumnCount = 6;
            GridViewCustomer.Columns[0].Name = "Số Giấy Tờ";
            GridViewCustomer.Columns[1].Name = "Tên Khách Hàng";
            GridViewCustomer.Columns[2].Name = "Số Điện Thoại";
            GridViewCustomer.Columns[3].Name = "Giới Tính";
            GridViewCustomer.Columns[4].Name = "Giấy Tờ";
            GridViewCustomer.Columns[5].Name = "Id";
            GridViewCustomer.Columns[5].Visible = false;
            GridViewCustomer.Rows.Clear();
            foreach (var x in _customers)
                GridViewCustomer.Rows.Add(x.IdentityNumber,x.Name,x.PhoneNumber,x.Gender ? "Nam" : "Nữ",
                    x.Type == 1 ? "CCCD" : x.Type == 2 ? "GPLX":"Passport");
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

        private void LoadFrm()
        {
            var frmRe = Program.Container.GetInstance<FrmReceiptDetail>();
            frmRe.Show();
            frmRe.RoomId = _roomId;
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
            if(transaction is not null && _confirm.IsConfirm("Bạn có chắc không?"))
            {
                MessageBox.Show(await _transacsion.Create(transaction));
                ShowReceipt();
            }
        }

        private async void Checkout_Click(object sender, EventArgs e)
        {
            LoadFrm();
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
            if (!_confirm.IsConfirm("Bạn có chắc không?")) return;
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
            try
            {
                var deposit = TbxDeposit.Text;
                if (deposit != "")
                {
                    _ = Convert.ToInt32(deposit);
                }
            }
            catch
            {
                TbxDeposit.ErrorMessage = "Chỉ được nhập số";
                return null;
            }

            if (_customers.Count == 0)
            {
                MessageBox.Show("Không thể tạo hóa đơn khi không có khách hàng");
                return null;
            }

            var transaction = new TransactionDTO()
            {
                RoomId = _roomId,
                Customers = _customers,
                Receipt = new()
                {
                    Note = TbxNote.Text,
                    Number = Convert.ToInt32(LblPeople.Text),
                    IdentificationId = Convert.ToInt32(cbx_giayTo.SelectedValue)
                },
                Services = _serviceInOrder
            };
            if (CbxByDay.Checked)
            {
                transaction.Detail = new ReceiptDetailDTO
                {
                    CheckIn = Dtpicker_checkIn.Value,
                    CheckOut = Dtpicker_checkOut.Value
                };

                if (!_isReceipt)
                {
                    _history.Add(new HistoryDTO
                    {
                        Start = Dtpicker_checkIn.Value,
                        End = Dtpicker_checkOut.Value,
                        Status = 0
                    });
                }
                else
                {
                    if (_originStatus != 0)
                    {
                        _history.Add(new HistoryDTO
                        {
                            Start = Dtpicker_checkIn.Value,
                            End = Dtpicker_checkOut.Value,
                            Status = 0
                        });
                    }
                    else
                    {
                        var currentHistory = _history.First(x => x.Start.ToShortDateString() == Dtpicker_checkIn.Value.ToShortDateString());
                        currentHistory.End = Dtpicker_checkOut.Value;
                    }
                }

            }
            else if (CbxByHour.Checked)
            {
                transaction.Detail = new ReceiptDetailDTO
                {
                    CheckIn = Dtpicker_in.Value,
                    CheckOut = Dtpicker_out.Value
                };
                if (!_isReceipt)
                {
                    _history.Add(new HistoryDTO
                    {
                        Start = Dtpicker_in.Value,
                        End = Dtpicker_out.Value,
                        Status = 1
                    });
                }
                else
                {
                    if (_originStatus != 1)
                    {
                        _history.Add(new HistoryDTO
                        {
                            Start = Dtpicker_in.Value,
                            End = Dtpicker_out.Value,
                            Status = 1
                        });
                    }
                    else
                    {
                        var currentHistory = _history.First(x => x.Start.ToShortDateString() == Dtpicker_in.Value.ToShortDateString());
                        currentHistory.End = Dtpicker_out.Value;
                    }
                }
            }
            else transaction.Receipt.Status = 2;

            transaction.Receipt.Deposit = TbxDeposit.Text == "" ? 0 : Convert.ToInt32(TbxDeposit.Text);

            transaction.Histories = _history;
            return transaction;

        }

        private string MoneyFormat(double money) => money.ToString("C", new CultureInfo("vi-VN"));

        private string Remove(string money) => _pattern.Replace(money, "");

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!_confirm.IsConfirm("Bạn có muốn cập nhật?")) return;
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
        }

        #region Quét căn cước

        void OpenCamera()
        {
            _filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filter in _filterInfoCollection)
                cbo_webcam.Items.Add(filter.Name);
            cbo_webcam.SelectedIndex = 0;
            _videoCaptureDevice = new VideoCaptureDevice();
        }
        private void FrmReceipt_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                if (_videoCaptureDevice.IsRunning)
                {
                    _videoCaptureDevice.Stop();
                }
            }
            catch (Exception )
            {
                return;
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            _videoCaptureDevice = new VideoCaptureDevice(_filterInfoCollection[cbo_webcam.SelectedIndex].MonikerString);
            _videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            _videoCaptureDevice.Start();
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
                        if (_videoCaptureDevice.IsRunning)
                        {
                            _videoCaptureDevice.Stop();
                        }
                    }
                }
            }
            catch
            {
                return;
            }
        }

        #endregion

        private void Btn_AddCustomer_Click(object sender, EventArgs e)
        {
            _validate = new Validate();
            _validate
                .Add(new ValidateModel
                    {Control = TbxCustomerName, Error = "Tên không đúng định dạng", Pattern = Pattern.Name})
                .Add(new ValidateModel
                    {Control = TbxIdentityNumber, Error = "Số dịnh danh không đúng", Pattern = Pattern.IdentityNumber})
                .Add(new ValidateModel
                    {Control = TbxPhoneNumber, Error = "SĐT không đúng", Pattern = Pattern.PhoneNumber});
            if (_validate.Run().Accept() && _confirm.IsConfirm("Bạn có chắc không"))
            {
                _customerDTO = new CustomerDTO
                {
                    IdentityNumber = TbxIdentityNumber.Text,
                    Name = TbxCustomerName.Text,
                    PhoneNumber = TbxPhoneNumber.Text,
                    Gender = RbtMale.Checked,
                    Type = Convert.ToInt32(cbx_giayTo.SelectedValue)
                };
                _customers.Add(_customerDTO);
                LblPeople.Text = _customers.Count.ToString();
                LoadCustomer();
            }
        }
    }
}