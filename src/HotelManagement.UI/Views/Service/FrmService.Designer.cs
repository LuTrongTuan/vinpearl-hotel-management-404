
namespace HotelManagement.UI.Views.Service
{
    partial class FrmService
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
            this.dg_DV = new System.Windows.Forms.DataGridView();
            this.btn_seaDV = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.txt_DV = new HotelManagement.UI.Components.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_price = new HotelManagement.UI.Components.TextBox();
            this.btn_cl = new System.Windows.Forms.Button();
            this.cmb_LDV = new System.Windows.Forms.ComboBox();
            this.btn_add = new HotelManagement.UI.Components.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_addLDV = new HotelManagement.UI.Components.CustomButton();
            this.TbxSearch = new System.Windows.Forms.TextBox();
            this.txt_LDV = new HotelManagement.UI.Components.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_DV
            // 
            this.dg_DV.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dg_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_DV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dg_DV.Location = new System.Drawing.Point(0, 392);
            this.dg_DV.Name = "dg_DV";
            this.dg_DV.RowHeadersWidth = 51;
            this.dg_DV.RowTemplate.Height = 29;
            this.dg_DV.Size = new System.Drawing.Size(1132, 218);
            this.dg_DV.TabIndex = 25;
            this.dg_DV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_DV_CellClick);
            // 
            // btn_seaDV
            // 
            this.btn_seaDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_seaDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_seaDV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_seaDV.Image = global::HotelManagement.UI.Properties.Resources.zoom;
            this.btn_seaDV.Location = new System.Drawing.Point(668, 338);
            this.btn_seaDV.Name = "btn_seaDV";
            this.btn_seaDV.Size = new System.Drawing.Size(122, 37);
            this.btn_seaDV.TabIndex = 18;
            this.btn_seaDV.Text = "Search";
            this.btn_seaDV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_seaDV.UseVisualStyleBackColor = false;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sua.Location = new System.Drawing.Point(533, 244);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(108, 37);
            this.btn_sua.TabIndex = 17;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // txt_DV
            // 
            this.txt_DV.BorderColor = System.Drawing.Color.BlueViolet;
            this.txt_DV.BorderRadius = 0;
            this.txt_DV.ErrorMessage = null;
            this.txt_DV.FocusedColor = System.Drawing.Color.Aqua;
            this.txt_DV.IsError = false;
            this.txt_DV.Location = new System.Drawing.Point(267, 91);
            this.txt_DV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DV.Multiline = false;
            this.txt_DV.Name = "txt_DV";
            this.txt_DV.Padding = new System.Windows.Forms.Padding(7);
            this.txt_DV.Password = false;
            this.txt_DV.PlaceHolder = null;
            this.txt_DV.Size = new System.Drawing.Size(255, 37);
            this.txt_DV.TabIndex = 14;
            this.txt_DV.Underline = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(138, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "Giá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(138, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tên dịch vụ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(138, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Loại dịch vụ";
            // 
            // txt_price
            // 
            this.txt_price.BorderColor = System.Drawing.Color.BlueViolet;
            this.txt_price.BorderRadius = 0;
            this.txt_price.ErrorMessage = null;
            this.txt_price.FocusedColor = System.Drawing.Color.Aqua;
            this.txt_price.IsError = false;
            this.txt_price.Location = new System.Drawing.Point(267, 146);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_price.Multiline = false;
            this.txt_price.Name = "txt_price";
            this.txt_price.Padding = new System.Windows.Forms.Padding(7);
            this.txt_price.Password = false;
            this.txt_price.PlaceHolder = null;
            this.txt_price.Size = new System.Drawing.Size(255, 37);
            this.txt_price.TabIndex = 14;
            this.txt_price.Underline = false;
            // 
            // btn_cl
            // 
            this.btn_cl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_cl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cl.Location = new System.Drawing.Point(682, 245);
            this.btn_cl.Name = "btn_cl";
            this.btn_cl.Size = new System.Drawing.Size(108, 37);
            this.btn_cl.TabIndex = 19;
            this.btn_cl.Text = "Clear";
            this.btn_cl.UseVisualStyleBackColor = false;
            // 
            // cmb_LDV
            // 
            this.cmb_LDV.FormattingEnabled = true;
            this.cmb_LDV.Location = new System.Drawing.Point(267, 41);
            this.cmb_LDV.Name = "cmb_LDV";
            this.cmb_LDV.Size = new System.Drawing.Size(255, 28);
            this.cmb_LDV.TabIndex = 26;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_add.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_add.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_add.BorderRadius = 0;
            this.btn_add.BorderSize = 0;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add.Location = new System.Drawing.Point(394, 245);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(108, 37);
            this.btn_add.TabIndex = 27;
            this.btn_add.Text = "Thêm";
            this.btn_add.TextColor = System.Drawing.SystemColors.ControlText;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btn_addLDV);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TbxSearch);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmb_LDV);
            this.panel1.Controls.Add(this.txt_LDV);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_cl);
            this.panel1.Controls.Add(this.btn_seaDV);
            this.panel1.Controls.Add(this.btn_sua);
            this.panel1.Controls.Add(this.dg_DV);
            this.panel1.Controls.Add(this.txt_DV);
            this.panel1.Controls.Add(this.txt_price);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 610);
            this.panel1.TabIndex = 28;
            // 
            // btn_addLDV
            // 
            this.btn_addLDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_addLDV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_addLDV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_addLDV.BorderRadius = 0;
            this.btn_addLDV.BorderSize = 0;
            this.btn_addLDV.FlatAppearance.BorderSize = 0;
            this.btn_addLDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addLDV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_addLDV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_addLDV.Image = global::HotelManagement.UI.Properties.Resources.plus;
            this.btn_addLDV.Location = new System.Drawing.Point(948, 32);
            this.btn_addLDV.Name = "btn_addLDV";
            this.btn_addLDV.Size = new System.Drawing.Size(172, 37);
            this.btn_addLDV.TabIndex = 27;
            this.btn_addLDV.Text = "Thêm loại dịch vụ";
            this.btn_addLDV.TextColor = System.Drawing.SystemColors.ControlText;
            this.btn_addLDV.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_addLDV.UseVisualStyleBackColor = false;
            this.btn_addLDV.Click += new System.EventHandler(this.btn_addLDV_Click);
            // 
            // TbxSearch
            // 
            this.TbxSearch.Location = new System.Drawing.Point(404, 338);
            this.TbxSearch.Multiline = true;
            this.TbxSearch.Name = "TbxSearch";
            this.TbxSearch.Size = new System.Drawing.Size(247, 37);
            this.TbxSearch.TabIndex = 30;
            this.TbxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // txt_LDV
            // 
            this.txt_LDV.BorderColor = System.Drawing.Color.BlueViolet;
            this.txt_LDV.BorderRadius = 0;
            this.txt_LDV.ErrorMessage = null;
            this.txt_LDV.FocusedColor = System.Drawing.Color.Aqua;
            this.txt_LDV.IsError = false;
            this.txt_LDV.Location = new System.Drawing.Point(667, 32);
            this.txt_LDV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LDV.Multiline = false;
            this.txt_LDV.Name = "txt_LDV";
            this.txt_LDV.Padding = new System.Windows.Forms.Padding(7);
            this.txt_LDV.Password = false;
            this.txt_LDV.PlaceHolder = null;
            this.txt_LDV.Size = new System.Drawing.Size(255, 37);
            this.txt_LDV.TabIndex = 14;
            this.txt_LDV.Underline = false;
            // 
            // FrmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1132, 610);
            this.Controls.Add(this.panel1);
            this.Name = "FrmService";
            this.Text = "Quản lý dịch vụ";
            ((System.ComponentModel.ISupportInitialize)(this.dg_DV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.DataGridView dg_DV;
        private System.Windows.Forms.Button btn_seaDV;
        private System.Windows.Forms.Button btn_sua;
        private Components.TextBox txt_DV;
        private Components.TextBox txt_price;
        private System.Windows.Forms.Button btn_cl;
        private System.Windows.Forms.ComboBox cmb_LDV;
        private Components.CustomButton btn_add;
        private System.Windows.Forms.Panel panel1;
        private Components.CustomButton btn_addLDV;
        private Components.TextBox txt_LDV;
        private System.Windows.Forms.TextBox TbxSearch;
    }
}