using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs.Room;
using HotelManagement.UI.Contracts;


namespace HotelManagement.UI.Views.Room
{
    public partial class FrmUpdateRoom : Form
    {
        private readonly IRoomService _roomService;
        private readonly IConfirm _confirm;
        private readonly IList<CreateRoomDTO> _queue = new List<CreateRoomDTO>();
        private RoomDetailDTO _roomDetail;

        public FrmUpdateRoom(IRoomService roomService, IConfirm confirm)
        {
            InitializeComponent();
            _roomService = roomService;
            _confirm = confirm;
        }

        public int Id
        {
            set => Binding(value);
        }

        public async void Binding(int id)
        {
            _roomDetail = await _roomService.GetDetail(id);
            TbxName.Text = _roomDetail.Name;
            if (_roomDetail.Status == 0)
                CbxActive.Checked = true;
            else
                CbxDeactive.Checked = true;

        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (_confirm.IsConfirm("Bạn chắc chứ?"))
                MessageBox.Show(await _roomService.Update(_roomDetail));
        }

        private async void BtnEditToQueue_Click(object sender, EventArgs e)
        {
            _roomDetail.Name = TbxName.Text;
            _roomDetail.Status = CbxActive.Checked ? 0 : 1;
            MessageBox.Show(await _roomService.Update(_roomDetail));
        }
    }
}
