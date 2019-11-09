using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKT
{
    class SinhVien
    {
        private int MaSV;
        private string HoTenSv;
        private int NgaySinh;
        private string Lop;
        private string Khoa;

        public int MASV { get => MaSV; set => MaSV = value; }
        public string HOTENSV { get => HoTenSv; set => HoTenSv = value; }
        public int NGAYSINH{ get => NgaySinh; set => NgaySinh = value; }
        public string LOP { get => Lop; set => Lop = value; }
        public string KHOA { get => Khoa; set => Khoa = value; }




        public SinhVien(int MaSV, string HoTenSv, int NgaySinh, string Lop, string Khoa)
        {
            this.MaSV = MaSV;
            this.HoTenSv = HoTenSv;
            this.NgaySinh = NgaySinh;
            this.Lop = Lop;
            this.Khoa = Khoa;
        }   

        public SinhVien()
        {

        }

        public void Print()
        {
            Console.WriteLine(MASV);
            Console.WriteLine(HOTENSV);
            Console.WriteLine(NGAYSINH);
            Console.WriteLine(LOP);
            Console.WriteLine(KHOA);

        }


    }
}
