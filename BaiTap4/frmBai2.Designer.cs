namespace BaiTap4
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
			this.txtDiemLyThuyet = new System.Windows.Forms.TextBox();
			this.txtDiemThucHanh = new System.Windows.Forms.TextBox();
			this.btnXepLoai = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lblKQXepLoai = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập điểm lý thuyết: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nhập điểm thực hành: ";
			// 
			// txtDiemLyThuyet
			// 
			this.txtDiemLyThuyet.Location = new System.Drawing.Point(195, 35);
			this.txtDiemLyThuyet.Name = "txtDiemLyThuyet";
			this.txtDiemLyThuyet.Size = new System.Drawing.Size(100, 22);
			this.txtDiemLyThuyet.TabIndex = 0;
			// 
			// txtDiemThucHanh
			// 
			this.txtDiemThucHanh.Location = new System.Drawing.Point(195, 70);
			this.txtDiemThucHanh.Name = "txtDiemThucHanh";
			this.txtDiemThucHanh.Size = new System.Drawing.Size(100, 22);
			this.txtDiemThucHanh.TabIndex = 1;
			// 
			// btnXepLoai
			// 
			this.btnXepLoai.Location = new System.Drawing.Point(184, 117);
			this.btnXepLoai.Name = "btnXepLoai";
			this.btnXepLoai.Size = new System.Drawing.Size(120, 39);
			this.btnXepLoai.TabIndex = 2;
			this.btnXepLoai.Text = "Xếp loại";
			this.btnXepLoai.UseVisualStyleBackColor = true;
			this.btnXepLoai.Click += new System.EventHandler(this.btnXepLoai_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(42, 178);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 18);
			this.label3.TabIndex = 0;
			this.label3.Text = "Kết quả xếp loại:";
			// 
			// lblKQXepLoai
			// 
			this.lblKQXepLoai.AutoSize = true;
			this.lblKQXepLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblKQXepLoai.ForeColor = System.Drawing.Color.Red;
			this.lblKQXepLoai.Location = new System.Drawing.Point(197, 178);
			this.lblKQXepLoai.Name = "lblKQXepLoai";
			this.lblKQXepLoai.Size = new System.Drawing.Size(13, 18);
			this.lblKQXepLoai.TabIndex = 0;
			this.lblKQXepLoai.Text = ".";
			// 
			// frmBai2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblKQXepLoai);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnXepLoai);
			this.Controls.Add(this.txtDiemThucHanh);
			this.Controls.Add(this.txtDiemLyThuyet);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmBai2";
			this.Text = "Bài 2";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiemLyThuyet;
        private System.Windows.Forms.TextBox txtDiemThucHanh;
        private System.Windows.Forms.Button btnXepLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKQXepLoai;
    }
}