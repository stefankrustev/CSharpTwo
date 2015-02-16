/* Problem 1. Allocate array

Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
Print the obtained array on the console.*/
using System;

class AllocateArray
{
    static void Main()
    {
        int[] nArray = new int[20];

        for (int i = 0; i < nArray.Length; i++)
        {
            nArray[i] = i * 5;
        }

        for (int i = 0; i < nArray.Length; i++)
        {
            Console.WriteLine(nArray[i]);
        }

    }
}

