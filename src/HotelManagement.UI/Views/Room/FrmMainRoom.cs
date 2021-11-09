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
        private void customButton2_Click(object sender, EventArgs e)
        {
            var demo = Program.Container.GetInstance<FrmUpdateRoom>();
            demo.Show();
        }
        async void LoadRoom(string name = "")
        {
            var location = new Point(10, 5);
            const int numberOf = 1100 / 220;
            var count = numberOf;
            var request = await _roomService.Get(name);
            if (request.Count != 0)
            {
                PanelContainer.Controls.Clear();
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
                    0 => Color.Red,
                    1 => Color.Green,
                    _ => Color.Yellow
                },
                BorderSize = 2,
                BorderColor = Color.Green,
                BorderRadius = 5,
                Size = new Size(170, 70)
            };
        }

        private void BtnRefresh_Click(object sender, EventArgs e) => LoadRoom();

        private void TbxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            LoadRoom(TbxSearch.Text);
        }
    }
}
