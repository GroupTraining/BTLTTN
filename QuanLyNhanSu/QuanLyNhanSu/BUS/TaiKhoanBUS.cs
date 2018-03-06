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
            var data = from u in tks.NhanViens
                       from t in tks.PhongBans
                       from v in tks.PhanCongs
                       from z in tks.DuAns
                       where u.MaNV == v.MaNV
                       where v.MaDA == z.MaDA
                       where u.MaPB == t.MaPB
                       select new
                       {
                           MaNV = u.MaNV,
                           HoTen = u.HoTen,
                           NS = u.NS,
                           GT = u.GT,
                           TenPB = t.TenPB,
                           TenDA = z.TenDA
                       };
            return data;
        }
        public object Search(string text)
        {
           var data = from u in tks.NhanViens
                        from t in tks.PhongBans
                        from v in tks.PhanCongs
                        from z in tks.DuAns
                        where u.MaNV == v.MaNV
                        where v.MaDA == z.MaDA
                        where u.MaPB == t.MaPB
                        select new
                        {
                            MaNV = u.MaNV,
                            HoTen = u.HoTen,
                            NS = u.NS,
                            GT = u.GT,
                            TenPB = t.TenPB,
                            TenDA = z.TenDA
                        } into timkiemNV
                        where timkiemNV.MaNV.Contains(text)
                        || timkiemNV.HoTen.Contains(text)
                        || timkiemNV.TenPB.Contains(text)
                        || timkiemNV.TenDA.Contains(text)
                        select timkiemNV;
            return data;
            
        }
        public object getData1()
        {
            var data = from u in tks.NhanViens
                       from t in tks.PhongBans
                       from v in tks.PhanCongs
                       from z in tks.DuAns
                       where u.MaNV == v.MaNV
                       where v.MaDA == z.MaDA
                       where u.MaPB == t.MaPB
                       select new
                       {
                           MaNV = u.MaNV,
                           HoTen = u.HoTen,
                           NS = u.NS,
                           GT = u.GT,
                           MaPB = t.MaPB,
                           MaDA = v.MaDA
                       };

            return data;    
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
            if(gt == "Nam")
            {
                nv.GT = false;
            }if(gt == "Nữ")
            {
                nv.GT = true;
            }
            nv.MaPB = ma_pb;

            tks.SubmitChanges();
            return 1;
        }
    }
}
    