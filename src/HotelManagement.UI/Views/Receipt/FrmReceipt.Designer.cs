
using System.Windows.Forms;

namespace HotelManagement.UI.Views.Receipt
{
    partial class FrmReceipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CheckOutTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckInTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_giayTo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbService = new System.Windows.Forms.ComboBox();
            this.ServiceQuantity = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_roomPrice = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txb_hinhthuc = new System.Windows.Forms.TextBox();
            this.CbxByNight = new System.Windows.Forms.CheckBox();
            this.CbxByDay = new System.Windows.Forms.CheckBox();
            this.CbxByHour = new System.Windows.Forms.CheckBox();
            this.txb_note = new System.Windows.Forms.TextBox();
            this.TbxDeposit = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.PeopleAmount = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.LblRoomType = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbx_roomtype = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbxPayment = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Price = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txb_numberPhone = new System.Windows.Forms.TextBox();
            this.RbtFemale = new System.Windows.Forms.RadioButton();
            this.RbtMale = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RoomName = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ServiceGridView = new System.Windows.Forms.DataGridView();
            this.BtnConfirm = new HotelManagement.UI.Components.CustomButton();
            this.BtnCancle = new HotelManagement.UI.Components.CustomButton();
            this.BtnAddService = new HotelManagement.UI.Components.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleAmount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiền trả trước";
            // 
            // CheckOutTime
            // 
            this.CheckOutTime.CustomFormat = "MMMMdd, yyyy  |  hh:mm";
            this.CheckOutTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CheckOutTime.Location = new System.Drawing.Point(166, 203);
            this.CheckOutTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckOutTime.Name = "CheckOutTime";
            this.CheckOutTime.Size = new System.Drawing.Size(300, 27);
            this.CheckOutTime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày ra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(18, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày vào";
            // 
            // CheckInTime
            // 
            this.CheckInTime.CustomFormat = "MMMMdd, yyyy  |  hh:mm";
            this.CheckInTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckInTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CheckInTime.Location = new System.Drawing.Point(166, 159);
            this.CheckInTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckInTime.Name = "CheckInTime";
            this.CheckInTime.Size = new System.Drawing.Size(300, 27);
            this.CheckInTime.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(18, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Giấy tờ";
            // 
            // cbx_giayTo
            // 
            this.cbx_giayTo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbx_giayTo.ForeColor = System.Drawing.Color.Gray;
            this.cbx_giayTo.FormattingEnabled = true;
            this.cbx_giayTo.Location = new System.Drawing.Point(145, 85);
            this.cbx_giayTo.Name = "cbx_giayTo";
            this.cbx_giayTo.Size = new System.Drawing.Size(263, 28);
            this.cbx_giayTo.TabIndex = 8;
            this.cbx_giayTo.Text = "Giấy tờ";
            this.cbx_giayTo.Enter += new System.EventHandler(this.cbx_giayTo_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Dịch vụ";
            // 
            // CmbService
            // 
            this.CmbService.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CmbService.ForeColor = System.Drawing.Color.Gray;
            this.CmbService.FormattingEnabled = true;
            this.CmbService.Location = new System.Drawing.Point(145, 36);
            this.CmbService.Name = "CmbService";
            this.CmbService.Size = new System.Drawing.Size(275, 28);
            this.CmbService.TabIndex = 8;
            this.CmbService.Text = "Tên dịch vụ";
            this.CmbService.SelectedIndexChanged += new System.EventHandler(this.CmbService_SelectedIndexChanged);
            this.CmbService.Enter += new System.EventHandler(this.CmbService_Enter);
            // 
            // ServiceQuantity
            // 
            this.ServiceQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ServiceQuantity.Location = new System.Drawing.Point(166, 93);
            this.ServiceQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ServiceQuantity.Name = "ServiceQuantity";
            this.ServiceQuantity.Size = new System.Drawing.Size(117, 27);
            this.ServiceQuantity.TabIndex = 10;
            this.ServiceQuantity.ValueChanged += new System.EventHandler(this.ServiceQuantity_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Số lượng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_roomPrice);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txb_hinhthuc);
            this.groupBox1.Controls.Add(this.CbxByNight);
            this.groupBox1.Controls.Add(this.CbxByDay);
            this.groupBox1.Controls.Add(this.CbxByHour);
            this.groupBox1.Controls.Add(this.txb_note);
            this.groupBox1.Controls.Add(this.TbxDeposit);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.PeopleAmount);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.LblRoomType);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CheckOutTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cbx_roomtype);
            this.groupBox1.Controls.Add(this.cbx_giayTo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.CheckInTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 477);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // lbl_roomPrice
            // 
            this.lbl_roomPrice.AutoSize = true;
            this.lbl_roomPrice.Location = new System.Drawing.Point(145, 387);
            this.lbl_roomPrice.Name = "lbl_roomPrice";
            this.lbl_roomPrice.Size = new System.Drawing.Size(83, 20);
            this.lbl_roomPrice.TabIndex = 30;
            this.lbl_roomPrice.Text = "RoomPrice";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.ForeColor = System.Drawing.Color.Gray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 425);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 28);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.Text = "Thêm phòng";
            // 
            // txb_hinhthuc
            // 
            this.txb_hinhthuc.ForeColor = System.Drawing.Color.Gray;
            this.txb_hinhthuc.Location = new System.Drawing.Point(145, 219);
            this.txb_hinhthuc.Name = "txb_hinhthuc";
            this.txb_hinhthuc.Size = new System.Drawing.Size(263, 27);
            this.txb_hinhthuc.TabIndex = 28;
            this.txb_hinhthuc.Text = "Hình thức thanh toán";
            this.txb_hinhthuc.Enter += new System.EventHandler(this.txb_hinhthuc_Enter);
            // 
            // CbxByNight
            // 
            this.CbxByNight.AutoSize = true;
            this.CbxByNight.Location = new System.Drawing.Point(419, 471);
            this.CbxByNight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbxByNight.Name = "CbxByNight";
            this.CbxByNight.Size = new System.Drawing.Size(99, 24);
            this.CbxByNight.TabIndex = 26;
            this.CbxByNight.Text = "Theo đêm";
            this.CbxByNight.UseVisualStyleBackColor = true;
            this.CbxByNight.CheckedChanged += new System.EventHandler(this.CbxByNight_CheckedChanged);
            // 
            // CbxByDay
            // 
            this.CbxByDay.AutoSize = true;
            this.CbxByDay.Location = new System.Drawing.Point(295, 469);
            this.CbxByDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbxByDay.Name = "CbxByDay";
            this.CbxByDay.Size = new System.Drawing.Size(103, 24);
            this.CbxByDay.TabIndex = 26;
            this.CbxByDay.Text = "Theo ngày";
            this.CbxByDay.UseVisualStyleBackColor = true;
            this.CbxByDay.CheckedChanged += new System.EventHandler(this.CbxByDay_CheckedChanged);
            // 
            // CbxByHour
            // 
            this.CbxByHour.AutoSize = true;
            this.CbxByHour.Location = new System.Drawing.Point(166, 471);
            this.CbxByHour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbxByHour.Name = "CbxByHour";
            this.CbxByHour.Size = new System.Drawing.Size(91, 24);
            this.CbxByHour.TabIndex = 26;
            this.CbxByHour.Text = "Theo giờ";
            this.CbxByHour.UseVisualStyleBackColor = true;
            this.CbxByHour.CheckedChanged += new System.EventHandler(this.CbxByHour_CheckedChanged);
            // 
            // txb_note
            // 
            this.txb_note.ForeColor = System.Drawing.Color.Gray;
            this.txb_note.Location = new System.Drawing.Point(145, 251);
            this.txb_note.Multiline = true;
            this.txb_note.Name = "txb_note";
            this.txb_note.Size = new System.Drawing.Size(263, 59);
            this.txb_note.TabIndex = 25;
            this.txb_note.Text = "Ghi chú";
            this.txb_note.Enter += new System.EventHandler(this.txb_note_Enter);
            // 
            // TbxDeposit
            // 
            this.TbxDeposit.ForeColor = System.Drawing.Color.Gray;
            this.TbxDeposit.Location = new System.Drawing.Point(166, 247);
            this.TbxDeposit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbxDeposit.Name = "TbxDeposit";
            this.TbxDeposit.Size = new System.Drawing.Size(300, 27);
            this.TbxDeposit.TabIndex = 25;
            this.TbxDeposit.Text = "Tiền trả trước";
            this.TbxDeposit.Enter += new System.EventHandler(this.txb_payments_Enter);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(18, 323);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 20);
            this.label19.TabIndex = 23;
            this.label19.Text = "Số người";
            // 
            // PeopleAmount
            // 
            this.PeopleAmount.Location = new System.Drawing.Point(166, 421);
            this.PeopleAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PeopleAmount.Name = "PeopleAmount";
            this.PeopleAmount.Size = new System.Drawing.Size(120, 27);
            this.PeopleAmount.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(18, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Trạng thái";
            // 
            // LblRoomType
            // 
            this.LblRoomType.AutoSize = true;
            this.LblRoomType.Location = new System.Drawing.Point(145, 43);
            this.LblRoomType.Name = "LblRoomType";
            this.LblRoomType.Size = new System.Drawing.Size(0, 20);
            this.LblRoomType.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(21, 253);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Ghi chú";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(21, 428);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Thêm phòng";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(18, 387);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "Giá phòng";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(18, 221);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 20);
            this.label20.TabIndex = 0;
            this.label20.Text = "Hình thức";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(18, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Loại phòng:";
            // 
            // cbx_roomtype
            // 
            this.cbx_roomtype.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbx_roomtype.ForeColor = System.Drawing.Color.Gray;
            this.cbx_roomtype.FormattingEnabled = true;
            this.cbx_roomtype.Location = new System.Drawing.Point(145, 45);
            this.cbx_roomtype.Name = "cbx_roomtype";
            this.cbx_roomtype.Size = new System.Drawing.Size(263, 28);
            this.cbx_roomtype.TabIndex = 8;
            this.cbx_roomtype.Text = "Loại phòng";
            this.cbx_roomtype.Enter += new System.EventHandler(this.cbx_roomtype_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Thành tiền";
            // 
            // TbxPayment
            // 
            this.TbxPayment.ForeColor = System.Drawing.Color.Gray;
            this.TbxPayment.Location = new System.Drawing.Point(137, 991);
            this.TbxPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbxPayment.Name = "TbxPayment";
            this.TbxPayment.Size = new System.Drawing.Size(210, 27);
            this.TbxPayment.TabIndex = 25;
            this.TbxPayment.Text = "Thành tiền";
            this.TbxPayment.Enter += new System.EventHandler(this.txb_deposits_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Price);
            this.groupBox2.Controls.Add(this.CmbService);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ServiceQuantity);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(6, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(618, 289);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm dịch vụ";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(384, 103);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(93, 20);
            this.Price.TabIndex = 11;
            this.Price.Text = "ServicePrice";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(255, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "Đơn giá";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txb_numberPhone);
            this.groupBox3.Controls.Add(this.RbtFemale);
            this.groupBox3.Controls.Add(this.RbtMale);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(600, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(559, 431);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khách hàng";
            // 
            // txb_numberPhone
            // 
            this.txb_numberPhone.ForeColor = System.Drawing.Color.Gray;
            this.txb_numberPhone.Location = new System.Drawing.Point(155, 112);
            this.txb_numberPhone.Name = "txb_numberPhone";
            this.txb_numberPhone.Size = new System.Drawing.Size(260, 27);
            this.txb_numberPhone.TabIndex = 25;
            this.txb_numberPhone.Text = "Số điện thoại";
            this.txb_numberPhone.Enter += new System.EventHandler(this.txb_numberPhone_Enter);
            // 
            // RbtFemale
            // 
            this.RbtFemale.AutoSize = true;
            this.RbtFemale.Location = new System.Drawing.Point(298, 201);
            this.RbtFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbtFemale.Name = "RbtFemale";
            this.RbtFemale.Size = new System.Drawing.Size(52, 24);
            this.RbtFemale.TabIndex = 20;
            this.RbtFemale.TabStop = true;
            this.RbtFemale.Text = "Nữ";
            this.RbtFemale.UseVisualStyleBackColor = true;
            // 
            // RbtMale
            // 
            this.RbtMale.AutoSize = true;
            this.RbtMale.Location = new System.Drawing.Point(177, 201);
            this.RbtMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbtMale.Name = "RbtMale";
            this.RbtMale.Size = new System.Drawing.Size(64, 24);
            this.RbtMale.TabIndex = 20;
            this.RbtMale.TabStop = true;
            this.RbtMale.Text = "Nam";
            this.RbtMale.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Số";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Giới tính";
            // 
            // RoomName
            // 
            this.RoomName.AutoSize = true;
            this.RoomName.Dock = System.Windows.Forms.DockStyle.Top;
            this.RoomName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RoomName.Location = new System.Drawing.Point(0, 0);
            this.RoomName.Name = "RoomName";
            this.RoomName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 13);
            this.RoomName.Size = new System.Drawing.Size(77, 41);
            this.RoomName.TabIndex = 4;
            this.RoomName.Text = "Phòng:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ServiceGridView);
            this.groupBox5.Location = new System.Drawing.Point(0, 696);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1173, 197);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách hóa đơn";
            // 
            // ServiceGridView
            // 
            this.ServiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ServiceGridView.Location = new System.Drawing.Point(3, -31);
            this.ServiceGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ServiceGridView.Name = "ServiceGridView";
            this.ServiceGridView.RowHeadersWidth = 51;
            this.ServiceGridView.RowTemplate.Height = 29;
            this.ServiceGridView.Size = new System.Drawing.Size(1167, 225);
            this.ServiceGridView.TabIndex = 0;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnConfirm.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnConfirm.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnConfirm.BorderRadius = 8;
            this.BtnConfirm.BorderSize = 2;
            this.BtnConfirm.FlatAppearance.BorderSize = 0;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnConfirm.Location = new System.Drawing.Point(1113, 979);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(198, 56);
            this.BtnConfirm.TabIndex = 26;
            this.BtnConfirm.TextColor = System.Drawing.SystemColors.ControlText;
            this.BtnConfirm.UseVisualStyleBackColor = false;
            // 
            // BtnCancle
            // 
            this.BtnCancle.BackColor = System.Drawing.Color.Red;
            this.BtnCancle.BackgroundColor = System.Drawing.Color.Red;
            this.BtnCancle.BorderColor = System.Drawing.Color.Red;
            this.BtnCancle.BorderRadius = 8;
            this.BtnCancle.BorderSize = 2;
            this.BtnCancle.FlatAppearance.BorderSize = 0;
            this.BtnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancle.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancle.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCancle.Location = new System.Drawing.Point(906, 979);
            this.BtnCancle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancle.Name = "BtnCancle";
            this.BtnCancle.Size = new System.Drawing.Size(170, 56);
            this.BtnCancle.TabIndex = 27;
            this.BtnCancle.Text = "Hủy";
            this.BtnCancle.TextColor = System.Drawing.Color.Transparent;
            this.BtnCancle.UseVisualStyleBackColor = false;
            this.BtnCancle.Click += new System.EventHandler(this.BtnCancle_Click);
            // 
            // BtnAddService
            // 
            this.BtnAddService.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnAddService.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BtnAddService.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.BtnAddService.BorderRadius = 8;
            this.BtnAddService.BorderSize = 1;
            this.BtnAddService.FlatAppearance.BorderSize = 0;
            this.BtnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddService.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAddService.ForeColor = System.Drawing.Color.White;
            this.BtnAddService.Location = new System.Drawing.Point(1077, 565);
            this.BtnAddService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAddService.Name = "BtnAddService";
            this.BtnAddService.Size = new System.Drawing.Size(178, 67);
            this.BtnAddService.TabIndex = 28;
            this.BtnAddService.Text = "Thêm dịch vụ";
            this.BtnAddService.TextColor = System.Drawing.Color.White;
            this.BtnAddService.UseVisualStyleBackColor = false;
            this.BtnAddService.Click += new System.EventHandler(this.BtnAddService_Click);
            // 
            // FrmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 1036);
            this.Controls.Add(this.BtnAddService);
            this.Controls.Add(this.BtnCancle);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.TbxPayment);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RoomName);
            this.Controls.Add(this.label7);
            this.Name = "FrmReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn khách hàng";
            this.Load += new System.EventHandler(this.FrmReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleAmount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker CheckOutTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker CheckInTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbx_giayTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbService;
        private System.Windows.Forms.NumericUpDown ServiceQuantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label RoomName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LblRoomType;
        private System.Windows.Forms.ComboBox cbx_roomtype;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton RbtMale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton RbtFemale;
        private System.Windows.Forms.TextBox TbxPayment;
        private System.Windows.Forms.TextBox txb_note;
        private System.Windows.Forms.TextBox TbxDeposit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txb_numberPhone;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_number;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView ServiceGridView;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown PeopleAmount;
        private System.Windows.Forms.CheckBox CbxByNight;
        private System.Windows.Forms.CheckBox CbxByDay;
        private System.Windows.Forms.CheckBox CbxByHour;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txb_hinhthuc;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbl_roomPrice;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label Price;
        private Components.CustomButton BtnConfirm;
        private Components.CustomButton BtnCancle;
        private Components.CustomButton BtnAddService;
    }
}