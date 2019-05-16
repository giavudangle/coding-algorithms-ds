using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
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

        public static PhanSo operator + (PhanSo p1,PhanSo p2)
        {
            PhanSo res = new PhanSo();
            res.tuSo= p1.tuSo * p2.mauSo + p2.tuSo * p1.mauSo;
            res.mauSo = p1.mauSo * p2.mauSo;
            return res;
        }

        public static PhanSo operator -(PhanSo p1, PhanSo p2)
        {
            PhanSo res = new PhanSo();
            res.tuSo = p1.tuSo * p2.mauSo - p2.tuSo * p1.mauSo;
            res.mauSo = p1.mauSo * p2.mauSo;
            return res;
        }


        public static PhanSo operator *(PhanSo p1, PhanSo p2)
        {
            PhanSo res = new PhanSo();
            res.tuSo = p1.tuSo*p2.tuSo;
            res.mauSo = p1.mauSo * p2.mauSo;
            return res;
        }    
        public static PhanSo operator /(PhanSo p1, PhanSo p2)
        {
            PhanSo res = new PhanSo();
            res.tuSo = p1.tuSo * p2.tuSo + p1.mauSo * p2.mauSo;
            res.mauSo = p1.mauSo * p2.tuSo;
            return res;
        }
        
        public static bool operator ==(PhanSo p1, PhanSo p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(PhanSo p1, PhanSo p2)
        {
            return !p1.Equals(p2);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static bool operator < (PhanSo p1, PhanSo p2)
        {
            if (p1.mauSo == p2.mauSo && p1.tuSo < p2.tuSo) return true;
            if (p1.mauSo > p2.mauSo) return true;
            return false;
        }

        public static bool operator >(PhanSo p1, PhanSo p2)
        {
            if (p1.mauSo == p2.mauSo && p1.tuSo > p2.tuSo) return true;
            if (p1.mauSo < p2.mauSo) return true;
            return false;
        }

        public static bool operator <=(PhanSo p1, PhanSo p2)
        {
            if (p1 < p2 || p1==p2) return true;
            return false;
        }

        public static bool operator >=(PhanSo p1, PhanSo p2)
        {
            if (p1 > p2 || p1==p2) return true;
            return false;
        }

    }
}
