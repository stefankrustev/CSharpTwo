/*Problem 15. Prime numbers

Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.*/
using System;

class PrimeNumbers
{
    static void Main()
    {

        long n = 10000000;
        bool[] isNotPrime = new bool[n];

        for (int i = 2; i < n; i++)
        {
            if (!isNotPrime[i])
            {
                
                for (int j = 2; i * j < n; j++)
                {
                    isNotPrime[i * j] = true;
                }
            }
        }


        for (int i = 2; i < n; i++)
        {
            if (!isNotPrime[i])
            {
                Console.Write(i + ",");
            }
        }
    }
}
