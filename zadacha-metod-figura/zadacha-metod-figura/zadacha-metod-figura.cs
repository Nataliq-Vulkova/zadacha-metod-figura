using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_metod_figura
{
    internal class Program
    {
        static void PrintHeaderRow(int n)
        { 
        Console.WriteLine(new string('-',2 * n));
        }
        static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i <n; i++)
                Console.Write("\\/");
            Console.WriteLine('-');
        }
        static void PrintBottomRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
                Console.Write("/\\");
            Console.WriteLine('-');

        }

        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            PrintHeaderRow(n);
            for (int i = 0; i < n - 2; i++)
            PrintMiddleRow(n);
            for (int i = 0; i < n - 2; i++)
            PrintBottomRow(n);
            PrintHeaderRow(n);
        }
    }
}
