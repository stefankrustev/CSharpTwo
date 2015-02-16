﻿
/*Problem 7. Selection sort
Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
find the smallest from the rest, move it at the second position, etc.
*/
using System;


class SelectionSortAlgo
{
    static void Main()
    {
        Console.Write("Enter number for array's length: ");
        int arrLength = int.Parse(Console.ReadLine());
        int[] userArray = new int[arrLength];

        Console.WriteLine();

        for (int i = 0; i < arrLength; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            userArray[i] = int.Parse(Console.ReadLine());
        }


        Console.Write("\nNumbers in array before sorting: ");
        for (int i = 0; i < userArray.Length; i++)
        {
            Console.Write("{0} ", userArray[i]);
        }

        userArray = SelectionSort(userArray);

        Console.WriteLine();
        Console.Write("\nNumbers in array after sorting: ");


        for (int i = 0; i < userArray.Length; i++)
        {
            Console.Write("{0} ", userArray[i]);
        }

        Console.WriteLine();

    }

    private static int[] SelectionSort( int[] algo)
    {
        for (int i = 0; i < algo.Length - 1; i++)
        {
            int index = i;
            for (int j = i + 1; j < algo.Length; j++)
            {
                if (algo[j] < algo[index])
                {
                    index = j;
                }
            }
            int swap = algo[i];
            algo[i] = algo[index];
            algo[index] = swap;
        }
        return algo;
    }
}
