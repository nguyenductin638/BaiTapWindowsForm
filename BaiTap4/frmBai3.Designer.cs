namespace BaiTap4
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
			this.btnThongBao = new System.Windows.Forms.Button();
			this.lblThongBao = new System.Windows.Forms.Label();
			this.lblSoM = new System.Windows.Forms.Label();
			this.lblSoN = new System.Windows.Forms.Label();
			this.txtSoM = new System.Windows.Forms.TextBox();
			this.txtSoN = new System.Windows.Forms.TextBox();
			this.btnUCLN = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lblKQUCLN = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdbNu = new System.Windows.Forms.RadioButton();
			this.rdbNam = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập họ tên:";
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(157, 35);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(155, 22);
			this.txtHoTen.TabIndex = 0;
			// 
			// btnThongBao
			// 
			this.btnThongBao.Location = new System.Drawing.Point(93, 244);
			this.btnThongBao.Name = "btnThongBao";
			this.btnThongBao.Size = new System.Drawing.Size(118, 29);
			this.btnThongBao.TabIndex = 2;
			this.btnThongBao.Text = "Thông báo";
			this.btnThongBao.UseVisualStyleBackColor = true;
			this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);
			// 
			// lblThongBao
			// 
			this.lblThongBao.AutoSize = true;
			this.lblThongBao.Location = new System.Drawing.Point(90, 307);
			this.lblThongBao.Name = "lblThongBao";
			this.lblThongBao.Size = new System.Drawing.Size(10, 16);
			this.lblThongBao.TabIndex = 0;
			this.lblThongBao.Text = ".";
			// 
			// lblSoM
			// 
			this.lblSoM.AutoSize = true;
			this.lblSoM.Location = new System.Drawing.Point(431, 35);
			this.lblSoM.Name = "lblSoM";
			this.lblSoM.Size = new System.Drawing.Size(75, 16);
			this.lblSoM.TabIndex = 0;
			this.lblSoM.Text = "Nhập số m:";
			// 
			// lblSoN
			// 
			this.lblSoN.AutoSize = true;
			this.lblSoN.Location = new System.Drawing.Point(431, 72);
			this.lblSoN.Name = "lblSoN";
			this.lblSoN.Size = new System.Drawing.Size(71, 16);
			this.lblSoN.TabIndex = 0;
			this.lblSoN.Text = "Nhập số n:";
			// 
			// txtSoM
			// 
			this.txtSoM.Location = new System.Drawing.Point(531, 36);
			this.txtSoM.Name = "txtSoM";
			this.txtSoM.Size = new System.Drawing.Size(109, 22);
			this.txtSoM.TabIndex = 3;
			// 
			// txtSoN
			// 
			this.txtSoN.Location = new System.Drawing.Point(531, 72);
			this.txtSoN.Name = "txtSoN";
			this.txtSoN.Size = new System.Drawing.Size(109, 22);
			this.txtSoN.TabIndex = 4;
			// 
			// btnUCLN
			// 
			this.btnUCLN.Location = new System.Drawing.Point(480, 122);
			this.btnUCLN.Name = "btnUCLN";
			this.btnUCLN.Size = new System.Drawing.Size(118, 29);
			this.btnUCLN.TabIndex = 5;
			this.btnUCLN.Text = "Tìm UCLN";
			this.btnUCLN.UseVisualStyleBackColor = true;
			this.btnUCLN.Click += new System.EventHandler(this.btnUCLN_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(431, 187);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "UCLN là:";
			// 
			// lblKQUCLN
			// 
			this.lblKQUCLN.AutoSize = true;
			this.lblKQUCLN.Location = new System.Drawing.Point(497, 187);
			this.lblKQUCLN.Name = "lblKQUCLN";
			this.lblKQUCLN.Size = new System.Drawing.Size(0, 16);
			this.lblKQUCLN.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdbNu);
			this.groupBox1.Controls.Add(this.rdbNam);
			this.groupBox1.Location = new System.Drawing.Point(47, 103);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn giới tính";
			// 
			// rdbNu
			// 
			this.rdbNu.AutoSize = true;
			this.rdbNu.Location = new System.Drawing.Point(19, 64);
			this.rdbNu.Name = "rdbNu";
			this.rdbNu.Size = new System.Drawing.Size(45, 20);
			this.rdbNu.TabIndex = 1;
			this.rdbNu.TabStop = true;
			this.rdbNu.Text = "Nữ";
			this.rdbNu.UseVisualStyleBackColor = true;
			// 
			// rdbNam
			// 
			this.rdbNam.AutoSize = true;
			this.rdbNam.Checked = true;
			this.rdbNam.Location = new System.Drawing.Point(19, 27);
			this.rdbNam.Name = "rdbNam";
			this.rdbNam.Size = new System.Drawing.Size(57, 20);
			this.rdbNam.TabIndex = 0;
			this.rdbNam.TabStop = true;
			this.rdbNam.Text = "Nam";
			this.rdbNam.UseVisualStyleBackColor = true;
			// 
			// frmBai3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblKQUCLN);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtSoN);
			this.Controls.Add(this.txtSoM);
			this.Controls.Add(this.lblSoN);
			this.Controls.Add(this.lblSoM);
			this.Controls.Add(this.lblThongBao);
			this.Controls.Add(this.btnUCLN);
			this.Controls.Add(this.btnThongBao);
			this.Controls.Add(this.txtHoTen);
			this.Controls.Add(this.label1);
			this.Name = "frmBai3";
			this.Text = "Bài 3";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnThongBao;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label lblSoM;
        private System.Windows.Forms.Label lblSoN;
        private System.Windows.Forms.TextBox txtSoM;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.Button btnUCLN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKQUCLN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
    }
}