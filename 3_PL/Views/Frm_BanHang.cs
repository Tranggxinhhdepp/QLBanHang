using _2_BUS.IServices;
using _2_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class Frm_BanHang : Form
    {
        IHoaDonServices _ihoadonservices;
        ISanPhamServices _isanphamservices;
        IHoaDonChiTietServices _ihoadonchiTietservices;
        public Frm_BanHang()
        {
            InitializeComponent();
            _ihoadonservices = new HoaDonServices();
            _isanphamservices=new SanPhamServices();
            _ihoadonchiTietservices = new HoaDonChiTietServices();
            LoadSP();
            LoadGioHang();
        }
        public void LoadSP()
        {
            dgrid_sanpham.ColumnCount = 7;
            int stt = 1;
            dgrid_sanpham.Columns[0].Name = "ID";
            dgrid_sanpham.Columns[0].Visible = false;
            dgrid_sanpham.Columns[1].Name = "STT";
            dgrid_sanpham.Columns[2].Name = "Mã SP";
            dgrid_sanpham.Columns[3].Name = "Tên SP";
            dgrid_sanpham.Columns[4].Name = "Số lượng";
            dgrid_sanpham.Columns[5].Name = "Giá Nhập";
            dgrid_sanpham.Columns[6].Name = "Giá bán";
            dgrid_sanpham.Rows.Clear();
            foreach (var x in _isanphamservices.GetAll())
            {
                dgrid_sanpham.Rows.Add(x.Id, stt++, x.MaSP, x.TenSP, x.SoLuongTon, x.GiaNhap, x.GiaBan);
            }
        }
        public void LoadGioHang()
        {
            dgrid_giohan.ColumnCount=6;
            int stt = 1;
           
            dgrid_giohan.Columns[0].Name = "STT";
            dgrid_giohan.Columns[1].Name = "Mã SP";
            dgrid_giohan.Columns[2].Name = "Tên SP";
            dgrid_giohan.Columns[3].Name = "Số lượng";
            dgrid_giohan.Columns[4].Name = "Đơn giá";
            dgrid_giohan.Columns[5].Name = "Thành Tiền";
            dgrid_giohan.Rows.Clear();
            foreach (var x in _ihoadonchiTietservices.GetAll())
            {
                dgrid_giohan.Rows.Add(stt++, x.MaSP, x.TenSP, x.SoLuong, x.DonGia, (x.DonGia * x.SoLuong));
            }
        }
        public void LoadHoaDon()
        {

        }

    }
}
