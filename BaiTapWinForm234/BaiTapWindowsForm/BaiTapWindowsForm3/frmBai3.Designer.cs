namespace BaiTapWindowsForm3
{
    partial class frmBai3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSoNguyenLienTiep = new System.Windows.Forms.RadioButton();
            this.rdbHoTen = new System.Windows.Forms.RadioButton();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số nguyên n1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số nguyên n2:";
            // 
            // tbHoVaTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(188, 63);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTen.Name = "tbHoVaTen";
            this.txtHoTen.Size = new System.Drawing.Size(193, 22);
            this.txtHoTen.TabIndex = 4;
            // 
            // tbSoN1
            // 
            this.txtN1.Location = new System.Drawing.Point(188, 105);
            this.txtN1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtN1.Name = "tbSoN1";
            this.txtN1.Size = new System.Drawing.Size(193, 22);
            this.txtN1.TabIndex = 5;
            // 
            // tbSoN2
            // 
            this.txtN2.Location = new System.Drawing.Point(188, 153);
            this.txtN2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtN2.Name = "tbSoN2";
            this.txtN2.Size = new System.Drawing.Size(193, 22);
            this.txtN2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 524);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kết quả:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbSoNguyenLienTiep);
            this.groupBox1.Controls.Add(this.rdbHoTen);
            this.groupBox1.Location = new System.Drawing.Point(85, 323);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(283, 111);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chức năng";
            // 
            // rdKiemTraHaiSoNguyenCoLienTiep
            // 
            this.rdbSoNguyenLienTiep.AutoSize = true;
            this.rdbSoNguyenLienTiep.Location = new System.Drawing.Point(8, 78);
            this.rdbSoNguyenLienTiep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbSoNguyenLienTiep.Name = "rdKiemTraHaiSoNguyenCoLienTiep";
            this.rdbSoNguyenLienTiep.Size = new System.Drawing.Size(269, 20);
            this.rdbSoNguyenLienTiep.TabIndex = 1;
            this.rdbSoNguyenLienTiep.TabStop = true;
            this.rdbSoNguyenLienTiep.Text = "Kiểm tra hai số nguyên có liên tiếp không";
            this.rdbSoNguyenLienTiep.UseVisualStyleBackColor = true;
            // 
            // rdTachHoTen
            // 
            this.rdbHoTen.AutoSize = true;
            this.rdbHoTen.Checked = true;
            this.rdbHoTen.Location = new System.Drawing.Point(8, 34);
            this.rdbHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbHoTen.Name = "rdTachHoTen";
            this.rdbHoTen.Size = new System.Drawing.Size(98, 20);
            this.rdbHoTen.TabIndex = 0;
            this.rdbHoTen.TabStop = true;
            this.rdbHoTen.Text = "Tách họ tên";
            this.rdbHoTen.UseVisualStyleBackColor = true;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(254, 524);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(27, 25);
            this.lblKetQua.TabIndex = 9;
            this.lblKetQua.Text = "...";
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.Location = new System.Drawing.Point(171, 473);
            this.btnXemKetQua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(100, 28);
            this.btnXemKetQua.TabIndex = 10;
            this.btnXemKetQua.Text = "Xem kết quả";
            this.btnXemKetQua.UseVisualStyleBackColor = true;
            this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 216);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Họ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 257);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tên:";
            // 
            // tbHo
            // 
            this.txtHo.Location = new System.Drawing.Point(186, 210);
            this.txtHo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHo.Name = "tbHo";
            this.txtHo.Size = new System.Drawing.Size(108, 22);
            this.txtHo.TabIndex = 13;
            // 
            // tbTen
            // 
            this.txtTen.Location = new System.Drawing.Point(186, 251);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTen.Name = "tbTen";
            this.txtTen.Size = new System.Drawing.Size(108, 22);
            this.txtTen.TabIndex = 14;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 660);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnXemKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnXemKetQua;
        private System.Windows.Forms.RadioButton rdbSoNguyenLienTiep;
        private System.Windows.Forms.RadioButton rdbHoTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
    }
}