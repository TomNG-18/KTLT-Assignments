using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTracking
{
    class Program
    {
        static int[] arr = new int[20];
        static int n, k, dem = 0;

        static void Output()
        {
            for (int h = 1; h <= k; h++)
                Console.Write(arr[h] + " ");
            Console.WriteLine();
        }
        static void Permulation(int i)
        {
            for (int j = 1; j <= n; j++)
            {            
                arr[i] = j;
                if (i == k)
                {
                    dem++;
                    Output();
                }
                else
                {
                    Permulation(i + 1);
                }
            }
        }
        static void Main(string[] args)
        {
            n = 2;
            k = 3;
            Permulation(1);
            Console.WriteLine(dem);
            Console.ReadLine();
        }
    }
}
