using System.Windows.Forms;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs;
using HotelManagement.Application.DTOs.Room;

namespace HotelManagement.UI.Views.Receipt
{
    public partial class FrmReceipt : Form
    {
        private readonly IIdentificationService _identificationService;
        private readonly IService _service;
        private readonly IRoomTypeService _roomTypeService;
        private readonly IRoomService _roomService;
        private int _roomId;
        private ReceiptDTO _receipt;
        private RoomDetailDTO _room;

        // properties
        public int RoomId
        {
            get => _roomId;
            set
            {
                _roomId = value;
                Binding();
            }
        }

        public FrmReceipt(IIdentificationService identificationService, IService service,
            IRoomTypeService roomTypeService, IRoomService roomService)
        {
            _identificationService = identificationService;
            _service = service;
            _roomTypeService = roomTypeService;
            _roomService = roomService;
            InitializeComponent();
        }

        private async void LoadIdentification()
        {
            var query = await _identificationService.Get();
            CmbIdentification.DisplayMember = "Name";
            CmbIdentification.ValueMember = "Id";
            CmbIdentification.DataSource = query;
        }

        private async void LoadService()
        {
            var query = await _service.Get();
            CmbService.DisplayMember = "Name";
            CmbService.ValueMember = "Id";
            CmbService.DataSource = query;
        }

        private async void GetRoomType()
        {
            //var query = await _roomTypeService.GetRoomTypeName();
            //LblRoomType.Text = query;
        }

        private async void Binding()
        {
            //_room = await _roomService.GetDetail(_roomId);
            //GetRoomType();
        }
    }
}
