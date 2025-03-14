using _14._03._2025_Egor_Mansur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._03._2025_Egor_Mansur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите номер задания (от 1 до 10) или 0 для выхода:");
                if (int.TryParse(Console.ReadLine(), out int taskNumber))
                {
                    if (taskNumber == 0) break;

                    switch (taskNumber)
                    {
                        case 1:
                            Class1.Execute();
                            break;
                        case 2:
                            Class2.Execute();
                            break;
                        case 3:
                            Class3.Execute();
                            break;
                        case 4:
                            Class4.Execute();
                            break;
                        case 5:
                            Class5.Execute();
                            break;
                        case 6:
                            class6.execute();
                            break;
                        case 7:
                            class7.execute();
                            break;
                        case 8:
                            class8.execute();
                            break;
                        case 9:
                            class9.execute();
                            break;
                        case 10:
                            class10.execute();
                            break;
                        default:
                            console.writeline("некорректный номер задания.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                }
            }
        }
    }
}

