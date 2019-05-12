using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
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
            return tuSo * 1.0 / mauSo;
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

        public bool isEqual(PhanSo p)
        {
            if (tuSo * p.mauSo == mauSo * p.tuSo) return true;
            return false;
        }

        public bool isNotEqual(PhanSo p)
        {
            if (tuSo * p.mauSo != mauSo * p.tuSo) return true;
            return false;
        }

        public bool isGreatter(PhanSo p)
        {
            // Cùng mẫu,tử lớn hơn là lớn hơn
            // Ko cùng mẫu,mẫu lớn hơn thì bé hơn
            // return true tức phân số hiện tại lớn hơn phân số truyền vào
            if (mauSo == p.mauSo && tuSo > p.tuSo) return true;
            if (p.mauSo > mauSo) return true;
            return false;
            
        }

        public bool isLess(PhanSo p)
        {
            // Cùng mẫu,tử nhỏ hơn là nhỏ hơn
            // Ko cùng mẫu,mẫu lớn phân số càng bé.Tức phân số hiện tại bé hơn
            // return true tức phân số hiện tại bé hơn phân số truyền vào
            if (mauSo == p.mauSo && tuSo < p.tuSo) return true;
            if (mauSo>p.mauSo) return true;
            return false;
        }

        // Tương tự >= <=
        public bool isUpperBound(PhanSo p)
        {                   
            if (mauSo == p.mauSo && tuSo >= p.tuSo) return true;
            if (p.mauSo >= mauSo) return true;
            return false;
        }

        public bool isLowerBound(PhanSo p)
        {
            if (mauSo == p.mauSo && tuSo < p.tuSo) return true;
            if (mauSo > p.mauSo) return true;
            return false;
        }


    }
}
