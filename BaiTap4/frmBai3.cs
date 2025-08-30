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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }
        private void btnThongBao_Click(object sender, EventArgs e)
        {
            string ht = txtHoTen.Text;
            if (rdbNam.Checked)
                lblThongBao.Text = "Chào ông " + ht;
            else
                lblThongBao.Text = "Chào bà " + ht;
        }
        private void btnUCLN_Click(object sender, EventArgs e)
        {
            int m, n;
            if (int.TryParse(txtSoM.Text, out m)
                && int.TryParse(txtSoN.Text, out n))
            {
                Cau3 obj = new Cau3();
                obj.USCLN(m, n);
                lblKQUCLN.Text = obj.USCLN(m, n).ToString();
            }
            else
                lblKQUCLN.Text = "Vui lòng nhập số nguyên";
        }
    }
}
