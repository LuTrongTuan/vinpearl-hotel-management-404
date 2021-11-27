
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSave = new HotelManagement.UI.Components.CustomButton();
            this.CbxDeactive = new System.Windows.Forms.CheckBox();
            this.CbxNameType = new System.Windows.Forms.ComboBox();
            this.TbxDay = new HotelManagement.UI.Components.TextBox();
            this.TbxName = new HotelManagement.UI.Components.TextBox();
            this.TbxHour = new HotelManagement.UI.Components.TextBox();
            this.SuspendLayout();
            // 
            // PanelContainer
            // 
            this.PanelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContainer.Location = new System.Drawing.Point(-2284, 229);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1422, 403);
            this.PanelContainer.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1423, 636);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(696, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name Room:";
            // 
            // CbxActive
            // 
            this.CbxActive.AutoSize = true;
            this.CbxActive.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CbxActive.Location = new System.Drawing.Point(396, 174);
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
            this.label3.Location = new System.Drawing.Point(694, 24);
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
            this.BtnRefresh.Location = new System.Drawing.Point(856, 157);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(48, 45);
            this.BtnRefresh.TabIndex = 25;
            this.BtnRefresh.TextColor = System.Drawing.SystemColors.ControlText;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(239, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Name Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(239, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Giá Giờ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(239, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Status:";
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
            this.BtnSave.Location = new System.Drawing.Point(952, 156);
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
            this.CbxDeactive.Location = new System.Drawing.Point(558, 172);
            this.CbxDeactive.Name = "CbxDeactive";
            this.CbxDeactive.Size = new System.Drawing.Size(172, 27);
            this.CbxDeactive.TabIndex = 18;
            this.CbxDeactive.Text = "Không Hoạt Động";
            this.CbxDeactive.UseVisualStyleBackColor = true;
            this.CbxDeactive.CheckedChanged += new System.EventHandler(this.CbxDeactive_CheckedChanged);
            // 
            // CbxNameType
            // 
            this.CbxNameType.FormattingEnabled = true;
            this.CbxNameType.Location = new System.Drawing.Point(396, 19);
            this.CbxNameType.Name = "CbxNameType";
            this.CbxNameType.Size = new System.Drawing.Size(214, 28);
            this.CbxNameType.TabIndex = 34;
            // 
            // TbxDay
            // 
            this.TbxDay.Background = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.TbxDay.BorderColor = System.Drawing.Color.White;
            this.TbxDay.BorderRadius = 0;
            this.TbxDay.ErrorMessage = null;
            this.TbxDay.FocusedColor = System.Drawing.Color.Aqua;
            this.TbxDay.ForeColor = System.Drawing.Color.White;
            this.TbxDay.IsError = false;
            this.TbxDay.Location = new System.Drawing.Point(882, 10);
            this.TbxDay.Margin = new System.Windows.Forms.Padding(4);
            this.TbxDay.Multiline = false;
            this.TbxDay.Name = "TbxDay";
            this.TbxDay.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.TbxDay.Password = false;
            this.TbxDay.PlaceHolder = "";
            this.TbxDay.PlaceHolderColor = System.Drawing.SystemColors.ScrollBar;
            this.TbxDay.Size = new System.Drawing.Size(214, 37);
            this.TbxDay.TabIndex = 38;
            this.TbxDay.Underline = true;
            // 
            // TbxName
            // 
            this.TbxName.Background = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.TbxName.BorderColor = System.Drawing.Color.White;
            this.TbxName.BorderRadius = 0;
            this.TbxName.ErrorMessage = null;
            this.TbxName.FocusedColor = System.Drawing.Color.Aqua;
            this.TbxName.ForeColor = System.Drawing.Color.White;
            this.TbxName.IsError = false;
            this.TbxName.Location = new System.Drawing.Point(882, 98);
            this.TbxName.Margin = new System.Windows.Forms.Padding(4);
            this.TbxName.Multiline = false;
            this.TbxName.Name = "TbxName";
            this.TbxName.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.TbxName.Password = false;
            this.TbxName.PlaceHolder = "";
            this.TbxName.PlaceHolderColor = System.Drawing.SystemColors.ScrollBar;
            this.TbxName.Size = new System.Drawing.Size(214, 37);
            this.TbxName.TabIndex = 39;
            this.TbxName.Underline = true;
            // 
            // TbxHour
            // 
            this.TbxHour.Background = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.TbxHour.BorderColor = System.Drawing.Color.White;
            this.TbxHour.BorderRadius = 0;
            this.TbxHour.ErrorMessage = null;
            this.TbxHour.FocusedColor = System.Drawing.Color.Aqua;
            this.TbxHour.ForeColor = System.Drawing.Color.White;
            this.TbxHour.IsError = false;
            this.TbxHour.Location = new System.Drawing.Point(396, 98);
            this.TbxHour.Margin = new System.Windows.Forms.Padding(4);
            this.TbxHour.Multiline = false;
            this.TbxHour.Name = "TbxHour";
            this.TbxHour.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.TbxHour.Password = false;
            this.TbxHour.PlaceHolder = "";
            this.TbxHour.PlaceHolderColor = System.Drawing.SystemColors.ScrollBar;
            this.TbxHour.Size = new System.Drawing.Size(214, 37);
            this.TbxHour.TabIndex = 40;
            this.TbxHour.Underline = true;
            // 
            // FrmUpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 901);
            this.Controls.Add(this.TbxHour);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.TbxDay);
            this.Controls.Add(this.CbxNameType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.CbxDeactive);
            this.Controls.Add(this.CbxActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Components.CustomButton BtnSave;
        private System.Windows.Forms.CheckBox CbxDeactive;
        private System.Windows.Forms.ComboBox CbxNameType;
        private Components.TextBox TbxDay;
        private Components.TextBox TbxName;
        private Components.TextBox TbxHour;
    }
}