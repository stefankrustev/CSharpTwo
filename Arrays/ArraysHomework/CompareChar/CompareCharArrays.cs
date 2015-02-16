/*Problem 3. Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter)*/
using System;
using System.Collections.Generic;

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Enter first char array: ");
        string first = Console.ReadLine();

        Console.Write("Enter second char array: ");
        string second = Console.ReadLine();

        char[] fArray = first.ToCharArray();
        char[] sArray = second.ToCharArray();

        if (fArray.Length == sArray.Length)
        {
            for (int i = 0; i < fArray.Length; i++)
            {
                if (fArray[i] == sArray[i])
                {
                    Console.Write("Chars on {0} index are identical: ", i);
                    Console.WriteLine("{0} = {1}", fArray[i], sArray[i]);
                }
                else
                {
                    Console.Write("Chars on {0} index are not identical: ", i);
                    Console.WriteLine("{0} != {1}", fArray[i], sArray[i]);
                }
            }
        }

        else
        {
            Console.WriteLine("Arrays have different lenghts!");
        }
    }
}

