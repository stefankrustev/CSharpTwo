/*Problem 9. Frequent number

Write a program that finds the most frequent number in an array.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FrequentNumber
{
    static void Main()
    {
        Console.Write("Enter sequence of integers separated by , : ");
        string strInput = Console.ReadLine(); //Reading string from the console in order to det all elements from single line
        string[] inpArr = strInput.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        List<int> listInts = new List<int>();
        int count = 0;
        int tCount = 0;
        int element = 0;

        //Adding user input to list array
        for (int i = 0; i < inpArr.Length; i++)
        {
            listInts.Add(int.Parse(inpArr[i]));
        }

        listInts.Sort();

        for (int i = 1; i < listInts.Count; i++)
        {
            while (i < listInts.Count)
            {
                if (listInts[i - 1] == listInts[i])
                {
                    tCount++;
                    i++;
                }
                else
                {
                    break;
                }

            }

            if (count <= tCount && element < listInts[i - 1])
            {
                element = listInts[i - 1];
                count = tCount;
                tCount = 0;
            }
            
            tCount = 0;
        }
        
        Console.Write("{0} ", element);
        Console.Write("({0} Times)", count + 1);
        Console.WriteLine();

    }
}
