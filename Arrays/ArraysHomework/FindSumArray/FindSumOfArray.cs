/*Problem 10. Find sum in array

Write a program that finds in given array of integers a sequence of given sum S (if present).*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FindSumOfArray
{
    static void Main()
    {
        Console.Write("Enter number fos S: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Enter sequence of integers separated by , : ");
        string strInput = Console.ReadLine(); //Reading string from the console in order to det all elements from single line
        string[] inpArr = strInput.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        List<int> listInts = new List<int>();
        bool exists = false;

        for (int i = 0; i < inpArr.Length; i++)
        {
            listInts.Add(int.Parse(inpArr[i]));
        }

        


        // for every number, generate the combinations that start with him
        for (int i = 1; i < listInts.Count && !exists; i++)
        {
            // helpers
            int sum = listInts[i];
            string sequence = listInts[i] + ",";

            for (int j = i + 1; j < listInts.Count && !exists; j++)
            {
                // update sum and sequence
                sum += listInts[j];
                sequence += listInts[j] + ",";

                // if we find any valid sequence, print it and set exists, so we break the loops
                if (sum == s)
                {
                    Console.WriteLine(sequence.TrimEnd(','));
                    exists = true;
                }

            }

        }

        if (!exists)
        {
            Console.WriteLine("No such sequence");
        }
    }
}

