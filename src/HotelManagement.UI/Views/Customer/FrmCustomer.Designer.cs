
namespace HotelManagement.UI.Views.Customer
{
    partial class FrmCustomer
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
            this.dgrid_customer = new System.Windows.Forms.DataGridView();
            this.txb_search = new HotelManagement.UI.Components.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_customer
            // 
            this.dgrid_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_customer.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgrid_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_customer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_customer.Location = new System.Drawing.Point(0, 318);
            this.dgrid_customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_customer.Name = "dgrid_customer";
            this.dgrid_customer.RowHeadersWidth = 51;
            this.dgrid_customer.RowTemplate.Height = 29;
            this.dgrid_customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_customer.Size = new System.Drawing.Size(1052, 206);
            this.dgrid_customer.TabIndex = 31;
            // 
            // txb_search
            // 
            this.txb_search.Background = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.txb_search.BorderColor = System.Drawing.Color.BlueViolet;
            this.txb_search.BorderRadius = 0;
            this.txb_search.ErrorMessage = null;
            this.txb_search.FocusedColor = System.Drawing.Color.Aqua;
            this.txb_search.IsError = false;
            this.txb_search.Location = new System.Drawing.Point(630, 281);
            this.txb_search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txb_search.Multiline = false;
            this.txb_search.Name = "txb_search";
            this.txb_search.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txb_search.Password = false;
            this.txb_search.PlaceHolder = "Tìm kiếm ở đây";
            this.txb_search.PlaceHolderColor = System.Drawing.Color.WhiteSmoke;
            this.txb_search.Size = new System.Drawing.Size(228, 29);
            this.txb_search.TabIndex = 26;
            this.txb_search.Underline = true;
            this.txb_search._TextChanged += new System.EventHandler(this.txb_search__TextChanged);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(1052, 524);
            this.Controls.Add(this.dgrid_customer);
            this.Controls.Add(this.txb_search);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCustomer";
            this.Text = "Quản lý khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_customer;
        private Components.TextBox txb_search;
    }
}