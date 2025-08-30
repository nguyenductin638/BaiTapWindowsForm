namespace BaiTap4
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
			this.lblThongTin = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblThongTin
			// 
			this.lblThongTin.AutoSize = true;
			this.lblThongTin.Location = new System.Drawing.Point(63, 30);
			this.lblThongTin.Name = "lblThongTin";
			this.lblThongTin.Size = new System.Drawing.Size(124, 16);
			this.lblThongTin.TabIndex = 0;
			this.lblThongTin.Text = "Thông tin sản phẩm";
			// 
			// frmBai1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblThongTin);
			this.Name = "frmBai1";
			this.Text = "Bài 1";
			this.Load += new System.EventHandler(this.frmBai1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongTin;
    }
}