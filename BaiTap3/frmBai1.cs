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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void lblThongTinNV_Click(object sender, EventArgs e)
        {

        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien("NV001", "Nguyễn Đức Tín", DateTime.Parse("09/08/2002"), 10000000, 5000000);
            lblThongTinNV.Text = nv.HienThi();
        }
    }
}
