using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.UnicodeCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            char UnicodeCharacter = '\u002A';
            Console.WriteLine("The notation of \\u002a translate to a {0} in the console", UnicodeCharacter);
        }
    }
}
