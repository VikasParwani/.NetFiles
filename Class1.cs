\using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 0;
            int[] b = { };
            int[] a = { 101, 202, 303, 404, 505 };
            for (int i = a.Length; i >= 0; i--)
            {
                b[m] = a[i];
                m++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}
