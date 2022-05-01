using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueen
{
    class Program
    {
        static int n, dem = 0;
        static int[] a = new int[20];
        static void Xuat()
        {
            for (int i = 1; i <= n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }

        static bool KiemTra(int x2, int y2)
        {
            for(int i = 1; i < x2; i++)
            {
                if (a[i] == y2 || Math.Abs(i - x2) == Math.Abs(a[i] - y2))
                    return false;
            }

            return true;
        }

        static void Try(int i)
        {
            for(int j = 1; j <= n; j++)
            {
                if (KiemTra(i, j))
                {
                    a[i] = j;

                    if (i == n)
                    {
                        dem++;
                        Xuat();
                    }
                    else Try(i + 1);
                }
            }
        }
        static void Main(string[] args)
        {
            n = 8;
            Try(1);
            Console.Write(dem);
            Console.ReadLine();
        }
    }
}
