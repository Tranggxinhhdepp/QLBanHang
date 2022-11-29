namespace _3_PL.Views
{
    partial class Frm_BanHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_taohoadon = new System.Windows.Forms.Button();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.dgrid_giohan = new System.Windows.Forms.DataGridView();
            this.dgrid_sanpham = new System.Windows.Forms.DataGridView();
            this.dgrid_hoadon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.txt_tienkhach = new System.Windows.Forms.TextBox();
            this.txt_tienthua = new System.Windows.Forms.TextBox();
            this.cmb_httt = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_giohan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_sanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrid_giohan);
            this.groupBox1.Controls.Add(this.btn_taohoadon);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giỏ Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrid_sanpham);
            this.groupBox2.Location = new System.Drawing.Point(6, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(763, 377);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản Phẩm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgrid_hoadon);
            this.groupBox3.Location = new System.Drawing.Point(828, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 354);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hoá đơn chờ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmb_httt);
            this.groupBox4.Controls.Add(this.txt_tienthua);
            this.groupBox4.Controls.Add(this.txt_tienkhach);
            this.groupBox4.Controls.Add(this.txt_tongtien);
            this.groupBox4.Controls.Add(this.txt_ma);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btn_thanhtoan);
            this.groupBox4.Location = new System.Drawing.Point(826, 388);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 343);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thanh Toán";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(15, 303);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(139, 34);
            this.btn_xoa.TabIndex = 0;
            this.btn_xoa.Text = "Xoá sản phẩm";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(198, 303);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(112, 34);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_taohoadon
            // 
            this.btn_taohoadon.Location = new System.Drawing.Point(384, 303);
            this.btn_taohoadon.Name = "btn_taohoadon";
            this.btn_taohoadon.Size = new System.Drawing.Size(134, 34);
            this.btn_taohoadon.TabIndex = 2;
            this.btn_taohoadon.Text = "Tạo hoá đơn";
            this.btn_taohoadon.UseVisualStyleBackColor = true;
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Location = new System.Drawing.Point(114, 303);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(112, 34);
            this.btn_thanhtoan.TabIndex = 3;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            // 
            // dgrid_giohan
            // 
            this.dgrid_giohan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_giohan.Location = new System.Drawing.Point(6, 30);
            this.dgrid_giohan.Name = "dgrid_giohan";
            this.dgrid_giohan.RowHeadersWidth = 62;
            this.dgrid_giohan.RowTemplate.Height = 33;
            this.dgrid_giohan.Size = new System.Drawing.Size(751, 258);
            this.dgrid_giohan.TabIndex = 3;
            // 
            // dgrid_sanpham
            // 
            this.dgrid_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_sanpham.Location = new System.Drawing.Point(4, 36);
            this.dgrid_sanpham.Name = "dgrid_sanpham";
            this.dgrid_sanpham.RowHeadersWidth = 62;
            this.dgrid_sanpham.RowTemplate.Height = 33;
            this.dgrid_sanpham.Size = new System.Drawing.Size(744, 328);
            this.dgrid_sanpham.TabIndex = 0;
            // 
            // dgrid_hoadon
            // 
            this.dgrid_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_hoadon.Location = new System.Drawing.Point(10, 36);
            this.dgrid_hoadon.Name = "dgrid_hoadon";
            this.dgrid_hoadon.RowHeadersWidth = 62;
            this.dgrid_hoadon.RowTemplate.Height = 33;
            this.dgrid_hoadon.Size = new System.Drawing.Size(381, 294);
            this.dgrid_hoadon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã hoá đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hình thức thanh  toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tiền khách đưa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tiền thừa";
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(182, 42);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(150, 31);
            this.txt_ma.TabIndex = 9;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(182, 90);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(150, 31);
            this.txt_tongtien.TabIndex = 10;
            // 
            // txt_tienkhach
            // 
            this.txt_tienkhach.Location = new System.Drawing.Point(182, 194);
            this.txt_tienkhach.Name = "txt_tienkhach";
            this.txt_tienkhach.Size = new System.Drawing.Size(150, 31);
            this.txt_tienkhach.TabIndex = 11;
            // 
            // txt_tienthua
            // 
            this.txt_tienthua.Location = new System.Drawing.Point(182, 237);
            this.txt_tienthua.Name = "txt_tienthua";
            this.txt_tienthua.Size = new System.Drawing.Size(150, 31);
            this.txt_tienthua.TabIndex = 12;
            // 
            // cmb_httt
            // 
            this.cmb_httt.FormattingEnabled = true;
            this.cmb_httt.Location = new System.Drawing.Point(212, 144);
            this.cmb_httt.Name = "cmb_httt";
            this.cmb_httt.Size = new System.Drawing.Size(176, 33);
            this.cmb_httt.TabIndex = 13;
            // 
            // Frm_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 743);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_BanHang";
            this.Text = "Frm_BanHang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_giohan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_sanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrid_giohan;
        private System.Windows.Forms.Button btn_taohoadon;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrid_sanpham;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgrid_hoadon;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmb_httt;
        private System.Windows.Forms.TextBox txt_tienthua;
        private System.Windows.Forms.TextBox txt_tienkhach;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_thanhtoan;
    }
}