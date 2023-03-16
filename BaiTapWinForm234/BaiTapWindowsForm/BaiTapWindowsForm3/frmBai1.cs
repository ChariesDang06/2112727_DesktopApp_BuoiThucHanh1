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
    public partial class frmBai1 : Form
    {
        List<NhanVien> danhSachNhanVien = new List<NhanVien>();
        public frmBai1()
        {
            InitializeComponent();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nhanVienMoi = new NhanVien(txtMaNV.Text,txtHoTen.Text,txtNgaySinh.Text,
                double.Parse(txtHeSoLuong.Text), double.Parse(txtHeSoPhucap.Text));

            danhSachNhanVien.Add(nhanVienMoi);
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            NhanVien newNV = new NhanVien(txtMaNV.Text, txtHoTen.Text, txtNgaySinh.Text,
                double.Parse(txtHeSoLuong.Text), double.Parse(txtHeSoPhucap.Text));

            lblKetQuaTongLuong.Text = newNV.TinhTongLuong().ToString();
        }

        private void btnHienThiThongTin_Click(object sender, EventArgs e)
        {
            foreach(NhanVien item in danhSachNhanVien)
            {
                if(item.MaNV == tbNhapMaNV.Text)
                {
                    txtMaNV.Text = item.MaNV;
                    txtHoTen.Text = item.HoTen;
                    txtNgaySinh.Text = item.NgaySinh;
                    txtHeSoLuong.Text = item.HeSoLuong.ToString();
                    txtHeSoPhucap.Text = item.HeSoPhuCap.ToString();
                    break;
                }
            }
        }
    }
}
