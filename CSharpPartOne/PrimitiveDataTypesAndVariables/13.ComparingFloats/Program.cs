using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's compare some number with precision up to 0.000001.\nPlease enter your first number:");
            float firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number for comparison:");
            float secondNumber = float.Parse(Console.ReadLine());
            bool equal = firstNumber == secondNumber;
            if (equal == false)
            {
                Console.WriteLine("The numbers are not equal.");
            }
            else
            {
                Console.WriteLine("The numbers are equal. Hooray!");
            }
        }
    }
}
