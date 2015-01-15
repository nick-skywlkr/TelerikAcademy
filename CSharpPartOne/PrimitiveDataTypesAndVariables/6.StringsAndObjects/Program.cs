using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "Hello";
            string secondString = "World";
            object firstPlusSecond = firstString + " " + secondString;
            string thirdString = firstPlusSecond.ToString();
            Console.WriteLine(thirdString);
        }
    }
}
