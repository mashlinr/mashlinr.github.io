using System;

namespace PasswordProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correctPassword = "GHK";   // You can change this
            int attempts = 0;
            int maxAttempts = 3;

            while (attempts < maxAttempts)
            {
                Console.WriteLine("Please enter your password");
                string userInput = Console.ReadLine();

                if (userInput == correctPassword)
                {
                    Console.WriteLine("You have successfully logged in");
                    return; // Ends program if correct
                }
                else
                {
                    attempts++;
                    int triesLeft = maxAttempts - attempts;

                    if (triesLeft > 0)
                    {
                        Console.WriteLine($"Password incorrect - you have {triesLeft} tries left");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you are out of tries");
                    }
                }
            }
        }
    }
}