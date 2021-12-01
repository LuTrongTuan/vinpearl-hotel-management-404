
namespace HotelManagement.UI.Views.Room
{
    partial class FrmMainRoom
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnCreateRoom = new HotelManagement.UI.Components.CustomButton();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.BtnRefresh = new HotelManagement.UI.Components.CustomButton();
            this.TbxSearch = new System.Windows.Forms.TextBox();
            this.BtnUpdateRoom = new HotelManagement.UI.Components.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBack = new HotelManagement.UI.Components.CustomButton();
            this.CmbFloor = new System.Windows.Forms.ComboBox();
            this.CmbRoomType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BtnCreateRoom
            // 
            this.BtnCreateRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCreateRoom.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnCreateRoom.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.BtnCreateRoom.BorderColor = System.Drawing.Color.CadetBlue;
            this.BtnCreateRoom.BorderRadius = 5;
            this.BtnCreateRoom.BorderSize = 1;
            this.BtnCreateRoom.FlatAppearance.BorderSize = 0;
            this.BtnCreateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCreateRoom.ForeColor = System.Drawing.Color.White;
            this.BtnCreateRoom.Location = new System.Drawing.Point(1224, 24);
            this.BtnCreateRoom.Name = "BtnCreateRoom";
            this.BtnCreateRoom.Size = new System.Drawing.Size(188, 50);
            this.BtnCreateRoom.TabIndex = 1;
            this.BtnCreateRoom.Text = "Tạo Phòng";
            this.BtnCreateRoom.TextColor = System.Drawing.Color.White;
            this.BtnCreateRoom.UseVisualStyleBackColor = false;
            this.BtnCreateRoom.Click += new System.EventHandler(this.BtnCreateRoom_Click);
            // 
            // PanelContainer
            // 
            this.PanelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContainer.AutoScroll = true;
            this.PanelContainer.Location = new System.Drawing.Point(0, 135);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1618, 333);
            this.PanelContainer.TabIndex = 2;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefresh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnRefresh.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnRefresh.BorderColor = System.Drawing.SystemColors.Highlight;
            this.BtnRefresh.BorderRadius = 5;
            this.BtnRefresh.BorderSize = 2;
            this.BtnRefresh.FlatAppearance.BorderSize = 0;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnRefresh.Image = global::HotelManagement.UI.Properties.Resources.refresh__2_;
            this.BtnRefresh.Location = new System.Drawing.Point(1170, 24);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(48, 50);
            this.BtnRefresh.TabIndex = 3;
            this.BtnRefresh.TextColor = System.Drawing.SystemColors.ControlText;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // TbxSearch
            // 
            this.TbxSearch.BackColor = System.Drawing.SystemColors.Window;
            this.TbxSearch.Location = new System.Drawing.Point(99, 35);
            this.TbxSearch.Name = "TbxSearch";
            this.TbxSearch.Size = new System.Drawing.Size(190, 27);
            this.TbxSearch.TabIndex = 7;
            this.TbxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbxSearch_KeyUp);
            // 
            // BtnUpdateRoom
            // 
            this.BtnUpdateRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdateRoom.BackColor = System.Drawing.Color.DeepPink;
            this.BtnUpdateRoom.BackgroundColor = System.Drawing.Color.DeepPink;
            this.BtnUpdateRoom.BorderColor = System.Drawing.Color.HotPink;
            this.BtnUpdateRoom.BorderRadius = 5;
            this.BtnUpdateRoom.BorderSize = 1;
            this.BtnUpdateRoom.FlatAppearance.BorderSize = 0;
            this.BtnUpdateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdateRoom.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateRoom.Location = new System.Drawing.Point(1418, 24);
            this.BtnUpdateRoom.Name = "BtnUpdateRoom";
            this.BtnUpdateRoom.Size = new System.Drawing.Size(188, 50);
            this.BtnUpdateRoom.TabIndex = 8;
            this.BtnUpdateRoom.Text = "Sửa Phòng";
            this.BtnUpdateRoom.TextColor = System.Drawing.Color.White;
            this.BtnUpdateRoom.UseVisualStyleBackColor = false;
            this.BtnUpdateRoom.Click += new System.EventHandler(this.BtnUpdateRoom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search:";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnBack.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnBack.BorderColor = System.Drawing.Color.Transparent;
            this.BtnBack.BorderRadius = 5;
            this.BtnBack.BorderSize = 2;
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnBack.Image = global::HotelManagement.UI.Properties.Resources.previous;
            this.BtnBack.Location = new System.Drawing.Point(21, 85);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(117, 44);
            this.BtnBack.TabIndex = 10;
            this.BtnBack.Text = "Trở lại";
            this.BtnBack.TextColor = System.Drawing.SystemColors.ControlText;
            this.BtnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // CmbFloor
            // 
            this.CmbFloor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbFloor.FormattingEnabled = true;
            this.CmbFloor.Location = new System.Drawing.Point(1287, 95);
            this.CmbFloor.Name = "CmbFloor";
            this.CmbFloor.Size = new System.Drawing.Size(151, 28);
            this.CmbFloor.TabIndex = 11;
            this.CmbFloor.SelectedIndexChanged += new System.EventHandler(this.CmbFloor_SelectedIndexChanged);
            // 
            // CmbRoomType
            // 
            this.CmbRoomType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbRoomType.FormattingEnabled = true;
            this.CmbRoomType.Location = new System.Drawing.Point(1455, 95);
            this.CmbRoomType.Name = "CmbRoomType";
            this.CmbRoomType.Size = new System.Drawing.Size(151, 28);
            this.CmbRoomType.TabIndex = 12;
            this.CmbRoomType.SelectedIndexChanged += new System.EventHandler(this.CmbRoomType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(847, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Đang dọn dẹp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(718, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Có khách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(561, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Phòng trống";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(678, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 29);
            this.button3.TabIndex = 17;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(807, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 29);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(521, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 29);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmMainRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(1618, 472);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CmbRoomType);
            this.Controls.Add(this.CmbFloor);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnUpdateRoom);
            this.Controls.Add(this.TbxSearch);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.BtnCreateRoom);
            this.Name = "FrmMainRoom";
            this.Text = "Quản lý Phòng";
            this.Load += new System.EventHandler(this.FrmMainRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Components.CustomButton BtnCreateRoom;
        private System.Windows.Forms.Panel PanelContainer;
        private Components.CustomButton BtnRefresh;
        private System.Windows.Forms.TextBox TbxSearch;
        private Components.CustomButton BtnUpdateRoom;
        private System.Windows.Forms.Label label1;
        private Components.CustomButton BtnBack;
        private System.Windows.Forms.ComboBox CmbFloor;
        private System.Windows.Forms.ComboBox CmbRoomType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}