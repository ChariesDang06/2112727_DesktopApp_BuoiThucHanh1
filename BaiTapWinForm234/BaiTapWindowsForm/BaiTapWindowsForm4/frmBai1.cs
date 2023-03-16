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
    public partial class frmBai1 : Form
    {
        List<SanPham> danhSachSanPham = new List<SanPham>();
        public frmBai1()
        {
            InitializeComponent();
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            SanPham spMoi = new SanPham();
            spMoi.maSP = txtMaSP.Text;
            spMoi.tenSP = txtTenSP.Text;
            spMoi.loaiSP = txtLoaiSP.Text;
            spMoi.ngaySX = txtNgaySX.Text;

            danhSachSanPham.Add(spMoi);
        }

        private void btnHienThiThongTin_Click(object sender, EventArgs e)
        {
            foreach (SanPham item in danhSachSanPham)
            {
                if(txtMaSPCanTim.Text == item.maSP)
                {
                    txtMaSP.Text = item.maSP;
                    txtTenSP.Text = item.tenSP;
                    txtLoaiSP.Text = item.loaiSP;
                    txtNgaySX.Text = item.ngaySX;
                    break;
                }
            }
        }

        private void btnXemNamHetHanSD_Click(object sender, EventArgs e)
        {
            SanPham spMoi = new SanPham();
            spMoi.maSP = txtMaSP.Text;
            spMoi.tenSP = txtTenSP.Text;
            spMoi.loaiSP = txtLoaiSP.Text;
            spMoi.ngaySX = txtNgaySX.Text;

            lblNamHetHan.Text = spMoi.NamHetHan().ToString();
        }
    }
}
