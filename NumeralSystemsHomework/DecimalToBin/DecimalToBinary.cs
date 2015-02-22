/*Problem 1. Decimal to binary

Write a program to convert decimal numbers to their binary representation.*/
using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter some number: ");
        int number = int.Parse(Console.ReadLine());
        string dec = "";

        while (number != 0)
        { 
                dec += (number % 2).ToString();
                number = number / 2;
        }

        char[] decArr = dec.ToCharArray();
        Array.Reverse(decArr);
        Console.Write("Binary representation: ");
        foreach (char s in decArr)
        {
            Console.Write(s);
        }
        Console.WriteLine();

    }
}

