/*Problem 5. Maximal increasing sequence

Write a program that finds the maximal increasing sequence in an array.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MaxIncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter sequence of integers separated by , : ");
        string usrInput = Console.ReadLine();
        string[] inpArr = usrInput.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        List<int> seqList = new List<int>();
        int start = 0;
        int length = 1;
        int bStart = 0;
        int bLength = 1;



        for (int i = 0; i < inpArr.Length; i++)
        {
            seqList.Add(int.Parse(inpArr[i]));
        }

        for (int i = 1; i < seqList.Count; i++)
        {
            if (seqList[i] > seqList[i - 1])
            {
                start = i;
                length++;

                if (bLength < length)
                {
                    bStart = start;
                    bLength = length;
                }
            }

            else
            {
                length = 1;
            }
        }
        Console.WriteLine();
        Console.Write("Maximal increasing sequence is: ");
        for (int j = bStart - bLength + 1; j <= bStart; j++)
        {
            Console.Write("{0} ", seqList[j]);
        }
        Console.WriteLine();
    }
}


