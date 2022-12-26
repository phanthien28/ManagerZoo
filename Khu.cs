using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerZoo___Final_Exam.Model
{
    class Khu
    {
        String IDKhu;
        String TenKhu;
        List<Chuong> listChuong;

        public string IDKhu1 { get => IDKhu; set => IDKhu = value; }
        public string TenKhu1 { get => TenKhu; set => TenKhu = value; }
        internal List<Chuong> ListChuong { get => listChuong; set => listChuong = value; }

        public Khu(string iDKhu, string tenKhu, List<Chuong> listchuong)
        {
            IDKhu = iDKhu;
            TenKhu = tenKhu;
            this.listChuong = listchuong;
        }

        public Khu()
        {
        }
    }
}
