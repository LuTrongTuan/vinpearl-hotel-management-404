
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
            this.BtnRoom = new HotelManagement.UI.Components.CustomButton();
            this.PanelAppName = new System.Windows.Forms.Panel();
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
            this.sidebar.Controls.Add(this.BtnRoom);
            this.sidebar.Controls.Add(this.PanelAppName);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(228, 559);
            this.sidebar.TabIndex = 0;
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
            this.BtnRoom.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRoom.ForeColor = System.Drawing.Color.White;
            this.BtnRoom.Location = new System.Drawing.Point(0, 88);
            this.BtnRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnRoom.Name = "BtnRoom";
            this.BtnRoom.Size = new System.Drawing.Size(228, 40);
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
            this.PanelAppName.Controls.Add(this.label1);
            this.PanelAppName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PanelAppName.Location = new System.Drawing.Point(0, 0);
            this.PanelAppName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelAppName.Name = "PanelAppName";
            this.PanelAppName.Size = new System.Drawing.Size(228, 62);
            this.PanelAppName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Khách Sạn";
            // 
            // PanelTittle
            // 
            this.PanelTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(194)))));
            this.PanelTittle.Controls.Add(this.LblTittle);
            this.PanelTittle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PanelTittle.Location = new System.Drawing.Point(226, 0);
            this.PanelTittle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelTittle.Name = "PanelTittle";
            this.PanelTittle.Size = new System.Drawing.Size(973, 62);
            this.PanelTittle.TabIndex = 1;
            // 
            // LblTittle
            // 
            this.LblTittle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTittle.AutoSize = true;
            this.LblTittle.ForeColor = System.Drawing.Color.White;
            this.LblTittle.Location = new System.Drawing.Point(394, 21);
            this.LblTittle.Name = "LblTittle";
            this.LblTittle.Size = new System.Drawing.Size(0, 19);
            this.LblTittle.TabIndex = 3;
            // 
            // PanelMain
            // 
            this.PanelMain.Location = new System.Drawing.Point(230, 68);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(969, 491);
            this.PanelMain.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 559);
            this.Controls.Add(this.PanelTittle);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}