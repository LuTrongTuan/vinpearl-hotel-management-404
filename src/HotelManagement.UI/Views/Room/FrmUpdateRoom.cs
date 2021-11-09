using System;
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
        private RoomDetailDTO _roomDetail;
        private Components.Room _room;

        public FrmUpdateRoom(IRoomService roomService, IConfirm confirm)
        {
            InitializeComponent();
            _roomService = roomService;
            _confirm = confirm;
            LoadRoom();
        }

        async void LoadRoom()
        {
            var location = new Point(10, 5);
            const int numberOf = 1100 / 220;
            var count = numberOf;
            var request = await _roomService.Get();
            foreach (var room in request)
            {
                _room = SetAttribute(room);
                _room.Click += OpenEditForm;
                _room.Location = location;
                if (count == 1)
                {
                    location = Location(location, false);
                    count = numberOf;
                }
                else
                {
                    location = Location(location);
                    count--;
                }
                this.PanelContainer.Controls.Add(_room);
            }
        }
        private async void OpenEditForm(object sender, EventArgs e)
        {
            var obj = sender as Components.Room;
            _roomDetail = await _roomService.GetDetail(obj.Id);
            TbxName.Text = obj.RoomNumber;
            if (obj.Status == 0)
                CbxActive.Checked = true;
            if (obj.Status == 1)
                CbxDeactive.Checked = true;
            if (obj.Status == 2)
                CbxToUp.Checked = true;
        }
        new Point Location(Point point, bool wrap = true)
        {
            return wrap
                ? new Point(point.X += 180, point.Y = point.Y)
                : new Point(point.X = 10, point.Y += 80);
        }
        private Components.Room SetAttribute(RoomListDTO source)
        {
            return new Components.Room()
            {
                RoomNumber = source.Name,
                Id = source.Id,
                Status = source.Status,
                Background = source.Status switch
                {
                    0 => Color.Red,
                    1 => Color.Green,
                    2 => Color.Yellow
                },
                BorderSize = 2,
                BorderColor = Color.Green,
                BorderRadius = 5,
                Size = new Size(170, 70)
            };
        }
        private async void BtnSave_Click(object sender, EventArgs e)
        {
            _roomDetail.Name = TbxName.Text;
            if (CbxActive.Checked)
                _roomDetail.Status = 0;
            if (CbxDeactive.Checked)
                _roomDetail.Status = 1;
            if (CbxToUp.Checked)
                _roomDetail.Status = 2;
            if (_confirm.IsConfirm("Bạn chắc chứ?"))
                MessageBox.Show(await _roomService.Update(_roomDetail));
        }

        private void CbxActive_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxActive.Checked)
            {
                CbxDeactive.Checked = false;
                CbxToUp.Checked = false;
            }
        }

        private void CbxDeactive_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxDeactive.Checked)
            {
                CbxActive.Checked = false;
                CbxToUp.Checked = false;
            }
        }

        private void CbxToUp_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxToUp.Checked)
            {
                CbxDeactive.Checked = false;
                CbxActive.Checked = false;
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e) => LoadRoom();
    }
}
