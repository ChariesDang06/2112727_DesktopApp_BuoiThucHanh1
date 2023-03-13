using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class frmBai1 : Form
    {
        public readonly float redCar = 21000;
        public readonly float blueCar = 22000;
        public readonly float whiteCar = 20000;
        public frmBai1()
        {
            InitializeComponent();
        }

        private void rdbRed_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = redCar.ToString();
            pictureBox1.Image = Image.FromFile(@"redCar.png");
        }

        private void rdbBlue_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = blueCar.ToString();
            pictureBox1.Image = Image.FromFile(@"blueCar.png");
        }

        private void rdbWhite_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = whiteCar.ToString();
            pictureBox1.Image = Image.FromFile(@"whiteCar.png");
        }

        
        

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSoLuong.Text, out int value))
                MessageBox.Show("Nhập một số nguyên dương", "Lỗi");
            else
            {
                float tongTien = float.Parse(txtSoLuong.Text) * float.Parse(txtDonGia.Text);
                lblTongTien.Text = tongTien.ToString();
            }
        }


        //private void txtDonGia_TextChanged(object sender, EventArgs e)
        //{
        //    if(rdbRed.Checked)
        //        txtDonGia.Text = redCar.ToString();
        //    else if (rdbBlue.Checked)
        //        txtDonGia.Text = blueCar.ToString();
        //    else 
        //        txtDonGia.Text = whiteCar.ToString();   
        //}

    }
}
