using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinhHopKhongLap
{
    class Program
    {
        static int[] a = new int[20];
        static int n, k, dem = 0;
        static bool[] b = new bool[20];

        static void Xuat()
        {
            for (int i = 1; i <= k; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }
        static void ChinhhopKhonglap(int i)
        {
            if (i > k) Xuat();
            else 
                for (int j = 1; j <= n; j++)
                {
                    if (b[j] == false)
                    {
                        a[i] = j;
                        if (i == k)
                        {
                            dem++;
                            Xuat();
                        }
                        else
                        {
                            b[j] = true;
                            ChinhhopKhonglap(i + 1);
                            b[j] = false;
                        }
                    }
                }
        }
        static void Main(string[] args)
        {
            n = 2;
            k = 2;
            b = new bool[n + 1];
            for (int i = 0; i < n + 1; i++)
                b[i] = false;
            ChinhhopKhonglap(1);
            Console.WriteLine(dem);
            Console.ReadLine();
        }
    }
}
