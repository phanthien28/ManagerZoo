using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerZoo___Final_Exam.Model
{
    class Chuong
    {
        String IDChuong;
        String IDKhu;
        String TenChuong;
        List<Thu> listThu;

        public string IDChuong1 { get => IDChuong; set => IDChuong = value; }
        public string IDKhu1 { get => IDKhu; set => IDKhu = value; }
        public string TenChuong1 { get => TenChuong; set => TenChuong = value; }
        internal List<Thu> ListThu { get => listThu; set => listThu = value; }

        public Chuong(string iDChuong, string iDKhu, string tenChuong, List<Thu> listthu)
        {
            IDChuong = iDChuong;
            IDKhu = iDKhu;
            TenChuong = tenChuong;
            this.listThu = listthu;
        }

        public Chuong()
        {
        }
    }
}
