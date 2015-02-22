/*Problem 2. Binary to decimal

Write a program to convert binary numbers to their decimal representation.*/
using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string binary = Console.ReadLine();
        long inDec = Convert.ToInt32(binary, 2);
        Console.WriteLine("Your binary number {0} in decimal is {1}", binary, inDec);
    }
}

