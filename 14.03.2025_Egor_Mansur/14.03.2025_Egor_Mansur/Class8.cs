using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._03._2025_Egor_Mansur
{
    class Class8
    {
        static TraceSwitch traceSwitch = new TraceSwitch("MyTraceSwitch", "Switch for tracing");
        public static void Execute()
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("trace.log")));
            Trace.AutoFlush = true;

            while (true)
            {
                Console.WriteLine("Введите уровень трассировки (0 - Off, 1 - Error, 2 - Warning, 3 - Info):");
                if (int.TryParse(Console.ReadLine(), out int level) && level >= 0 && level <= 3)
                {
                    traceSwitch.Level = (TraceLevel)level;
                    LogMessages();
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                }
            }
        }

        static void LogMessages()
        {
            Trace.WriteLineIf(traceSwitch.TraceError, "[ERROR] Произошла ошибка!");
            Trace.WriteLineIf(traceSwitch.TraceWarning, "[WARNING] Возможная проблема.");
            Trace.WriteLineIf(traceSwitch.TraceInfo, "[INFO] Информационное сообщение.");
            Trace.WriteLineIf(traceSwitch.TraceVerbose, "[VERBOSE] Подробная отладочная информация.");
        }
    }
}

