using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Guide
{
    public class ExceptionGuide
    {
        public void ExceptionHandling(int a, int b)
        {
            try
            {
                int result = a / b;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: You cannot divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("This block always runs, regardless of an error.");
            }
        }
    }
}
