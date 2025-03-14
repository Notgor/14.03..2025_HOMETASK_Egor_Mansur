using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._03._2025_Egor_Mansur
{
    class Class10
    {
        public static void Execute()
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.AutoFlush = true;
            TraceSwitch traceSwitch = new TraceSwitch("TraceSwitch", "Управление уровнем трассировки");

            // Устанавливаем максимальный уровень трассировки
            traceSwitch.Level = TraceLevel.Verbose;

            ИзмеритьВремя(traceSwitch, "Операция 1", Операция1);
            ИзмеритьВремя(traceSwitch, "Операция 2", Операция2);
            ИзмеритьВремя(traceSwitch, "Операция 3", Операция3);

            Console.WriteLine("\nПереключаем уровень трассировки на критический...\n");
            traceSwitch.Level = TraceLevel.Error;

            ИзмеритьВремя(traceSwitch, "Операция 1", Операция1);
            ИзмеритьВремя(traceSwitch, "Операция 2", Операция2);
            ИзмеритьВремя(traceSwitch, "Операция 3", Операция3);
        }

        static void ИзмеритьВремя(TraceSwitch traceSwitch, string название, Action операция)
        {
            if (traceSwitch.TraceInfo)
                Trace.WriteLine($"Начало {название}: {DateTime.Now:HH:mm:ss.fff}");

            Stopwatch секундомер = Stopwatch.StartNew();
            операция();
            секундомер.Stop();

            if (traceSwitch.TraceInfo)
                Trace.WriteLine($"Конец {название}: {DateTime.Now:HH:mm:ss.fff}");

            if (traceSwitch.TraceError)
                Trace.WriteLine($"Время выполнения {название}: {секундомер.ElapsedMilliseconds} мс");
        }

        static void Операция1()
        {
            Thread.Sleep(500);
        }

        static void Операция2()
        {
            Thread.Sleep(1000);
        }

        static void Операция3()
        {
            Thread.Sleep(1500);
        }
    }
}




