using _1_DAL.Entities;
using _1_DAL.IRepositories;
using _1_DAL.Repositories;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3_PL.Views
{
   
    public partial class FrmDangNhap : Form
    {
        INhanVienRepository _inhanvienrep;
        IChucVuRepository _ichucvurepository;
        public FrmDangNhap()
        {
            InitializeComponent();
            _inhanvienrep = new NhanVienRepository();
            _ichucvurepository = new ChucVuRepository();
            GetAll();
        }

        public List<ChucVuView> GetAll()
        {
            List<ChucVuView> lst = new List<ChucVuView>();
            lst = (from a in _inhanvienrep.GetAll()
                      join b in _ichucvurepository.GetAll()
                      on a.IdCV equals b.Id
                      select new ChucVuView()
                      {
                          Ma = b.Ma,
                          Ten = b.Ten,
                          Id = b.Id,
                      }).ToList();
                             
            return lst;
        }
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {

            int stt=0;
            foreach (var x in _inhanvienrep.GetAll())
            {
                if (x.Email == txt_tendangnhap.Text && x.MatKhau == txt_matkhau.Text)
                {
                    var name = GetAll().FirstOrDefault(c => c.Id == x.IdCV).Ten;
                    string hovaten = x.Ho +" "+ x.TenDem +" " +x .Ten; 
                    FrmMenu menu = new FrmMenu(name,hovaten);
                     stt = 1;
                    menu.ShowDialog();
                    break;
                }
            }
            if (stt != 1 )
            {
                MessageBox.Show("Tài khoản không tồn tại đâu ạ !!!!");
            }
        }
        private void lb_quenmatkhau_Click(object sender, EventArgs e)
        {
            FrmQuenMatKhau qmk = new FrmQuenMatKhau();
            qmk.ShowDialog();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tendangnhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
