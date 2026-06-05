using System;
using System.Collections.Generic;

namespace Programming_Guide
{
    class Program
    {
        // The Fruit structure to store all related data
        public struct Fruit
        {
            public char fruitidentifier;
            public string fruitname;
            public int fruitvalue;
        }

        static void FruitsAI(string[] args)
        {
            // Initialize the board and random generator
            char[,] Board = new char[10, 10];
            Random rand = new Random();

            // 1. Create the library of 7 fruits
            Fruit[] fruitLibrary = new Fruit[7];
            string[] names = { "Apple", "Banana", "Cherry", "Date", "Elderberry", "Fig", "Grape" };

            for (int i = 0; i < fruitLibrary.Length; i++)
            {
                fruitLibrary[i].fruitname = names[i];
                fruitLibrary[i].fruitidentifier = names[i][0];
                fruitLibrary[i].fruitvalue = rand.Next(11); 
            }

            // 2. Add the fruits to random coordinates on the board
            for (int i = 0; i < fruitLibrary.Length; i++)
            {
                int rRow, rCol;
                // Loop to ensure we don't overwrite a spot that already has a fruit
                do
                {
                    rRow = rand.Next(0, 10);
                    rCol = rand.Next(0, 10);
                } while (Board[rRow, rCol] != '\0');

                Board[rRow, rCol] = fruitLibrary[i].fruitidentifier;
            }

            // 3. Display the board to the user
            PrintBoard(Board);

            // 4. Input and Output Logic
            Console.WriteLine("\n--- Fruit Search ---");
            try
            {
                Console.Write("Enter Row (0-9): ");
                int userRow = int.Parse(Console.ReadLine());
                Console.Write("Enter Column (0-9): ");
                int userCol = int.Parse(Console.ReadLine());

                // Check if the input is within board boundaries
                if (userRow >= 0 && userRow < 10 && userCol >= 0 && userCol < 10)
                {
                    char identifierAtSpot = Board[userRow, userCol];
                    bool found = false;

                    // Match the character on the board to the fruit in the library
                    foreach (var f in fruitLibrary)
                    {
                        if (f.fruitidentifier == identifierAtSpot && identifierAtSpot != '\0')
                        {
                            Console.WriteLine($"\nSUCCESS! You found: {f.fruitname}");
                            Console.WriteLine($"Value stored at [{userRow},{userCol}]: {f.fruitvalue} points");
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("\nThere is nothing but empty dirt at this location.");
                    }
                }
                else
                {
                    Console.WriteLine("Coordinates are out of bounds! Please use 0-9.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numbers only.");
            }

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();
        }

        private static void PrintBoard(char[,] Board)
        {
            Console.WriteLine("\nGame Board:");
            Console.Write("   "); // Offset for row numbers
            for (int i = 0; i < 10; i++) Console.Write(i + "   ");
            Console.WriteLine("\n  " + new string('-', 41));

            for (int row = 0; row < 10; row++)
            {
                Console.Write(row + " | ");
                for (int col = 0; col < 10; col++)
                {
                    // Print a blank space if the char is null, otherwise print the fruit ID
                    char display = Board[row, col] == '\0' ? ' ' : Board[row, col];
                    Console.Write(display + " | ");
                }
                Console.WriteLine();
            }
        }
    }
}