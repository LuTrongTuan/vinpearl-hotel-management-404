using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs.Room;
using HotelManagement.UI.Components;
using HotelManagement.UI.Contracts;
using HotelManagement.UI.Views.Receipt;


namespace HotelManagement.UI.Views.Room
{
    public partial class FrmUpdateRoom : Form
    {
        private readonly IFloorService _floorService;
        private readonly IRoomService _roomService;
        private IRoomTypeService _iRoomTypeService;
        private readonly IConfirm _confirm;
        private RoomDetailDTO _roomDetail;
        private RoomTypeDTO _roomTypeDTO;
        private Components.Room _room;
        private int _width;

        public FrmUpdateRoom(IRoomService roomService, IConfirm confirm, IFloorService iFloorService,
            IRoomTypeService roomTypeService)
        {
            InitializeComponent();
            _floorService = iFloorService;
            _roomService = roomService;
            _iRoomTypeService = roomTypeService;
            _confirm = confirm;
            LoadRoom();
        }

        async void LoadRoom()
        {
            var roomLocation = new Point(120, 5);
            var floorLocation = new Point(5, 5);
            var numberOf = ((_width - 100) / 220) + 1;
            var request = await _floorService.GetAll();
            if (request.Count == 0) return;
            PanelContainer.Controls.Clear();
            foreach (var floor in request)
            {
                var btn = CreateButton(floor.Floor);
                btn.Location = floorLocation;
                roomLocation.Y = floorLocation.Y;
                roomLocation.X = 120;
                floorLocation = new Point(10, 50);
                this.panel1.Controls.Add(btn);
                var count = numberOf;
                foreach (var room in floor.Rooms)
                {
                    _room = SetAttribute(room);
                    _room.Click += OpenEdit;
                    _room.Location = roomLocation;
                    if (count == 1)
                    {
                        roomLocation = Location(roomLocation, false);
                        count = numberOf;
                        floorLocation.Y += 80;
                    }
                    else
                    {
                        roomLocation = Location(roomLocation);
                        count--;
                    }
                    this.panel1.Controls.Add(_room);
                }
            }
        }

        private CustomButton CreateButton(int floorNumber)
        {
            return new CustomButton
            {
                BorderRadius = 3,
                BackgroundColor = Color.White,
                BorderSize = 2,
                BorderColor = Color.Aqua,
                Text = "Tầng " + floorNumber.ToString(),
                Size = new Size(100, 70),
                Enabled = false
            };
        }

        private async void OpenEdit(object sender, EventArgs e)
        {
            var obj = sender as Components.Room;
            _roomDetail = await _roomService.GetDetail(obj.Id);
            TbxName.Text = _roomDetail.Name;
            if (_roomDetail.Status == 0) CbxActive.Checked = true;
            if (_roomDetail.Status == 1) CbxToUp.Checked = true;
            if (_roomDetail.Status == 2) CbxDeactive.Checked = true;
        }

        new Point Location(Point point, bool wrap = true)
        {
            return wrap
                ? new Point(point.X += 180, point.Y = point.Y)
                : new Point(point.X = 10, point.Y += 80);
        }

        private Components.Room SetAttribute(RoomListDTO source)
        {
            var room = new Components.Room();
            room.RoomNumber = source.Name;
            room.Id = source.Id;
            room.BorderColor = Color.AliceBlue;
            room.BorderSize = 2;
            room.BorderRadius = 5;
            room.Size = new Size(170, 70);
            switch (source.Status)
            {
                case 0:
                    room.Background = Color.Red;
                    room.IconStatus = Properties.Resources.user;
                    break;
                case 1:
                    room.Background = Color.Yellow;
                    room.IconStatus = Properties.Resources.broom;
                    break;
                default:
                    room.Background = Color.Green;
                    room.IconStatus = Properties.Resources.bed;
                    break;
            }
            return room;
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            _roomDetail.Name = TbxName.Text;
            if (CbxActive.Checked)
                _roomDetail.Status = 0;
            if (CbxToUp.Checked)
                _roomDetail.Status = 1;
            if (CbxDeactive.Checked)
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

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = Program.Container.GetInstance<FrmUpdateRoom>();
            form.ShowDialog();
        }
    }
}
