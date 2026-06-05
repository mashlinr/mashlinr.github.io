using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace Programming_Guide
{
    public class ArrayGuide
    {
        public void Array()
        {
            // Declaration and initialization - 2D Array

            string[] fruits = ["Apple", "Banana", "Cherry"];

            // 3D Array

            string[,] vegetables = new string[7, 7];

            // Empty array with 5 slots

            int[] numbers = new int[5];

            // Assigning values

            numbers[0] = 10;

            // Accessing values

            string firstFruit = fruits[0];
        }
    }
}
