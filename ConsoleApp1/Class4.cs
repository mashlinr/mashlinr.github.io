using System;

namespace BasketProgram
{
    internal class Program
    {
        static void Main5(string[] args)
        {
            int itemCount = 0;
            double totalPrice = 0;
            string response;

            do
            {
                Console.WriteLine("Do you want to put an item in your basket - respond Y for yes and N for No");
                response = Console.ReadLine().ToUpper();

                if (response == "Y")
                {
                    Console.WriteLine("What is the price of your item?");
                    double price = Convert.ToDouble(Console.ReadLine());

                    totalPrice += price;
                    itemCount++;
                }

            } while (response == "Y");

            Console.WriteLine($"You have {itemCount} items and the value of your basket is {totalPrice:F2}");
        }
    }
}