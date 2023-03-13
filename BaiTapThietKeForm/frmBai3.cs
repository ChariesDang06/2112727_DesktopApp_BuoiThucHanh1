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
    public partial class frmBai3 : Form
    {
        List<string> list = new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string word = txtThemTu.Text;
            string meaning = txtThemNghia.Text;
            listBox1.Items.Add(word);
            list.Add(meaning);

            txtThemTu.Focus();
            txtThemTu.Text = "";
            txtThemNghia.Text = "";

            listBox1.SelectedItem = listBox1.Items.Count - 1;
            txtNghia.Text = meaning;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = listBox1.SelectedIndex;
            txtNghia.Text = list[stt];
        }

    }
}
