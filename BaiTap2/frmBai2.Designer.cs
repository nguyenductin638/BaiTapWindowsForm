namespace BaiTap2
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtSoThuNhat = new System.Windows.Forms.TextBox();
			this.txtSoThuHai = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdbChia = new System.Windows.Forms.RadioButton();
			this.rdbNhan = new System.Windows.Forms.RadioButton();
			this.rdbTru = new System.Windows.Forms.RadioButton();
			this.rdbCong = new System.Windows.Forms.RadioButton();
			this.btnXemKetQua = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lblKetQua = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(62, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Số thứ nhất:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(62, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Số thứ hai:";
			// 
			// txtSoThuNhat
			// 
			this.txtSoThuNhat.Location = new System.Drawing.Point(175, 25);
			this.txtSoThuNhat.Name = "txtSoThuNhat";
			this.txtSoThuNhat.Size = new System.Drawing.Size(115, 22);
			this.txtSoThuNhat.TabIndex = 0;
			// 
			// txtSoThuHai
			// 
			this.txtSoThuHai.Location = new System.Drawing.Point(175, 80);
			this.txtSoThuHai.Name = "txtSoThuHai";
			this.txtSoThuHai.Size = new System.Drawing.Size(115, 22);
			this.txtSoThuHai.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdbChia);
			this.groupBox1.Controls.Add(this.rdbNhan);
			this.groupBox1.Controls.Add(this.rdbTru);
			this.groupBox1.Controls.Add(this.rdbCong);
			this.groupBox1.Location = new System.Drawing.Point(175, 148);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(178, 167);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn phép toán:";
			// 
			// rdbChia
			// 
			this.rdbChia.AutoSize = true;
			this.rdbChia.Location = new System.Drawing.Point(32, 119);
			this.rdbChia.Name = "rdbChia";
			this.rdbChia.Size = new System.Drawing.Size(55, 20);
			this.rdbChia.TabIndex = 3;
			this.rdbChia.TabStop = true;
			this.rdbChia.Text = "Chia";
			this.rdbChia.UseVisualStyleBackColor = true;
			// 
			// rdbNhan
			// 
			this.rdbNhan.AutoSize = true;
			this.rdbNhan.Location = new System.Drawing.Point(32, 93);
			this.rdbNhan.Name = "rdbNhan";
			this.rdbNhan.Size = new System.Drawing.Size(60, 20);
			this.rdbNhan.TabIndex = 2;
			this.rdbNhan.TabStop = true;
			this.rdbNhan.Text = "Nhân";
			this.rdbNhan.UseVisualStyleBackColor = true;
			// 
			// rdbTru
			// 
			this.rdbTru.AutoSize = true;
			this.rdbTru.Location = new System.Drawing.Point(32, 67);
			this.rdbTru.Name = "rdbTru";
			this.rdbTru.Size = new System.Drawing.Size(48, 20);
			this.rdbTru.TabIndex = 1;
			this.rdbTru.TabStop = true;
			this.rdbTru.Text = "Trừ";
			this.rdbTru.UseVisualStyleBackColor = true;
			// 
			// rdbCong
			// 
			this.rdbCong.AutoSize = true;
			this.rdbCong.Checked = true;
			this.rdbCong.Location = new System.Drawing.Point(32, 41);
			this.rdbCong.Name = "rdbCong";
			this.rdbCong.Size = new System.Drawing.Size(60, 20);
			this.rdbCong.TabIndex = 0;
			this.rdbCong.TabStop = true;
			this.rdbCong.Text = "Cộng";
			this.rdbCong.UseVisualStyleBackColor = true;
			// 
			// btnXemKetQua
			// 
			this.btnXemKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnXemKetQua.Location = new System.Drawing.Point(175, 332);
			this.btnXemKetQua.Name = "btnXemKetQua";
			this.btnXemKetQua.Size = new System.Drawing.Size(115, 32);
			this.btnXemKetQua.TabIndex = 3;
			this.btnXemKetQua.Text = "Xem kết quả";
			this.btnXemKetQua.UseVisualStyleBackColor = true;
			this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(171, 380);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Kết quả là: ";
			// 
			// lblKetQua
			// 
			this.lblKetQua.AutoSize = true;
			this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblKetQua.Location = new System.Drawing.Point(271, 380);
			this.lblKetQua.Name = "lblKetQua";
			this.lblKetQua.Size = new System.Drawing.Size(0, 20);
			this.lblKetQua.TabIndex = 4;
			// 
			// frmBai2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 496);
			this.Controls.Add(this.lblKetQua);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnXemKetQua);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtSoThuHai);
			this.Controls.Add(this.txtSoThuNhat);
			this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoThuNhat;
        private System.Windows.Forms.TextBox txtSoThuHai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbChia;
        private System.Windows.Forms.RadioButton rdbNhan;
        private System.Windows.Forms.RadioButton rdbTru;
        private System.Windows.Forms.RadioButton rdbCong;
        private System.Windows.Forms.Button btnXemKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKetQua;
    }
}