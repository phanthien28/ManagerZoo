using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerZoo___Final_Exam.Manager
{
    class checkLoi
    {
        public static int KiemTraChon(String check)
        {
            int menu = 0;
            try
            {
                menu = Convert.ToInt32(check);
            }catch(Exception ex)
            {
             
            }
            return menu;
        }
    }
}
