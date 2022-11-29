namespace _3_PL.Views
{
    partial class FrmChucVu
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
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dtg_hienthi = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tenchucvu = new System.Windows.Forms.TextBox();
            this.txt_machucvu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(401, 139);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(92, 25);
            this.btn_xoa.TabIndex = 17;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(256, 139);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(92, 25);
            this.btn_sua.TabIndex = 16;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(102, 139);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(92, 25);
            this.btn_them.TabIndex = 15;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dtg_hienthi
            // 
            this.dtg_hienthi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtg_hienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_hienthi.Location = new System.Drawing.Point(74, 179);
            this.dtg_hienthi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_hienthi.Name = "dtg_hienthi";
            this.dtg_hienthi.RowHeadersWidth = 51;
            this.dtg_hienthi.RowTemplate.Height = 29;
            this.dtg_hienthi.Size = new System.Drawing.Size(451, 141);
            this.dtg_hienthi.TabIndex = 14;
            this.dtg_hienthi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_hienthi_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(256, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Chức Vụ";
            // 
            // txt_tenchucvu
            // 
            this.txt_tenchucvu.Location = new System.Drawing.Point(244, 94);
            this.txt_tenchucvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenchucvu.Name = "txt_tenchucvu";
            this.txt_tenchucvu.Size = new System.Drawing.Size(239, 23);
            this.txt_tenchucvu.TabIndex = 12;
            // 
            // txt_machucvu
            // 
            this.txt_machucvu.Location = new System.Drawing.Point(244, 54);
            this.txt_machucvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_machucvu.Name = "txt_machucvu";
            this.txt_machucvu.Size = new System.Drawing.Size(239, 23);
            this.txt_machucvu.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Chức Vụ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã Chức Vụ :";
            // 
            // FrmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(630, 355);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dtg_hienthi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tenchucvu);
            this.Controls.Add(this.txt_machucvu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmChucVu";
            this.Text = "FrmChucVu";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hienthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dtg_hienthi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tenchucvu;
        private System.Windows.Forms.TextBox txt_machucvu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}