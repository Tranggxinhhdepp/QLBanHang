namespace _3_PL.Views
{
    partial class FrmHinhThucThanhToan
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.txt_loaihinh = new System.Windows.Forms.TextBox();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.rbn_hoatdong = new System.Windows.Forms.RadioButton();
            this.rbn_khonghd = new System.Windows.Forms.RadioButton();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.dtg_hienthi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(246, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hình Thức Thanh Toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hình thức :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại hình thanh toán :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng tiền thanh toán :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trạng thái :";
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(214, 54);
            this.txt_ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(332, 23);
            this.txt_ma.TabIndex = 5;
            // 
            // txt_loaihinh
            // 
            this.txt_loaihinh.Location = new System.Drawing.Point(214, 98);
            this.txt_loaihinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_loaihinh.Name = "txt_loaihinh";
            this.txt_loaihinh.Size = new System.Drawing.Size(332, 23);
            this.txt_loaihinh.TabIndex = 6;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(214, 144);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(332, 23);
            this.txt_tongtien.TabIndex = 7;
            // 
            // rbn_hoatdong
            // 
            this.rbn_hoatdong.AutoSize = true;
            this.rbn_hoatdong.Location = new System.Drawing.Point(214, 186);
            this.rbn_hoatdong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbn_hoatdong.Name = "rbn_hoatdong";
            this.rbn_hoatdong.Size = new System.Drawing.Size(82, 19);
            this.rbn_hoatdong.TabIndex = 8;
            this.rbn_hoatdong.TabStop = true;
            this.rbn_hoatdong.Text = "Hoạt động";
            this.rbn_hoatdong.UseVisualStyleBackColor = true;
            // 
            // rbn_khonghd
            // 
            this.rbn_khonghd.AutoSize = true;
            this.rbn_khonghd.Location = new System.Drawing.Point(402, 186);
            this.rbn_khonghd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbn_khonghd.Name = "rbn_khonghd";
            this.rbn_khonghd.Size = new System.Drawing.Size(118, 19);
            this.rbn_khonghd.TabIndex = 9;
            this.rbn_khonghd.TabStop = true;
            this.rbn_khonghd.Text = "Không hoạt động";
            this.rbn_khonghd.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(587, 50);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(131, 30);
            this.btn_them.TabIndex = 10;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(587, 97);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(131, 30);
            this.btn_sua.TabIndex = 11;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(587, 146);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(131, 30);
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // dtg_hienthi
            // 
            this.dtg_hienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_hienthi.Location = new System.Drawing.Point(37, 232);
            this.dtg_hienthi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_hienthi.Name = "dtg_hienthi";
            this.dtg_hienthi.RowHeadersWidth = 51;
            this.dtg_hienthi.RowTemplate.Height = 29;
            this.dtg_hienthi.Size = new System.Drawing.Size(682, 141);
            this.dtg_hienthi.TabIndex = 13;
            this.dtg_hienthi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_hienthi_CellClick);
            // 
            // FrmHinhThucThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(755, 382);
            this.Controls.Add(this.dtg_hienthi);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.rbn_khonghd);
            this.Controls.Add(this.rbn_hoatdong);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.txt_loaihinh);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmHinhThucThanhToan";
            this.Text = "Hình Thức Thanh Toán";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hienthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.TextBox txt_loaihinh;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.RadioButton rbn_hoatdong;
        private System.Windows.Forms.RadioButton rbn_khonghd;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.DataGridView dtg_hienthi;
    }
}