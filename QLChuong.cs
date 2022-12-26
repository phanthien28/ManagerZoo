using ManagerZoo___Final_Exam.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerZoo___Final_Exam.Manager
{
    class QLChuong
    {
        public static List<Chuong> listchuong = new List<Chuong>();

        public static void hienthi()
        {
            int check = 0;
            Console.WriteLine("ID Chuong\t|\tTen Chuong\t|\t");
            foreach (Chuong c in listchuong)
            {
                check++;
                Console.WriteLine("{0}\t|\t{1}", c.IDChuong1, c.TenChuong1);
            }
            if(check == 0)
            {
                Console.WriteLine("Chuong nay khong ton tai !!!");
            }

        }

        public static Chuong checkChuong(String IDChuong)
        {
            foreach(Chuong c in listchuong)
            {
                if (c.IDChuong1.Equals(IDChuong))
                {
                    return c;
                }    
            }
            return null;
        }

        public static int menu()
        {
            int i;
            Console.WriteLine("----------Quan Li Chuong----------");
            Console.WriteLine("1. DANH SACH Thu");
            Console.WriteLine("2. Them thu");
            Console.WriteLine("3. Xoa thu");
            Console.WriteLine("4. Thoat");
            Console.WriteLine("Moi ban chon tu 1-4");
            i = checkLoi.KiemTraChon(Console.ReadLine());
            return i;
        }
    }
}
