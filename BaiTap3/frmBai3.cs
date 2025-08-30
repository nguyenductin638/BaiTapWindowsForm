using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap3
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }
        private void btnTach_Click(object sender, EventArgs e)
        {
            string s1 = txtSo1.Text;
            string s2 = txtSo2.Text;
            string hoTen = txtHoTen.Text;
            Cau3 obj = new Cau3();
            obj.TachChuoi(hoTen, ref s1, ref s2);
            lblHo.Text = s1.ToString();
            lblTen.Text = s2.ToString();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int soThuNhat, soThuHai;
            if (int.TryParse(txtSo1.Text, out soThuNhat)
                && int.TryParse(txtSo2.Text, out soThuHai))
            {
				Cau3 obj = new Cau3();
				if (obj.ThuTu(soThuNhat, soThuHai))
					lblSTT.Text = soThuNhat + " và " + soThuHai + " là 2 số nguyên liên tiếp";
				else
					lblSTT.Text = soThuNhat + " và " + soThuHai + " không phải 2 số nguyên liên tiếp";
			}
            else
                lblSTT.Text = "Vui lòng nhập số nguyên";
		}
    }
}
