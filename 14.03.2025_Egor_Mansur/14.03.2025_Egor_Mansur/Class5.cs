using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._03._2025_Egor_Mansur
{
<<<<<<< HEAD
    internal class Class5
    {
        public static void Execute()
        {
                       
=======
    public class Class5
    {
        public static void Execute()
        {
            int sum = 0;

            for (int i = 0; i < 20; i++)
            {
                sum += i;

                // Установи условную точку остановки здесь (например, когда sum > 50)
                Console.WriteLine($"Итерация {i}: сумма = {sum}");
            }
>>>>>>> 360d17676c74304900c17cf180ffd10e0d63db22
        }
    }
}
