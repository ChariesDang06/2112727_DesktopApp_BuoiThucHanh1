namespace BaiTapWindowsForm4
{
    partial class frmBai1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtLoaiSP = new System.Windows.Forms.TextBox();
            this.txtNgaySX = new System.Windows.Forms.TextBox();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.btnHienThiThongTin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaSPCanTim = new System.Windows.Forms.TextBox();
            this.btnXemNamHetHanSD = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNamHetHan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại sản phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sản xuất:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(153, 48);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(140, 22);
            this.txtMaSP.TabIndex = 4;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(153, 98);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(140, 22);
            this.txtTenSP.TabIndex = 5;
            // 
            // txtLoaiSP
            // 
            this.txtLoaiSP.Location = new System.Drawing.Point(153, 159);
            this.txtLoaiSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoaiSP.Name = "txtLoaiSP";
            this.txtLoaiSP.Size = new System.Drawing.Size(140, 22);
            this.txtLoaiSP.TabIndex = 6;
            // 
            // txtNgaySX
            // 
            this.txtNgaySX.Location = new System.Drawing.Point(153, 215);
            this.txtNgaySX.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgaySX.Name = "txtNgaySX";
            this.txtNgaySX.Size = new System.Drawing.Size(140, 22);
            this.txtNgaySX.TabIndex = 7;
            this.txtNgaySX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.Location = new System.Drawing.Point(51, 273);
            this.btnThemSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(242, 64);
            this.btnThemSanPham.TabIndex = 8;
            this.btnThemSanPham.Text = "Thêm sản phẩm vào danh sách";
            this.btnThemSanPham.UseVisualStyleBackColor = true;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // btnHienThiThongTin
            // 
            this.btnHienThiThongTin.Location = new System.Drawing.Point(563, 98);
            this.btnHienThiThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.btnHienThiThongTin.Name = "btnHienThiThongTin";
            this.btnHienThiThongTin.Size = new System.Drawing.Size(199, 98);
            this.btnHienThiThongTin.TabIndex = 9;
            this.btnHienThiThongTin.Text = "Hiển thị thông tin sản phẩm theo mã sản phẩm";
            this.btnHienThiThongTin.UseVisualStyleBackColor = true;
            this.btnHienThiThongTin.Click += new System.EventHandler(this.btnHienThiThongTin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nhập mã sản phẩm cần tìm";
            // 
            // txtMaSPCanTim
            // 
            this.txtMaSPCanTim.Location = new System.Drawing.Point(663, 44);
            this.txtMaSPCanTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSPCanTim.Name = "txtMaSPCanTim";
            this.txtMaSPCanTim.Size = new System.Drawing.Size(149, 22);
            this.txtMaSPCanTim.TabIndex = 11;
            // 
            // btnXemNamHetHanSD
            // 
            this.btnXemNamHetHanSD.Location = new System.Drawing.Point(563, 228);
            this.btnXemNamHetHanSD.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemNamHetHanSD.Name = "btnXemNamHetHanSD";
            this.btnXemNamHetHanSD.Size = new System.Drawing.Size(199, 41);
            this.btnXemNamHetHanSD.TabIndex = 12;
            this.btnXemNamHetHanSD.Text = "Xem năm hết hạn sử dụng";
            this.btnXemNamHetHanSD.UseVisualStyleBackColor = true;
            this.btnXemNamHetHanSD.Click += new System.EventHandler(this.btnXemNamHetHanSD_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(558, 290);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Năm hết hạn:";
            // 
            // lblNamHetHan
            // 
            this.lblNamHetHan.AutoSize = true;
            this.lblNamHetHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamHetHan.Location = new System.Drawing.Point(714, 290);
            this.lblNamHetHan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamHetHan.Name = "lblNamHetHan";
            this.lblNamHetHan.Size = new System.Drawing.Size(27, 25);
            this.lblNamHetHan.TabIndex = 14;
            this.lblNamHetHan.Text = "...";
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 384);
            this.Controls.Add(this.lblNamHetHan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnXemNamHetHanSD);
            this.Controls.Add(this.txtMaSPCanTim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHienThiThongTin);
            this.Controls.Add(this.btnThemSanPham);
            this.Controls.Add(this.txtNgaySX);
            this.Controls.Add(this.txtLoaiSP);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBai1";
            this.Text = "frmBai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtLoaiSP;
        private System.Windows.Forms.TextBox txtNgaySX;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.Button btnHienThiThongTin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaSPCanTim;
        private System.Windows.Forms.Button btnXemNamHetHanSD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNamHetHan;
    }
}