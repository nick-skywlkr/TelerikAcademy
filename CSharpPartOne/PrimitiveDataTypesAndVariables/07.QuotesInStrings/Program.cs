using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.QuotesInStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string quotationMarksOneWay = "The \"use\" of quotations causes difficulties.";
            string quotationMarksTheOtherWay = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine("You can have it this way: {0}", quotationMarksOneWay);
            Console.WriteLine("Or you can do it this way: {0}", quotationMarksTheOtherWay);
        }
    }
}
