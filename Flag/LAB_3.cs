using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication2
{
    class Program
    {
        static int n;
        static string line;
        
        public static void Input()
        {
            using (StreamReader myFile=new StreamReader("D:\\INP.txt"))
            {
                line = myFile.ReadLine();
                n = int.Parse(line);
            }
        }
        public static bool isPrime(int n)
        {
            if (n < 2) return false;
            if (n < 4) return true;
            if (n % 2 == 0 || n % 3 == 0) return false;
            long bound = (int)Math.Sqrt(n);
            for (int i = 5; i <= bound; i+=6)          
                if ( (n % i == 0 ) || (n % (i + 2) == 0) ) return false;
            return true;      
        }

        public static void Output()
        {
            using (StreamWriter outFile = new StreamWriter("D:\\OUT.txt"))
            {
               outFile.Write(isPrime(n) ? "YES" : "NO");
            }
        }

        static void Main(string[] args)
        {
            Input();
            isPrime(n);
            Output();

        }
    }
}
