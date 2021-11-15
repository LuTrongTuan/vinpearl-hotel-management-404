using System;
using System.Drawing;
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
        private Components.Room _room;
        private int _width;

        public FrmMainRoom(IFloorService floorService)
        {
            _floorService = floorService;
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
            var roomLocation = new Point(120, 5);
            var floorLocation = new Point(10, 5);
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
                floorLocation = new Point(10, 90);

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
                        floorLocation.Y += 80;
                    }
                    else
                    {
                        roomLocation = Location(roomLocation);
                        count--;
                    }
                    this.PanelContainer.Controls.Add(_room);
                }
            }

            _floorService = Program.Container.GetInstance<IFloorService>();
        }

        private new Point Location(Point point, bool wrap = true)
        {
            return wrap
                ? new Point(point.X += 180, point.Y = point.Y)
                : new Point(point.X = 120, point.Y += 80);
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
                Size = new Size(170, 70)
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

        private async void BtnRefresh_Click(object sender, EventArgs e) => await LoadRoom();

        private void TbxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            //LoadRoom(TbxSearch.Text);
            //issue, fix request
        }

        private async void PanelContainer_ClientSizeChanged(object sender, EventArgs e)
        {
            _width = this.PanelContainer.ClientSize.Width;
            await LoadRoom();
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
            var room = sender as Components.Room;
            form.RoomId = room.Id;
            form.Closed += CloseForm;
            form.ShowDialog();
        }

        private async void CloseForm(object sender, EventArgs e) => await LoadRoom();
    }
}
