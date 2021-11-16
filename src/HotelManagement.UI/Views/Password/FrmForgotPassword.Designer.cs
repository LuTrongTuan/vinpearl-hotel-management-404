
namespace HotelManagement.UI.Views.Password
{
    partial class FrmForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmForgotPassword));
            this.txt_email = new HotelManagement.UI.Components.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customButton1 = new HotelManagement.UI.Components.CustomButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customButton2 = new HotelManagement.UI.Components.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.BorderColor = System.Drawing.Color.BlueViolet;
            this.txt_email.BorderRadius = 10;
            this.txt_email.ErrorMessage = null;
            this.txt_email.FocusedColor = System.Drawing.Color.Aqua;
            this.txt_email.IsError = false;
            this.txt_email.Location = new System.Drawing.Point(67, 252);
            this.txt_email.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_email.Multiline = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.Padding = new System.Windows.Forms.Padding(7);
            this.txt_email.Password = false;
            this.txt_email.PlaceHolder = "Email của bạn";
            this.txt_email.Size = new System.Drawing.Size(363, 37);
            this.txt_email.TabIndex = 0;
            this.txt_email.Underline = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(138, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forgot Password";
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 18;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customButton1.Location = new System.Drawing.Point(154, 308);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(186, 51);
            this.customButton1.TabIndex = 2;
            this.customButton1.Text = "Send mail";
            this.customButton1.TextColor = System.Drawing.SystemColors.ControlText;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(184, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 180);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.customButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.BorderRadius = 18;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customButton2.Location = new System.Drawing.Point(154, 369);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(186, 51);
            this.customButton2.TabIndex = 4;
            this.customButton2.Text = "Trở về";
            this.customButton2.TextColor = System.Drawing.SystemColors.ControlText;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // FrmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(498, 445);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_email);
            this.Name = "FrmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.TextBox txt_email;
        private System.Windows.Forms.Label label1;
        private Components.CustomButton customButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Components.CustomButton customButton2;
    }
}