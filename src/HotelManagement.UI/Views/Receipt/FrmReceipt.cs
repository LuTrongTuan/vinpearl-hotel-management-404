﻿using System;
using System.Windows.Forms;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs;
using HotelManagement.Application.DTOs.Room;

namespace HotelManagement.UI.Views.Receipt
{
    public partial class FrmReceipt : Form
    {
        private readonly IIdentificationService _identificationService;
        private readonly IService _service;
        private readonly IRoomTypeService _roomTypeService;
        private readonly IRoomService _roomService;
        private int _roomId;
        private ReceiptDTO _receipt;
        private RoomDetailDTO _room;
        private object datePortionDateTimePicker;
        private object timePortionDateTimePicker;

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

        public FrmReceipt(IIdentificationService identificationService, IService service,
            IRoomTypeService roomTypeService, IRoomService roomService)
        {
            _identificationService = identificationService;
            _service = service;
            _roomTypeService = roomTypeService;
            _roomService = roomService;
            InitializeComponent();
        }

        private async void LoadIdentification()
        {
            var query = await _identificationService.Get();
            cbx_giayTo.DisplayMember = "Name";
            cbx_giayTo.ValueMember = "Id";
            cbx_giayTo.DataSource = query;
        }

        private async void LoadService()
        {
            var query = await _service.Get();
            CmbService.DisplayMember = "Name";
            CmbService.ValueMember = "Id";
            CmbService.DataSource = query;
        }

        private async void GetRoomType()
        {
            //var query = await _roomTypeService.GetRoomTypeName();
            //LblRoomType.Text = query;
        }

        private async void Binding()
        {
            //_room = await _roomService.GetDetail(_roomId);
            //GetRoomType();
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
            if (txb_payments.Text == "Tiền trả trước")
            {
                txb_payments.Text = "";
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
            if (txb_deposits.Text == "Thành tiền")
            {
                txb_deposits.Text = "";
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

        private void txb_price_Enter(object sender, EventArgs e)
        {
            if (txb_price.Text == "Giá dịch vụ")
            {
                txb_price.Text = "";
            }
        }
        #endregion

    }
}