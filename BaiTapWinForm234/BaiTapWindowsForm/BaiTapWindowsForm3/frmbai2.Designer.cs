namespace BaiTapWindowsForm3
{
    partial class frmbai2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTinhNGiaiThua = new System.Windows.Forms.RadioButton();
            this.rdbTong = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập một số nguyên dương n:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTinhNGiaiThua);
            this.groupBox1.Controls.Add(this.rdbTong);
            this.groupBox1.Location = new System.Drawing.Point(169, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(221, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chưc năng:";
            // 
            // rdTinhNGiaiThua
            // 
            this.rdTinhNGiaiThua.AutoSize = true;
            this.rdTinhNGiaiThua.Location = new System.Drawing.Point(9, 81);
            this.rdTinhNGiaiThua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdTinhNGiaiThua.Name = "rdTinhNGiaiThua";
            this.rdTinhNGiaiThua.Size = new System.Drawing.Size(144, 20);
            this.rdTinhNGiaiThua.TabIndex = 1;
            this.rdTinhNGiaiThua.TabStop = true;
            this.rdTinhNGiaiThua.Text = "Tính N giai thừa (N!)";
            this.rdTinhNGiaiThua.UseVisualStyleBackColor = true;
            // 
            // rdTinhTong
            // 
            this.rdbTong.AutoSize = true;
            this.rdbTong.Location = new System.Drawing.Point(9, 38);
            this.rdbTong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbTong.Name = "rdTinhTong";
            this.rdbTong.Size = new System.Drawing.Size(140, 20);
            this.rdbTong.TabIndex = 0;
            this.rdbTong.TabStop = true;
            this.rdbTong.Text = "Tính tổng 1+2+...+N";
            this.rdbTong.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 350);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kết quả:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(312, 350);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(24, 20);
            this.lblKetQua.TabIndex = 3;
            this.lblKetQua.Text = "...";
            // 
            // tbSoN
            // 
            this.txtN.Location = new System.Drawing.Point(340, 65);
            this.txtN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtN.Name = "tbSoN";
            this.txtN.Size = new System.Drawing.Size(87, 22);
            this.txtN.TabIndex = 4;
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXemKetQua.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnXemKetQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemKetQua.Location = new System.Drawing.Point(169, 265);
            this.btnXemKetQua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(221, 49);
            this.btnXemKetQua.TabIndex = 5;
            this.btnXemKetQua.Text = "Xem kết quả";
            this.btnXemKetQua.UseVisualStyleBackColor = false;
            this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
            // 
            // frmbai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 448);
            this.Controls.Add(this.btnXemKetQua);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmbai2";
            this.Text = "frmbai2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTinhNGiaiThua;
        private System.Windows.Forms.RadioButton rdbTong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnXemKetQua;
    }
}