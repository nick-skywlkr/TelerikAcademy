using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("The value of the variable a is: {0}.\nThe value of variable b is: {1}.", a, b);
            int youCannotDoItWithoutAThirdVariable = a;
            a = b;
            b = youCannotDoItWithoutAThirdVariable;
            Console.WriteLine("After the exchange the new values are:\na = {0}.\nb = {1}", a, b);
        }
    }
}
