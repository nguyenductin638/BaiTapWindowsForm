namespace BaiTap3
{
    partial class frmBai2
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
			this.txtSoNguyenDuongN = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdbTinhTong = new System.Windows.Forms.RadioButton();
			this.rdbTinhGiaiThua = new System.Windows.Forms.RadioButton();
			this.btnXemKetQua = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lblKetQua = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(187, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập một số nguyên dương N:";
			// 
			// txtSoNguyenDuongN
			// 
			this.txtSoNguyenDuongN.Location = new System.Drawing.Point(244, 31);
			this.txtSoNguyenDuongN.Name = "txtSoNguyenDuongN";
			this.txtSoNguyenDuongN.Size = new System.Drawing.Size(115, 22);
			this.txtSoNguyenDuongN.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdbTinhTong);
			this.groupBox1.Controls.Add(this.rdbTinhGiaiThua);
			this.groupBox1.Location = new System.Drawing.Point(159, 85);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 110);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn một công việc:";
			// 
			// rdbTinhTong
			// 
			this.rdbTinhTong.AutoSize = true;
			this.rdbTinhTong.Checked = true;
			this.rdbTinhTong.Location = new System.Drawing.Point(23, 42);
			this.rdbTinhTong.Name = "rdbTinhTong";
			this.rdbTinhTong.Size = new System.Drawing.Size(140, 20);
			this.rdbTinhTong.TabIndex = 0;
			this.rdbTinhTong.TabStop = true;
			this.rdbTinhTong.Text = "Tính tổng 1+2+...+N";
			this.rdbTinhTong.UseVisualStyleBackColor = true;
			// 
			// rdbTinhGiaiThua
			// 
			this.rdbTinhGiaiThua.AutoSize = true;
			this.rdbTinhGiaiThua.Location = new System.Drawing.Point(23, 68);
			this.rdbTinhGiaiThua.Name = "rdbTinhGiaiThua";
			this.rdbTinhGiaiThua.Size = new System.Drawing.Size(144, 20);
			this.rdbTinhGiaiThua.TabIndex = 1;
			this.rdbTinhGiaiThua.TabStop = true;
			this.rdbTinhGiaiThua.Text = "Tính N giai thừa (N!)";
			this.rdbTinhGiaiThua.UseVisualStyleBackColor = true;
			// 
			// btnXemKetQua
			// 
			this.btnXemKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnXemKetQua.Location = new System.Drawing.Point(159, 230);
			this.btnXemKetQua.Name = "btnXemKetQua";
			this.btnXemKetQua.Size = new System.Drawing.Size(119, 46);
			this.btnXemKetQua.TabIndex = 2;
			this.btnXemKetQua.Text = "Xem kết quả";
			this.btnXemKetQua.UseVisualStyleBackColor = true;
			this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(155, 298);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 22);
			this.label2.TabIndex = 0;
			this.label2.Text = "Kết quả là:";
			// 
			// lblKetQua
			// 
			this.lblKetQua.AutoSize = true;
			this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblKetQua.Location = new System.Drawing.Point(257, 298);
			this.lblKetQua.Name = "lblKetQua";
			this.lblKetQua.Size = new System.Drawing.Size(0, 22);
			this.lblKetQua.TabIndex = 0;
			// 
			// frmBai2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblKetQua);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnXemKetQua);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtSoNguyenDuongN);
			this.Controls.Add(this.label1);
			this.Name = "frmBai2";
			this.Text = "Bài 2";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoNguyenDuongN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTinhTong;
        private System.Windows.Forms.RadioButton rdbTinhGiaiThua;
        private System.Windows.Forms.Button btnXemKetQua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKetQua;
    }
}