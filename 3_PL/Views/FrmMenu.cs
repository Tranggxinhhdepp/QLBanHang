using _1_DAL.IRepositories;
using _1_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class FrmMenu : Form
    {
        private string quanly;
        INhanVienRepository _inhanvienrep;
        public FrmMenu()
        {
            InitializeComponent();
            _inhanvienrep = new NhanVienRepository();
        }
        public FrmMenu(string chucvu,string tennv)
        {
            InitializeComponent();
            _inhanvienrep = new NhanVienRepository();
            lb_chucvu.Text = chucvu;
            lb_tennhanvien.Text = tennv;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {



        }
        
        private void button4_Click_1(object sender, EventArgs e)
        {
            FrmHoaDon hoadon = new FrmHoaDon();
            hoadon.ShowDialog();
            this.Hide();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            if (lb_chucvu.Text == "Quản Lý")
            {
                btn_hoadon.Enabled = true;
                btn_khachhang.Enabled = true;
                btn_nhanvien.Enabled = true;
                btn_sanpham.Enabled = true;
            }
            else
            {

                btn_hoadon.Enabled = true;
                btn_khachhang.Enabled = true;
                btn_nhanvien.Enabled = false;
                btn_sanpham.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            FrmNhanVien nv = new FrmNhanVien();
            nv.ShowDialog();
            this.Hide();

        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            FrmSanPham sp = new FrmSanPham();
            sp.ShowDialog();
            this.Hide();

        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            FrmKhachHang kh = new FrmKhachHang();
            kh.ShowDialog();
            this.Hide();

        }
    }
}
