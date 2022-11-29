namespace _3_PL.Views
{
    partial class FrmQuenMatKhau
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
            this.lb_thoat = new System.Windows.Forms.Label();
            this.btn_luu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_tendangnhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_matkhau2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_hienthi = new System.Windows.Forms.Label();
            this.lb_tendn = new System.Windows.Forms.Label();
            this.lb_mk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_thoat
            // 
            this.lb_thoat.AutoSize = true;
            this.lb_thoat.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lb_thoat.ForeColor = System.Drawing.Color.Red;
            this.lb_thoat.Location = new System.Drawing.Point(169, 233);
            this.lb_thoat.Name = "lb_thoat";
            this.lb_thoat.Size = new System.Drawing.Size(50, 21);
            this.lb_thoat.TabIndex = 31;
            this.lb_thoat.Text = "Thoát";
            this.lb_thoat.Click += new System.EventHandler(this.lb_thoat_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_luu.Location = new System.Drawing.Point(370, 227);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(124, 32);
            this.btn_luu.TabIndex = 30;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(238, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 30);
            this.label3.TabIndex = 29;
            this.label3.Text = "Quên Mật Khẩu ";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(274, 124);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(239, 23);
            this.txt_matkhau.TabIndex = 28;
            // 
            // txt_tendangnhap
            // 
            this.txt_tendangnhap.Location = new System.Drawing.Point(274, 84);
            this.txt_tendangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tendangnhap.Name = "txt_tendangnhap";
            this.txt_tendangnhap.Size = new System.Drawing.Size(239, 23);
            this.txt_tendangnhap.TabIndex = 27;
            this.txt_tendangnhap.TextChanged += new System.EventHandler(this.txt_tendangnhap_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mật Khẩu : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tên Đăng Nhập :";
            // 
            // txt_matkhau2
            // 
            this.txt_matkhau2.Location = new System.Drawing.Point(274, 168);
            this.txt_matkhau2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_matkhau2.Name = "txt_matkhau2";
            this.txt_matkhau2.Size = new System.Drawing.Size(239, 23);
            this.txt_matkhau2.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nhập Lại Mật Khẩu : ";
            // 
            // lb_hienthi
            // 
            this.lb_hienthi.AutoSize = true;
            this.lb_hienthi.Font = new System.Drawing.Font("Segoe UI", 5.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lb_hienthi.ForeColor = System.Drawing.Color.Red;
            this.lb_hienthi.Location = new System.Drawing.Point(274, 193);
            this.lb_hienthi.Name = "lb_hienthi";
            this.lb_hienthi.Size = new System.Drawing.Size(0, 10);
            this.lb_hienthi.TabIndex = 34;
            // 
            // lb_tendn
            // 
            this.lb_tendn.AutoSize = true;
            this.lb_tendn.Font = new System.Drawing.Font("Segoe UI", 5.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lb_tendn.ForeColor = System.Drawing.Color.Red;
            this.lb_tendn.Location = new System.Drawing.Point(274, 109);
            this.lb_tendn.Name = "lb_tendn";
            this.lb_tendn.Size = new System.Drawing.Size(0, 10);
            this.lb_tendn.TabIndex = 35;
            // 
            // lb_mk
            // 
            this.lb_mk.AutoSize = true;
            this.lb_mk.Font = new System.Drawing.Font("Segoe UI", 5.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lb_mk.ForeColor = System.Drawing.Color.Red;
            this.lb_mk.Location = new System.Drawing.Point(274, 149);
            this.lb_mk.Name = "lb_mk";
            this.lb_mk.Size = new System.Drawing.Size(0, 10);
            this.lb_mk.TabIndex = 36;
            // 
            // FrmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 311);
            this.Controls.Add(this.lb_mk);
            this.Controls.Add(this.lb_tendn);
            this.Controls.Add(this.lb_hienthi);
            this.Controls.Add(this.txt_matkhau2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_thoat);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_tendangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmQuenMatKhau";
            this.Text = "FrmQuenMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_thoat;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_tendangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_matkhau2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_hienthi;
        private System.Windows.Forms.Label lb_tendn;
        private System.Windows.Forms.Label lb_mk;
    }
}