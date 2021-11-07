
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
            this.SuspendLayout();
            // 
            // LblRoomName
            // 
            this.LblRoomName.AutoSize = true;
            this.LblRoomName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblRoomName.Location = new System.Drawing.Point(57, 27);
            this.LblRoomName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRoomName.Name = "LblRoomName";
            this.LblRoomName.Size = new System.Drawing.Size(55, 19);
            this.LblRoomName.TabIndex = 0;
            this.LblRoomName.Text = "Phòng";
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblRoomName);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Room";
            this.Size = new System.Drawing.Size(170, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRoomName;
    }
}
