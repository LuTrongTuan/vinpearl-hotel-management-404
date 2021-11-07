using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs.Room;
using HotelManagement.UI.Contracts;

namespace HotelManagement.UI.Views.Room
{
    public partial class FrmCreateRoom : Form
    {
        private readonly IRoomTypeService _roomTypeService;
        private readonly IConfirm _confirm;
        private readonly IRoomService _roomService;
        private readonly IList<CreateRoomDTO> _queue = new List<CreateRoomDTO>();
        public FrmCreateRoom(IRoomTypeService roomTypeService, IConfirm confirm,
            IRoomService roomService)
        {
            InitializeComponent();
            _roomTypeService = roomTypeService;
            _confirm = confirm;
            _roomService = roomService;
            LoadRoomType();
        }

        void RoomInQueue()
        {
            GridView.ColumnCount = 3;
            GridView.Columns[0].HeaderText = "Tầng";
            GridView.Columns[1].HeaderText = "Loại phòng";
            GridView.Columns[2].HeaderText = "Số lượng";
            GridView.Rows.Clear();

            foreach (var room in _queue)
                GridView.Rows.Add(room.Floor, room.RoomType, room.Quantity);
        }

        async void LoadRoomType()
        {
            var result = await _roomTypeService.Get();
            CmbRoomType.DataSource = result.ToList();

            CmbRoomType.DisplayMember = "Name";
            CmbRoomType.ValueMember = "Id";
        }

        private async void BtnAddRoomType_Click(object sender, EventArgs e)
        {
            if (TbxRoomType.Text == string.Empty)
            {
                TbxRoomType.IsError = true;
                TbxRoomType.ErrorMessage = "Không được để trống";
            }
            else
            {
                var roomType = new RoomTypeDTO {Name = TbxRoomType.Text};
                if (_confirm.IsConfirm("Bạn chắc chắn muốn thêm"))
                {
                    await _roomTypeService.Add(roomType);
                    _queue.Clear();
                    RoomInQueue();
                    LoadRoomType();
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (_queue.Count == 0)
            {
                Close();
                return;
            }
            if(_confirm.IsConfirm("Mọi dữ liệu sẽ không được lưu lại? Bạn chắc chứ"))
                Close();
        }

        private void BtnAddToQueue_Click(object sender, EventArgs e)
        {
            var createRoom = new CreateRoomDTO
            {
                Quantity = Convert.ToInt32(TbxQuantity.Text),
                Floor = Convert.ToInt32(TbxFloor.Text),
                RoomType = Convert.ToInt32(CmbRoomType.SelectedValue)
            };

            _queue.Add(createRoom);
            RoomInQueue();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (_confirm.IsConfirm("Bạn chắc chứ?"))
                MessageBox.Show(await _roomService.AddRoom(_queue));
        }
    }
}
