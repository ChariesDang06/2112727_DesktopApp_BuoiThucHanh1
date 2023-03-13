﻿using System;
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
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int so;
            for (int i = 1; i <= 10; i++)
            {
                so = random.Next(1, 100);
                listBox1.Items.Add(so);
            }    
                    
        }

        private void btnTimSo_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNhapSo.Text, out int value))
                MessageBox.Show("Nhập một số nguyên dương <100", "Lỗi");
            else
            {
                int soCanTim = int.Parse(txtNhapSo.Text);
                lblKetQua.Text = "Không tìm thấy";
                foreach (int so in listBox1.Items)
                {
                    if (so == soCanTim)
                    {
                        lblKetQua.Text = "Tìm thấy";
                        break;
                    }
                }
            }
               
            
        }
    }
}
