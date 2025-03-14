using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._03._2025_Egor_Mansur
{
    public class Class1
    {
        public static void Execute()
        {
            Method1();
            Method2();
        }

        static void Method1()
        {
            Console.WriteLine("Method1");
            Method3();
        }

        static void Method2()
        {
            Console.WriteLine("Method2");
        }

        static void Method3()
        {
            Console.WriteLine("Method3");
        }
    }
}

