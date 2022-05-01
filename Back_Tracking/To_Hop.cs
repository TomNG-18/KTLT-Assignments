using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToHop
{
    class Program
    {
        static int[] a = new int[20];
        static int n, k;
        static void Xuat()
        {
            for (int i = 1; i <= k; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }
        static void Tohop(int i)
        {
            for (int j = a[i - 1] + 1; j <= n - k + i; j++)
            {
                a[i] = j;
                if (i == k)
                {
                    Xuat();
                }
                else
                    Tohop(i + 1);
            }
        }
        static void Main(string[] args)
        {
            n = 4;
            k = 2;
            a[0] = 0;
            Tohop(1);
            Console.ReadLine();
        }
    }
}
