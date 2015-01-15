using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.AgeInTenYears
{
    class AgeInTenYears
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("You will be {0} years old in ten years", Age + 10);
        }
    }
}
