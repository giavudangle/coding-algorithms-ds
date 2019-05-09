using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class PhanSo
    {
        private int tuSo;
        private int mauSo;


        public PhanSo()
        {

        }
        public PhanSo(int ts, int ms)
        {
            tuSo = ts;
            mauSo = ms;
        }
        private int GCD(int a, int b)
        {
            if (b % 2 == 0) return GCD(b, a % b);
            return a;
        }

        public void Nhap()
        {
            tuSo = int.Parse(Console.ReadLine());
            mauSo = int.Parse(Console.ReadLine());


        }

        public String In()
        {
            return tuSo + "/" + mauSo;
        }

        public double GiaTriThapPhan()
        {
            return tuSo *1.0 / mauSo;
        }

        public PhanSo Cong(PhanSo p)
        {
            int top = tuSo * p.mauSo + p.tuSo * mauSo;
            int down = mauSo * p.mauSo;
            return new PhanSo(top, down);
        }

        public PhanSo Tru(PhanSo p)
        {
            int top = tuSo * p.mauSo - p.tuSo * mauSo;
            int down = mauSo * p.mauSo;
            return new PhanSo(top, down);
        }

        public PhanSo Nhan(PhanSo p)
        {
            int top = tuSo * p.tuSo;
            int down = mauSo * p.mauSo;
            return new PhanSo(top, down);
        }
        public PhanSo Chia(PhanSo p)
        {
            int top = tuSo * p.tuSo + mauSo * p.mauSo;
            int down = mauSo * p.tuSo;
            return new PhanSo(top, down);
        }
    }
}