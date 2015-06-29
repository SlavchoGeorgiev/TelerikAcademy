using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
/*
 *Problem 11. Bank Account Data
A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names. 
 */
class BankAccountData
    {
        static void Main()
        {
            string firstName = "Ivan";
            string middleName = "Petrov";
            string lastName = "Ivanov";
            decimal balance = 1500.34M;
            string iban = "BG51ABCB98881001123456";
            List<BigInteger> cardNumber = new List<BigInteger>();
            cardNumber.Add(BigInteger.Parse("9999888877775555"));
            cardNumber.Add(BigInteger.Parse("9999888877774444"));
            cardNumber.Add(BigInteger.Parse("9999888877773333"));
            Console.WriteLine("{0} {1} {2} bank balans is {3}$", firstName, middleName, lastName, balance);
            Console.WriteLine("IBAN: {0}", iban);
            foreach (var card in cardNumber)
            {
                Console.Write("Car number : ");
                Console.WriteLine(card);
            }
        }
    }
