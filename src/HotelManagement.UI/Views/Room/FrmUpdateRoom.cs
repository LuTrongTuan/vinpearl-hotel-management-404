using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs.Room;
using HotelManagement.UI.Components;
using HotelManagement.UI.Contracts;


namespace HotelManagement.UI.Views.Room
{
    public partial class FrmUpdateRoom : Form
    {
        private IFloorService _floorService;
        private readonly IRoomService _roomService;
        private IRoomTypeService _roomType;
        private readonly IConfirm _confirm;
        private RoomDetailDTO _roomDetail;
        private Components.Room _room;
        private const int PanelWidth = 1610;
        private Regex number;
        
        public FrmUpdateRoom(IRoomService roomService, IConfirm confirm, IFloorService iFloorService,
            IRoomTypeService roomType)
        {
            InitializeComponent();
            _floorService = iFloorService;
            _roomService = roomService;
            _roomType = roomType;
            _confirm = confirm;
            LoadRoom();
            LoadRoomType();
            number = new Regex(@"^[0-9]*$");
        }

        async void LoadRoomType()
        {
            var load = await _roomType.Get();
            CbxNameType.DataSource = load.ToList();
            CbxNameType.DisplayMember = "Name";
            CbxNameType.ValueMember = "Id";
            CbxNameType.Enabled = false;
        }

        async void LoadRoom()
        {
            var roomLocation = new Point(140, 5);
            var floorLocation = new Point(10, 5);
            var numberOf = (PanelWidth - 100) / 250;
            var request = await _floorService.GetAll();
            if (request.Count == 0) return;
            panel1.Controls.Clear();
            foreach (var floor in request)
            {
                var btn = CreateButton(Convert.ToInt32(floor.Floor));
                btn.Location = floorLocation;
                roomLocation.Y = floorLocation.Y;
                roomLocation.X = 140;
                this.panel1.Controls.Add(btn);
                var count = numberOf;
                foreach (var room in floor.Rooms)
                {
                    _room = SetAttribute(room);
                    _room.Location = roomLocation;
                    _room.Click += OpenEdit;
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
                    this.panel1.Controls.Add(_room);
                }
                floorLocation.Y += 130;
            }
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

        private async void OpenEdit(object sender, EventArgs e)
        {
            var obj = sender as Components.Room;
            _roomDetail = await _roomService.GetDetail(obj.Id);

            CbxNameType.Text = _roomDetail.RoomType.Name;
            TbxDay.Text = Convert.ToString(_roomDetail.RoomType.ByDay);
            TbxHour.Text = Convert.ToString(_roomDetail.RoomType.ByHour);

            TbxName.Text = _roomDetail.Name;
            if (_roomDetail.Status == 0) CbxActive.Checked = true;
            if (_roomDetail.Status == 2) CbxDeactive.Checked = true;
        }

        new Point Location(Point point, bool wrap = true)
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
                Size = new Size(220, 120)
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

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var roomTypeDTO = _roomDetail.RoomType;
            if (TbxName.Text == String.Empty || TbxDay.Text == String.Empty || TbxHour.Text == String.Empty)
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            if (!number.IsMatch(TbxDay.Text))
            {
                TbxDay.Text = "";
                MessageBox.Show("Giá Ngày Không Được Nhập Chữ", "Thông Báo");
                return;
            }
            roomTypeDTO.ByDay = Convert.ToDouble(TbxDay.Text);
            if (!number.IsMatch(TbxHour.Text))
            {
                TbxHour.Text = "";
                MessageBox.Show("Giá Giờ Không Được Nhập Chữ", "Thông Báo");
                return;
            }
            roomTypeDTO.ByHour = Convert.ToDouble(TbxHour.Text);

            var type = await _roomService.Get();
            if (type.Any(c => c.Name == TbxName.Text))
            {
                MessageBox.Show("Tên phòng đã tồn tại");
                return;
            }
            _roomDetail.Name = TbxName.Text;
            if (CbxActive.Checked) _roomDetail.Status = 0;
            if (CbxDeactive.Checked) _roomDetail.Status = 2;
            if (_confirm.IsConfirm("Bạn chắc chứ?")) 
                MessageBox.Show(await _roomService.Update(_roomDetail));
            await _roomType.Update(roomTypeDTO);
        }

        private void CbxActive_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxActive.Checked)
            {
                CbxDeactive.Checked = false;
            }
        }

        private void CbxDeactive_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxDeactive.Checked)
            {
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