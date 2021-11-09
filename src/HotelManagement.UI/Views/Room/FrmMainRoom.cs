using System;
using System.Drawing;
using System.Windows.Forms;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs.Room;

namespace HotelManagement.UI.Views.Room
{
    public partial class FrmMainRoom : Form
    {
        private readonly IRoomService _roomService;
        private Components.Room _room;

        public FrmMainRoom(IRoomService roomService)
        {
            _roomService = roomService;
            InitializeComponent();
            LoadRoom();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            var demo = Program.Container.GetInstance<FrmCreateRoom>();
            demo.Show();
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
                Background = source.Status switch
                {
                    0 => Color.Green,
                    1 => Color.Yellow,
                    _ => Color.Red
                },
                BorderSize = 2,
                BorderColor = Color.Green,
                BorderRadius = 5,
                Size = new Size(170, 70)
            };
        }

        private void BtnRefresh_Click(object sender, EventArgs e) => LoadRoom();

        async void LoadRoomSearch(string name)
        {
            var location = new Point(10, 5);
            const int numberOf = 1100 / 220;
            var count = numberOf;
            var request = await _roomService.GetSearch(name);
            if (request.Count != 0)
            {
                PanelContainer.Controls.Clear();
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
        }
        private void TbxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            LoadRoomSearch(TbxSearch.Text);
        }

        private void OpenEditForm(object sender, EventArgs e)
        {
            var edit = Program.Container.GetInstance<FrmUpdateRoom>();
            var d = sender as Components.Room;
            edit.Id = d.Id;
            edit.Show();
        }
    }
}
