/*Problem 12. Index of letters

Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.*/
using System;

class IndexOfLetters
{
        static void Main()
        {
            char[] alphabet = new char[26];

            for (int i = 0; i <= 25; i++)
            {
                alphabet[i] = Convert.ToChar(65+i);
            }

            Console.WriteLine("Capital letter word:");
            string word = Console.ReadLine();

            foreach (char letter in word)
            {
                Console.WriteLine("{0} = {1}", letter, (int)letter-65);
            }
    }
}

