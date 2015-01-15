using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BankAccountData
{
    class Program
    {
        static void Main(string[] args)
        {
            string holderFirstName = "Nikola";
            string holderMiddleName = "Nikolov";
            string holderLastName = "Georgiev";
            decimal accountBalance = 1000000.00M;
            string bankName = "Frankfurter Volksbank";
            string iban = "SA03 8000 0000 6080 1016 7519";
            long creditCardOne = 4556442028137143;
            long creditCardTwo = 5315903215729850;
            long creditCardThree = 4024007171468993;
            Console.WriteLine("Bank account data of holder:\nFirst name: {0}\nMiddle name: {1}\nLast name: {2}\nAccount balance: {3}\nBank name: {4}\nIBAN: {5}\nCredit Card Number One: {6}\nCredit Card Number Two: {7}\nCredit Card Number Three: {8}",
                holderFirstName, holderMiddleName, holderLastName, accountBalance, bankName, iban, creditCardOne, creditCardTwo, creditCardThree);
        }
    }
}
