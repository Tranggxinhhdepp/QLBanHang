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
    public partial class FrmQuenMatKhau : Form
    {
        INhanVienRepository _inhanvienrep;
        public FrmQuenMatKhau()
        {
            InitializeComponent();
            _inhanvienrep = new NhanVienRepository();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            foreach (var x in _inhanvienrep.GetAll())
            {
                //lb_tendn.Text = "";
                //lb_mk.Text = "";
                //lb_hienthi.Text = ""; 
                //txt_matkhau.Enabled = true;
                //txt_matkhau2.Enabled = true;
                if (x.Email != txt_tendangnhap.Text)
                {
                    txt_matkhau.Enabled = true;
                    txt_matkhau2.Enabled = true;
                    lb_tendn.Text = "Tên đăng nhập không tồn tại ";
                }
                else
                if (x.Email == txt_tendangnhap.Text && txt_matkhau.Text == "")
                {
                    lb_tendn.Text = "";
                    txt_matkhau.Enabled = true;
                    txt_matkhau2.Enabled = true;
                    lb_mk.Text = "Nhập mật khẩu đã ";
                }
                else
                if (x.Email == txt_tendangnhap.Text && txt_matkhau.Text != null && txt_matkhau2.Text == txt_matkhau.Text)
                {
                    txt_matkhau.Enabled = true;
                    txt_matkhau2.Enabled = true;
                    lb_tendn.Text = "";
                    lb_mk.Text = "";
                    x.Email = txt_tendangnhap.Text;
                    x.MatKhau = txt_matkhau.Text;
                    _inhanvienrep.Add(x);
                    MessageBox.Show("Thành Công ");
                    break;
                }
            }
        }

        private void lb_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap dn = new FrmDangNhap();
            dn.ShowDialog();
        }

        private void txt_tendangnhap_TextChanged(object sender, EventArgs e)
        {
        //    foreach (var x in _inhanvienrep.GetAll())
        //    {
        //        if (x.Email != txt_tendangnhap.Text)
        //        {
        //            lb_tendn.Text = "Tên đăng nhập không tồn tại ";
        //            txt_matkhau.Enabled = false;
        //            txt_matkhau2.Enabled = false;
        //        }
        //        else
        //        if (x.Email == txt_tendangnhap.Text )
        //        {
        //            lb_tendn.Text = "";
        //            lb_mk.Text = "Nhập mật khẩu đã ";
        //            txt_matkhau2.Enabled = false;
        //        }
               
            //}
        }
    }
}
