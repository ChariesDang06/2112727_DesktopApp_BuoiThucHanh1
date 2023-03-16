using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm3
{
    public partial class frmBai3 : Form
    {
        string str1;
        string str2;

        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            if(rdbHoTen.Checked)
            {
                XuLy.TachChuoi(txtHoTen.Text, ref str1, ref str2);
                txtHo.Text = str1;
                txtTen.Text = str2;
            }
            else if(rdbSoNguyenLienTiep.Checked)
            {
                if(XuLy.ThuTu(int.Parse(txtN1.Text), int.Parse(txtN2.Text)) == true)
                    lblKetQua.Text = "Đây là hai số nguyên liên tiếp";
                else
                    lblKetQua.Text = "N1 và N2 không phải là hai số nguyên liên tiếp";
            }
            else
                lblKetQua.Text = "Lỗi nhập liệu";
        }
    }
}
