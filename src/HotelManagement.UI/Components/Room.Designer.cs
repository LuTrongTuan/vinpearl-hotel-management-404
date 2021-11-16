
namespace HotelManagement.UI.Components
{
    partial class Room
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblRoomName = new System.Windows.Forms.Label();
            this.Icon = new System.Windows.Forms.PictureBox();
            this.CustomerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRoomName
            // 
            this.LblRoomName.AutoSize = true;
            this.LblRoomName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblRoomName.Location = new System.Drawing.Point(24, 24);
            this.LblRoomName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRoomName.Name = "LblRoomName";
            this.LblRoomName.Size = new System.Drawing.Size(67, 24);
            this.LblRoomName.TabIndex = 0;
            this.LblRoomName.Text = "Phòng";
            // 
            // Icon
            // 
            this.Icon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Icon.Location = new System.Drawing.Point(132, 12);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(50, 53);
            this.Icon.TabIndex = 1;
            this.Icon.TabStop = false;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(19, 68);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(64, 24);
            this.CustomerName.TabIndex = 2;
            this.CustomerName.Text = "label1";
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.Icon);
            this.Controls.Add(this.LblRoomName);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Room";
            this.Size = new System.Drawing.Size(195, 102);
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRoomName;
        private System.Windows.Forms.PictureBox Icon;
        private System.Windows.Forms.Label CustomerName;
    }
}
