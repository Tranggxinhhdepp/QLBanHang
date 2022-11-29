using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.IServices
{
    public interface IHoaDonServices
    {
        string Add(HoaDonViews obj);
        string Update(HoaDonViews obj);
        string Delete(HoaDonViews obj);
        List<HoaDonViews> GetAll();
    }
}
