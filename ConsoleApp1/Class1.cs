using System;

namespace ConsoleApp1
{
    internal class Class1
    {
        private static void Main1(string[] args)
        {
            Console.WriteLine("Enter the number you want to learn the times tables of:");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i + " * " + num + " = " + (num * i));
            }
        }
    }
}