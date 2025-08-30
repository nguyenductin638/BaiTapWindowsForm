using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap2
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnNoi_Click(object sender, EventArgs e)
        {
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            string hoTen = "";
            ClassBai3 obj = new ClassBai3();
            obj.NoiChuoi(ho, ten, ref hoTen);
            if (string.IsNullOrEmpty(ho))
                hoTen = "Không có họ để nối";
            if (string.IsNullOrEmpty(ten))
                hoTen = "Không có tên để nối";
            if (string.IsNullOrEmpty(ho) && string.IsNullOrEmpty(ten))
                hoTen = "Không có họ và tên để nối";
                lblHoTen.Text = hoTen.ToString();
        }

        private void btnGiaiThua_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtSoN.Text, out n))
            {
                ClassBai3 obj = new ClassBai3();
                obj.GiaiThua(n);
                lblKetQua.Text = obj.GiaiThua(n).ToString();
            }
            else
                lblKetQua.Text = "Vui lòng nhập số nguyên";
        }
    }
}
