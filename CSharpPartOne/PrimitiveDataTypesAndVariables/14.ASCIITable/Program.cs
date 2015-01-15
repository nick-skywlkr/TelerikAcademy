using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 255; i++)
            {
                char characterToPrint = (char)i;
                Console.WriteLine(characterToPrint);
            }
        }
    }
}
