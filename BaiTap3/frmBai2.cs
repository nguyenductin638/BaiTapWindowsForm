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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtSoNguyenDuongN.Text, out n))
            {
                if (rdbTinhTong.Checked)
                {
                    TinhToan obj = new TinhToan();
                    obj.Tong(n);
                    lblKetQua.Text = obj.Tong(n).ToString();
                }
                else
                {
                    TinhToan obj = new TinhToan();
                    obj.GiaiThua(n);
                    lblKetQua.Text = obj.GiaiThua(n).ToString();
                }
            }
            else
                lblKetQua.Text = "Vui lòng nhập số nguyên";
        }
    }
}
