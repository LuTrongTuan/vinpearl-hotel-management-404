
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
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRoomName
            // 
            this.LblRoomName.AutoSize = true;
            this.LblRoomName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblRoomName.Location = new System.Drawing.Point(23, 24);
            this.LblRoomName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRoomName.Name = "LblRoomName";
            this.LblRoomName.Size = new System.Drawing.Size(67, 24);
            this.LblRoomName.TabIndex = 0;
            this.LblRoomName.Text = "Phòng";
            // 
            // Icon
            // 
            this.Icon.Location = new System.Drawing.Point(121, 16);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(38, 39);
            this.Icon.TabIndex = 1;
            this.Icon.TabStop = false;
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Icon);
            this.Controls.Add(this.LblRoomName);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Room";
            this.Size = new System.Drawing.Size(170, 70);
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRoomName;
        private System.Windows.Forms.PictureBox Icon;
    }
}
