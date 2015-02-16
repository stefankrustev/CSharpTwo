/*Problem 8. Maximal sum

Write a program that finds the sequence of maximal sum in given array.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MaximalSum
{
    static void Main()
    {

        Console.Write("Enter sequence of integers separated by , : ");
        string strInput = Console.ReadLine(); //Reading string from the console in order to det all elements from single line
        string[] inpArr = strInput.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        List<int> listInts = new List<int>();        
        int sum = 0;
        int begin, end, tBegin;
        begin = end = tBegin = 0;
        int mSum = int.MinValue;


        //Adding user input to list array
        for (int i = 0; i < inpArr.Length; i++)
        {
            listInts.Add(int.Parse(inpArr[i]));
        }

        for (int i = 0; i < listInts.Count; i++) //loop thru the elements
        {
            sum += listInts[i]; //updating the sum

            if (sum > mSum) // if sum is larger than msum there is new largest sum
            {
                mSum = sum;
                end = i; //when there is new largest sum we have to change the end
                begin = tBegin;
            }

            if (sum <= 0) //if the sum is negative or 0 we reset
            {
                sum = 0;
                tBegin = i + 1; // and start from next element
            }
        }

        // printing the result
        for (int i = begin; i <= end; i++)
        {
            Console.Write(listInts[i] + (i != end ? ", " : ""));
        }

        Console.WriteLine();
    }
}


