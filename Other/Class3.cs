using System;

namespace ConsoleApp1
{
    internal class Class3
    {
        private static void Main4(string[] args)
        {
            int correctAnswer = 4;
            int userAnswer = 0;
            int tries = 0;

            while (userAnswer != correctAnswer)
            {
                Console.WriteLine("What is 2 + 2?");

                userAnswer = Convert.ToInt32(Console.ReadLine());
                tries++;

                if (userAnswer != correctAnswer)
                {
                    Console.WriteLine("Wrong - try again");
                }
            }

            Console.WriteLine("Well done - you got that right in " + tries + " tries");
        }
    }
}