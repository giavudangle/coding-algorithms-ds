using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Exercise_9
{
    class Exercise_9
    {
        static void Main(string[] args)
        {
            int m, n, k;
            int[,] a;
            int[,] b;
            string[] tokens;
            string line;


            using (StreamReader myFile = new StreamReader("E:\\INP.txt"))
            {
                line = myFile.ReadLine();
                tokens = line.Split(' ');
                m = int.Parse(tokens[0]);
                n = int.Parse(tokens[1]);
                k = int.Parse(tokens[2]);

                int row = m;
                int col = n;
                a = new int[m, n];
                b = new int[k, k];
                int resRow = m - k + 1;
                int resCol = n - k + 1;
                int[,] result = new int[resRow, resCol];
                //.WriteLine(resRow);
                //Console.WriteLine(resCol);
                for (int i = 0; i < m; i++)
                {
                    line = myFile.ReadLine();
                    tokens = line.Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        a[i, j] = int.Parse(tokens[j]);
                    }
                }

                for (int i = 0; i < k; i++)
                {
                    line = myFile.ReadLine();
                    tokens = line.Split(' ');
                    for (int j = 0; j < k; j++)
                    {
                        b[i, j] = int.Parse(tokens[j]);
                    }

                    // find center position of kernel (half of kernel size)
                    int kCenterX = k / 2;
                    int kCenterY = k / 2;
                    int zz = 0, xx = 0, ii = 0, jj = 0;
                    int q=0, w=0, e=0, r=0;
                    for (q = 0; q < m; ++q)              // rows
                    {
                        for ( w = 0; w < n; ++w)          // columns
                        {
                            for ( e = 0; e < k; ++e)     // kernel rows
                            {
                                zz = k - 1 - e;      // fix size

                                for ( r = 0; r < k; ++r) // kernel columns
                                {
                                    xx = k - 1 - r;  // fix size

                                    // check input true ?
                                    ii = q + (kCenterY - zz);
                                    jj = w + (kCenterX - xx);
                                    //Console.WriteLine(ii);
                                    //Console.WriteLine(jj);
                                    int[,] check = new int[ii, jj];
                                    int[,] temp = new int[zz, xx];
                                    // check input false?
                                    if (ii >= 0 && ii < row && jj >= 0 && jj < col)
                                        result[q, w] += check[ii, jj] * b[zz, xx];
                                }
                            }
                        }
                    }
                }
                using (StreamWriter outFile = new StreamWriter("E:\\OUT.txt"))
                {
                    for (int i = 0; i < resRow; i++)
                    {
                        for (int j = 0; j < resCol; j++)
                        {
                            outFile.Write("{0} ", result[resRow, resCol]);
                        }
                    }
                }
            }


        }
    }
}
