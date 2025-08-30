namespace BaiTapWindowsForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSoA = new System.Windows.Forms.TextBox();
			this.txtSoB = new System.Windows.Forms.TextBox();
			this.txtSoN = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdbTong1N = new System.Windows.Forms.RadioButton();
			this.rdbTong = new System.Windows.Forms.RadioButton();
			this.btnKetQua = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lblKetQua = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Số a = ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(43, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Số  b = ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(43, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Số  n = ";
			// 
			// txtSoA
			// 
			this.txtSoA.Location = new System.Drawing.Point(112, 35);
			this.txtSoA.Name = "txtSoA";
			this.txtSoA.Size = new System.Drawing.Size(116, 22);
			this.txtSoA.TabIndex = 1;
			this.txtSoA.Text = "0";
			// 
			// txtSoB
			// 
			this.txtSoB.Location = new System.Drawing.Point(112, 68);
			this.txtSoB.Name = "txtSoB";
			this.txtSoB.Size = new System.Drawing.Size(116, 22);
			this.txtSoB.TabIndex = 2;
			this.txtSoB.Text = "0";
			// 
			// txtSoN
			// 
			this.txtSoN.Location = new System.Drawing.Point(112, 107);
			this.txtSoN.Name = "txtSoN";
			this.txtSoN.Size = new System.Drawing.Size(116, 22);
			this.txtSoN.TabIndex = 3;
			this.txtSoN.Text = "0";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdbTong1N);
			this.groupBox1.Controls.Add(this.rdbTong);
			this.groupBox1.Location = new System.Drawing.Point(46, 180);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn phép toán";
			// 
			// rdbTong1N
			// 
			this.rdbTong1N.AutoSize = true;
			this.rdbTong1N.Location = new System.Drawing.Point(34, 60);
			this.rdbTong1N.Name = "rdbTong1N";
			this.rdbTong1N.Size = new System.Drawing.Size(142, 20);
			this.rdbTong1N.TabIndex = 1;
			this.rdbTong1N.TabStop = true;
			this.rdbTong1N.Text = "Tính tổng từ 1 đến n";
			this.rdbTong1N.UseVisualStyleBackColor = true;
			// 
			// rdbTong
			// 
			this.rdbTong.AutoSize = true;
			this.rdbTong.Checked = true;
			this.rdbTong.Location = new System.Drawing.Point(34, 34);
			this.rdbTong.Name = "rdbTong";
			this.rdbTong.Size = new System.Drawing.Size(133, 20);
			this.rdbTong.TabIndex = 0;
			this.rdbTong.TabStop = true;
			this.rdbTong.Text = "Tính tổng của a, b";
			this.rdbTong.UseVisualStyleBackColor = true;
			// 
			// btnKetQua
			// 
			this.btnKetQua.Location = new System.Drawing.Point(80, 286);
			this.btnKetQua.Name = "btnKetQua";
			this.btnKetQua.Size = new System.Drawing.Size(133, 33);
			this.btnKetQua.TabIndex = 5;
			this.btnKetQua.Text = "Xem kết quả";
			this.btnKetQua.UseVisualStyleBackColor = true;
			this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(46, 359);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 22);
			this.label4.TabIndex = 0;
			this.label4.Text = "Kết quả là: ";
			// 
			// lblKetQua
			// 
			this.lblKetQua.AutoSize = true;
			this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblKetQua.Location = new System.Drawing.Point(153, 359);
			this.lblKetQua.Name = "lblKetQua";
			this.lblKetQua.Size = new System.Drawing.Size(0, 22);
			this.lblKetQua.TabIndex = 0;
			// 
			// frmBai3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblKetQua);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnKetQua);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtSoN);
			this.Controls.Add(this.txtSoB);
			this.Controls.Add(this.txtSoA);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmBai3";
			this.Text = " Bài 3";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTong1N;
        private System.Windows.Forms.RadioButton rdbTong;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKetQua;
    }
}