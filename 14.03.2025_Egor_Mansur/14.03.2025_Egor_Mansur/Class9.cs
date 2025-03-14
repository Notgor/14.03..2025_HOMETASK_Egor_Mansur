using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._03._2025_Egor_Mansur
{
    class Class9
    {


        public static void Execute()
        {
            Console.WriteLine("Запуск многопоточного приложения...");

            
            for (int i = 1; i <= 3; i++)
            {
                int threadNum = i;
                Thread thread = new Thread(() => DoWork(threadNum));
                thread.Name = $"Поток {threadNum}";
                thread.Start();
            }

            static void DoWork(int threadNum)
            {
                Console.WriteLine($"[{Thread.CurrentThread.Name}] Начало работы.");

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"[{Thread.CurrentThread.Name}] Итерация {i + 1}");
                    Thread.Sleep(1000); // Эмуляция работы
                }

                Console.WriteLine($"[{Thread.CurrentThread.Name}] Завершение работы.");
            }


        }
    }
}
