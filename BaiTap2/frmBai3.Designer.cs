namespace BaiTap2
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
			this.txtHo = new System.Windows.Forms.TextBox();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.btnNoi = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lblHoTen = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSoN = new System.Windows.Forms.TextBox();
			this.btnGiaiThua = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.lblKetQua = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập họ:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nhập tên:";
			// 
			// txtHo
			// 
			this.txtHo.Location = new System.Drawing.Point(130, 33);
			this.txtHo.Name = "txtHo";
			this.txtHo.Size = new System.Drawing.Size(140, 22);
			this.txtHo.TabIndex = 0;
			// 
			// txtTen
			// 
			this.txtTen.Location = new System.Drawing.Point(130, 66);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(140, 22);
			this.txtTen.TabIndex = 1;
			// 
			// btnNoi
			// 
			this.btnNoi.Location = new System.Drawing.Point(130, 105);
			this.btnNoi.Name = "btnNoi";
			this.btnNoi.Size = new System.Drawing.Size(118, 34);
			this.btnNoi.TabIndex = 2;
			this.btnNoi.Text = "Nối họ và tên";
			this.btnNoi.UseVisualStyleBackColor = true;
			this.btnNoi.Click += new System.EventHandler(this.btnNoi_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(45, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Họ và tên: ";
			// 
			// lblHoTen
			// 
			this.lblHoTen.AutoSize = true;
			this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblHoTen.Location = new System.Drawing.Point(142, 158);
			this.lblHoTen.Name = "lblHoTen";
			this.lblHoTen.Size = new System.Drawing.Size(0, 20);
			this.lblHoTen.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(364, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "Nhập số n:";
			// 
			// txtSoN
			// 
			this.txtSoN.Location = new System.Drawing.Point(453, 33);
			this.txtSoN.Name = "txtSoN";
			this.txtSoN.Size = new System.Drawing.Size(140, 22);
			this.txtSoN.TabIndex = 3;
			// 
			// btnGiaiThua
			// 
			this.btnGiaiThua.Location = new System.Drawing.Point(453, 105);
			this.btnGiaiThua.Name = "btnGiaiThua";
			this.btnGiaiThua.Size = new System.Drawing.Size(118, 34);
			this.btnGiaiThua.TabIndex = 4;
			this.btnGiaiThua.Text = "Tính giai thừa (n!)";
			this.btnGiaiThua.UseVisualStyleBackColor = true;
			this.btnGiaiThua.Click += new System.EventHandler(this.btnGiaiThua_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.Location = new System.Drawing.Point(363, 158);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 20);
			this.label5.TabIndex = 0;
			this.label5.Text = "Kết quả:";
			// 
			// lblKetQua
			// 
			this.lblKetQua.AutoSize = true;
			this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblKetQua.Location = new System.Drawing.Point(449, 158);
			this.lblKetQua.Name = "lblKetQua";
			this.lblKetQua.Size = new System.Drawing.Size(0, 20);
			this.lblKetQua.TabIndex = 0;
			// 
			// frmBai3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblHoTen);
			this.Controls.Add(this.lblKetQua);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnGiaiThua);
			this.Controls.Add(this.btnNoi);
			this.Controls.Add(this.txtTen);
			this.Controls.Add(this.txtSoN);
			this.Controls.Add(this.txtHo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Name = "frmBai3";
			this.Text = "Bài 3";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnNoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.Button btnGiaiThua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKetQua;
    }
}