﻿namespace QuanLyHoSoSDH
{
    partial class frmMain
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
            this.btExit = new System.Windows.Forms.Button();
            this.btnQLHS = new System.Windows.Forms.Button();
            this.btnYKNH = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.Red;
            this.btExit.Location = new System.Drawing.Point(12, 401);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(319, 37);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "THOÁT";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btnQLHS
            // 
            this.btnQLHS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLHS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHS.ForeColor = System.Drawing.Color.Indigo;
            this.btnQLHS.Location = new System.Drawing.Point(12, 12);
            this.btnQLHS.Name = "btnQLHS";
            this.btnQLHS.Size = new System.Drawing.Size(319, 68);
            this.btnQLHS.TabIndex = 3;
            this.btnQLHS.Text = "QUẢN LÝ HỒ SƠ";
            this.btnQLHS.UseVisualStyleBackColor = true;
            this.btnQLHS.Click += new System.EventHandler(this.btQLHS_Click);
            // 
            // btnYKNH
            // 
            this.btnYKNH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYKNH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYKNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYKNH.ForeColor = System.Drawing.Color.Blue;
            this.btnYKNH.Location = new System.Drawing.Point(12, 86);
            this.btnYKNH.Name = "btnYKNH";
            this.btnYKNH.Size = new System.Drawing.Size(319, 68);
            this.btnYKNH.TabIndex = 3;
            this.btnYKNH.Text = "THU THẬP Ý KIẾN NGƯỜI HỌC";
            this.btnYKNH.UseVisualStyleBackColor = true;
            this.btnYKNH.Click += new System.EventHandler(this.btnYKNH_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(12, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(319, 68);
            this.button2.TabIndex = 3;
            this.button2.Text = "THU THẬP Ý KIẾN GIẢNG VIÊN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btQLHS_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(12, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 68);
            this.button1.TabIndex = 3;
            this.button1.Text = "TEST CHUC NANG FIRE BASE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btCNFB_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnYKNH);
            this.Controls.Add(this.btnQLHS);
            this.Controls.Add(this.btExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btnQLHS;
        private System.Windows.Forms.Button btnYKNH;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}