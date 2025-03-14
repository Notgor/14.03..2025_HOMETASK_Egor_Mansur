using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._03._2025_Egor_Mansur
{
    public class Class3
    {
        public static void Execute()
        {
            HelperMethod1();
        }

        static void HelperMethod1()
        {
            Console.WriteLine("Внутри HelperMethod1");
            HelperMethod2();
        }

        static void HelperMethod2()
        {
            Console.WriteLine("Внутри HelperMethod2");
        }
    }   
}
