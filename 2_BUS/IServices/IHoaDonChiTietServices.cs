using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.IServices
{
    public interface IHoaDonChiTietServices
    {
        string Add(HoaDonChiTietViews obj);
        string Update(HoaDonChiTietViews obj);
        string Delete(HoaDonChiTietViews obj);
        List<HoaDonChiTietViews> GetAll();
    }
}
