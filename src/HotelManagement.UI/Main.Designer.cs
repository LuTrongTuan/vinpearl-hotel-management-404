﻿
using System.Drawing;
using System.Runtime.CompilerServices;

namespace HotelManagement.UI
{
    partial class Main
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
            this.sidebar = new System.Windows.Forms.Panel();
            this.customButton3 = new HotelManagement.UI.Components.CustomButton();
            this.customButton2 = new HotelManagement.UI.Components.CustomButton();
            this.customButton1 = new HotelManagement.UI.Components.CustomButton();
            this.btnEmployee = new HotelManagement.UI.Components.CustomButton();
            this.BtnRoom = new HotelManagement.UI.Components.CustomButton();
            this.PanelAppName = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelTittle = new System.Windows.Forms.Panel();
            this.LblTittle = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.PanelAppName.SuspendLayout();
            this.PanelTittle.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(194)))));
            this.sidebar.Controls.Add(this.customButton3);
            this.sidebar.Controls.Add(this.customButton2);
            this.sidebar.Controls.Add(this.customButton1);
            this.sidebar.Controls.Add(this.btnEmployee);
            this.sidebar.Controls.Add(this.BtnRoom);
            this.sidebar.Controls.Add(this.PanelAppName);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(261, 745);
            this.sidebar.TabIndex = 0;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.customButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.customButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton3.BorderRadius = 0;
            this.customButton3.BorderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(-3, 346);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(261, 50);
            this.customButton3.TabIndex = 4;
            this.customButton3.Text = "Dịch vụ";
            this.customButton3.TextColor = System.Drawing.Color.White;
            this.customButton3.UseVisualStyleBackColor = false;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.customButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.BorderRadius = 0;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(-3, 290);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(261, 50);
            this.customButton2.TabIndex = 4;
            this.customButton2.Text = "Hóa đơn";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 0;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(0, 234);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(261, 50);
            this.customButton1.TabIndex = 3;
            this.customButton1.Text = "Khách hàng";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btnEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btnEmployee.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEmployee.BorderRadius = 0;
            this.btnEmployee.BorderSize = 0;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Location = new System.Drawing.Point(0, 178);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(261, 50);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Text = "Nhân viên";
            this.btnEmployee.TextColor = System.Drawing.Color.White;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // BtnRoom
            // 
            this.BtnRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.BtnRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.BtnRoom.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnRoom.BorderRadius = 0;
            this.BtnRoom.BorderSize = 0;
            this.BtnRoom.FlatAppearance.BorderSize = 0;
            this.BtnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRoom.ForeColor = System.Drawing.Color.White;
            this.BtnRoom.Location = new System.Drawing.Point(-9, 117);
            this.BtnRoom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnRoom.Name = "BtnRoom";
            this.BtnRoom.Size = new System.Drawing.Size(267, 53);
            this.BtnRoom.TabIndex = 1;
            this.BtnRoom.Text = "    Phòng";
            this.BtnRoom.TextColor = System.Drawing.Color.White;
            this.BtnRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRoom.UseVisualStyleBackColor = true;
            this.BtnRoom.Click += new System.EventHandler(this.BtnRoom_Click);
            // 
            // PanelAppName
            // 
            this.PanelAppName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.PanelAppName.Controls.Add(this.label2);
            this.PanelAppName.Controls.Add(this.label1);
            this.PanelAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PanelAppName.Location = new System.Drawing.Point(0, 0);
            this.PanelAppName.Name = "PanelAppName";
            this.PanelAppName.Size = new System.Drawing.Size(261, 83);
            this.PanelAppName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(84, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vinpear";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Khách Sạn";
            // 
            // PanelTittle
            // 
            this.PanelTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(194)))));
            this.PanelTittle.Controls.Add(this.LblTittle);
            this.PanelTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PanelTittle.Location = new System.Drawing.Point(258, 0);
            this.PanelTittle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PanelTittle.Name = "PanelTittle";
            this.PanelTittle.Size = new System.Drawing.Size(1112, 83);
            this.PanelTittle.TabIndex = 1;
            // 
            // LblTittle
            // 
            this.LblTittle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTittle.AutoSize = true;
            this.LblTittle.ForeColor = System.Drawing.Color.White;
            this.LblTittle.Location = new System.Drawing.Point(450, 28);
            this.LblTittle.Name = "LblTittle";
            this.LblTittle.Size = new System.Drawing.Size(0, 25);
            this.LblTittle.TabIndex = 3;
            // 
            // PanelMain
            // 
            this.PanelMain.Location = new System.Drawing.Point(258, 80);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1112, 665);
            this.PanelMain.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 745);
            this.Controls.Add(this.PanelTittle);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.sidebar.ResumeLayout(false);
            this.PanelAppName.ResumeLayout(false);
            this.PanelAppName.PerformLayout();
            this.PanelTittle.ResumeLayout(false);
            this.PanelTittle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel PanelAppName;
        private Components.CustomButton BtnRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelTittle;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Label LblTittle;
        private Components.CustomButton btnEmployee;
        private Components.CustomButton customButton1;
        private Components.CustomButton customButton3;
        private Components.CustomButton customButton2;
        private System.Windows.Forms.Label label2;
    }
}