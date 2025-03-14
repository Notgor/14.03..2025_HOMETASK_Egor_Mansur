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
                        //case 6:
                        //    Class6.Execute();
                        //    break;
                        //case 7:
                        //    Class7.Execute();
                        //    break;
                        //case 8:
                        //    Class8.Execute();
                        //    break;
                        //case 9:
                        //    Class9.Execute();
                        //    break;
                        //case 10:
                        //    Class10.Execute();
                        //    break;
                        //default:
                        //    Console.WriteLine("Некорректный номер задания.");
                        //    break;
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

