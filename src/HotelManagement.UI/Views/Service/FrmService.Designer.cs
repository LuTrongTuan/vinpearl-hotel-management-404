
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmService));
            this.dg_DV = new System.Windows.Forms.DataGridView();
            this.btn_seaDV = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.txt_SeaDV = new HotelManagement.UI.Components.TextBox();
            this.txt_DV = new HotelManagement.UI.Components.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_price = new HotelManagement.UI.Components.TextBox();
            this.btn_cl = new System.Windows.Forms.Button();
            this.cmb_LDV = new System.Windows.Forms.ComboBox();
            this.btn_add = new HotelManagement.UI.Components.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_addLDV = new HotelManagement.UI.Components.CustomButton();
            this.btn_CLLDV = new System.Windows.Forms.Button();
            this.btn_SeaLDV = new System.Windows.Forms.Button();
            this.dg_LDVview = new System.Windows.Forms.DataGridView();
            this.lbl_LDV = new System.Windows.Forms.Label();
            this.txt_SeaLDV = new HotelManagement.UI.Components.TextBox();
            this.txt_LDV = new HotelManagement.UI.Components.TextBox();
            this.TbxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_LDVview)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_DV
            // 
            this.dg_DV.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dg_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_DV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dg_DV.Location = new System.Drawing.Point(0, 348);
            this.dg_DV.Name = "dg_DV";
            this.dg_DV.RowHeadersWidth = 51;
            this.dg_DV.RowTemplate.Height = 29;
            this.dg_DV.Size = new System.Drawing.Size(574, 227);
            this.dg_DV.TabIndex = 25;
            this.dg_DV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_DV_CellClick);
            // 
            // btn_seaDV
            // 
            this.btn_seaDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_seaDV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_seaDV.Location = new System.Drawing.Point(364, 290);
            this.btn_seaDV.Name = "btn_seaDV";
            this.btn_seaDV.Size = new System.Drawing.Size(108, 37);
            this.btn_seaDV.TabIndex = 18;
            this.btn_seaDV.Text = "Search";
            this.btn_seaDV.UseVisualStyleBackColor = false;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sua.Location = new System.Drawing.Point(217, 215);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(108, 37);
            this.btn_sua.TabIndex = 17;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // txt_SeaDV
            // 
            this.txt_SeaDV.BorderColor = System.Drawing.Color.BlueViolet;
            this.txt_SeaDV.BorderRadius = 0;
            this.txt_SeaDV.ErrorMessage = null;
            this.txt_SeaDV.FocusedColor = System.Drawing.Color.Aqua;
            this.txt_SeaDV.IsError = false;
            this.txt_SeaDV.Location = new System.Drawing.Point(87, 290);
            this.txt_SeaDV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SeaDV.Multiline = false;
            this.txt_SeaDV.Name = "txt_SeaDV";
            this.txt_SeaDV.Padding = new System.Windows.Forms.Padding(7);
            this.txt_SeaDV.Password = false;
            this.txt_SeaDV.PlaceHolder = null;
            this.txt_SeaDV.Size = new System.Drawing.Size(254, 37);
            this.txt_SeaDV.TabIndex = 15;
            this.txt_SeaDV.Underline = false;
            this.txt_SeaDV._TextChanged += new System.EventHandler(this.txt_SeaDV__TextChanged);
            this.txt_SeaDV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SeaDV_KeyDown);
            this.txt_SeaDV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_SeaDV_KeyUp);
            // 
            // txt_DV
            // 
            this.txt_DV.BorderColor = System.Drawing.Color.BlueViolet;
            this.txt_DV.BorderRadius = 0;
            this.txt_DV.ErrorMessage = null;
            this.txt_DV.FocusedColor = System.Drawing.Color.Aqua;
            this.txt_DV.IsError = false;
            this.txt_DV.Location = new System.Drawing.Point(217, 77);
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
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(87, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "Giá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(87, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tên dịch vụ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(87, 32);
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
            this.txt_price.Location = new System.Drawing.Point(217, 132);
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
            this.btn_cl.Location = new System.Drawing.Point(366, 216);
            this.btn_cl.Name = "btn_cl";
            this.btn_cl.Size = new System.Drawing.Size(108, 37);
            this.btn_cl.TabIndex = 19;
            this.btn_cl.Text = "Clear";
            this.btn_cl.UseVisualStyleBackColor = false;
            // 
            // cmb_LDV
            // 
            this.cmb_LDV.FormattingEnabled = true;
            this.cmb_LDV.Location = new System.Drawing.Point(217, 27);
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
            this.btn_add.Location = new System.Drawing.Point(78, 216);
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
            this.panel1.BackgroundImage = global::HotelManagement.UI.Properties.Resources.z2914805628131_5fbbb0b306b67de840cab4412b5fc185;
            this.panel1.Controls.Add(this.cmb_LDV);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_cl);
            this.panel1.Controls.Add(this.btn_seaDV);
            this.panel1.Controls.Add(this.btn_sua);
            this.panel1.Controls.Add(this.dg_DV);
            this.panel1.Controls.Add(this.txt_SeaDV);
            this.panel1.Controls.Add(this.txt_DV);
            this.panel1.Controls.Add(this.txt_price);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 575);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::HotelManagement.UI.Properties.Resources.z2914805628131_5fbbb0b306b67de840cab4412b5fc185;
            this.panel2.Controls.Add(this.btn_addLDV);
            this.panel2.Controls.Add(this.btn_CLLDV);
            this.panel2.Controls.Add(this.btn_SeaLDV);
            this.panel2.Controls.Add(this.dg_LDVview);
            this.panel2.Controls.Add(this.lbl_LDV);
            this.panel2.Controls.Add(this.txt_SeaLDV);
            this.panel2.Controls.Add(this.txt_LDV);
            this.panel2.Location = new System.Drawing.Point(605, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 412);
            this.panel2.TabIndex = 29;
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
            this.btn_addLDV.Location = new System.Drawing.Point(25, 100);
            this.btn_addLDV.Name = "btn_addLDV";
            this.btn_addLDV.Size = new System.Drawing.Size(108, 37);
            this.btn_addLDV.TabIndex = 27;
            this.btn_addLDV.Text = "Thêm";
            this.btn_addLDV.TextColor = System.Drawing.SystemColors.ControlText;
            this.btn_addLDV.UseVisualStyleBackColor = false;
            this.btn_addLDV.Click += new System.EventHandler(this.btn_addLDV_Click);
            // 
            // btn_CLLDV
            // 
            this.btn_CLLDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_CLLDV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CLLDV.Location = new System.Drawing.Point(407, 186);
            this.btn_CLLDV.Name = "btn_CLLDV";
            this.btn_CLLDV.Size = new System.Drawing.Size(108, 37);
            this.btn_CLLDV.TabIndex = 19;
            this.btn_CLLDV.Text = "Clear";
            this.btn_CLLDV.UseVisualStyleBackColor = false;
            // 
            // btn_SeaLDV
            // 
            this.btn_SeaLDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_SeaLDV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SeaLDV.Location = new System.Drawing.Point(286, 186);
            this.btn_SeaLDV.Name = "btn_SeaLDV";
            this.btn_SeaLDV.Size = new System.Drawing.Size(108, 37);
            this.btn_SeaLDV.TabIndex = 18;
            this.btn_SeaLDV.Text = "Search";
            this.btn_SeaLDV.UseVisualStyleBackColor = false;
            // 
            // dg_LDVview
            // 
            this.dg_LDVview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_LDVview.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dg_LDVview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_LDVview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dg_LDVview.Location = new System.Drawing.Point(0, 236);
            this.dg_LDVview.Name = "dg_LDVview";
            this.dg_LDVview.RowHeadersWidth = 51;
            this.dg_LDVview.RowTemplate.Height = 29;
            this.dg_LDVview.Size = new System.Drawing.Size(520, 176);
            this.dg_LDVview.TabIndex = 25;
            // 
            // lbl_LDV
            // 
            this.lbl_LDV.AutoSize = true;
            this.lbl_LDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_LDV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_LDV.Location = new System.Drawing.Point(182, 32);
            this.lbl_LDV.Name = "lbl_LDV";
            this.lbl_LDV.Size = new System.Drawing.Size(106, 23);
            this.lbl_LDV.TabIndex = 9;
            this.lbl_LDV.Text = "Loại dịch vụ";
            // 
            // txt_SeaLDV
            // 
            this.txt_SeaLDV.BorderColor = System.Drawing.Color.BlueViolet;
            this.txt_SeaLDV.BorderRadius = 0;
            this.txt_SeaLDV.ErrorMessage = null;
            this.txt_SeaLDV.FocusedColor = System.Drawing.Color.Aqua;
            this.txt_SeaLDV.IsError = false;
            this.txt_SeaLDV.Location = new System.Drawing.Point(25, 186);
            this.txt_SeaLDV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SeaLDV.Multiline = false;
            this.txt_SeaLDV.Name = "txt_SeaLDV";
            this.txt_SeaLDV.Padding = new System.Windows.Forms.Padding(7);
            this.txt_SeaLDV.Password = false;
            this.txt_SeaLDV.PlaceHolder = null;
            this.txt_SeaLDV.Size = new System.Drawing.Size(254, 37);
            this.txt_SeaLDV.TabIndex = 15;
            this.txt_SeaLDV.Underline = false;
            // 
            // txt_LDV
            // 
            this.txt_LDV.BorderColor = System.Drawing.Color.BlueViolet;
            this.txt_LDV.BorderRadius = 0;
            this.txt_LDV.ErrorMessage = null;
            this.txt_LDV.FocusedColor = System.Drawing.Color.Aqua;
            this.txt_LDV.IsError = false;
            this.txt_LDV.Location = new System.Drawing.Point(170, 100);
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
            // TbxSearch
            // 
            this.TbxSearch.Location = new System.Drawing.Point(714, 447);
            this.TbxSearch.Name = "TbxSearch";
            this.TbxSearch.Size = new System.Drawing.Size(125, 27);
            this.TbxSearch.TabIndex = 30;
            this.TbxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // FrmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1132, 590);
<<<<<<< HEAD
            this.Controls.Add(this.TbxSearch);
=======
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
>>>>>>> aedac2ca5c67e726997c273c90795f72400a38a3
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmService";
            this.Text = "Quản lý dịch vụ";
            ((System.ComponentModel.ISupportInitialize)(this.dg_DV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_LDVview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.DataGridView dg_DV;
        private System.Windows.Forms.Button btn_seaDV;
        private System.Windows.Forms.Button btn_sua;
        private Components.TextBox txt_SeaDV;
        private Components.TextBox txt_DV;
        private Components.TextBox txt_price;
        private System.Windows.Forms.Button btn_cl;
        private System.Windows.Forms.ComboBox cmb_LDV;
        private Components.CustomButton btn_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Components.CustomButton btn_addLDV;
        private System.Windows.Forms.Button btn_CLLDV;
        private System.Windows.Forms.Button btn_SeaLDV;
        private System.Windows.Forms.DataGridView dg_LDVview;
        private System.Windows.Forms.Label lbl_LDV;
        private Components.TextBox txt_SeaLDV;
        private Components.TextBox txt_LDV;
<<<<<<< HEAD
        private System.Windows.Forms.TextBox TbxSearch;
=======

>>>>>>> aedac2ca5c67e726997c273c90795f72400a38a3
    }
}