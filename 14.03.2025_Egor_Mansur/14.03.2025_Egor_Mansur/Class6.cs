using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._03._2025_Egor_Mansur
{
    class Class6
    {
        public static void Execute()
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));

            Console.WriteLine("Начало программы\n");

            Debug.WriteLine("[Debug] видно только в режиме отладки.");
            Trace.WriteLine("[Trace] видно как в режиме отладки, так и в продакшене.");

            Debug.Indent();
            Trace.Indent();

            Debug.WriteLine("[Debug] Отладочное сообщение внутри блока");
            Trace.WriteLine("[Trace] Трассировочное сообщение внутри блока");

            Debug.Unindent();
            Trace.Unindent();

            Console.WriteLine("\nКонец программы");
        }
        
    }
}
