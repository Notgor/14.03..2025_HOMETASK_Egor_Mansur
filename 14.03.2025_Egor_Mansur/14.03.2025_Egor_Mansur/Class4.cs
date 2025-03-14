using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._03._2025_Egor_Mansur
{
    public class Class4
    {
        public static void Execute()
        {

            int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                Console.WriteLine($"Итерация {i}: сумма = {sum}");
            }
        }
    }
}
