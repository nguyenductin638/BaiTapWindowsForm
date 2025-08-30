using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap4
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }
        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            float diemlt, diemth;
			string s;
            if (float.TryParse(txtDiemLyThuyet.Text, out diemlt)
                && float.TryParse(txtDiemThucHanh.Text, out diemth))
            {
                if (diemlt < 0 || diemth < 0 || diemlt > 10 || diemth > 10)
                    s = "Điểm phải nằm trong khoảng 0 đến 10";
                else
                {
                    float dtb = (diemlt + diemth) / 2;
                    if (diemlt < 5 || diemth < 5)
                        s = "Yếu";
                    else if (dtb < 7)
                        s = "Trung bình";
                    else if (dtb < 8)
                        s = "Khá";
                    else if (dtb < 9)
                        s = "Giỏi";
                    else
                        s = "Xuất sắc";
                }
            }
            else
                s = "Vui lòng nhập số thực";
            lblKQXepLoai.Text = s;
        }
    }
}
