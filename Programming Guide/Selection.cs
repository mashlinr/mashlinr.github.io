using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Guide
{
    public class SelectionGuide
    {
        public void Selection(int score)
        {
            // If-Else Statement
            if (score >= 50)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}