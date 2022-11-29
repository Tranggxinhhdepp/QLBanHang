namespace _3_PL.Views
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.btn_nhanvien = new System.Windows.Forms.Button();
            this.btn_khachhang = new System.Windows.Forms.Button();
            this.btn_sanpham = new System.Windows.Forms.Button();
            this.btn_hoadon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_tennhanvien = new System.Windows.Forms.Label();
            this.lb_chucvu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.Location = new System.Drawing.Point(57, 370);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.Size = new System.Drawing.Size(127, 47);
            this.btn_nhanvien.TabIndex = 1;
            this.btn_nhanvien.Text = "Nhân Viên ";
            this.btn_nhanvien.UseVisualStyleBackColor = true;
            this.btn_nhanvien.Click += new System.EventHandler(this.btn_nhanvien_Click);
            // 
            // btn_khachhang
            // 
            this.btn_khachhang.Location = new System.Drawing.Point(57, 449);
            this.btn_khachhang.Name = "btn_khachhang";
            this.btn_khachhang.Size = new System.Drawing.Size(127, 47);
            this.btn_khachhang.TabIndex = 2;
            this.btn_khachhang.Text = "Khách Hàng ";
            this.btn_khachhang.UseVisualStyleBackColor = true;
            this.btn_khachhang.Click += new System.EventHandler(this.btn_khachhang_Click);
            // 
            // btn_sanpham
            // 
            this.btn_sanpham.Location = new System.Drawing.Point(57, 286);
            this.btn_sanpham.Name = "btn_sanpham";
            this.btn_sanpham.Size = new System.Drawing.Size(127, 47);
            this.btn_sanpham.TabIndex = 3;
            this.btn_sanpham.Text = "Sản Phẩm";
            this.btn_sanpham.UseVisualStyleBackColor = true;
            this.btn_sanpham.Click += new System.EventHandler(this.btn_sanpham_Click);
            // 
            // btn_hoadon
            // 
            this.btn_hoadon.Location = new System.Drawing.Point(57, 203);
            this.btn_hoadon.Name = "btn_hoadon";
            this.btn_hoadon.Size = new System.Drawing.Size(127, 47);
            this.btn_hoadon.TabIndex = 4;
            this.btn_hoadon.Text = "Hóa Đơn ";
            this.btn_hoadon.UseVisualStyleBackColor = true;
            this.btn_hoadon.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(285, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 535);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhân Viên  : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_tennhanvien
            // 
            this.lb_tennhanvien.AutoSize = true;
            this.lb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_tennhanvien.Location = new System.Drawing.Point(30, 110);
            this.lb_tennhanvien.Name = "lb_tennhanvien";
            this.lb_tennhanvien.Size = new System.Drawing.Size(187, 32);
            this.lb_tennhanvien.TabIndex = 7;
            this.lb_tennhanvien.Text = "Tên Nhân Viên ";
            // 
            // lb_chucvu
            // 
            this.lb_chucvu.AutoSize = true;
            this.lb_chucvu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_chucvu.Location = new System.Drawing.Point(126, 68);
            this.lb_chucvu.Name = "lb_chucvu";
            this.lb_chucvu.Size = new System.Drawing.Size(83, 25);
            this.lb_chucvu.TabIndex = 8;
            this.lb_chucvu.Text = "Chức Vụ";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1005, 578);
            this.Controls.Add(this.lb_chucvu);
            this.Controls.Add(this.lb_tennhanvien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_hoadon);
            this.Controls.Add(this.btn_sanpham);
            this.Controls.Add(this.btn_khachhang);
            this.Controls.Add(this.btn_nhanvien);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_nhanvien;
        private System.Windows.Forms.Button btn_khachhang;
        private System.Windows.Forms.Button btn_sanpham;
        private System.Windows.Forms.Button btn_hoadon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_tennhanvien;
        private System.Windows.Forms.Label lb_chucvu;
    }
}