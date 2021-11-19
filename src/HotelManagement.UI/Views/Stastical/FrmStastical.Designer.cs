
namespace HotelManagement.UI.Views.Check
{
    partial class FrmStastical
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
            this.statisCustomer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_tang = new System.Windows.Forms.ComboBox();
            this.dg_tkp = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataCustomer = new System.Windows.Forms.DataGridView();
            this.statisCustomer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_tkp)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // statisCustomer
            // 
            this.statisCustomer.Controls.Add(this.tabPage1);
            this.statisCustomer.Controls.Add(this.tabPage2);
            this.statisCustomer.Location = new System.Drawing.Point(12, 12);
            this.statisCustomer.Name = "statisCustomer";
            this.statisCustomer.SelectedIndex = 0;
            this.statisCustomer.Size = new System.Drawing.Size(854, 426);
            this.statisCustomer.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmb_tang);
            this.tabPage1.Controls.Add(this.dg_tkp);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(846, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thống kê phòng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tầng :";
            // 
            // cmb_tang
            // 
            this.cmb_tang.FormattingEnabled = true;
            this.cmb_tang.Location = new System.Drawing.Point(672, 36);
            this.cmb_tang.Name = "cmb_tang";
            this.cmb_tang.Size = new System.Drawing.Size(151, 28);
            this.cmb_tang.TabIndex = 1;
            // 
            // dg_tkp
            // 
            this.dg_tkp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_tkp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dg_tkp.Location = new System.Drawing.Point(3, 101);
            this.dg_tkp.Name = "dg_tkp";
            this.dg_tkp.RowHeadersWidth = 51;
            this.dg_tkp.RowTemplate.Height = 29;
            this.dg_tkp.Size = new System.Drawing.Size(840, 289);
            this.dg_tkp.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataCustomer);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(846, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kê khách hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataCustomer
            // 
            this.dataCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCustomer.Location = new System.Drawing.Point(3, 92);
            this.dataCustomer.Name = "dataCustomer";
            this.dataCustomer.RowHeadersWidth = 51;
            this.dataCustomer.RowTemplate.Height = 29;
            this.dataCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCustomer.Size = new System.Drawing.Size(840, 298);
            this.dataCustomer.TabIndex = 0;
            // 
            // FrmStastical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.statisCustomer);
            this.Name = "FrmStastical";
            this.Text = "Thống kê";
            this.statisCustomer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_tkp)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl statisCustomer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dg_tkp;
        private System.Windows.Forms.DataGridView dataCustomer;
        private System.Windows.Forms.ComboBox cmb_tang;
        private System.Windows.Forms.Label label1;
    }
}