using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._03._2025_Egor_Mansur
{
    class Class7
    {

        public static void Execute()
        {
            ConsoleTraceListener consoleListener = new ConsoleTraceListener();
            consoleListener.Filter = new EventTypeFilter(SourceLevels.Information);

            string filePath = "trace.log";
            TextWriterTraceListener fileListener = new TextWriterTraceListener(filePath);
            fileListener.Filter = new EventTypeFilter(SourceLevels.Verbose);

            Trace.Listeners.Clear();

            Console.WriteLine("Выберите тип слушателя:");
            Console.WriteLine("1 - Вывод в консоль");
            Console.WriteLine("2 - Запись в файл");
            Console.Write("Ваш выбор: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Trace.Listeners.Add(consoleListener);
                Console.WriteLine("Используется слушатель для вывода в консоль.\n");
            }
            else if (choice == "2")
            {
                Trace.Listeners.Add(fileListener);
                Console.WriteLine($"Используется слушатель для записи в файл: {filePath}\n");
            }
            else
            {
                Console.WriteLine("Неверный выбор. По умолчанию используется вывод в консоль.\n");
                Trace.Listeners.Add(consoleListener);
            }

            Trace.TraceError("Это сообщение уровня ERROR.");
            Trace.TraceWarning("Это сообщение уровня WARNING.");
            Trace.TraceInformation("Это сообщение уровня INFORMATION.");
            Trace.WriteLine("Это сообщение уровня VERBOSE.");

            Trace.Flush();

            if (choice == "2")
            {
                Console.WriteLine($"\nСообщения записаны в файл {filePath}");
            }
            else
            {
                Console.WriteLine("\nНажмите любую клавишу для выхода...");
                Console.ReadKey();
            }
        }
    }
}
    


