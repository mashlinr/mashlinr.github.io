using System;
using System.IO;

namespace Programming_Guide
{
    public class DataManager
    {
        public static void StreamWriter()
        {
            string[] names = new string[5];
            string[] ages = new string[5];
            string filename = "NamesAndAges.txt";

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Name: ");
                names[i] = Console.ReadLine();

                Console.Write("Enter Age: ");
                ages[i] = Console.ReadLine();
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        sw.WriteLine(names[i] + " " + ages[i]);
                    }
                }
                Console.WriteLine("File saved! Check your bin folder.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}