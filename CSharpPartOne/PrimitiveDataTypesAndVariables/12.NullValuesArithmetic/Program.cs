using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NullValuesArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;
            Console.WriteLine("The value of integer variable a is: {0}\nThe value of double variable b is: {1}\n", a, b);
            Console.WriteLine("Lets add some number to the variables.\nVariable a + 10 = {0}\nVariable b + 15 = {1}\n", a + 10, b + 15);
            Console.WriteLine("As we see the variables value is again null.");
        }
    }
}
