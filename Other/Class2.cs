using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class2
    {
        private static void Main3(string[] args)
        {
            Console.WriteLine("Conversion : Pounds to Kilograms");
            Console.WriteLine("Pounds             |             Kilograms");
            Console.WriteLine("------------------------------------------");
            double num = 0.4536;
            for (int i = 1; i <= 20; i++)
                {
                    Console.WriteLine(i + "                        " + num*i);
                }
        }
    }
}
