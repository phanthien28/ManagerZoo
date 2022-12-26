using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerZoo___Final_Exam.Model
{
    class Thu
    {
        String LoaiThu;
        String IDThu;
        String IDChuong;
        String Ten;
        String NgayNuoi;
        String NguonGoc;
        String SucKhoe;

        public string LoaiThu1 { get => LoaiThu; set => LoaiThu = value; }
        public string IDThu1 { get => IDThu; set => IDThu = value; }
        public string IDChuong1 { get => IDChuong; set => IDChuong = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public string NgayNuoi1 { get => NgayNuoi; set => NgayNuoi = value; }
        public string NguonGoc1 { get => NguonGoc; set => NguonGoc = value; }
        public string SucKhoe1 { get => SucKhoe; set => SucKhoe = value; }

        public Thu(string loaiThu, string iDThu, string iDChuong, string ten, string ngayNuoi, string nguonGoc, string sucKhoe)
        {
            LoaiThu = loaiThu;
            IDThu = iDThu;
            IDChuong = iDChuong;
            Ten = ten;
            NgayNuoi = ngayNuoi;
            NguonGoc = nguonGoc;
            SucKhoe = sucKhoe;
        }

        public Thu()
        {
        }
    }
}
