/*Problem 4. Maximal sequence

Write a program that finds the maximal sequence of equal elements in an array.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MaximalSequence
{
    static void Main()
    {
        Console.Write("Enter sequence of integers separated by , : ");
        string uInput = Console.ReadLine();
        string[] input = uInput.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        int count = 0;
        int length = 0;
        int mLength = 0;
        string biggest = "0";


        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == input[count])
            {
                length++;
            }
            else
            {
                count = i;
                length = 1;
            }

            if (length >= mLength)
            {
                mLength = length;
                biggest = input[i];
            }
        }
        for (int i = 0; i < mLength; i++)
        {
            Console.Write("{0} ", biggest);
        }
        Console.WriteLine();
    }
}

