using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Nikola";
            string lastName = "Georgiev";
            byte age = 28;
            char gender = 'm';
            long PersonalID = 8306112507;
            int uniqueEmployeeNumber = 27560000;
            Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID number: {4}\nUnique Employee ID: {5}", firstName, lastName, age, gender, PersonalID, uniqueEmployeeNumber);
        }
    }
}
