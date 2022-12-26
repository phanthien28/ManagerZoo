using ManagerZoo___Final_Exam.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerZoo___Final_Exam.Manager
{
    class QLKhu
    {
        public static List<Khu> listkhu = new List<Khu>();

        public static Khu checkKhu(String IDKhu)
        {
            foreach(Khu k in listkhu)
            {
                if(k.IDKhu1.Equals(IDKhu))
                {
                    return k;
                }    
            }
            return null;
        }

        public static 
    }
}
