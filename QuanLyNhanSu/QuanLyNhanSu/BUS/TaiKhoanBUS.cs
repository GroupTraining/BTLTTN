using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BUS
{
    public class TaiKhoanBUS
    {
        QLTaiKhoanDataContext tks = new QLTaiKhoanDataContext();
        public bool check_login(string username, string pass)
        {
            int taikhoan = (from tk in tks.TaiKhoans
                      where tk.username == username && tk.password == pass
                      select tk).Count();
            if (taikhoan == 1)
                return true;
            else
                return false;
        }
        public object getData()
        {
            var nhanvien = (from nv in tks.NhanViens
                            select nv);
            return nhanvien;

        }
        public object Delete(string ma)
        {
            var nv = from a in tks.NhanViens
                     where a.MaNV == ma
                     select a;
            tks.NhanViens.DeleteAllOnSubmit(nv);
            var nv1 = from b in tks.PhanCongs
                      where b.MaNV == ma
                      select b;
            tks.PhanCongs.DeleteAllOnSubmit(nv1);
            tks.SubmitChanges();
            return 1;
        }
        public object Edit(string ma, string ten, string ns, string gt, string ma_pb, string ma_da)
        {
            NhanVien nv = tks.NhanViens.Single(a => a.MaNV == ma);
            nv.MaNV = ma;
            nv.HoTen = ten;
            nv.NS = DateTime.Parse(ns);
            nv.GT = Boolean.Parse(gt);
            nv.MaPB = ma_pb;

            PhanCong pc = tks.PhanCongs.Single(a => a.MaNV == ma);
            pc.MaNV = ma;
            pc.MaDA = ma_da;
            tks.SubmitChanges();
            return 1;
        }
    }

}
    