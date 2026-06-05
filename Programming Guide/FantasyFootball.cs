using System;
using System.IO;

namespace Programming_Guide
{
    public class FantasyFootball
    {
        static string filename = "FantasyFootball.txt";

        public static void Main()
        {
            int userChoice = 0;
            userChoice = OutputMenu();

            while (userChoice != 4)
            {
                if (userChoice == 1)
                {
                    if (CountTeam(filename) < 5)
                    {
                        StoreFootballer(filename);
                    }
                    else
                    {
                        Console.WriteLine("Team is full!");
                    }
                }
                else if (userChoice == 2)
                {
                    ViewTeam();
                }
                else if (userChoice == 3)
                {
                    TeamValue();
                }
                userChoice = OutputMenu();
            }
            if (userChoice == 4)
            {
                Console.WriteLine("");
            }
        }
        public static int OutputMenu()
        {
            int menuchoice;

            Console.WriteLine("Welcome to your fantasy team - do you want to:");
            Console.WriteLine("1. Add a new player");
            Console.WriteLine("2. View the team");
            Console.WriteLine("3. Calculate the team's value");
            Console.WriteLine("4. Quit the program");
            menuchoice = Convert.ToInt32(Console.ReadLine());
            return menuchoice;
        }
        public static void StoreFootballer(string FantasyFootball)
        {
            string playername;
            string goals;
            string yellowcards;
            string redcards;

            Console.WriteLine("What is your players name?");
            playername = Console.ReadLine();

            Console.WriteLine("How many goals has your player scored?");
            goals = Console.ReadLine();
            
            Console.WriteLine("How many yellow cards does your player have?");
            yellowcards = Console.ReadLine();

            Console.WriteLine("How many red cards does your player have?");
            redcards = Console.ReadLine();

            string playerLine = $"{playername},{goals},{yellowcards},{redcards}";
            using (StreamWriter SW = new StreamWriter(FantasyFootball, true))
            {
                SW.WriteLine(playerLine);
            }
        }

        public static void ViewTeam()
        {
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                Console.WriteLine("\n--- Current Team ---");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("No players found.");
            }
        }
        public static void TeamValue()
        {
            if (!File.Exists(filename)) return;

            int totalValue = 0;
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] stats = line.Split(',');

                string playernames = stats[0];
                    int goals = int.Parse(stats[1]);
                int yellowcards = int.Parse(stats[2]);
                int redcards = int.Parse(stats[3]);

                totalValue += (goals * 10) - (yellowcards * 2) - (redcards * 5);
            }
            Console.WriteLine("Total Team Value: " + totalValue);
        }
        public static int CountTeam(string filename)
        {
            if (!File.Exists(filename)) return 0;
            return File.ReadAllLines(filename).Length;
        }

    }
}