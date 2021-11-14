
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
            this.TbxName = new HotelManagement.UI.Components.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxActive = new System.Windows.Forms.CheckBox();
            this.CbxDeactive = new System.Windows.Forms.CheckBox();
            this.BtnSave = new HotelManagement.UI.Components.CustomButton();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.CbxToUp = new System.Windows.Forms.CheckBox();
            this.BtnRefresh = new HotelManagement.UI.Components.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TbxName
            // 
            this.TbxName.BorderColor = System.Drawing.Color.Silver;
            this.TbxName.BorderRadius = 5;
            this.TbxName.ErrorMessage = null;
            this.TbxName.FocusedColor = System.Drawing.Color.LightSeaGreen;
            this.TbxName.IsError = false;
            this.TbxName.Location = new System.Drawing.Point(260, 33);
            this.TbxName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TbxName.Multiline = false;
            this.TbxName.Name = "TbxName";
            this.TbxName.Padding = new System.Windows.Forms.Padding(7);
            this.TbxName.Password = false;
            this.TbxName.PlaceHolder = "";
            this.TbxName.Size = new System.Drawing.Size(230, 37);
            this.TbxName.TabIndex = 12;
            this.TbxName.Underline = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(103, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Status:";
            // 
            // CbxActive
            // 
            this.CbxActive.AutoSize = true;
            this.CbxActive.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CbxActive.Location = new System.Drawing.Point(260, 106);
            this.CbxActive.Name = "CbxActive";
            this.CbxActive.Size = new System.Drawing.Size(117, 27);
            this.CbxActive.TabIndex = 17;
            this.CbxActive.Text = "Hoạt Động";
            this.CbxActive.UseVisualStyleBackColor = true;
            this.CbxActive.CheckedChanged += new System.EventHandler(this.CbxActive_CheckedChanged);
            // 
            // CbxDeactive
            // 
            this.CbxDeactive.AutoSize = true;
            this.CbxDeactive.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CbxDeactive.Location = new System.Drawing.Point(453, 106);
            this.CbxDeactive.Name = "CbxDeactive";
            this.CbxDeactive.Size = new System.Drawing.Size(172, 27);
            this.CbxDeactive.TabIndex = 18;
            this.CbxDeactive.Text = "Không Hoạt Động";
            this.CbxDeactive.UseVisualStyleBackColor = true;
            this.CbxDeactive.CheckedChanged += new System.EventHandler(this.CbxDeactive_CheckedChanged);
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
            this.BtnSave.Location = new System.Drawing.Point(831, 50);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(120, 45);
            this.BtnSave.TabIndex = 22;
            this.BtnSave.Text = "Lưu";
            this.BtnSave.TextColor = System.Drawing.Color.White;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // PanelContainer
            // 
            this.PanelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContainer.Location = new System.Drawing.Point(-2284, 229);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1073, 403);
            this.PanelContainer.TabIndex = 23;
            // 
            // CbxToUp
            // 
            this.CbxToUp.AutoSize = true;
            this.CbxToUp.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CbxToUp.Location = new System.Drawing.Point(344, 160);
            this.CbxToUp.Name = "CbxToUp";
            this.CbxToUp.Size = new System.Drawing.Size(146, 27);
            this.CbxToUp.TabIndex = 24;
            this.CbxToUp.Text = "Đang Dọn Dẹp";
            this.CbxToUp.UseVisualStyleBackColor = true;
            this.CbxToUp.CheckedChanged += new System.EventHandler(this.CbxToUp_CheckedChanged);
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
            this.BtnRefresh.Location = new System.Drawing.Point(743, 51);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(48, 45);
            this.BtnRefresh.TabIndex = 25;
            this.BtnRefresh.TextColor = System.Drawing.SystemColors.ControlText;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 292);
            this.panel1.TabIndex = 26;
            // 
            // FrmUpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 667);
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
        private Components.TextBox TbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CbxActive;
        private System.Windows.Forms.CheckBox CbxDeactive;
        private Components.CustomButton BtnSave;
        private Components.CustomButton BtnEditToQueue;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.CheckBox CbxToUp;
        private Components.CustomButton BtnRefresh;
        private System.Windows.Forms.Panel panel1;
    }
}