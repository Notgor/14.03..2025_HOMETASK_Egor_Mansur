using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._03._2025_Egor_Mansur
{
    public class Class2
    {
        public static void Execute()
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < 10; i++)
            {
                a += b;
                b += a;
                Console.WriteLine($"Итерация {i}: a = {a}, b = {b}");
            }
        }
    }
}
