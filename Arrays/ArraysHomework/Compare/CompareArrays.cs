/*Problem 2. Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element.*/
using System;

class CompareArrays
{
    static void Main()
    {
        Console.Write("First array length: ");
        int n = int.Parse(Console.ReadLine());
        int[] fArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter integer for index {0}: ", i);
            fArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("");
        Console.Write("Second array length: ");

        int m = int.Parse(Console.ReadLine());
        int[] sArray = new int[m];

        if (n == m)
        {

            for (int i = 0; i < m; i++)
            {
                Console.Write("Enter integer for index {0}: ", i);
                sArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("");

            for (int i = 0; i < n; i++)
            {
                if (fArray[i] == sArray[i])
                {
                    Console.WriteLine("Elements with index {0} are equals: {1} = {2}", i, fArray[i], sArray[i]);
                }
                else if (fArray[i] > sArray[i])
                {
                    Console.WriteLine("Elements with index {0} are not equals: {1} > {2}", i, fArray[i], sArray[i]);
                }
                else if (fArray[i] < sArray[i])
                {
                    Console.WriteLine("Elements with index {0} are not equals: {1} > {2}", i, sArray[i], fArray[i]);
                }
            }
        }
        else
        {
            Console.WriteLine("Arrays must have same length to compare them!");

        }

    }
}

