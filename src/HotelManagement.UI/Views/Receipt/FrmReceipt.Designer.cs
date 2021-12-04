
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Dtpicker_checkOut = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Dtpicker_checkIn = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_giayTo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbService = new System.Windows.Forms.ComboBox();
            this.ServiceQuantity = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblType = new System.Windows.Forms.Label();
            this.LblPeople = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Dtpicker_out = new System.Windows.Forms.DateTimePicker();
            this.Dtpicker_in = new System.Windows.Forms.DateTimePicker();
            this.TbxNote = new HotelManagement.UI.Components.TextBox();
            this.TbxDeposit = new HotelManagement.UI.Components.TextBox();
            this.lbl_roomPrice = new System.Windows.Forms.Label();
            this.CbxByDay = new System.Windows.Forms.CheckBox();
            this.CbxByHour = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblRoomType = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnAddService = new HotelManagement.UI.Components.CustomButton();
            this.Price = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_AddCustomer = new HotelManagement.UI.Components.CustomButton();
            this.TbxPhoneNumber = new HotelManagement.UI.Components.TextBox();
            this.TbxCustomerName = new HotelManagement.UI.Components.TextBox();
            this.TbxIdentityNumber = new HotelManagement.UI.Components.TextBox();
            this.RbtFemale = new System.Windows.Forms.RadioButton();
            this.RbtMale = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RoomName = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ServiceGridView = new System.Windows.Forms.DataGridView();
            this.GridViewCustomer = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnConfirm = new HotelManagement.UI.Components.CustomButton();
            this.BtnCancle = new HotelManagement.UI.Components.CustomButton();
            this.LblPayment = new System.Windows.Forms.Label();
            this.BtnUpdate = new HotelManagement.UI.Components.CustomButton();
            this.ptb_quet = new System.Windows.Forms.PictureBox();
            this.cbo_webcam = new System.Windows.Forms.ComboBox();
            this.txb_QR = new System.Windows.Forms.TextBox();
            this.btn_Start = new HotelManagement.UI.Components.CustomButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_quet)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiền trả trước";
            // 
            // Dtpicker_checkOut
            // 
            this.Dtpicker_checkOut.CustomFormat = "";
            this.Dtpicker_checkOut.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dtpicker_checkOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtpicker_checkOut.Location = new System.Drawing.Point(145, 127);
            this.Dtpicker_checkOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dtpicker_checkOut.Name = "Dtpicker_checkOut";
            this.Dtpicker_checkOut.Size = new System.Drawing.Size(160, 27);
            this.Dtpicker_checkOut.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày ra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày vào";
            // 
            // Dtpicker_checkIn
            // 
            this.Dtpicker_checkIn.CustomFormat = "";
            this.Dtpicker_checkIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dtpicker_checkIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtpicker_checkIn.Location = new System.Drawing.Point(145, 84);
            this.Dtpicker_checkIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dtpicker_checkIn.Name = "Dtpicker_checkIn";
            this.Dtpicker_checkIn.Size = new System.Drawing.Size(160, 27);
            this.Dtpicker_checkIn.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Giấy tờ";
            // 
            // cbx_giayTo
            // 
            this.cbx_giayTo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbx_giayTo.ForeColor = System.Drawing.Color.Black;
            this.cbx_giayTo.FormattingEnabled = true;
            this.cbx_giayTo.Location = new System.Drawing.Point(151, 195);
            this.cbx_giayTo.Name = "cbx_giayTo";
            this.cbx_giayTo.Size = new System.Drawing.Size(274, 28);
            this.cbx_giayTo.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Dịch vụ";
            // 
            // CmbService
            // 
            this.CmbService.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CmbService.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CmbService.FormattingEnabled = true;
            this.CmbService.Location = new System.Drawing.Point(145, 36);
            this.CmbService.Name = "CmbService";
            this.CmbService.Size = new System.Drawing.Size(275, 28);
            this.CmbService.TabIndex = 8;
            this.CmbService.SelectedIndexChanged += new System.EventHandler(this.CmbService_SelectedIndexChanged);
            // 
            // ServiceQuantity
            // 
            this.ServiceQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ServiceQuantity.Location = new System.Drawing.Point(145, 77);
            this.ServiceQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ServiceQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ServiceQuantity.Name = "ServiceQuantity";
            this.ServiceQuantity.Size = new System.Drawing.Size(81, 27);
            this.ServiceQuantity.TabIndex = 10;
            this.ServiceQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.groupBox1.Controls.Add(this.LblType);
            this.groupBox1.Controls.Add(this.LblPeople);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Dtpicker_out);
            this.groupBox1.Controls.Add(this.Dtpicker_in);
            this.groupBox1.Controls.Add(this.TbxNote);
            this.groupBox1.Controls.Add(this.TbxDeposit);
            this.groupBox1.Controls.Add(this.lbl_roomPrice);
            this.groupBox1.Controls.Add(this.CbxByDay);
            this.groupBox1.Controls.Add(this.CbxByHour);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.LblRoomType);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Dtpicker_checkOut);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.Dtpicker_checkIn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(78, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 440);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.ForeColor = System.Drawing.Color.White;
            this.LblType.Location = new System.Drawing.Point(142, 45);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(81, 20);
            this.LblType.TabIndex = 43;
            this.LblType.Text = "RoomType";
            // 
            // LblPeople
            // 
            this.LblPeople.AutoSize = true;
            this.LblPeople.ForeColor = System.Drawing.Color.White;
            this.LblPeople.Location = new System.Drawing.Point(142, 309);
            this.LblPeople.Name = "LblPeople";
            this.LblPeople.Size = new System.Drawing.Size(55, 20);
            this.LblPeople.TabIndex = 42;
            this.LblPeople.Text = "People";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tiền mặt",
            "Banking"});
            this.comboBox1.Location = new System.Drawing.Point(142, 213);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(303, 28);
            this.comboBox1.TabIndex = 41;
            // 
            // Dtpicker_out
            // 
            this.Dtpicker_out.CustomFormat = "HH:mm";
            this.Dtpicker_out.Enabled = false;
            this.Dtpicker_out.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtpicker_out.Location = new System.Drawing.Point(311, 128);
            this.Dtpicker_out.Name = "Dtpicker_out";
            this.Dtpicker_out.ShowUpDown = true;
            this.Dtpicker_out.Size = new System.Drawing.Size(134, 27);
            this.Dtpicker_out.TabIndex = 40;
            // 
            // Dtpicker_in
            // 
            this.Dtpicker_in.CustomFormat = "HH:mm";
            this.Dtpicker_in.Enabled = false;
            this.Dtpicker_in.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtpicker_in.Location = new System.Drawing.Point(311, 84);
            this.Dtpicker_in.Name = "Dtpicker_in";
            this.Dtpicker_in.ShowUpDown = true;
            this.Dtpicker_in.Size = new System.Drawing.Size(134, 27);
            this.Dtpicker_in.TabIndex = 39;
            this.Dtpicker_in.Value = new System.DateTime(2021, 11, 17, 9, 27, 0, 0);
            // 
            // TbxNote
            // 
            this.TbxNote.Background = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.TbxNote.BorderColor = System.Drawing.Color.White;
            this.TbxNote.BorderRadius = 0;
            this.TbxNote.ErrorMessage = null;
            this.TbxNote.FocusedColor = System.Drawing.Color.Aqua;
            this.TbxNote.ForeColor = System.Drawing.Color.White;
            this.TbxNote.IsError = false;
            this.TbxNote.Location = new System.Drawing.Point(142, 248);
            this.TbxNote.Margin = new System.Windows.Forms.Padding(4);
            this.TbxNote.Multiline = false;
            this.TbxNote.Name = "TbxNote";
            this.TbxNote.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.TbxNote.Password = false;
            this.TbxNote.PlaceHolder = "Ghi chú";
            this.TbxNote.PlaceHolderColor = System.Drawing.SystemColors.ScrollBar;
            this.TbxNote.Size = new System.Drawing.Size(300, 37);
            this.TbxNote.TabIndex = 38;
            this.TbxNote.Underline = true;
            // 
            // TbxDeposit
            // 
            this.TbxDeposit.Background = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.TbxDeposit.BorderColor = System.Drawing.Color.White;
            this.TbxDeposit.BorderRadius = 0;
            this.TbxDeposit.ErrorMessage = null;
            this.TbxDeposit.FocusedColor = System.Drawing.Color.Aqua;
            this.TbxDeposit.ForeColor = System.Drawing.Color.White;
            this.TbxDeposit.IsError = false;
            this.TbxDeposit.Location = new System.Drawing.Point(145, 162);
            this.TbxDeposit.Margin = new System.Windows.Forms.Padding(4);
            this.TbxDeposit.Multiline = false;
            this.TbxDeposit.Name = "TbxDeposit";
            this.TbxDeposit.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.TbxDeposit.Password = false;
            this.TbxDeposit.PlaceHolder = "Tiền trả trước";
            this.TbxDeposit.PlaceHolderColor = System.Drawing.SystemColors.ScrollBar;
            this.TbxDeposit.Size = new System.Drawing.Size(300, 37);
            this.TbxDeposit.TabIndex = 36;
            this.TbxDeposit.Underline = true;
            // 
            // lbl_roomPrice
            // 
            this.lbl_roomPrice.AutoSize = true;
            this.lbl_roomPrice.ForeColor = System.Drawing.Color.White;
            this.lbl_roomPrice.Location = new System.Drawing.Point(145, 396);
            this.lbl_roomPrice.Name = "lbl_roomPrice";
            this.lbl_roomPrice.Size = new System.Drawing.Size(83, 20);
            this.lbl_roomPrice.TabIndex = 30;
            this.lbl_roomPrice.Text = "RoomPrice";
            // 
            // CbxByDay
            // 
            this.CbxByDay.AutoSize = true;
            this.CbxByDay.ForeColor = System.Drawing.Color.White;
            this.CbxByDay.Location = new System.Drawing.Point(143, 349);
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
            this.CbxByHour.ForeColor = System.Drawing.Color.White;
            this.CbxByHour.Location = new System.Drawing.Point(254, 349);
            this.CbxByHour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbxByHour.Name = "CbxByHour";
            this.CbxByHour.Size = new System.Drawing.Size(91, 24);
            this.CbxByHour.TabIndex = 26;
            this.CbxByHour.Text = "Theo giờ";
            this.CbxByHour.UseVisualStyleBackColor = true;
            this.CbxByHour.CheckedChanged += new System.EventHandler(this.CbxByHour_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(18, 309);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 20);
            this.label19.TabIndex = 23;
            this.label19.Text = "Số người";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
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
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(18, 265);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Ghi chú";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(18, 397);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "Giá phòng";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(15, 221);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 20);
            this.label20.TabIndex = 0;
            this.label20.Text = "Hình thức";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(18, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Loại phòng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnAddService);
            this.groupBox2.Controls.Add(this.Price);
            this.groupBox2.Controls.Add(this.CmbService);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ServiceQuantity);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(6, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(512, 165);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm dịch vụ";
            // 
            // BtnAddService
            // 
            this.BtnAddService.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnAddService.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnAddService.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnAddService.BorderRadius = 10;
            this.BtnAddService.BorderSize = 0;
            this.BtnAddService.FlatAppearance.BorderSize = 0;
            this.BtnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddService.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAddService.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnAddService.Location = new System.Drawing.Point(316, 114);
            this.BtnAddService.Name = "BtnAddService";
            this.BtnAddService.Size = new System.Drawing.Size(182, 42);
            this.BtnAddService.TabIndex = 28;
            this.BtnAddService.Text = "Thêm";
            this.BtnAddService.TextColor = System.Drawing.SystemColors.ControlText;
            this.BtnAddService.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAddService.UseVisualStyleBackColor = false;
            this.BtnAddService.Click += new System.EventHandler(this.BtnAddService_Click);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(316, 79);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(93, 20);
            this.Price.TabIndex = 11;
            this.Price.Text = "ServicePrice";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(244, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "Đơn giá";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_AddCustomer);
            this.groupBox3.Controls.Add(this.TbxPhoneNumber);
            this.groupBox3.Controls.Add(this.TbxCustomerName);
            this.groupBox3.Controls.Add(this.TbxIdentityNumber);
            this.groupBox3.Controls.Add(this.RbtFemale);
            this.groupBox3.Controls.Add(this.RbtMale);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbx_giayTo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(613, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(523, 440);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khách hàng";
            // 
            // Btn_AddCustomer
            // 
            this.Btn_AddCustomer.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Btn_AddCustomer.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.Btn_AddCustomer.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_AddCustomer.BorderRadius = 10;
            this.Btn_AddCustomer.BorderSize = 0;
            this.Btn_AddCustomer.FlatAppearance.BorderSize = 0;
            this.Btn_AddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddCustomer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_AddCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_AddCustomer.Location = new System.Drawing.Point(321, 230);
            this.Btn_AddCustomer.Name = "Btn_AddCustomer";
            this.Btn_AddCustomer.Size = new System.Drawing.Size(182, 42);
            this.Btn_AddCustomer.TabIndex = 29;
            this.Btn_AddCustomer.Text = "Thêm";
            this.Btn_AddCustomer.TextColor = System.Drawing.SystemColors.ControlText;
            this.Btn_AddCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_AddCustomer.UseVisualStyleBackColor = false;
            this.Btn_AddCustomer.Click += new System.EventHandler(this.Btn_AddCustomer_Click);
            // 
            // TbxPhoneNumber
            // 
            this.TbxPhoneNumber.Background = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.TbxPhoneNumber.BorderColor = System.Drawing.Color.White;
            this.TbxPhoneNumber.BorderRadius = 0;
            this.TbxPhoneNumber.ErrorMessage = null;
            this.TbxPhoneNumber.FocusedColor = System.Drawing.Color.Aqua;
            this.TbxPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.TbxPhoneNumber.IsError = false;
            this.TbxPhoneNumber.Location = new System.Drawing.Point(151, 118);
            this.TbxPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TbxPhoneNumber.Multiline = false;
            this.TbxPhoneNumber.Name = "TbxPhoneNumber";
            this.TbxPhoneNumber.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.TbxPhoneNumber.Password = false;
            this.TbxPhoneNumber.PlaceHolder = "Sô điện thoại";
            this.TbxPhoneNumber.PlaceHolderColor = System.Drawing.SystemColors.ScrollBar;
            this.TbxPhoneNumber.Size = new System.Drawing.Size(274, 37);
            this.TbxPhoneNumber.TabIndex = 36;
            this.TbxPhoneNumber.Underline = true;
            // 
            // TbxCustomerName
            // 
            this.TbxCustomerName.Background = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.TbxCustomerName.BorderColor = System.Drawing.Color.White;
            this.TbxCustomerName.BorderRadius = 0;
            this.TbxCustomerName.ErrorMessage = null;
            this.TbxCustomerName.FocusedColor = System.Drawing.Color.Aqua;
            this.TbxCustomerName.ForeColor = System.Drawing.Color.White;
            this.TbxCustomerName.IsError = false;
            this.TbxCustomerName.Location = new System.Drawing.Point(151, 73);
            this.TbxCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.TbxCustomerName.Multiline = false;
            this.TbxCustomerName.Name = "TbxCustomerName";
            this.TbxCustomerName.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TbxCustomerName.Password = false;
            this.TbxCustomerName.PlaceHolder = "Tên khách hàng";
            this.TbxCustomerName.PlaceHolderColor = System.Drawing.SystemColors.ScrollBar;
            this.TbxCustomerName.Size = new System.Drawing.Size(274, 37);
            this.TbxCustomerName.TabIndex = 35;
            this.TbxCustomerName.Underline = true;
            // 
            // TbxIdentityNumber
            // 
            this.TbxIdentityNumber.Background = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.TbxIdentityNumber.BorderColor = System.Drawing.Color.White;
            this.TbxIdentityNumber.BorderRadius = 0;
            this.TbxIdentityNumber.ErrorMessage = null;
            this.TbxIdentityNumber.FocusedColor = System.Drawing.Color.Aqua;
            this.TbxIdentityNumber.ForeColor = System.Drawing.Color.White;
            this.TbxIdentityNumber.IsError = false;
            this.TbxIdentityNumber.Location = new System.Drawing.Point(151, 28);
            this.TbxIdentityNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TbxIdentityNumber.Multiline = false;
            this.TbxIdentityNumber.Name = "TbxIdentityNumber";
            this.TbxIdentityNumber.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TbxIdentityNumber.Password = false;
            this.TbxIdentityNumber.PlaceHolder = "Số giấy tờ";
            this.TbxIdentityNumber.PlaceHolderColor = System.Drawing.SystemColors.ScrollBar;
            this.TbxIdentityNumber.Size = new System.Drawing.Size(274, 37);
            this.TbxIdentityNumber.TabIndex = 34;
            this.TbxIdentityNumber.Underline = true;
            this.TbxIdentityNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxIdentityNumber_KeyDown);
            // 
            // RbtFemale
            // 
            this.RbtFemale.AutoSize = true;
            this.RbtFemale.Location = new System.Drawing.Point(261, 163);
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
            this.RbtMale.Location = new System.Drawing.Point(151, 163);
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
            this.label12.Location = new System.Drawing.Point(16, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Số";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Giới tính";
            // 
            // RoomName
            // 
            this.RoomName.AutoSize = true;
            this.RoomName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RoomName.Location = new System.Drawing.Point(654, -6);
            this.RoomName.Name = "RoomName";
            this.RoomName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 13);
            this.RoomName.Size = new System.Drawing.Size(110, 51);
            this.RoomName.TabIndex = 4;
            this.RoomName.Text = "Phòng:";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.ServiceGridView);
            this.groupBox5.Location = new System.Drawing.Point(0, 520);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(807, 187);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách dịch vụ";
            // 
            // ServiceGridView
            // 
            this.ServiceGridView.AllowUserToAddRows = false;
            this.ServiceGridView.AllowUserToDeleteRows = false;
            this.ServiceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServiceGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ServiceGridView.Location = new System.Drawing.Point(3, 28);
            this.ServiceGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ServiceGridView.Name = "ServiceGridView";
            this.ServiceGridView.RowHeadersVisible = false;
            this.ServiceGridView.RowHeadersWidth = 51;
            this.ServiceGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.ServiceGridView.RowTemplate.Height = 29;
            this.ServiceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceGridView.Size = new System.Drawing.Size(801, 156);
            this.ServiceGridView.TabIndex = 0;
            // 
            // GridViewCustomer
            // 
            this.GridViewCustomer.AllowUserToAddRows = false;
            this.GridViewCustomer.AllowUserToDeleteRows = false;
            this.GridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridViewCustomer.Location = new System.Drawing.Point(3, 28);
            this.GridViewCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GridViewCustomer.Name = "GridViewCustomer";
            this.GridViewCustomer.RowHeadersVisible = false;
            this.GridViewCustomer.RowHeadersWidth = 51;
            this.GridViewCustomer.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.GridViewCustomer.RowTemplate.Height = 29;
            this.GridViewCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewCustomer.Size = new System.Drawing.Size(714, 156);
            this.GridViewCustomer.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(286, 721);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tạm tính:";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfirm.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnConfirm.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnConfirm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnConfirm.BorderRadius = 12;
            this.BtnConfirm.BorderSize = 0;
            this.BtnConfirm.FlatAppearance.BorderSize = 0;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnConfirm.Image = global::HotelManagement.UI.Properties.Resources.bill;
            this.BtnConfirm.Location = new System.Drawing.Point(1404, 710);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(159, 41);
            this.BtnConfirm.TabIndex = 26;
            this.BtnConfirm.Text = "Thanh toán";
            this.BtnConfirm.TextColor = System.Drawing.SystemColors.ControlText;
            this.BtnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnConfirm.UseVisualStyleBackColor = false;
            // 
            // BtnCancle
            // 
            this.BtnCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancle.BackColor = System.Drawing.Color.Crimson;
            this.BtnCancle.BackgroundColor = System.Drawing.Color.Crimson;
            this.BtnCancle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnCancle.BorderRadius = 12;
            this.BtnCancle.BorderSize = 0;
            this.BtnCancle.FlatAppearance.BorderSize = 0;
            this.BtnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCancle.Location = new System.Drawing.Point(1115, 710);
            this.BtnCancle.Name = "BtnCancle";
            this.BtnCancle.Size = new System.Drawing.Size(121, 42);
            this.BtnCancle.TabIndex = 37;
            this.BtnCancle.Text = "Cancel";
            this.BtnCancle.TextColor = System.Drawing.SystemColors.ControlText;
            this.BtnCancle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnCancle.UseVisualStyleBackColor = false;
            this.BtnCancle.Click += new System.EventHandler(this.btb_cancel_Click);
            // 
            // LblPayment
            // 
            this.LblPayment.AutoSize = true;
            this.LblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPayment.ForeColor = System.Drawing.Color.Red;
            this.LblPayment.Location = new System.Drawing.Point(397, 721);
            this.LblPayment.Name = "LblPayment";
            this.LblPayment.Size = new System.Drawing.Size(0, 25);
            this.LblPayment.TabIndex = 38;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnUpdate.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.BtnUpdate.BorderColor = System.Drawing.Color.SteelBlue;
            this.BtnUpdate.BorderRadius = 8;
            this.BtnUpdate.BorderSize = 1;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnUpdate.Location = new System.Drawing.Point(1266, 710);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(107, 42);
            this.BtnUpdate.TabIndex = 39;
            this.BtnUpdate.Text = "Lưu";
            this.BtnUpdate.TextColor = System.Drawing.SystemColors.ControlText;
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // ptb_quet
            // 
            this.ptb_quet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_quet.Location = new System.Drawing.Point(1211, 117);
            this.ptb_quet.Name = "ptb_quet";
            this.ptb_quet.Size = new System.Drawing.Size(349, 281);
            this.ptb_quet.TabIndex = 40;
            this.ptb_quet.TabStop = false;
            // 
            // cbo_webcam
            // 
            this.cbo_webcam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_webcam.FormattingEnabled = true;
            this.cbo_webcam.Location = new System.Drawing.Point(1210, 83);
            this.cbo_webcam.Name = "cbo_webcam";
            this.cbo_webcam.Size = new System.Drawing.Size(350, 28);
            this.cbo_webcam.TabIndex = 41;
            // 
            // txb_QR
            // 
            this.txb_QR.Location = new System.Drawing.Point(1211, 410);
            this.txb_QR.Multiline = true;
            this.txb_QR.Name = "txb_QR";
            this.txb_QR.Size = new System.Drawing.Size(349, 63);
            this.txb_QR.TabIndex = 42;
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Start.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Start.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Start.BorderRadius = 10;
            this.btn_Start.BorderSize = 0;
            this.btn_Start.FlatAppearance.BorderSize = 0;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Start.ForeColor = System.Drawing.Color.Black;
            this.btn_Start.Location = new System.Drawing.Point(1327, 479);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(118, 40);
            this.btn_Start.TabIndex = 43;
            this.btn_Start.Text = "Quét";
            this.btn_Start.TextColor = System.Drawing.Color.Black;
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GridViewCustomer);
            this.groupBox4.Location = new System.Drawing.Point(843, 520);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(720, 187);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách khách hàng";
            // 
            // FrmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(1575, 776);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.txb_QR);
            this.Controls.Add(this.cbo_webcam);
            this.Controls.Add(this.ptb_quet);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.LblPayment);
            this.Controls.Add(this.BtnCancle);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RoomName);
            this.Controls.Add(this.label13);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReceipt_FormClosing);
            this.Load += new System.EventHandler(this.FrmReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_quet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dtpicker_checkOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Dtpicker_checkIn;
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
        private System.Windows.Forms.RadioButton RbtMale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton RbtFemale;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView ServiceGridView;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox CbxByDay;
        private System.Windows.Forms.CheckBox CbxByHour;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbl_roomPrice;
        private System.Windows.Forms.Label Price;
        private Components.CustomButton BtnAddService;
        private Components.TextBox TbxNote;
        private Components.TextBox TbxDeposit;
        private Components.CustomButton btb;
        private Components.TextBox TbxPhoneNumber;
        private Components.TextBox textBox2;
        private Components.TextBox TbxIdentityNumber;
        private Label label13;
        private Components.CustomButton BtnConfirm;
        private Components.CustomButton BtnCancle;
        private Components.TextBox TbxCustomerName;
        private DateTimePicker Dtpicker_out;
        private DateTimePicker Dtpicker_in;
        private Label LblPayment;
        private Components.CustomButton BtnUpdate;
        private ComboBox comboBox1;
        private PictureBox ptb_quet; 
        private ComboBox cbo_webcam;
        private TextBox txb_QR;
        private Components.CustomButton btn_Start;
        private Timer timer1;
        private Components.CustomButton Btn_AddCustomer;
        private DataGridView GridViewCustomer;
        private GroupBox groupBox4;
        private Label LblPeople;
        private Label LblType;
    }
}