
namespace HotelManagement.UI.Views.Room
{
    partial class FrmUpdateRoom
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
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxActive = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRefresh = new HotelManagement.UI.Components.CustomButton();
            this.TbxDay = new HotelManagement.UI.Components.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CbxToUp = new System.Windows.Forms.CheckBox();
            this.TbxNight = new HotelManagement.UI.Components.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxName = new HotelManagement.UI.Components.TextBox();
            this.BtnSave = new HotelManagement.UI.Components.CustomButton();
            this.CbxDeactive = new System.Windows.Forms.CheckBox();
            this.TbxHour = new HotelManagement.UI.Components.TextBox();
            this.CbxNameType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // PanelContainer
            // 
            this.PanelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContainer.Location = new System.Drawing.Point(-2284, 229);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(999, 403);
            this.PanelContainer.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 292);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name Room:";
            // 
            // CbxActive
            // 
            this.CbxActive.AutoSize = true;
            this.CbxActive.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CbxActive.Location = new System.Drawing.Point(210, 261);
            this.CbxActive.Name = "CbxActive";
            this.CbxActive.Size = new System.Drawing.Size(117, 27);
            this.CbxActive.TabIndex = 17;
            this.CbxActive.Text = "Hoạt Động";
            this.CbxActive.UseVisualStyleBackColor = true;
            this.CbxActive.CheckedChanged += new System.EventHandler(this.CbxActive_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(508, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Giá Ban Ngày:";
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
            this.BtnRefresh.Location = new System.Drawing.Point(695, 225);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(48, 45);
            this.BtnRefresh.TabIndex = 25;
            this.BtnRefresh.TextColor = System.Drawing.SystemColors.ControlText;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // TbxDay
            // 
            this.TbxDay.BorderColor = System.Drawing.Color.Silver;
            this.TbxDay.BorderRadius = 5;
            this.TbxDay.ErrorMessage = null;
            this.TbxDay.FocusedColor = System.Drawing.Color.LightSeaGreen;
            this.TbxDay.IsError = false;
            this.TbxDay.Location = new System.Drawing.Point(696, 13);
            this.TbxDay.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TbxDay.Multiline = false;
            this.TbxDay.Name = "TbxDay";
            this.TbxDay.Padding = new System.Windows.Forms.Padding(7);
            this.TbxDay.Password = false;
            this.TbxDay.PlaceHolder = "";
            this.TbxDay.Size = new System.Drawing.Size(214, 37);
            this.TbxDay.TabIndex = 32;
            this.TbxDay.Underline = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(508, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "Giá Ban Đêm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(53, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Name Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(53, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Giá Giờ:";
            // 
            // CbxToUp
            // 
            this.CbxToUp.AutoSize = true;
            this.CbxToUp.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CbxToUp.Location = new System.Drawing.Point(294, 315);
            this.CbxToUp.Name = "CbxToUp";
            this.CbxToUp.Size = new System.Drawing.Size(146, 27);
            this.CbxToUp.TabIndex = 24;
            this.CbxToUp.Text = "Đang Dọn Dẹp";
            this.CbxToUp.UseVisualStyleBackColor = true;
            this.CbxToUp.CheckedChanged += new System.EventHandler(this.CbxToUp_CheckedChanged);
            // 
            // TbxNight
            // 
            this.TbxNight.BorderColor = System.Drawing.Color.Silver;
            this.TbxNight.BorderRadius = 5;
            this.TbxNight.ErrorMessage = null;
            this.TbxNight.FocusedColor = System.Drawing.Color.LightSeaGreen;
            this.TbxNight.IsError = false;
            this.TbxNight.Location = new System.Drawing.Point(696, 80);
            this.TbxNight.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TbxNight.Multiline = false;
            this.TbxNight.Name = "TbxNight";
            this.TbxNight.Padding = new System.Windows.Forms.Padding(7);
            this.TbxNight.Password = false;
            this.TbxNight.PlaceHolder = "";
            this.TbxNight.Size = new System.Drawing.Size(214, 37);
            this.TbxNight.TabIndex = 33;
            this.TbxNight.Underline = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(53, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Status:";
            // 
            // TbxName
            // 
            this.TbxName.BorderColor = System.Drawing.Color.Silver;
            this.TbxName.BorderRadius = 5;
            this.TbxName.ErrorMessage = null;
            this.TbxName.FocusedColor = System.Drawing.Color.LightSeaGreen;
            this.TbxName.IsError = false;
            this.TbxName.Location = new System.Drawing.Point(210, 188);
            this.TbxName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TbxName.Multiline = false;
            this.TbxName.Name = "TbxName";
            this.TbxName.Padding = new System.Windows.Forms.Padding(7);
            this.TbxName.Password = false;
            this.TbxName.PlaceHolder = "";
            this.TbxName.Size = new System.Drawing.Size(214, 37);
            this.TbxName.TabIndex = 12;
            this.TbxName.Underline = false;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnSave.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.BtnSave.BorderColor = System.Drawing.Color.SteelBlue;
            this.BtnSave.BorderRadius = 7;
            this.BtnSave.BorderSize = 2;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(766, 225);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(144, 45);
            this.BtnSave.TabIndex = 22;
            this.BtnSave.Text = "Sửa ";
            this.BtnSave.TextColor = System.Drawing.Color.White;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CbxDeactive
            // 
            this.CbxDeactive.AutoSize = true;
            this.CbxDeactive.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CbxDeactive.Location = new System.Drawing.Point(403, 261);
            this.CbxDeactive.Name = "CbxDeactive";
            this.CbxDeactive.Size = new System.Drawing.Size(172, 27);
            this.CbxDeactive.TabIndex = 18;
            this.CbxDeactive.Text = "Không Hoạt Động";
            this.CbxDeactive.UseVisualStyleBackColor = true;
            this.CbxDeactive.CheckedChanged += new System.EventHandler(this.CbxDeactive_CheckedChanged);
            // 
            // TbxHour
            // 
            this.TbxHour.BorderColor = System.Drawing.Color.Silver;
            this.TbxHour.BorderRadius = 5;
            this.TbxHour.ErrorMessage = null;
            this.TbxHour.FocusedColor = System.Drawing.Color.LightSeaGreen;
            this.TbxHour.IsError = false;
            this.TbxHour.Location = new System.Drawing.Point(210, 80);
            this.TbxHour.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TbxHour.Multiline = false;
            this.TbxHour.Name = "TbxHour";
            this.TbxHour.Padding = new System.Windows.Forms.Padding(7);
            this.TbxHour.Password = false;
            this.TbxHour.PlaceHolder = "";
            this.TbxHour.Size = new System.Drawing.Size(214, 37);
            this.TbxHour.TabIndex = 31;
            this.TbxHour.Underline = false;
            // 
            // CbxNameType
            // 
            this.CbxNameType.FormattingEnabled = true;
            this.CbxNameType.Location = new System.Drawing.Point(210, 15);
            this.CbxNameType.Name = "CbxNameType";
            this.CbxNameType.Size = new System.Drawing.Size(214, 28);
            this.CbxNameType.TabIndex = 34;
            // 
            // FrmUpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 667);
            this.Controls.Add(this.CbxNameType);
            this.Controls.Add(this.TbxNight);
            this.Controls.Add(this.TbxDay);
            this.Controls.Add(this.TbxHour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.CbxToUp);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.CbxDeactive);
            this.Controls.Add(this.CbxActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxName);
            this.Name = "FrmUpdateRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUpdateRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Components.CustomButton BtnEditToQueue;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CbxActive;
        private System.Windows.Forms.Label label3;
        private Components.CustomButton BtnRefresh;
        private Components.TextBox TbxDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CbxToUp;
        private Components.TextBox TbxNight;
        private System.Windows.Forms.Label label2;
        private Components.TextBox TbxName;
        private Components.CustomButton BtnSave;
        private System.Windows.Forms.CheckBox CbxDeactive;
        private Components.TextBox TbxHour;
        private System.Windows.Forms.ComboBox CbxNameType;
    }
}