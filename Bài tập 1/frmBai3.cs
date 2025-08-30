using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            float a, b, kq = 0;
            int n;
            bool number = true;
            if (rdbTong.Checked)
            {
                if (float.TryParse(txtSoA.Text, out a)
                    && float.TryParse(txtSoB.Text, out b))
                    TinhToan.CongHaiSo(a, b, ref kq);
                else
                    number = false;
            }
            else
            {
                
				if (int.TryParse(txtSoN.Text, out n))
					TinhToan.TongDaySo(n, ref kq);
				else
					number = false;
			}
            if (number)
                lblKetQua.Text = kq.ToString();
            else
                lblKetQua.Text = "Vui lòng nhập số";
        }
    }
}
