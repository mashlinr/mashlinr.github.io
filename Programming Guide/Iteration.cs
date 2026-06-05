using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Guide
{
    public class IterationGuide
    {
        public void Iteration()
        {
            // For loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Count: {i}");
            }

            // Foreach loop
            string[] colors = { "Red", "Green", "Blue" };
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            // While loop (Runs as long as condition is true)
            int timer = 3;
            while (timer > 0)
            {
                timer--;
            }
        }
    }
}
