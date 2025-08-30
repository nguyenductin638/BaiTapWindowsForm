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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }
        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            float soThuNhat, soThuHai, ketQua = 0;
            if (float.TryParse(txtSoThuNhat.Text, out soThuNhat)
                && float.TryParse(txtSoThuHai.Text, out soThuHai))
            {
                if (rdbCong.Checked)
                    ketQua = soThuNhat + soThuHai;
                if (rdbTru.Checked)
                    ketQua = soThuNhat - soThuHai;
                if (rdbNhan.Checked)
                    ketQua = soThuNhat * soThuHai;
                if (rdbChia.Checked)
                    ketQua = soThuNhat / soThuHai;
                lblKetQua.Text = ketQua.ToString();
            }
            else
                lblKetQua.Text = "Vui lòng nhập số thực";
        }
    }
}
