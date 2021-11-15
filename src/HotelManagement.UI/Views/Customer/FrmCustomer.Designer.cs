
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txb_search = new HotelManagement.UI.Components.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 471);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1202, 227);
            this.dataGridView1.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = global::HotelManagement.UI.Properties.Resources.zoom;
            this.button2.Location = new System.Drawing.Point(960, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 44);
            this.button2.TabIndex = 29;
            this.button2.Text = "Search";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txb_search
            // 
            this.txb_search.BorderColor = System.Drawing.Color.BlueViolet;
            this.txb_search.BorderRadius = 0;
            this.txb_search.ErrorMessage = null;
            this.txb_search.FocusedColor = System.Drawing.Color.Aqua;
            this.txb_search.IsError = false;
            this.txb_search.Location = new System.Drawing.Point(683, 375);
            this.txb_search.Margin = new System.Windows.Forms.Padding(4);
            this.txb_search.Multiline = false;
            this.txb_search.Name = "txb_search";
            this.txb_search.Padding = new System.Windows.Forms.Padding(7);
            this.txb_search.Password = false;
            this.txb_search.PlaceHolder = null;
            this.txb_search.Size = new System.Drawing.Size(260, 37);
            this.txb_search.TabIndex = 26;
            this.txb_search.Underline = false;
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(1202, 698);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txb_search);
            this.Name = "FrmCustomer";
            this.Text = "Quản lý khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private Components.TextBox txb_search;
    }
}