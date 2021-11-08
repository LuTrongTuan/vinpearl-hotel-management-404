
namespace HotelManagement.UI.Views.Room
{
    partial class FrmUpdateRoom
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
            this.TbxName = new HotelManagement.UI.Components.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxActive = new System.Windows.Forms.CheckBox();
            this.CbxDeactive = new System.Windows.Forms.CheckBox();
            this.BtnSave = new HotelManagement.UI.Components.CustomButton();
            this.BtnEditToQueue = new HotelManagement.UI.Components.CustomButton();
            this.SuspendLayout();
            // 
            // TbxName
            // 
            this.TbxName.BorderColor = System.Drawing.Color.Silver;
            this.TbxName.BorderRadius = 5;
            this.TbxName.ErrorMessage = null;
            this.TbxName.FocusedColor = System.Drawing.Color.LightSeaGreen;
            this.TbxName.IsError = false;
            this.TbxName.Location = new System.Drawing.Point(126, 23);
            this.TbxName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TbxName.Multiline = false;
            this.TbxName.Name = "TbxName";
            this.TbxName.Padding = new System.Windows.Forms.Padding(7);
            this.TbxName.Password = false;
            this.TbxName.PlaceHolder = "";
            this.TbxName.Size = new System.Drawing.Size(230, 37);
            this.TbxName.TabIndex = 12;
            this.TbxName.Underline = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name";
            // 
            // CbxActive
            // 
            this.CbxActive.AutoSize = true;
            this.CbxActive.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CbxActive.Location = new System.Drawing.Point(126, 125);
            this.CbxActive.Name = "CbxActive";
            this.CbxActive.Size = new System.Drawing.Size(117, 27);
            this.CbxActive.TabIndex = 17;
            this.CbxActive.Text = "Hoạt Động";
            this.CbxActive.UseVisualStyleBackColor = true;
            // 
            // CbxDeactive
            // 
            this.CbxDeactive.AutoSize = true;
            this.CbxDeactive.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CbxDeactive.Location = new System.Drawing.Point(300, 123);
            this.CbxDeactive.Name = "CbxDeactive";
            this.CbxDeactive.Size = new System.Drawing.Size(172, 27);
            this.CbxDeactive.TabIndex = 18;
            this.CbxDeactive.Text = "Không Hoạt Động";
            this.CbxDeactive.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnSave.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.BtnSave.BorderColor = System.Drawing.Color.SteelBlue;
            this.BtnSave.BorderRadius = 7;
            this.BtnSave.BorderSize = 2;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(557, 101);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(120, 45);
            this.BtnSave.TabIndex = 22;
            this.BtnSave.Text = "Lưu";
            this.BtnSave.TextColor = System.Drawing.Color.White;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnEditToQueue
            // 
            this.BtnEditToQueue.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnEditToQueue.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.BtnEditToQueue.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.BtnEditToQueue.BorderRadius = 7;
            this.BtnEditToQueue.BorderSize = 2;
            this.BtnEditToQueue.FlatAppearance.BorderSize = 0;
            this.BtnEditToQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditToQueue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditToQueue.ForeColor = System.Drawing.Color.White;
            this.BtnEditToQueue.Location = new System.Drawing.Point(557, 15);
            this.BtnEditToQueue.Name = "BtnEditToQueue";
            this.BtnEditToQueue.Size = new System.Drawing.Size(120, 45);
            this.BtnEditToQueue.TabIndex = 19;
            this.BtnEditToQueue.Text = "Sửa Phòng";
            this.BtnEditToQueue.TextColor = System.Drawing.Color.White;
            this.BtnEditToQueue.UseVisualStyleBackColor = false;
            this.BtnEditToQueue.Click += new System.EventHandler(this.BtnEditToQueue_Click);
            // 
            // FrmUpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 198);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnEditToQueue);
            this.Controls.Add(this.CbxDeactive);
            this.Controls.Add(this.CbxActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxName);
            this.Name = "FrmUpdateRoom";
            this.Text = "FrmUpdateRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Components.TextBox TbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CbxActive;
        private System.Windows.Forms.CheckBox CbxDeactive;
        private Components.CustomButton BtnSave;
        private Components.CustomButton BtnEditToQueue;
    }
}