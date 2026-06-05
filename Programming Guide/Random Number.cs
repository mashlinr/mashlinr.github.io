using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Guide
{
    public class RandomGuide
    {
        public void Random()
        {
            Random rnd = new Random();

            // Generate a random integer between 1 and 10 (11 is exclusive)
            int diceRoll = rnd.Next(1, 11);

            // Generate a random floating-point number between 0.0 and 1.0
            double chance = rnd.NextDouble();
        }
    }
}
