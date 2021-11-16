
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
            this.customButton1 = new HotelManagement.UI.Components.CustomButton();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.BtnRefresh = new HotelManagement.UI.Components.CustomButton();
            this.TbxSearch = new System.Windows.Forms.TextBox();
            this.customButton2 = new HotelManagement.UI.Components.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // customButton1
            // 
            this.customButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.customButton1.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.customButton1.BorderColor = System.Drawing.Color.CadetBlue;
            this.customButton1.BorderRadius = 5;
            this.customButton1.BorderSize = 1;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(406, 24);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(188, 50);
            this.customButton1.TabIndex = 1;
            this.customButton1.Text = "Tạo Phòng";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // PanelContainer
            // 
            this.PanelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContainer.AutoScroll = true;
            this.PanelContainer.Location = new System.Drawing.Point(0, 135);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(883, 335);
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
            this.BtnRefresh.Location = new System.Drawing.Point(338, 24);
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
            // customButton2
            // 
            this.customButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton2.BackColor = System.Drawing.Color.DeepPink;
            this.customButton2.BackgroundColor = System.Drawing.Color.DeepPink;
            this.customButton2.BorderColor = System.Drawing.Color.HotPink;
            this.customButton2.BorderRadius = 5;
            this.customButton2.BorderSize = 1;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(648, 24);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(188, 50);
            this.customButton2.TabIndex = 8;
            this.customButton2.Text = "Sửa Phòng";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
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
            // FrmMainRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.TbxSearch);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.customButton1);
            this.Name = "FrmMainRoom";
            this.Text = "Quản lý Phòng";
            this.Load += new System.EventHandler(this.FrmMainRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Components.CustomButton customButton1;
        private System.Windows.Forms.Panel PanelContainer;
        private Components.CustomButton BtnRefresh;
        private System.Windows.Forms.TextBox TbxSearch;
        private Components.CustomButton customButton2;
        private System.Windows.Forms.Label label1;
    }
}