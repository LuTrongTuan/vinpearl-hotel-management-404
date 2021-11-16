
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
            this.Dtpicker_out = new System.Windows.Forms.DateTimePicker();
            this.Dtpicker_in = new System.Windows.Forms.DateTimePicker();
            this.TbxNote = new HotelManagement.UI.Components.TextBox();
            this.txb_hinhthuc = new HotelManagement.UI.Components.TextBox();
            this.TbxDeposit = new HotelManagement.UI.Components.TextBox();
            this.lbl_roomPrice = new System.Windows.Forms.Label();
            this.CbxByDay = new System.Windows.Forms.CheckBox();
            this.CbxByHour = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.PeopleAmount = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.LblRoomType = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbx_roomtype = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnAddService = new HotelManagement.UI.Components.CustomButton();
            this.Price = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TbxPhoneNumber = new HotelManagement.UI.Components.TextBox();
            this.TbxCustomerName = new HotelManagement.UI.Components.TextBox();
            this.TbxIdentityNumber = new HotelManagement.UI.Components.TextBox();
            this.RbtFemale = new System.Windows.Forms.RadioButton();
            this.RbtMale = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RoomName = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ServiceGridView = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnConfirm = new HotelManagement.UI.Components.CustomButton();
            this.TbxPayment = new HotelManagement.UI.Components.TextBox();
            this.BtnCancle = new HotelManagement.UI.Components.CustomButton();
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
            this.label1.Location = new System.Drawing.Point(12, 211);
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
            this.Dtpicker_checkOut.Location = new System.Drawing.Point(145, 159);
            this.Dtpicker_checkOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dtpicker_checkOut.Name = "Dtpicker_checkOut";
            this.Dtpicker_checkOut.Size = new System.Drawing.Size(160, 27);
            this.Dtpicker_checkOut.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 89);
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
            // Dtpicker_checkIn
            // 
            this.Dtpicker_checkIn.CustomFormat = "";
            this.Dtpicker_checkIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dtpicker_checkIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtpicker_checkIn.Location = new System.Drawing.Point(145, 124);
            this.Dtpicker_checkIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dtpicker_checkIn.Name = "Dtpicker_checkIn";
            this.Dtpicker_checkIn.Size = new System.Drawing.Size(160, 27);
            this.Dtpicker_checkIn.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 134);
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
            this.cbx_giayTo.ForeColor = System.Drawing.Color.Black;
            this.cbx_giayTo.FormattingEnabled = true;
            this.cbx_giayTo.Location = new System.Drawing.Point(145, 85);
            this.cbx_giayTo.Name = "cbx_giayTo";
            this.cbx_giayTo.Size = new System.Drawing.Size(300, 28);
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
            this.CmbService.ForeColor = System.Drawing.Color.Black;
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
            this.ServiceQuantity.Name = "ServiceQuantity";
            this.ServiceQuantity.Size = new System.Drawing.Size(81, 27);
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
            this.groupBox1.Controls.Add(this.Dtpicker_out);
            this.groupBox1.Controls.Add(this.Dtpicker_in);
            this.groupBox1.Controls.Add(this.TbxNote);
            this.groupBox1.Controls.Add(this.txb_hinhthuc);
            this.groupBox1.Controls.Add(this.TbxDeposit);
            this.groupBox1.Controls.Add(this.lbl_roomPrice);
            this.groupBox1.Controls.Add(this.CbxByDay);
            this.groupBox1.Controls.Add(this.CbxByHour);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.PeopleAmount);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.LblRoomType);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Dtpicker_checkOut);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cbx_roomtype);
            this.groupBox1.Controls.Add(this.cbx_giayTo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Dtpicker_checkIn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 479);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // Dtpicker_out
            // 
            this.Dtpicker_out.CustomFormat = "HH:mm tt";
            this.Dtpicker_out.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtpicker_out.Location = new System.Drawing.Point(311, 160);
            this.Dtpicker_out.Name = "Dtpicker_out";
            this.Dtpicker_out.ShowUpDown = true;
            this.Dtpicker_out.Size = new System.Drawing.Size(134, 27);
            this.Dtpicker_out.TabIndex = 40;
            // 
            // Dtpicker_in
            // 
            this.Dtpicker_in.CustomFormat = "HH:mm tt";
            this.Dtpicker_in.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtpicker_in.Location = new System.Drawing.Point(311, 124);
            this.Dtpicker_in.Name = "Dtpicker_in";
            this.Dtpicker_in.ShowUpDown = true;
            this.Dtpicker_in.Size = new System.Drawing.Size(134, 27);
            this.Dtpicker_in.TabIndex = 39;
            this.Dtpicker_in.Value = new System.DateTime(2021, 11, 16, 9, 27, 20, 0);
            // 
            // TbxNote
            // 
            this.TbxNote.BorderColor = System.Drawing.Color.BlueViolet;
            this.TbxNote.BorderRadius = 0;
            this.TbxNote.ErrorMessage = null;
            this.TbxNote.FocusedColor = System.Drawing.Color.Aqua;
            this.TbxNote.IsError = false;
            this.TbxNote.Location = new System.Drawing.Point(145, 284);
            this.TbxNote.Margin = new System.Windows.Forms.Padding(4);
            this.TbxNote.Multiline = false;
            this.TbxNote.Name = "TbxNote";
            this.TbxNote.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.TbxNote.Password = false;
            this.TbxNote.PlaceHolder = "Ghi chú";
            this.TbxNote.Size = new System.Drawing.Size(300, 37);
            this.TbxNote.TabIndex = 38;
            this.TbxNote.Underline = false;
            // 
            // txb_hinhthuc
            // 
            this.txb_hinhthuc.BorderColor = System.Drawing.Color.BlueViolet;
            this.txb_hinhthuc.BorderRadius = 0;
            this.txb_hinhthuc.ErrorMessage = null;
            this.txb_hinhthuc.FocusedColor = System.Drawing.Color.Aqua;
            this.txb_hinhthuc.IsError = false;
            this.txb_hinhthuc.Location = new System.Drawing.Point(145, 239);
            this.txb_hinhthuc.Margin = new System.Windows.Forms.Padding(4);
            this.txb_hinhthuc.Multiline = false;
            this.txb_hinhthuc.Name = "txb_hinhthuc";
            this.txb_hinhthuc.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txb_hinhthuc.Password = false;
            this.txb_hinhthuc.PlaceHolder = "Hình thức thanh toán";
            this.txb_hinhthuc.Size = new System.Drawing.Size(300, 37);
            this.txb_hinhthuc.TabIndex = 37;
            this.txb_hinhthuc.Underline = false;
            // 
            // TbxDeposit
            // 
            this.TbxDeposit.BorderColor = System.Drawing.Color.BlueViolet;
            this.TbxDeposit.BorderRadius = 0;
            this.TbxDeposit.ErrorMessage = null;
            this.TbxDeposit.FocusedColor = System.Drawing.Color.Aqua;
            this.TbxDeposit.IsError = false;
            this.TbxDeposit.Location = new System.Drawing.Point(145, 194);
            this.TbxDeposit.Margin = new System.Windows.Forms.Padding(4);
            this.TbxDeposit.Multiline = false;
            this.TbxDeposit.Name = "TbxDeposit";
            this.TbxDeposit.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.TbxDeposit.Password = false;
            this.TbxDeposit.PlaceHolder = "Tiền trả trước";
            this.TbxDeposit.Size = new System.Drawing.Size(300, 37);
            this.TbxDeposit.TabIndex = 36;
            this.TbxDeposit.Underline = false;
            // 
            // lbl_roomPrice
            // 
            this.lbl_roomPrice.AutoSize = true;
            this.lbl_roomPrice.Location = new System.Drawing.Point(145, 402);
            this.lbl_roomPrice.Name = "lbl_roomPrice";
            this.lbl_roomPrice.Size = new System.Drawing.Size(83, 20);
            this.lbl_roomPrice.TabIndex = 30;
            this.lbl_roomPrice.Text = "RoomPrice";
            // 
            // CbxByDay
            // 
            this.CbxByDay.AutoSize = true;
            this.CbxByDay.Location = new System.Drawing.Point(145, 366);
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
            this.CbxByHour.Location = new System.Drawing.Point(256, 366);
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
            this.label19.Location = new System.Drawing.Point(18, 333);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 20);
            this.label19.TabIndex = 23;
            this.label19.Text = "Số người";
            // 
            // PeopleAmount
            // 
            this.PeopleAmount.Location = new System.Drawing.Point(145, 331);
            this.PeopleAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PeopleAmount.Name = "PeopleAmount";
            this.PeopleAmount.Size = new System.Drawing.Size(120, 27);
            this.PeopleAmount.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(18, 363);
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
            this.label16.Location = new System.Drawing.Point(18, 295);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Ghi chú";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(18, 402);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "Giá phòng";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(15, 256);
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
            this.cbx_roomtype.ForeColor = System.Drawing.Color.Black;
            this.cbx_roomtype.FormattingEnabled = true;
            this.cbx_roomtype.Location = new System.Drawing.Point(145, 45);
            this.cbx_roomtype.Name = "cbx_roomtype";
            this.cbx_roomtype.Size = new System.Drawing.Size(300, 28);
            this.cbx_roomtype.TabIndex = 8;
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
            this.groupBox2.Location = new System.Drawing.Point(6, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(547, 163);
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
            this.BtnAddService.Location = new System.Drawing.Point(359, 114);
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
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.TbxPhoneNumber);
            this.groupBox3.Controls.Add(this.TbxCustomerName);
            this.groupBox3.Controls.Add(this.TbxIdentityNumber);
            this.groupBox3.Controls.Add(this.RbtFemale);
            this.groupBox3.Controls.Add(this.RbtMale);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(600, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(559, 477);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khách hàng";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(262, 209);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(153, 24);
            this.checkBox2.TabIndex = 37;
            this.checkBox2.Text = "Không hoạt động";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(151, 209);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 24);
            this.checkBox1.TabIndex = 37;
            this.checkBox1.Text = "Hoạt động";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TbxPhoneNumber
            // 
            this.TbxPhoneNumber.BorderColor = System.Drawing.Color.BlueViolet;
            this.TbxPhoneNumber.BorderRadius = 0;
            this.TbxPhoneNumber.ErrorMessage = null;
            this.TbxPhoneNumber.FocusedColor = System.Drawing.Color.Aqua;
            this.TbxPhoneNumber.IsError = false;
            this.TbxPhoneNumber.Location = new System.Drawing.Point(151, 126);
            this.TbxPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TbxPhoneNumber.Multiline = false;
            this.TbxPhoneNumber.Name = "TbxPhoneNumber";
            this.TbxPhoneNumber.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.TbxPhoneNumber.Password = false;
            this.TbxPhoneNumber.PlaceHolder = "Sô điện thoại";
            this.TbxPhoneNumber.Size = new System.Drawing.Size(275, 37);
            this.TbxPhoneNumber.TabIndex = 36;
            this.TbxPhoneNumber.Underline = false;
            // 
            // TbxCustomerName
            // 
            this.TbxCustomerName.BorderColor = System.Drawing.Color.BlueViolet;
            this.TbxCustomerName.BorderRadius = 0;
            this.TbxCustomerName.ErrorMessage = null;
            this.TbxCustomerName.FocusedColor = System.Drawing.Color.Aqua;
            this.TbxCustomerName.IsError = false;
            this.TbxCustomerName.Location = new System.Drawing.Point(151, 81);
            this.TbxCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.TbxCustomerName.Multiline = false;
            this.TbxCustomerName.Name = "TbxCustomerName";
            this.TbxCustomerName.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TbxCustomerName.Password = false;
            this.TbxCustomerName.PlaceHolder = "Tên khách hàng";
            this.TbxCustomerName.Size = new System.Drawing.Size(275, 37);
            this.TbxCustomerName.TabIndex = 35;
            this.TbxCustomerName.Underline = false;
            // 
            // TbxIdentityNumber
            // 
            this.TbxIdentityNumber.BorderColor = System.Drawing.Color.BlueViolet;
            this.TbxIdentityNumber.BorderRadius = 0;
            this.TbxIdentityNumber.ErrorMessage = null;
            this.TbxIdentityNumber.FocusedColor = System.Drawing.Color.Aqua;
            this.TbxIdentityNumber.IsError = false;
            this.TbxIdentityNumber.Location = new System.Drawing.Point(151, 36);
            this.TbxIdentityNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TbxIdentityNumber.Multiline = false;
            this.TbxIdentityNumber.Name = "TbxIdentityNumber";
            this.TbxIdentityNumber.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TbxIdentityNumber.Password = false;
            this.TbxIdentityNumber.PlaceHolder = "Số giấy tờ";
            this.TbxIdentityNumber.Size = new System.Drawing.Size(275, 37);
            this.TbxIdentityNumber.TabIndex = 34;
            this.TbxIdentityNumber.Underline = false;
            // 
            // RbtFemale
            // 
            this.RbtFemale.AutoSize = true;
            this.RbtFemale.Location = new System.Drawing.Point(261, 171);
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
            this.RbtMale.Location = new System.Drawing.Point(151, 171);
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
            this.label12.Location = new System.Drawing.Point(16, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Số";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 173);
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
            this.groupBox5.Location = new System.Drawing.Point(0, 522);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1173, 182);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách dịch vụ";
            // 
            // ServiceGridView
            // 
            this.ServiceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ServiceGridView.Location = new System.Drawing.Point(3, 33);
            this.ServiceGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ServiceGridView.Name = "ServiceGridView";
            this.ServiceGridView.RowHeadersWidth = 51;
            this.ServiceGridView.RowTemplate.Height = 29;
            this.ServiceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceGridView.Size = new System.Drawing.Size(1167, 146);
            this.ServiceGridView.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(397, 723);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Thành tiền";
            // 
            // BtnConfirm
            // 
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
            this.BtnConfirm.Location = new System.Drawing.Point(1011, 712);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(159, 41);
            this.BtnConfirm.TabIndex = 26;
            this.BtnConfirm.Text = "Thanh toán";
            this.BtnConfirm.TextColor = System.Drawing.SystemColors.ControlText;
            this.BtnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnConfirm.UseVisualStyleBackColor = false;
            // 
            // TbxPayment
            // 
            this.TbxPayment.BorderColor = System.Drawing.Color.BlueViolet;
            this.TbxPayment.BorderRadius = 0;
            this.TbxPayment.ErrorMessage = null;
            this.TbxPayment.FocusedColor = System.Drawing.Color.Aqua;
            this.TbxPayment.IsError = false;
            this.TbxPayment.Location = new System.Drawing.Point(507, 715);
            this.TbxPayment.Margin = new System.Windows.Forms.Padding(4);
            this.TbxPayment.Multiline = false;
            this.TbxPayment.Name = "TbxPayment";
            this.TbxPayment.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TbxPayment.Password = false;
            this.TbxPayment.PlaceHolder = "Thành tiền";
            this.TbxPayment.Size = new System.Drawing.Size(178, 37);
            this.TbxPayment.TabIndex = 36;
            this.TbxPayment.Underline = false;
            // 
            // BtnCancle
            // 
            this.BtnCancle.BackColor = System.Drawing.Color.Crimson;
            this.BtnCancle.BackgroundColor = System.Drawing.Color.Crimson;
            this.BtnCancle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnCancle.BorderRadius = 12;
            this.BtnCancle.BorderSize = 0;
            this.BtnCancle.FlatAppearance.BorderSize = 0;
            this.BtnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCancle.Location = new System.Drawing.Point(884, 712);
            this.BtnCancle.Name = "BtnCancle";
            this.BtnCancle.Size = new System.Drawing.Size(121, 42);
            this.BtnCancle.TabIndex = 37;
            this.BtnCancle.Text = "Cancel";
            this.BtnCancle.TextColor = System.Drawing.SystemColors.ControlText;
            this.BtnCancle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnCancle.UseVisualStyleBackColor = false;
            this.BtnCancle.Click += new System.EventHandler(this.btb_cancel_Click);
            // 
            // FrmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 765);
            this.Controls.Add(this.BtnCancle);
            this.Controls.Add(this.TbxPayment);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RoomName);
            this.Controls.Add(this.label13);
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
        private System.Windows.Forms.ComboBox cbx_roomtype;
        private System.Windows.Forms.RadioButton RbtMale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton RbtFemale;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView ServiceGridView;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown PeopleAmount;
        private System.Windows.Forms.CheckBox CbxByDay;
        private System.Windows.Forms.CheckBox CbxByHour;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbl_roomPrice;
        private System.Windows.Forms.Label Price;
        private Components.CustomButton BtnAddService;
        private Components.TextBox TbxNote;
        private Components.TextBox txb_hinhthuc;
        private Components.TextBox TbxDeposit;
        private Components.CustomButton btb;
        private Components.TextBox TbxPhoneNumber;
        private Components.TextBox textBox2;
        private Components.TextBox TbxIdentityNumber;
        private Label label13;
        private Components.CustomButton BtnConfirm;
        private Components.TextBox TbxPayment;
        private Components.CustomButton BtnCancle;
        private Components.TextBox TbxCustomerName;
        private DateTimePicker Dtpicker_out;
        private DateTimePicker Dtpicker_in;
        private CheckBox checkBox1;
        private Label label7;
        private CheckBox checkBox2;
    }
}