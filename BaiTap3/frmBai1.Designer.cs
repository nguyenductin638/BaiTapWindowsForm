namespace BaiTap3
{
    partial class frmBai1
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
			this.lblThongTinNV = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblThongTinNV
			// 
			this.lblThongTinNV.AutoSize = true;
			this.lblThongTinNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblThongTinNV.Location = new System.Drawing.Point(130, 52);
			this.lblThongTinNV.Name = "lblThongTinNV";
			this.lblThongTinNV.Size = new System.Drawing.Size(169, 22);
			this.lblThongTinNV.TabIndex = 0;
			this.lblThongTinNV.Text = "Thông tin nhân viên";
			this.lblThongTinNV.Click += new System.EventHandler(this.lblThongTinNV_Click);
			// 
			// frmBai1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblThongTinNV);
			this.Name = "frmBai1";
			this.Text = "Bài 1";
			this.Load += new System.EventHandler(this.frmBai1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongTinNV;
    }
}