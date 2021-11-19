
namespace HotelManagement.UI.Views.Login
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txb_username = new HotelManagement.UI.Components.TextBox();
            this.btn_login = new HotelManagement.UI.Components.CustomButton();
            this.btn_exit = new HotelManagement.UI.Components.CustomButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.llb_quenmk = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_password = new HotelManagement.UI.Components.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_username
            // 
            this.txb_username.BorderColor = System.Drawing.Color.BlueViolet;
            this.txb_username.BorderRadius = 15;
            this.txb_username.ErrorMessage = null;
            this.txb_username.FocusedColor = System.Drawing.Color.Aqua;
            this.txb_username.IsError = false;
            this.txb_username.Location = new System.Drawing.Point(186, 117);
            this.txb_username.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txb_username.Multiline = false;
            this.txb_username.Name = "txb_username";
            this.txb_username.Padding = new System.Windows.Forms.Padding(7);
            this.txb_username.Password = false;
            this.txb_username.PlaceHolder = "Username";
            this.txb_username.Size = new System.Drawing.Size(309, 37);
            this.txb_username.TabIndex = 1;
            this.txb_username.Underline = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Green;
            this.btn_login.BackgroundColor = System.Drawing.Color.Green;
            this.btn_login.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_login.BorderRadius = 20;
            this.btn_login.BorderSize = 0;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_login.Location = new System.Drawing.Point(185, 259);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(309, 49);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.TextColor = System.Drawing.SystemColors.ControlText;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_login_KeyDown);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Green;
            this.btn_exit.BackgroundColor = System.Drawing.Color.Green;
            this.btn_exit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_exit.BorderRadius = 15;
            this.btn_exit.BorderSize = 0;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_exit.Location = new System.Drawing.Point(185, 327);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(309, 49);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.TextColor = System.Drawing.SystemColors.ControlText;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // llb_quenmk
            // 
            this.llb_quenmk.AutoSize = true;
            this.llb_quenmk.BackColor = System.Drawing.SystemColors.Control;
            this.llb_quenmk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.llb_quenmk.LinkColor = System.Drawing.SystemColors.InfoText;
            this.llb_quenmk.Location = new System.Drawing.Point(357, 212);
            this.llb_quenmk.Name = "llb_quenmk";
            this.llb_quenmk.Size = new System.Drawing.Size(138, 20);
            this.llb_quenmk.TabIndex = 5;
            this.llb_quenmk.TabStop = true;
            this.llb_quenmk.Text = "Forgot Password ?";
            this.llb_quenmk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_quenmk_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(265, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "User Login";
            // 
            // txb_password
            // 
            this.txb_password.BorderColor = System.Drawing.Color.BlueViolet;
            this.txb_password.BorderRadius = 15;
            this.txb_password.ErrorMessage = null;
            this.txb_password.FocusedColor = System.Drawing.Color.Aqua;
            this.txb_password.IsError = false;
            this.txb_password.Location = new System.Drawing.Point(186, 171);
            this.txb_password.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txb_password.Multiline = false;
            this.txb_password.Name = "txb_password";
            this.txb_password.Padding = new System.Windows.Forms.Padding(7);
            this.txb_password.Password = true;
            this.txb_password.PlaceHolder = "Password";
            this.txb_password.Size = new System.Drawing.Size(309, 37);
            this.txb_password.TabIndex = 2;
            this.txb_password.Underline = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(531, 425);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llb_quenmk);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txb_username);
            this.DoubleBuffered = true;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Components.TextBox txb_username;
        private Components.CustomButton btn_login;
        private Components.CustomButton btn_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel llb_quenmk;
        private System.Windows.Forms.Label label1;
        private Components.TextBox txb_password;
    }
}