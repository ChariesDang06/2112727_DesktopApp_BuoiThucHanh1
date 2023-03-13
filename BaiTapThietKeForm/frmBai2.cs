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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }
        public readonly float mouse = 100000;
        public readonly float keyboard = 150000;
        public readonly float printer = 2000000;
        public readonly float usb = 200000;
        private void btnChonHang_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            float tongTien = 0;
            foreach (string item in listBox2.Items)
            {
                switch (item)
                {
                    case "Chuột":
                        tongTien += mouse;
                        break;
                    case "Bàn phím":
                        tongTien += keyboard;
                        break;
                    case "Máy in":
                        tongTien += printer;
                        break;
                    case "USB Kingmax":
                        tongTien += usb;
                        break;
                }
            }
            lblTongTien.Text = tongTien.ToString() + " đồng";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

       
    }
}
