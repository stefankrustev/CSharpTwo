/*Problem 11. Binary search

Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.*/
using System;
using System.Linq;

class BinarySearch
{
    
    static void Main()
    {
       
        int[] intArr = Enumerable.Range(-20, 40).ToArray();

        Console.WriteLine("Key:");
        int key = int.Parse(Console.ReadLine());

        int lowerBound = 0, upperBound = intArr.Length, index = lowerBound + (upperBound - lowerBound) / 2;
        int found;

        // binary search 
        do{
            
            if (key > intArr[index])
            {
                lowerBound = index;
            }
            else if(key < intArr[index]) 
            {
                upperBound = index;
            }

            // update index
            index = lowerBound + (upperBound - lowerBound) / 2;


        } while (intArr[index] != key && upperBound - lowerBound > 1);


        // print
        Console.WriteLine(intArr[index] == key ? "Item with key {0} was found at {1}" : "Item with key {0} was not found", key, index);

    }
}

