using _1_DAL.Entities;
using _1_DAL.IRepositories;
using _1_DAL.Repositories;
using _2_BUS.IServices;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_BUS.Services
{
    public class HoaDonChiTietServices : IHoaDonChiTietServices
    {
    
        IHoaDonChiTietRepository _ihoadonchitietrepository;
        ISanPhamRepository _isanphamrepository;
        IHoaDonRepository _ihoadonrepository;

        public HoaDonChiTietServices()
        {
            _ihoadonchitietrepository = new HoaDonChiTietRepository();
            _isanphamrepository = new SanPhamRepository();
            _ihoadonrepository= new HoaDonRepository();
        }

        public string Add(HoaDonChiTietViews obj)
        {
            List<HoaDonChiTiet> lst = new List<HoaDonChiTiet>();
            if (obj == null) return "Thất bại";

            var a = new HoaDonChiTiet()
            {

                
                IdSP = obj.IdSP,
                IdHD = obj.IdHD,
                SoLuong = obj.SoLuong,
                TrangThai=obj.TrangThai,
               
                
            };
            if (_ihoadonchitietrepository.Add(a)) return "Thành Công";
            return "Thất bại";
        }

        public string Delete(HoaDonChiTietViews obj)
        {
            if (obj == null) return "Thất bại";

            var a = new HoaDonChiTiet()
            {

               
                IdSP = obj.IdSP,
                IdHD = obj.IdHD,
                SoLuong = obj.SoLuong,
                TrangThai=obj.TrangThai,
            };
            if (_ihoadonchitietrepository.Delete(a)) return "Thành Công";
            return "Thất bại";
        }

        public List<HoaDonChiTietViews> GetAll()
        {
            List<HoaDonChiTietViews> lst = new List<HoaDonChiTietViews>();
            lst = (from a in _ihoadonchitietrepository.GetAll()
                   join b in _isanphamrepository.GetAll()
                   on a.IdSP equals b.Id
                   join c in _ihoadonrepository.GetAll() on a.IdHD equals c.Id
                   select new HoaDonChiTietViews
                   {
                      
                       IdSP = b.Id,
                       IdHD = c.Id,
                       MaSP=b.Ma,
                       TenSP=b.Ten,
                       SoLuong = a.SoLuong,
                       DonGia=a.DonGia,
                       TrangThai = a.TrangThai,
                   }).ToList();
            return lst;

        }

        public string Update(HoaDonChiTietViews obj)
        {
            if (obj == null) return "Thất bại";

            var a = new HoaDonChiTiet()
            {

                
                IdSP = obj.IdSP,
                IdHD = obj.IdHD,
                SoLuong = obj.SoLuong,
               
                TrangThai=obj.TrangThai,
            };
            if (_ihoadonchitietrepository.Update(a)) return "Thành Công";
            return "Thất bại";
        }
    }
}
