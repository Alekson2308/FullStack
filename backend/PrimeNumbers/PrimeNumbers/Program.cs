using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var primeNumbers = new List<int>();

        for (int number = 2; number <= 100; number++)
        {
            var isPrime = true;

            for (int divisor = 2; divisor < number; divisor++)
            {
                if (number % divisor == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                primeNumbers.Add(number);
            }
        }

        Console.WriteLine("Prime numbers from 1 to 100:");

        for (int i = 0; i < primeNumbers.Count; i++)
        {
            Console.WriteLine(primeNumbers[i]);
        }
    }
}
