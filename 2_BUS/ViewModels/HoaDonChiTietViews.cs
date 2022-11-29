using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.ViewModels
{
    public class HoaDonChiTietViews
    {
        
        public Guid IdSP { get; set; }
        public Guid IdHD { get; set; }
        public int SoLuong { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public double DonGia { get; set; }
        public int TrangThai { get; set; }
    }
}
