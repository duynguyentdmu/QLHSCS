﻿namespace QuanLyHoSoSDH
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pic_open = new System.Windows.Forms.PictureBox();
            this.pic_clock = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_clock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHÒNG ĐÀO TẠO SAU ĐẠI HỌC";
            // 
            // btExit
            // 
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.Red;
            this.btExit.Location = new System.Drawing.Point(406, 147);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(175, 37);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "THOÁT";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btLogin
            // 
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.Green;
            this.btLogin.Location = new System.Drawing.Point(186, 147);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(214, 37);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "ĐĂNG NHẬP";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.DarkGray;
            this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbId.ForeColor = System.Drawing.Color.Black;
            this.tbId.Location = new System.Drawing.Point(301, 56);
            this.tbId.Margin = new System.Windows.Forms.Padding(2);
            this.tbId.Multiline = true;
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(280, 37);
            this.tbId.TabIndex = 0;
            this.tbId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.DarkGray;
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbPass.ForeColor = System.Drawing.Color.Black;
            this.tbPass.Location = new System.Drawing.Point(301, 97);
            this.tbPass.Margin = new System.Windows.Forms.Padding(2);
            this.tbPass.Multiline = true;
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(280, 37);
            this.tbPass.TabIndex = 1;
            this.tbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(184, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "TÀI KHOẢN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(189, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "MẬT KHẨU";
            // 
            // pic_open
            // 
            this.pic_open.Image = global::QuanLyHoSoSDH.Properties.Resources.khoa;
            this.pic_open.Location = new System.Drawing.Point(36, 97);
            this.pic_open.Name = "pic_open";
            this.pic_open.Size = new System.Drawing.Size(93, 88);
            this.pic_open.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_open.TabIndex = 7;
            this.pic_open.TabStop = false;
            // 
            // pic_clock
            // 
            this.pic_clock.Image = global::QuanLyHoSoSDH.Properties.Resources.khoa1;
            this.pic_clock.Location = new System.Drawing.Point(36, 97);
            this.pic_clock.Name = "pic_clock";
            this.pic_clock.Size = new System.Drawing.Size(93, 88);
            this.pic_clock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_clock.TabIndex = 6;
            this.pic_clock.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyHoSoSDH.Properties.Resources.Untitled_23;
            this.ClientSize = new System.Drawing.Size(599, 252);
            this.Controls.Add(this.pic_clock);
            this.Controls.Add(this.pic_open);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BẢO VỆ ỨNG DỤNG";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_clock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pic_open;
        private System.Windows.Forms.PictureBox pic_clock;
    }
}

