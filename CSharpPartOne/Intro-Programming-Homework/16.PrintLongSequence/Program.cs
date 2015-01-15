using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.PrintLongSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 2;
            int B = -3;
            for (int i = 2; i <= 501; i++)
            {
                Console.WriteLine(A);
                Console.WriteLine(B);
                A = A + 2;
                B = B - 2;
            }
        }
    }
}
