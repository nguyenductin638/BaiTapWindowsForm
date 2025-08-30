namespace BaiTap3
{
    partial class frmBai3
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
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.btnTach = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lblHo = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblTen = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSo2 = new System.Windows.Forms.TextBox();
			this.txtSo1 = new System.Windows.Forms.TextBox();
			this.btnKiemTra = new System.Windows.Forms.Button();
			this.lblSTT = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập họ tên: ";
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(140, 38);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(193, 22);
			this.txtHoTen.TabIndex = 0;
			// 
			// btnTach
			// 
			this.btnTach.Location = new System.Drawing.Point(140, 82);
			this.btnTach.Name = "btnTach";
			this.btnTach.Size = new System.Drawing.Size(146, 33);
			this.btnTach.TabIndex = 1;
			this.btnTach.Text = "Tách họ và tên";
			this.btnTach.UseVisualStyleBackColor = true;
			this.btnTach.Click += new System.EventHandler(this.btnTach_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Họ là: ";
			// 
			// lblHo
			// 
			this.lblHo.AutoSize = true;
			this.lblHo.Location = new System.Drawing.Point(101, 138);
			this.lblHo.Name = "lblHo";
			this.lblHo.Size = new System.Drawing.Size(10, 16);
			this.lblHo.TabIndex = 0;
			this.lblHo.Text = ".";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(41, 170);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "Tên là: ";
			// 
			// lblTen
			// 
			this.lblTen.AutoSize = true;
			this.lblTen.Location = new System.Drawing.Point(101, 170);
			this.lblTen.Name = "lblTen";
			this.lblTen.Size = new System.Drawing.Size(10, 16);
			this.lblTen.TabIndex = 0;
			this.lblTen.Text = ".";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(424, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Nhập số thứ nhất:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(424, 82);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(102, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "Nhập số thứ hai:";
			// 
			// txtSo2
			// 
			this.txtSo2.Location = new System.Drawing.Point(561, 76);
			this.txtSo2.Name = "txtSo2";
			this.txtSo2.Size = new System.Drawing.Size(111, 22);
			this.txtSo2.TabIndex = 3;
			// 
			// txtSo1
			// 
			this.txtSo1.Location = new System.Drawing.Point(561, 44);
			this.txtSo1.Name = "txtSo1";
			this.txtSo1.Size = new System.Drawing.Size(111, 22);
			this.txtSo1.TabIndex = 2;
			// 
			// btnKiemTra
			// 
			this.btnKiemTra.Location = new System.Drawing.Point(521, 123);
			this.btnKiemTra.Name = "btnKiemTra";
			this.btnKiemTra.Size = new System.Drawing.Size(95, 31);
			this.btnKiemTra.TabIndex = 4;
			this.btnKiemTra.Text = "Kiểm tra";
			this.btnKiemTra.UseVisualStyleBackColor = true;
			this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
			// 
			// lblSTT
			// 
			this.lblSTT.AutoSize = true;
			this.lblSTT.Location = new System.Drawing.Point(481, 170);
			this.lblSTT.Name = "lblSTT";
			this.lblSTT.Size = new System.Drawing.Size(10, 16);
			this.lblSTT.TabIndex = 0;
			this.lblSTT.Text = ".";
			// 
			// frmBai3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblSTT);
			this.Controls.Add(this.btnKiemTra);
			this.Controls.Add(this.txtSo1);
			this.Controls.Add(this.txtSo2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblTen);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblHo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnTach);
			this.Controls.Add(this.txtHoTen);
			this.Controls.Add(this.label1);
			this.Name = "frmBai3";
			this.Text = "Bài 3";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnTach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Label lblSTT;
    }
}