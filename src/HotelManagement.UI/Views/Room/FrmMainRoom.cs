using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs.Room;
using HotelManagement.Application.Services;
using HotelManagement.UI.Components;
using HotelManagement.UI.Views.Receipt;

namespace HotelManagement.UI.Views.Room
{
    public partial class FrmMainRoom : Form
    {
        private IFloorService _floorService;
        private readonly IRoomTypeService _roomTypeService;
        private readonly IRoomService _roomService;
        private Components.Room _room;
        private const int PanelWidth = 1610;
        private FrmReceipt _activeForm;
        private string _roomType = "";
        private string _floor = "";
        private bool _firstLoad;

        public FrmMainRoom(IFloorService floorService, IRoomService iRoomService,
            IRoomTypeService roomTypeService)
        {
            InitializeComponent();
            BtnBack.Hide();
            _floorService = floorService;
            _roomService = iRoomService;
            _roomTypeService = roomTypeService;
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
            request = request.Where(x => x.Floor.StartsWith(_floor)).ToList();
            if (request.Count == 0) return;
            PanelContainer.Controls.Clear();
            foreach (var floor in request)
            {
                var btn = CreateButton(Convert.ToInt32(floor.Floor));
                var roomListDtos = floor.Rooms.ToList();
                floor.Rooms = roomListDtos.Where(x => x.Type.StartsWith(_roomType));
                btn.Location = floorLocation;
                roomLocation.Y = floorLocation.Y;
                roomLocation.X = 140;
                this.PanelContainer.Controls.Add(btn);
                var count = numberOf;
                foreach (var room in roomListDtos)
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
            var a = new Thread(() => _floorService = Program.Container.GetInstance<IFloorService>());
            a.Start();
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
                Type = source.Type
            };
            switch (source.Status)
            {
                case 0:
                    room.Background = Color.Red;
                    room.IconStatus = Properties.Resources.user;
                    room.Customer = source.Customer;
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
            //_floorService = Program.Container.GetInstance<IFloorService>();
            await LoadRoom();
        }

        private void TbxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            LoadRoomSearch(TbxSearch.Text);
        }

        private async void LoadRoomSearch(string name)
        {
            var roomLocation = new Point(140, 5);
            var floorLocation = new Point(10, 5);
            var numberOf = (PanelWidth - 100) / 250;
            var requestt = await _roomService.Get(name);
            if (requestt.Count == 0) return;
            PanelContainer.Controls.Clear();
            var count = numberOf;
            foreach (var room in requestt)
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
            _floorService = Program.Container.GetInstance<IFloorService>();
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
            _activeForm = Program.Container.GetInstance<FrmReceipt>();
            if (sender is Components.Room room) _activeForm.RoomId = room.Id;
            _activeForm.Closed += CloseForm;
            OpenForm(_activeForm);
        }

        private async void CloseForm(object sender, EventArgs e) => await LoadRoom();

        private async void FrmMainRoom_Load(object sender, EventArgs e)
        {
            await LoadRoom();
            //_firstLoad = true;
            var roomType = await _roomTypeService.Get();
            var floor = await _floorService.Get();
            floor.Insert(0, new FloorDTO {Floor = "Tầng", Id = -1});
            roomType.Insert(0, new RoomTypeDTO { Name = "Loại phòng", Id = -1});
            CmbRoomType.DataSource = roomType;
            CmbRoomType.DisplayMember = "Name";
            CmbRoomType.ValueMember = "Id";
            CmbFloor.DataSource = floor;
            CmbFloor.DisplayMember = "Floor";
            CmbFloor.ValueMember = "Id";
            if (Session.Role == 1)
            {
                this.customButton1.Visible = false;
                this.customButton2.Visible = false;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _activeForm.Close();
            BtnBack.Hide();
        }
        private void OpenForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(form);
            PanelContainer.Tag = form;
            form.BringToFront();
            form.Show();
            BtnBack.Show();
        }

        private async void CmbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            _floor = (CmbFloor.SelectedItem as FloorDTO)?.Floor;
            if (_floor is "Tầng")
            {
                _floor = string.Empty;
                return;
            }
            await LoadRoom();
        }

        private async void CmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _roomType = (CmbRoomType.SelectedItem as RoomTypeDTO)?.Name;
            if(_roomType is "Loại phòng")
            {
                _roomType = string.Empty;
                return;
            }
            await LoadRoom();
        }
    }
}