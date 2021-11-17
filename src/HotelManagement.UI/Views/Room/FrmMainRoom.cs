using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs.Room;
using HotelManagement.UI.Components;
using HotelManagement.UI.Views.Receipt;

namespace HotelManagement.UI.Views.Room
{
    public partial class FrmMainRoom : Form
    {
        private IFloorService _floorService;
        private readonly IRoomService _iRoomService;
        private Components.Room _room;
        private const int PanelWidth = 1610;

        public FrmMainRoom(IFloorService floorService, IRoomService iRoomService)
        {
            _floorService = floorService;
            _iRoomService = iRoomService;
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            var demo = Program.Container.GetInstance<FrmCreateRoom>();
            demo.Show();
        }
        private void customButton2_Click(object sender, EventArgs e)
        {
            var demo = Program.Container.GetInstance<FrmUpdateRoom>();
            demo.Show();
        }

        private async Task LoadRoom()
        {
            var roomLocation = new Point(140, 5);
            var floorLocation = new Point(10, 5);
            var numberOf = (PanelWidth - 100) / 250;
            var request = await _floorService.GetAll();
            if (request.Count == 0) return;
            PanelContainer.Controls.Clear();
            foreach (var floor in request)
            {
                var btn = CreateButton(floor.Floor);
                btn.Location = floorLocation;
                roomLocation.Y = floorLocation.Y;
                roomLocation.X = 140;
                this.PanelContainer.Controls.Add(btn);
                var count = numberOf;
                foreach (var room in floor.Rooms)
                {
                    _room = SetAttribute(room);
                    _room.Location = roomLocation;

                    _room.Click += CreateReceiptForm;
                    if (count == 1)
                    {
                        roomLocation = Location(roomLocation, false);
                        count = numberOf;
                        floorLocation.Y += 130;
                    }
                    else
                    {
                        roomLocation = Location(roomLocation);
                        count--;
                    }
                    this.PanelContainer.Controls.Add(_room);
                }
                floorLocation.Y += 130;
            }
        }

        private new Point Location(Point point, bool wrap = true)
        {
            return wrap
                ? new Point(point.X += 230, point.Y = point.Y)
                : new Point(point.X = 140, point.Y += 130);
        }

        private Components.Room SetAttribute(RoomListDTO source)
        {
            var room = new Components.Room
            {
                RoomNumber = source.Name,
                Id = source.Id,
                BorderColor = Color.AliceBlue,
                BorderSize = 2,
                BorderRadius = 5,
                Size = new Size(220, 120),
                Customer = source.Customer
            };
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

        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            _floorService = Program.Container.GetInstance<IFloorService>();
            await LoadRoom();
        }

        private void TbxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            LoadRoomSearch(TbxSearch.Text);
        }

        private async void LoadRoomSearch(string name)
        {
            var roomLocation = new Point(120, 5);
            var numberOf = (PanelWidth - 100) / 240;
            var request = await _iRoomService.Get(name);
            PanelContainer.Controls.Clear();
            var count = numberOf;
            foreach (var room in request)
            {
                _room = SetAttribute(room);
                _room.Location = roomLocation;
                _room.Click += CreateReceiptForm;
                if (count == 1)
                {
                    roomLocation = Location(roomLocation, false);
                    count = numberOf;
                }
                else
                {
                    roomLocation = Location(roomLocation);
                    count--;
                }
                this.PanelContainer.Controls.Add(_room);
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

        private void CreateReceiptForm(object sender, EventArgs e)
        {
            var form = Program.Container.GetInstance<FrmReceipt>();
            if (sender is Components.Room room) form.RoomId = room.Id;
            form.Closed += CloseForm;
            form.ShowDialog();
        }

        private async void CloseForm(object sender, EventArgs e) => await LoadRoom();

        private async void FrmMainRoom_Load(object sender, EventArgs e) => await LoadRoom();
    }
}