using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm4
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnXuatThongBao_Click(object sender, EventArgs e)
        {
            if(rdNam.Checked)
            {
                lblThongBao.Text = XuLy.ChaoHoi(txtHoTen.Text, true);
            }
            else
            {
                lblThongBao.Text = XuLy.ChaoHoi(txtHoTen.Text, false);
            }
        }

        private void btnTimUSCLN_Click(object sender, EventArgs e)
        {
            int m = int.Parse(txtSoM.Text);
            int n = int.Parse(txtSoN.Text);
            lblKetQua.Text = XuLy.USCLN(m,n).ToString();
        }
    }
}
