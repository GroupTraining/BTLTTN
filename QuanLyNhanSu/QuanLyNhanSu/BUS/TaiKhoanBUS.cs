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
    }
}
    