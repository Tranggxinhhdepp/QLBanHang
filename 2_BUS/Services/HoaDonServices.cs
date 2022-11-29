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
   
        public class HoaDonServices : IHoaDonServices
        {
            IHoaDonRepository _ihoadonrepository;
            IHoaDonChiTietRepository _ihoadonchitietrepository;
            IHinhThucThanhToanRepository _ihinhthucthanhtoanrepository;
            IKhachHangRepository _ikhachhangrepository;
            INhanVienRepository _inhanvienrepository;
            public HoaDonServices()
            {
                _ihoadonrepository = new HoaDonRepository();
                _ihinhthucthanhtoanrepository = new HinhThucThanhToanRepository();
                _ikhachhangrepository = new KhachHangRepository();
                _ihoadonchitietrepository = new HoaDonChiTietRepository();
            }

            public string Add(HoaDonViews obj)
            {
                if (obj == null) return "Thất bại";
                var a = new HoaDon()
                {
                    Id = obj.Id,
                    IdKH = obj.IdKH,
                    IdNV = obj.IdNV,
                    NgayTao = obj.NgayTao,
                    NgayThanhToan = obj.NgayThanhToan,
                    TongTien = obj.TongTien,
                    TrangThai = Convert.ToInt32(obj.TrangThai),
                };
                if (_ihoadonrepository.Add(a)) return "Thành Công";
                return "Thất bại";
            }

            public string Delete(HoaDonViews obj)
            {
                if (obj == null) return "Thất bại";
                var a = new HoaDon()
                {
                    Id = obj.Id,
                    IdKH = obj.IdKH,
                    IdNV = obj.IdNV,
                    NgayTao = obj.NgayTao,
                    NgayThanhToan = obj.NgayThanhToan,
                    TongTien = obj.TongTien,
                    TrangThai = Convert.ToInt32(obj.TrangThai),
                };
                if (_ihoadonrepository.Delete(a)) return "Thành Công";
                return "Thất bại";
            }

            public List<HoaDonViews> GetAll()
            {
                List<HoaDonViews> lst = new List<HoaDonViews>();
                lst = (from a in _ihoadonrepository.GetAll()
                       join b in _ihinhthucthanhtoanrepository.GetAll() on a.Id equals b.IdHD
                       join c in _ikhachhangrepository.GetAll() on a.IdKH equals c.Id
                       select new HoaDonViews()
                       {
                           Id = a.Id,
                           IdKH = c.Id,
                           IdNV = b.IdNV,
                           NgayTao = a.NgayTao,
                           NgayThanhToan = a.NgayThanhToan,
                           TongTien = a.TongTien,
                           TrangThai = a.TrangThai,
                       }).ToList();
                return lst;
            }

            public string Update(HoaDonViews obj)
            {
                if (obj == null) return "Thất bại";
                var a = new HoaDon()
                {
                    Id = obj.Id,
                    IdKH = obj.IdKH,
                    IdNV = obj.IdNV,
                    NgayTao = obj.NgayTao,
                    NgayThanhToan = obj.NgayThanhToan,
                    TongTien = obj.TongTien,
                    TrangThai = Convert.ToInt32(obj.TrangThai),
                };
                if (_ihoadonrepository.Update(a)) return "Thành Công";
                return "Thất bại";
            }
        }
    }

