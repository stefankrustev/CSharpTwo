/*Problem 6. Maximal K sum

Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MaximalKSum
{
    static void Main()
    {
        Console.Write("Enter number for N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter number for K: ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if (n >= k)
        {

            int[] numArr = new int[n];
            Console.Write("Enter {0} numbers to initialize array \n", n);

            for (int i = 0; i < n; i++)
            {
                Console.Write("Number {0}: ", i + 1);
                numArr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numArr);
            List<int> result = new List<int>();
            int sum = 0;

            for (int i = numArr.Length - 1; i > numArr.Length - 1 - k; i--)
            {
                result.Add(numArr[i]);
            }

            Console.WriteLine();
            Console.Write("Elements that have maximal sum are: ");

            for (int i = 0; i < result.Count; i++)
            {

                Console.Write("{0} ", result[i]);
            }

            Console.WriteLine();
            for (int i = 0; i < result.Count; i++)
            {
                sum += result[i];
            }
            Console.Write("And their sum is: {0}", sum);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid!");
            Console.WriteLine("K must be smaller than N !"); ;
        }
    }
}

